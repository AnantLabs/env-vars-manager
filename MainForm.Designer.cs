namespace EnvVarsManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader mUserVariablesListViewColumnHeader2;
            System.Windows.Forms.ColumnHeader mUserVariablesListViewColumnHeader3;
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("User Variables", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("System Variables", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("356753");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "54367",
            "4564"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mFileMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRefreshMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mExitMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddUserMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddSystemMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRemoveMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mMainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mVariablesGroupBox = new System.Windows.Forms.GroupBox();
            this.mSearchTextBox = new System.Windows.Forms.TextBox();
            this.mRefreshButton = new System.Windows.Forms.Button();
            this.mRemoveVariableButton = new System.Windows.Forms.Button();
            this.mAddSystemVariableButton = new System.Windows.Forms.Button();
            this.mAddUserVariableButton = new System.Windows.Forms.Button();
            this.mVariablesListView = new System.Windows.Forms.ListView();
            this.mVariablesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mAddUserContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddSystemContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRemoveContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mUserVariablesListViewColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            mUserVariablesListViewColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mMainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMainSplitContainer)).BeginInit();
            this.mMainSplitContainer.Panel1.SuspendLayout();
            this.mMainSplitContainer.SuspendLayout();
            this.mVariablesGroupBox.SuspendLayout();
            this.mVariablesContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mUserVariablesListViewColumnHeader2
            // 
            mUserVariablesListViewColumnHeader2.Text = "Name";
            mUserVariablesListViewColumnHeader2.Width = 200;
            // 
            // mUserVariablesListViewColumnHeader3
            // 
            mUserVariablesListViewColumnHeader3.Text = "Value";
            mUserVariablesListViewColumnHeader3.Width = 473;
            // 
            // mMainMenuStrip
            // 
            this.mMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileMainMenuItem,
            this.variablesToolStripMenuItem});
            this.mMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mMainMenuStrip.Name = "mMainMenuStrip";
            this.mMainMenuStrip.Size = new System.Drawing.Size(844, 24);
            this.mMainMenuStrip.TabIndex = 0;
            this.mMainMenuStrip.Text = "Main Menu";
            // 
            // mFileMainMenuItem
            // 
            this.mFileMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRefreshMainMenuItem,
            this.toolStripMenuItem1,
            this.mExitMainMenuItem});
            this.mFileMainMenuItem.Name = "mFileMainMenuItem";
            this.mFileMainMenuItem.Size = new System.Drawing.Size(37, 20);
            this.mFileMainMenuItem.Text = "File";
            // 
            // mRefreshMainMenuItem
            // 
            this.mRefreshMainMenuItem.Image = global::EnvVarsManager.Properties.Resources.Refresh;
            this.mRefreshMainMenuItem.Name = "mRefreshMainMenuItem";
            this.mRefreshMainMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mRefreshMainMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mRefreshMainMenuItem.Text = "Refresh";
            this.mRefreshMainMenuItem.Click += new System.EventHandler(this.mRefreshMainMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // mExitMainMenuItem
            // 
            this.mExitMainMenuItem.Name = "mExitMainMenuItem";
            this.mExitMainMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mExitMainMenuItem.Text = "Exit";
            this.mExitMainMenuItem.Click += new System.EventHandler(this.mExitMainMenuItem_Click);
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAddUserMainMenuItem,
            this.mAddSystemMainMenuItem,
            this.mRemoveMainMenuItem});
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.variablesToolStripMenuItem.Text = "Variables";
            // 
            // mAddUserMainMenuItem
            // 
            this.mAddUserMainMenuItem.Image = global::EnvVarsManager.Properties.Resources.Symbol_Add;
            this.mAddUserMainMenuItem.Name = "mAddUserMainMenuItem";
            this.mAddUserMainMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mAddUserMainMenuItem.Text = "Add User";
            this.mAddUserMainMenuItem.Click += new System.EventHandler(this.mAddUserMainMenuItem_Click);
            // 
            // mAddSystemMainMenuItem
            // 
            this.mAddSystemMainMenuItem.Image = global::EnvVarsManager.Properties.Resources.Vista_Shield;
            this.mAddSystemMainMenuItem.Name = "mAddSystemMainMenuItem";
            this.mAddSystemMainMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mAddSystemMainMenuItem.Text = "Add System";
            this.mAddSystemMainMenuItem.Click += new System.EventHandler(this.mAddSystemMainMenuItem_Click);
            // 
            // mRemoveMainMenuItem
            // 
            this.mRemoveMainMenuItem.Image = global::EnvVarsManager.Properties.Resources.Symbol_Delete;
            this.mRemoveMainMenuItem.Name = "mRemoveMainMenuItem";
            this.mRemoveMainMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mRemoveMainMenuItem.Text = "Remove";
            this.mRemoveMainMenuItem.Click += new System.EventHandler(this.mRemoveMainMenuItem_Click);
            // 
            // mMainSplitContainer
            // 
            this.mMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mMainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mMainSplitContainer.Margin = new System.Windows.Forms.Padding(5);
            this.mMainSplitContainer.Name = "mMainSplitContainer";
            // 
            // mMainSplitContainer.Panel1
            // 
            this.mMainSplitContainer.Panel1.Controls.Add(this.mVariablesGroupBox);
            this.mMainSplitContainer.Panel2Collapsed = true;
            this.mMainSplitContainer.Size = new System.Drawing.Size(844, 638);
            this.mMainSplitContainer.SplitterDistance = 508;
            this.mMainSplitContainer.TabIndex = 1;
            // 
            // mVariablesGroupBox
            // 
            this.mVariablesGroupBox.Controls.Add(this.mSearchTextBox);
            this.mVariablesGroupBox.Controls.Add(this.mRefreshButton);
            this.mVariablesGroupBox.Controls.Add(this.mRemoveVariableButton);
            this.mVariablesGroupBox.Controls.Add(this.mAddSystemVariableButton);
            this.mVariablesGroupBox.Controls.Add(this.mAddUserVariableButton);
            this.mVariablesGroupBox.Controls.Add(this.mVariablesListView);
            this.mVariablesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mVariablesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mVariablesGroupBox.Name = "mVariablesGroupBox";
            this.mVariablesGroupBox.Size = new System.Drawing.Size(844, 638);
            this.mVariablesGroupBox.TabIndex = 2;
            this.mVariablesGroupBox.TabStop = false;
            this.mVariablesGroupBox.Text = "Environment Variables";
            // 
            // mSearchTextBox
            // 
            this.mSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mSearchTextBox.Location = new System.Drawing.Point(138, 597);
            this.mSearchTextBox.Name = "mSearchTextBox";
            this.mSearchTextBox.Size = new System.Drawing.Size(220, 20);
            this.mSearchTextBox.TabIndex = 3;
            this.mSearchTextBox.Text = "Search text";
            this.mSearchTextBox.TextChanged += new System.EventHandler(this.mSearchTextBox_TextChanged);
            this.mSearchTextBox.Enter += new System.EventHandler(this.mSearchTextBox_Enter);
            // 
            // mRefreshButton
            // 
            this.mRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mRefreshButton.Image = global::EnvVarsManager.Properties.Resources.Refresh;
            this.mRefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mRefreshButton.Location = new System.Drawing.Point(12, 586);
            this.mRefreshButton.Name = "mRefreshButton";
            this.mRefreshButton.Size = new System.Drawing.Size(120, 40);
            this.mRefreshButton.TabIndex = 2;
            this.mRefreshButton.Text = "Refresh";
            this.mRefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mRefreshButton.UseVisualStyleBackColor = true;
            this.mRefreshButton.Click += new System.EventHandler(this.mRefreshButton_Click);
            // 
            // mRemoveVariableButton
            // 
            this.mRemoveVariableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mRemoveVariableButton.Image = global::EnvVarsManager.Properties.Resources.Symbol_Delete;
            this.mRemoveVariableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mRemoveVariableButton.Location = new System.Drawing.Point(712, 586);
            this.mRemoveVariableButton.Name = "mRemoveVariableButton";
            this.mRemoveVariableButton.Size = new System.Drawing.Size(120, 40);
            this.mRemoveVariableButton.TabIndex = 1;
            this.mRemoveVariableButton.Text = "Remove";
            this.mRemoveVariableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mRemoveVariableButton.UseVisualStyleBackColor = true;
            this.mRemoveVariableButton.Click += new System.EventHandler(this.mRemoveVariableButton_Click);
            // 
            // mAddSystemVariableButton
            // 
            this.mAddSystemVariableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mAddSystemVariableButton.Image = global::EnvVarsManager.Properties.Resources.Vista_Shield;
            this.mAddSystemVariableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mAddSystemVariableButton.Location = new System.Drawing.Point(571, 586);
            this.mAddSystemVariableButton.Name = "mAddSystemVariableButton";
            this.mAddSystemVariableButton.Size = new System.Drawing.Size(120, 40);
            this.mAddSystemVariableButton.TabIndex = 1;
            this.mAddSystemVariableButton.Text = "Add System";
            this.mAddSystemVariableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mAddSystemVariableButton.UseVisualStyleBackColor = true;
            this.mAddSystemVariableButton.Click += new System.EventHandler(this.mAddSystemVariableButton_Click);
            // 
            // mAddUserVariableButton
            // 
            this.mAddUserVariableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mAddUserVariableButton.Image = global::EnvVarsManager.Properties.Resources.Symbol_Add;
            this.mAddUserVariableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mAddUserVariableButton.Location = new System.Drawing.Point(445, 586);
            this.mAddUserVariableButton.Name = "mAddUserVariableButton";
            this.mAddUserVariableButton.Size = new System.Drawing.Size(120, 40);
            this.mAddUserVariableButton.TabIndex = 1;
            this.mAddUserVariableButton.Text = "Add User";
            this.mAddUserVariableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mAddUserVariableButton.UseVisualStyleBackColor = true;
            this.mAddUserVariableButton.Click += new System.EventHandler(this.mAddUserVariableButton_Click);
            // 
            // mVariablesListView
            // 
            this.mVariablesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mVariablesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            mUserVariablesListViewColumnHeader2,
            mUserVariablesListViewColumnHeader3});
            this.mVariablesListView.ContextMenuStrip = this.mVariablesContextMenu;
            this.mVariablesListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mVariablesListView.FullRowSelect = true;
            this.mVariablesListView.GridLines = true;
            listViewGroup1.Header = "User Variables";
            listViewGroup1.Name = "User";
            listViewGroup2.Header = "System Variables";
            listViewGroup2.Name = "System";
            this.mVariablesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.mVariablesListView.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.mVariablesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.mVariablesListView.Location = new System.Drawing.Point(12, 19);
            this.mVariablesListView.Name = "mVariablesListView";
            this.mVariablesListView.Size = new System.Drawing.Size(820, 561);
            this.mVariablesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mVariablesListView.TabIndex = 0;
            this.mVariablesListView.UseCompatibleStateImageBehavior = false;
            this.mVariablesListView.View = System.Windows.Forms.View.Details;
            this.mVariablesListView.ItemActivate += new System.EventHandler(this.mVariablesListView_ItemActivate);
            // 
            // mVariablesContextMenu
            // 
            this.mVariablesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAddUserContextMenuItem,
            this.mAddSystemContextMenuItem,
            this.mRemoveContextMenuItem});
            this.mVariablesContextMenu.Name = "mVariablesContextMenu";
            this.mVariablesContextMenu.Size = new System.Drawing.Size(138, 70);
            // 
            // mAddUserContextMenuItem
            // 
            this.mAddUserContextMenuItem.Image = global::EnvVarsManager.Properties.Resources.Symbol_Add;
            this.mAddUserContextMenuItem.Name = "mAddUserContextMenuItem";
            this.mAddUserContextMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mAddUserContextMenuItem.Text = "Add User";
            this.mAddUserContextMenuItem.Click += new System.EventHandler(this.mAddUserContextMenuItem_Click);
            // 
            // mAddSystemContextMenuItem
            // 
            this.mAddSystemContextMenuItem.Image = global::EnvVarsManager.Properties.Resources.Vista_Shield;
            this.mAddSystemContextMenuItem.Name = "mAddSystemContextMenuItem";
            this.mAddSystemContextMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mAddSystemContextMenuItem.Text = "Add System";
            this.mAddSystemContextMenuItem.Click += new System.EventHandler(this.mAddSystemContextMenuItem_Click);
            // 
            // mRemoveContextMenuItem
            // 
            this.mRemoveContextMenuItem.Image = global::EnvVarsManager.Properties.Resources.Symbol_Delete;
            this.mRemoveContextMenuItem.Name = "mRemoveContextMenuItem";
            this.mRemoveContextMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mRemoveContextMenuItem.Text = "Remove";
            this.mRemoveContextMenuItem.Click += new System.EventHandler(this.mRemoveContextMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 662);
            this.Controls.Add(this.mMainSplitContainer);
            this.Controls.Add(this.mMainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnvVarsManager";
            this.mMainMenuStrip.ResumeLayout(false);
            this.mMainMenuStrip.PerformLayout();
            this.mMainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mMainSplitContainer)).EndInit();
            this.mMainSplitContainer.ResumeLayout(false);
            this.mVariablesGroupBox.ResumeLayout(false);
            this.mVariablesGroupBox.PerformLayout();
            this.mVariablesContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mFileMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mExitMainMenuItem;
        private System.Windows.Forms.SplitContainer mMainSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem mRefreshMainMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.GroupBox mVariablesGroupBox;
        private System.Windows.Forms.Button mRemoveVariableButton;
        private System.Windows.Forms.Button mAddUserVariableButton;
        private System.Windows.Forms.ListView mVariablesListView;
        private System.Windows.Forms.ContextMenuStrip mVariablesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mAddUserContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRemoveContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAddSystemContextMenuItem;
        private System.Windows.Forms.Button mAddSystemVariableButton;
        private System.Windows.Forms.ToolStripMenuItem variablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAddUserMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAddSystemMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRemoveMainMenuItem;
        private System.Windows.Forms.Button mRefreshButton;
        private System.Windows.Forms.TextBox mSearchTextBox;
    }
}

