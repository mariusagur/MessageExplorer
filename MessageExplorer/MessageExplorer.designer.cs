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
            this.entityListBox = new System.Windows.Forms.ListBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.subscriberListBox = new System.Windows.Forms.ListBox();
            this.entityLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.entityCheckBox = new System.Windows.Forms.CheckBox();
            this.messageCheckBox = new System.Windows.Forms.CheckBox();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.visualStudioToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.visualStudioToolStripExtender2 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.doubleClickToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityListBox
            // 
            this.entityListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityListBox.FormattingEnabled = true;
            this.entityListBox.Location = new System.Drawing.Point(0, 0);
            this.entityListBox.Name = "entityListBox";
            this.entityListBox.Size = new System.Drawing.Size(166, 275);
            this.entityListBox.Sorted = true;
            this.entityListBox.TabIndex = 5;
            this.entityListBox.SelectedIndexChanged += new System.EventHandler(this.EntityListBox_SelectedIndexChanged);
            // 
            // messageListBox
            // 
            this.messageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.Location = new System.Drawing.Point(0, 0);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(163, 275);
            this.messageListBox.Sorted = true;
            this.messageListBox.TabIndex = 7;
            this.messageListBox.SelectedIndexChanged += new System.EventHandler(this.MessageListBox_SelectedIndexChanged);
            // 
            // subscriberListBox
            // 
            this.subscriberListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subscriberListBox.FormattingEnabled = true;
            this.subscriberListBox.Location = new System.Drawing.Point(333, 25);
            this.subscriberListBox.Name = "subscriberListBox";
            this.subscriberListBox.Size = new System.Drawing.Size(226, 275);
            this.subscriberListBox.Sorted = true;
            this.subscriberListBox.TabIndex = 8;
            this.subscriberListBox.DoubleClick += new System.EventHandler(this.SubscriberListBox_MouseDoubleClick);
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
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainContainer.Location = new System.Drawing.Point(0, 25);
            this.MainContainer.MaximumSize = new System.Drawing.Size(333, 0);
            this.MainContainer.MinimumSize = new System.Drawing.Size(200, 0);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.AllowDrop = true;
            this.MainContainer.Panel1.Controls.Add(this.entityListBox);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.AllowDrop = true;
            this.MainContainer.Panel2.Controls.Add(this.messageListBox);
            this.MainContainer.Size = new System.Drawing.Size(333, 275);
            this.MainContainer.SplitterDistance = 166;
            this.MainContainer.TabIndex = 14;
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
            this.toolStripMenu.Size = new System.Drawing.Size(559, 25);
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
            this.doubleClickToolTip.ToolTipTitle = "Double click for more information";
            // 
            // EntityExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entityCheckBox);
            this.Controls.Add(this.subscriberListBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.entityLabel);
            this.Controls.Add(this.messageCheckBox);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "EntityExplorer";
            this.Size = new System.Drawing.Size(559, 300);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.MessageExplorer_ConnectionUpdated);
            this.Load += new System.EventHandler(this.MessageExplorer_Load);
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox entityListBox;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.ListBox subscriberListBox;
        private System.Windows.Forms.Label entityLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.CheckBox entityCheckBox;
        private System.Windows.Forms.CheckBox messageCheckBox;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender visualStudioToolStripExtender1;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender visualStudioToolStripExtender2;
        private System.Windows.Forms.ToolTip doubleClickToolTip;
    }
}
