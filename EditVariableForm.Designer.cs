namespace EnvVarsManager
{
  partial class EditVariableForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVariableForm));
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("546773");
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("4567htg");
      this.mNameTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.mValueUpButton = new System.Windows.Forms.Button();
      this.mValueDownButton = new System.Windows.Forms.Button();
      this.mValuesListView = new System.Windows.Forms.ListView();
      this.mValueTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.mOKButton = new System.Windows.Forms.Button();
      this.mCancelButton = new System.Windows.Forms.Button();
      this.mValueAddButton = new System.Windows.Forms.Button();
      this.mValueDelButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // mNameTextBox
      // 
      this.mNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mNameTextBox.Location = new System.Drawing.Point(61, 12);
      this.mNameTextBox.Name = "mNameTextBox";
      this.mNameTextBox.Size = new System.Drawing.Size(468, 20);
      this.mNameTextBox.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Name:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Values:";
      // 
      // mValueUpButton
      // 
      this.mValueUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.mValueUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mValueUpButton.Image = ((System.Drawing.Image)(resources.GetObject("mValueUpButton.Image")));
      this.mValueUpButton.Location = new System.Drawing.Point(489, 78);
      this.mValueUpButton.Name = "mValueUpButton";
      this.mValueUpButton.Size = new System.Drawing.Size(40, 40);
      this.mValueUpButton.TabIndex = 3;
      this.mValueUpButton.Click += new System.EventHandler(this.mValueUpButton_Click);
      // 
      // mValueDownButton
      // 
      this.mValueDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.mValueDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mValueDownButton.Image = ((System.Drawing.Image)(resources.GetObject("mValueDownButton.Image")));
      this.mValueDownButton.Location = new System.Drawing.Point(489, 124);
      this.mValueDownButton.Name = "mValueDownButton";
      this.mValueDownButton.Size = new System.Drawing.Size(40, 40);
      this.mValueDownButton.TabIndex = 3;
      this.mValueDownButton.Click += new System.EventHandler(this.mValueDownButton_Click);
      // 
      // mValuesListView
      // 
      this.mValuesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mValuesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      this.mValuesListView.HideSelection = false;
      listViewItem1.StateImageIndex = 0;
      listViewItem2.StateImageIndex = 0;
      this.mValuesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
      this.mValuesListView.LabelEdit = true;
      this.mValuesListView.LabelWrap = false;
      this.mValuesListView.Location = new System.Drawing.Point(61, 78);
      this.mValuesListView.MultiSelect = false;
      this.mValuesListView.Name = "mValuesListView";
      this.mValuesListView.Size = new System.Drawing.Size(422, 248);
      this.mValuesListView.TabIndex = 4;
      this.mValuesListView.UseCompatibleStateImageBehavior = false;
      this.mValuesListView.View = System.Windows.Forms.View.List;
      this.mValuesListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.mValuesListView_AfterLabelEdit);
      this.mValuesListView.DoubleClick += new System.EventHandler(this.mValuesListView_DoubleClick);
      // 
      // mValueTextBox
      // 
      this.mValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mValueTextBox.Location = new System.Drawing.Point(61, 38);
      this.mValueTextBox.Name = "mValueTextBox";
      this.mValueTextBox.Size = new System.Drawing.Size(468, 20);
      this.mValueTextBox.TabIndex = 0;
      this.mValueTextBox.TextChanged += new System.EventHandler(this.mValueTextBox_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 41);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Value:";
      // 
      // mOKButton
      // 
      this.mOKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.mOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.mOKButton.Location = new System.Drawing.Point(323, 332);
      this.mOKButton.Name = "mOKButton";
      this.mOKButton.Size = new System.Drawing.Size(100, 32);
      this.mOKButton.TabIndex = 5;
      this.mOKButton.Text = "OK";
      this.mOKButton.UseVisualStyleBackColor = true;
      // 
      // mCancelButton
      // 
      this.mCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.mCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.mCancelButton.Location = new System.Drawing.Point(429, 332);
      this.mCancelButton.Name = "mCancelButton";
      this.mCancelButton.Size = new System.Drawing.Size(100, 32);
      this.mCancelButton.TabIndex = 6;
      this.mCancelButton.Text = "Cancel";
      this.mCancelButton.UseVisualStyleBackColor = true;
      // 
      // mValueAddButton
      // 
      this.mValueAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.mValueAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mValueAddButton.Image = ((System.Drawing.Image)(resources.GetObject("mValueAddButton.Image")));
      this.mValueAddButton.Location = new System.Drawing.Point(489, 240);
      this.mValueAddButton.Name = "mValueAddButton";
      this.mValueAddButton.Size = new System.Drawing.Size(40, 40);
      this.mValueAddButton.TabIndex = 3;
      this.mValueAddButton.UseVisualStyleBackColor = true;
      this.mValueAddButton.Click += new System.EventHandler(this.mValueAddButton_Click);
      // 
      // mValueDelButton
      // 
      this.mValueDelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.mValueDelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mValueDelButton.Image = ((System.Drawing.Image)(resources.GetObject("mValueDelButton.Image")));
      this.mValueDelButton.Location = new System.Drawing.Point(489, 286);
      this.mValueDelButton.Name = "mValueDelButton";
      this.mValueDelButton.Size = new System.Drawing.Size(40, 40);
      this.mValueDelButton.TabIndex = 3;
      this.mValueDelButton.UseVisualStyleBackColor = true;
      this.mValueDelButton.Click += new System.EventHandler(this.mValueDelButton_Click);
      // 
      // EditVariableForm
      // 
      this.AcceptButton = this.mOKButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.mCancelButton;
      this.ClientSize = new System.Drawing.Size(541, 376);
      this.Controls.Add(this.mNameTextBox);
      this.Controls.Add(this.mCancelButton);
      this.Controls.Add(this.mOKButton);
      this.Controls.Add(this.mValuesListView);
      this.Controls.Add(this.mValueDownButton);
      this.Controls.Add(this.mValueDelButton);
      this.Controls.Add(this.mValueAddButton);
      this.Controls.Add(this.mValueUpButton);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.mValueTextBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditVariableForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Edit Variable";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox mNameTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button mValueUpButton;
    private System.Windows.Forms.Button mValueDownButton;
    private System.Windows.Forms.ListView mValuesListView;
    private System.Windows.Forms.TextBox mValueTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button mOKButton;
    private System.Windows.Forms.Button mCancelButton;
    private System.Windows.Forms.Button mValueAddButton;
    private System.Windows.Forms.Button mValueDelButton;
  }
}