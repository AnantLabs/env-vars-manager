using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvVarsManager
{
  public partial class EditVariableForm : Form
  {
    private char[] kValueSeparator = new char[] { ';' };
    private bool mDisableListUpdate = false;

    public string VariableName
    {
      get { return mNameTextBox.Text; }
    }
    public string VariableValue
    {
      get { return mValueTextBox.Text; }
    }

    public EditVariableForm(string name, string value)
    {
      InitializeComponent();

      mNameTextBox.Text = name;
      mValueTextBox.Text = value;

      UpdateValuesList();
      mNameTextBox.Focus();
    }


    private void mValuesListView_DoubleClick(object sender, EventArgs e)
    {
      if (mValuesListView.SelectedItems.Count > 0)
        mValuesListView.SelectedItems[0].BeginEdit();
    }

    private void mValueTextBox_TextChanged(object sender, EventArgs e)
    {
      UpdateValuesList();
    }

    private void mValuesListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
    {
      e.CancelEdit = true;

      if (e.Item < mValuesListView.Items.Count)
      {
        string newValue = e.Label == null ? "" : e.Label.Trim();
        if (newValue.Length != 0)
        {
          if (mValuesListView.Items[e.Item].Text != newValue)
          {
            mValuesListView.Items[e.Item].Text = newValue;
            UpdateValuesText();

            mValuesListView.Items[e.Item].Selected = true;
          }
        }
        else
        {
          mValuesListView.Items[e.Item].Remove();
          UpdateValuesText();

          if (e.Item < mValuesListView.Items.Count)
            mValuesListView.Items[e.Item].Selected = true;
          else if (e.Item > 0)
            mValuesListView.Items[e.Item - 1].Selected = true;
        }
      }
      mValuesListView.Focus();
    }


    private void mValueUpButton_Click(object sender, EventArgs e)
    {
      if (mValuesListView.SelectedIndices.Count > 0)
      {
        int ind = mValuesListView.SelectedIndices[0];
        if (ind > 0)
        {
          string t = mValuesListView.Items[ind - 1].Text;
          mValuesListView.Items[ind - 1].Text = mValuesListView.Items[ind].Text;
          mValuesListView.Items[ind].Text = t;

          UpdateValuesText();

          mValuesListView.Items[ind - 1].Selected = true;
        }
      }

      mValuesListView.Focus();
    }

    private void mValueDownButton_Click(object sender, EventArgs e)
    {
      if (mValuesListView.SelectedIndices.Count > 0)
      {
        int ind = mValuesListView.SelectedIndices[0];
        if (ind + 1 < mValuesListView.Items.Count)
        {
          string t = mValuesListView.Items[ind + 1].Text;
          mValuesListView.Items[ind + 1].Text = mValuesListView.Items[ind].Text;
          mValuesListView.Items[ind].Text = t;

          UpdateValuesText();

          mValuesListView.Items[ind + 1].Selected = true;
        }
      }
      mValuesListView.Focus();
    }


    private void mValueAddButton_Click(object sender, EventArgs e)
    {
      ListViewItem item = mValuesListView.Items.Add("NewValue");

      item.Selected = true;
      item.BeginEdit();
    }

    private void mValueDelButton_Click(object sender, EventArgs e)
    {
      if (mValuesListView.SelectedIndices.Count > 0)
      {
        int ind = mValuesListView.SelectedIndices[0];

        mValuesListView.Items[ind].Remove();
        UpdateValuesText();

        if (ind < mValuesListView.Items.Count)
          mValuesListView.Items[ind].Selected = true;
        else if (ind > 0)
          mValuesListView.Items[ind - 1].Selected = true;
      }
      mValuesListView.Focus();
    }


    private void UpdateValuesList()
    {
      if (mDisableListUpdate)
        return;

      mValuesListView.Items.Clear();

      string[] values = VariableValue.Split(kValueSeparator, StringSplitOptions.RemoveEmptyEntries);
      for (int i = 0; i < values.Length; ++i)
      {
        ListViewItem item = new ListViewItem(values[i]);
        mValuesListView.Items.Add(item);
      }
    }

    private void UpdateValuesText()
    {
      string value = "";
      for (int i = 0; i < mValuesListView.Items.Count; ++i)
      {
        if (i != 0)
          value += ";";
        value += mValuesListView.Items[i].Text;
      }

      mDisableListUpdate = true;
      mValueTextBox.Text = value;
      mDisableListUpdate = false;
    }
  }
}
