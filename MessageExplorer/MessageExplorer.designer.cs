namespace MessageExplorer
{
    partial class EntityExplorer
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityExplorer));
            this.EntityListBox = new System.Windows.Forms.CheckedListBox();
            this.MessageView = new System.Windows.Forms.DataGridView();
            this.SubscriberListBox = new System.Windows.Forms.ListBox();
            this.entityLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.entityCheckBox = new System.Windows.Forms.CheckBox();
            this.messageCheckBox = new System.Windows.Forms.CheckBox();
            this.EntityPanel = new System.Windows.Forms.Panel();
            this.EntitySearchPanel = new System.Windows.Forms.Panel();
            this.EntitySearchBox = new System.Windows.Forms.TextBox();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.includeMessageCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn(false);
            this.visualStudioToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.visualStudioToolStripExtender2 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.doubleClickToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExportButton = new System.Windows.Forms.Button();
            this.MessageSubscriberSplitter = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.MessageView)).BeginInit();
            this.EntityPanel.SuspendLayout();
            this.EntitySearchPanel.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSubscriberSplitter)).BeginInit();
            this.MessageSubscriberSplitter.Panel1.SuspendLayout();
            this.MessageSubscriberSplitter.Panel2.SuspendLayout();
            this.MessageSubscriberSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntityListBox
            // 
            this.EntityListBox.CheckOnClick = true;
            this.EntityListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityListBox.FormattingEnabled = true;
            this.EntityListBox.Location = new System.Drawing.Point(0, 21);
            this.EntityListBox.Name = "EntityListBox";
            this.EntityListBox.Size = new System.Drawing.Size(200, 396);
            this.EntityListBox.TabIndex = 5;
            this.EntityListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EntityListBox_SelectedIndexChanged);
            // 
            // MessageView
            // 
            this.MessageView.AllowUserToAddRows = false;
            this.MessageView.AllowUserToDeleteRows = false;
            this.MessageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageView.Location = new System.Drawing.Point(0, 0);
            this.MessageView.Name = "MessageView";
            this.MessageView.Size = new System.Drawing.Size(357, 130);
            this.MessageView.TabIndex = 7;
            this.MessageView.CellContentClick += MessageView_CellClick;
            this.MessageView.CellValueChanged += MessageView_IncludeChanged;
            // 
            // SubscriberListBox
            // 
            this.SubscriberListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubscriberListBox.FormattingEnabled = true;
            this.SubscriberListBox.Location = new System.Drawing.Point(0, 0);
            this.SubscriberListBox.Name = "SubscriberListBox";
            this.SubscriberListBox.Size = new System.Drawing.Size(357, 283);
            this.SubscriberListBox.Sorted = true;
            this.SubscriberListBox.TabIndex = 8;
            this.doubleClickToolTip.SetToolTip(this.SubscriberListBox, "Double click to show more information");
            this.SubscriberListBox.DoubleClick += new System.EventHandler(this.SubscriberListBox_MouseDoubleClick);
            // 
            // entityLabel
            // 
            this.entityLabel.AutoSize = true;
            this.entityLabel.Location = new System.Drawing.Point(202, 5);
            this.entityLabel.Name = "entityLabel";
            this.entityLabel.Size = new System.Drawing.Size(108, 13);
            this.entityLabel.TabIndex = 9;
            this.entityLabel.Text = "Show unused entities";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(336, 5);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(122, 13);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "Show unused messages";
            // 
            // entityCheckBox
            // 
            this.entityCheckBox.AutoSize = true;
            this.entityCheckBox.Location = new System.Drawing.Point(185, 5);
            this.entityCheckBox.Name = "entityCheckBox";
            this.entityCheckBox.Size = new System.Drawing.Size(15, 14);
            this.entityCheckBox.TabIndex = 12;
            this.entityCheckBox.UseVisualStyleBackColor = true;
            this.entityCheckBox.CheckedChanged += new System.EventHandler(this.EntityCheckBox_Changed);
            // 
            // messageCheckBox
            // 
            this.messageCheckBox.AutoSize = true;
            this.messageCheckBox.Location = new System.Drawing.Point(322, 5);
            this.messageCheckBox.Name = "messageCheckBox";
            this.messageCheckBox.Size = new System.Drawing.Size(15, 14);
            this.messageCheckBox.TabIndex = 13;
            this.messageCheckBox.UseVisualStyleBackColor = true;
            this.messageCheckBox.CheckedChanged += new System.EventHandler(this.MessageCheckBox_Changed);
            // 
            // EntityPanel
            // 
            this.EntityPanel.AllowDrop = true;
            this.EntityPanel.Controls.Add(this.EntityListBox);
            this.EntityPanel.Controls.Add(this.EntitySearchPanel);
            this.EntityPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EntityPanel.Location = new System.Drawing.Point(0, 25);
            this.EntityPanel.MaximumSize = new System.Drawing.Size(200, 0);
            this.EntityPanel.MinimumSize = new System.Drawing.Size(200, 0);
            this.EntityPanel.Name = "EntityPanel";
            this.EntityPanel.Size = new System.Drawing.Size(200, 417);
            this.EntityPanel.TabIndex = 14;
            // 
            // EntitySearchPanel
            // 
            this.EntitySearchPanel.AllowDrop = true;
            this.EntitySearchPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EntitySearchPanel.Controls.Add(this.EntitySearchBox);
            this.EntitySearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntitySearchPanel.Location = new System.Drawing.Point(0, 0);
            this.EntitySearchPanel.MaximumSize = new System.Drawing.Size(0, 21);
            this.EntitySearchPanel.Name = "EntitySearchPanel";
            this.EntitySearchPanel.Size = new System.Drawing.Size(200, 21);
            this.EntitySearchPanel.TabIndex = 9;
            // 
            // EntitySearchBox
            // 
            this.EntitySearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntitySearchBox.Location = new System.Drawing.Point(0, 0);
            this.EntitySearchBox.Name = "EntitySearchBox";
            this.EntitySearchBox.Size = new System.Drawing.Size(200, 20);
            this.EntitySearchBox.TabIndex = 8;
            this.EntitySearchBox.TextChanged += new System.EventHandler(this.EntitySearchBox_Search);
            //
            // 
            //
            this.includeMessageCheckBoxColumn.DisplayIndex = 0;
            this.includeMessageCheckBoxColumn.Name = "IncludeMessage";
            this.includeMessageCheckBoxColumn.HeaderText = "Include";
            this.includeMessageCheckBoxColumn.FalseValue = 0;
            this.includeMessageCheckBoxColumn.TrueValue = 1;
            this.includeMessageCheckBoxColumn.ReadOnly = false;

            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshButton
            // 
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(76, 22);
            this.refreshButton.Text = "Refresh data";
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.refreshButton,
            this.toolStripSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(557, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // visualStudioToolStripExtender1
            // 
            this.visualStudioToolStripExtender1.DefaultRenderer = null;
            // 
            // visualStudioToolStripExtender2
            // 
            this.visualStudioToolStripExtender2.DefaultRenderer = null;
            // 
            // doubleClickToolTip
            // 
            this.doubleClickToolTip.ToolTipTitle = "Show more";
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(499, 2);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(56, 19);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // MessageSubscriberSplitter
            // 
            this.MessageSubscriberSplitter.AllowDrop = true;
            this.MessageSubscriberSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageSubscriberSplitter.IsSplitterFixed = true;
            this.MessageSubscriberSplitter.Location = new System.Drawing.Point(200, 25);
            this.MessageSubscriberSplitter.Name = "MessageSubscriberSplitter";
            this.MessageSubscriberSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MessageSubscriberSplitter.Panel1
            // 
            this.MessageSubscriberSplitter.Panel1.Controls.Add(this.MessageView);
            // 
            // MessageSubscriberSplitter.Panel2
            // 
            this.MessageSubscriberSplitter.Panel2.Controls.Add(this.SubscriberListBox);
            this.MessageSubscriberSplitter.Size = new System.Drawing.Size(357, 417);
            this.MessageSubscriberSplitter.SplitterDistance = 130;
            this.MessageSubscriberSplitter.TabIndex = 15;
            // 
            // EntityExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MessageSubscriberSplitter);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.entityCheckBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.entityLabel);
            this.Controls.Add(this.messageCheckBox);
            this.Controls.Add(this.EntityPanel);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "EntityExplorer";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(557, 442);
            this.TabIcon = ((System.Drawing.Image)(resources.GetObject("$this.TabIcon")));
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.MessageExplorer_ConnectionUpdated);
            this.Load += new System.EventHandler(this.MessageExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MessageView)).EndInit();
            this.EntityPanel.ResumeLayout(false);
            this.EntitySearchPanel.ResumeLayout(false);
            this.EntitySearchPanel.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.MessageSubscriberSplitter.Panel1.ResumeLayout(false);
            this.MessageSubscriberSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MessageSubscriberSplitter)).EndInit();
            this.MessageSubscriberSplitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox EntityListBox;
        private System.Windows.Forms.DataGridView MessageView;
        private System.Windows.Forms.ListBox SubscriberListBox;
        private System.Windows.Forms.Label entityLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.CheckBox entityCheckBox;
        private System.Windows.Forms.CheckBox messageCheckBox;
        private System.Windows.Forms.Panel EntityPanel;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender visualStudioToolStripExtender1;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender visualStudioToolStripExtender2;
        private System.Windows.Forms.ToolTip doubleClickToolTip;
        private System.Windows.Forms.TextBox EntitySearchBox;
        private System.Windows.Forms.Panel EntitySearchPanel;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.SplitContainer MessageSubscriberSplitter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn includeMessageCheckBoxColumn;
    }
}
