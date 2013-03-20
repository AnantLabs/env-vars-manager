using System;
using System.Collections;
using System.Windows.Forms;
using System.Security;
using System.Drawing;

namespace EnvVarsManager
{
  public partial class MainForm : Form
  {
    private Worker mWorker = new Worker();

    private ListViewGroup mUserVariablesViewGroup = new ListViewGroup("User", HorizontalAlignment.Left);
    private ListViewGroup mSystemVariablesViewGroup = new ListViewGroup("System", HorizontalAlignment.Left);

    private bool mSearchWasFocused = false;

    public MainForm()
    {
      InitializeComponent();

      ReloadList();
    }

    private void mRefreshMainMenuItem_Click(object sender, EventArgs e)
    {
      ReloadList();
    }

    private void mRefreshButton_Click(object sender, EventArgs e)
    {
      ReloadList();
    }

    private void mExitMainMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void mAddUserMainMenuItem_Click(object sender, EventArgs e)
    {
      EditVariable(EnvironmentVariableTarget.User, "", "");
    }

    private void mAddSystemMainMenuItem_Click(object sender, EventArgs e)
    {
      EditVariable(EnvironmentVariableTarget.Machine, "", "");
    }

    private void mRemoveMainMenuItem_Click(object sender, EventArgs e)
    {
      RemoveVariable();
    }

    private void mVariablesListView_ItemActivate(object sender, EventArgs e)
    {
      if (mVariablesListView.SelectedItems.Count == 0)
        return;

      ListViewItem item = mVariablesListView.SelectedItems[0];

      EnvironmentVariableTarget target = GetTargetByGroup(item.Group);
      string name = item.Text;
      string value = item.SubItems[1].Text;

      EditVariable(target, name, value);
    }

    private void mAddUserVariableButton_Click(object sender, EventArgs e)
    {
      EditVariable(EnvironmentVariableTarget.User, "", "");
    }

    private void mAddUserContextMenuItem_Click(object sender, EventArgs e)
    {
      EditVariable(EnvironmentVariableTarget.User, "", "");
    }

    private void mAddSystemVariableButton_Click(object sender, EventArgs e)
    {
      EditVariable(EnvironmentVariableTarget.Machine, "", "");
    }

    private void mAddSystemContextMenuItem_Click(object sender, EventArgs e)
    {
      EditVariable(EnvironmentVariableTarget.Machine, "", "");
    }

    private void mRemoveVariableButton_Click(object sender, EventArgs e)
    {
      RemoveVariable();
    }

    private void mRemoveContextMenuItem_Click(object sender, EventArgs e)
    {
      RemoveVariable();
    }


    private void ReloadList()
    {
      mVariablesListView.Items.Clear();

      IDictionary entries;

      entries = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);
      AddEntriesToList(entries, mVariablesListView.Groups["User"]);

      entries = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);
      AddEntriesToList(entries, mVariablesListView.Groups["System"]);
    }

    private void AddEntriesToList(IDictionary entries, ListViewGroup group)
    {
      if (entries == null || entries.Count == 0)
        return;

      string value;
      string key;
      foreach (DictionaryEntry entry in entries)
      {
        key = (string)entry.Key;
        value = (string)entry.Value;

        ListViewItem item;
        if (group != null)
          item = new ListViewItem(key, group);
        else
          item = new ListViewItem(key);

        item.SubItems.Add(value);

        mVariablesListView.Items.Add(item);
      }
    }

    private void EditVariable(EnvironmentVariableTarget target, string name, string value)
    {
      EditVariableForm form = new EditVariableForm(name, value);
      DialogResult r = form.ShowDialog();
      if (r == DialogResult.OK)
      {
        Cursor = Cursors.WaitCursor;

        if (name != form.VariableName)
        {
          // Add new variable
          if (form.VariableName != null)
            DoSetEnvironmentVariable(form.VariableName, form.VariableValue, target);
          // Remove old variable
          if (name != null && name.Length != 0)
            DoSetEnvironmentVariable(name, null, target);
        }
        else if (value != form.VariableValue)
        {
          // Set new variable's value
          DoSetEnvironmentVariable(form.VariableName, form.VariableValue, target);
        }

        ReloadList();

        ListViewItem item = mVariablesListView.Items[form.VariableName];
        if (item != null)
          item.Selected = true;

        Cursor = Cursors.Default;
      }

      mVariablesListView.Focus();
    }

    private void RemoveVariable()
    {
      if (mVariablesListView.SelectedIndices.Count > 0)
      {
        Cursor = Cursors.WaitCursor;

        int ind = mVariablesListView.SelectedIndices[0];

        EnvironmentVariableTarget target = GetTargetByGroup(mVariablesListView.Items[ind].Group);
        string name = mVariablesListView.Items[ind].Text;

        if (name != null && name.Length != 0)
        {
          DoSetEnvironmentVariable(name, null, target);
          ReloadList();

          if (ind < mVariablesListView.Items.Count)
            mVariablesListView.Items[ind].Selected = true;
          else if (ind > 0)
            mVariablesListView.Items[ind - 1].Selected = true;
        }

        Cursor = Cursors.Default;
      }

      mVariablesListView.Focus();
    }

    private EnvironmentVariableTarget GetTargetByGroup(ListViewGroup g)
    {
      if (g != null && g.Name == "System")
        return EnvironmentVariableTarget.Machine;
      return EnvironmentVariableTarget.User;
    }

    private void DoSetEnvironmentVariable(string n, string v, EnvironmentVariableTarget t)
    {
      string cmd = "SetEnvironmentVariable";
      cmd += Worker.kCmdDelimiter;
      cmd += n;
      cmd += Worker.kCmdDelimiter;
      cmd += v;
      cmd += Worker.kCmdDelimiter;
      cmd += t == EnvironmentVariableTarget.Machine ? "Machine" : "User";

      mWorker.DoCommand(cmd);
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        // Set focus on search box
        if (keyData == (Keys.Control | Keys.F))
        {
            mSearchTextBox.Focus();
            return true;
        }
        // Toggle search result mode
        else if (keyData == (Keys.Control | Keys.S))
        {
            mExcludingSearchCheckBox.Checked = !mExcludingSearchCheckBox.Checked;
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void mSearchTextBox_Enter(object sender, EventArgs e)
    {
      if (!mSearchWasFocused)
      {
        mSearchWasFocused = true;
        mSearchTextBox.Text = "";
      }
    }

    private void mSearchTextBox_TextChanged(object sender, EventArgs e)
    {
      string searchText = mSearchTextBox.Text;
    }

    private void mExcludingSearchCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        //
    }
  }
}
