namespace MessageExplorer
{
    partial class MessageSubscriber
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.entityListBox = new System.Windows.Forms.ListBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.subscriberListBox = new System.Windows.Forms.ListBox();
            this.entityLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.entityCheckBox = new System.Windows.Forms.CheckBox();
            this.messageCheckBox = new System.Windows.Forms.CheckBox();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(838, 32);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(129, 29);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbSample
            // 
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(23, 29);
            // 
            // entityListBox
            // 
            this.entityListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityListBox.FormattingEnabled = true;
            this.entityListBox.ItemHeight = 20;
            this.entityListBox.Location = new System.Drawing.Point(0, 0);
            this.entityListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entityListBox.Name = "entityListBox";
            this.entityListBox.Size = new System.Drawing.Size(250, 430);
            this.entityListBox.TabIndex = 5;
            this.entityListBox.SelectedIndexChanged += new System.EventHandler(this.EntityListBox_SelectedIndexChanged);
            // 
            // messageListBox
            // 
            this.messageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 20;
            this.messageListBox.Location = new System.Drawing.Point(0, 0);
            this.messageListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(244, 430);
            this.messageListBox.TabIndex = 7;
            this.messageListBox.SelectedIndexChanged += new System.EventHandler(this.MessageListBox_SelectedIndexChanged);
            // 
            // subscriberListBox
            // 
            this.subscriberListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subscriberListBox.FormattingEnabled = true;
            this.subscriberListBox.ItemHeight = 20;
            this.subscriberListBox.Location = new System.Drawing.Point(500, 32);
            this.subscriberListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subscriberListBox.Name = "subscriberListBox";
            this.subscriberListBox.Size = new System.Drawing.Size(338, 430);
            this.subscriberListBox.TabIndex = 8;
            // 
            // entityLabel
            // 
            this.entityLabel.AutoSize = true;
            this.entityLabel.Location = new System.Drawing.Point(184, 7);
            this.entityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entityLabel.Name = "entityLabel";
            this.entityLabel.Size = new System.Drawing.Size(161, 20);
            this.entityLabel.TabIndex = 9;
            this.entityLabel.Text = "Show unused entities";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(394, 7);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(183, 20);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "Show unused messages";
            // 
            // entityCheckBox
            // 
            this.entityCheckBox.AutoSize = true;
            this.entityCheckBox.Location = new System.Drawing.Point(155, 6);
            this.entityCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entityCheckBox.Name = "entityCheckBox";
            this.entityCheckBox.Size = new System.Drawing.Size(22, 21);
            this.entityCheckBox.TabIndex = 12;
            this.entityCheckBox.UseVisualStyleBackColor = true;
            this.entityCheckBox.CheckedChanged += new System.EventHandler(this.EntityCheckBox_Changed);
            // 
            // messageCheckBox
            // 
            this.messageCheckBox.AutoSize = true;
            this.messageCheckBox.Location = new System.Drawing.Point(368, 6);
            this.messageCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageCheckBox.Name = "messageCheckBox";
            this.messageCheckBox.Size = new System.Drawing.Size(22, 21);
            this.messageCheckBox.TabIndex = 13;
            this.messageCheckBox.UseVisualStyleBackColor = true;
            this.messageCheckBox.CheckedChanged += new System.EventHandler(this.MessageCheckBox_Changed);
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainContainer.Location = new System.Drawing.Point(0, 32);
            this.MainContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainContainer.MaximumSize = new System.Drawing.Size(500, 0);
            this.MainContainer.MinimumSize = new System.Drawing.Size(300, 0);
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
            this.MainContainer.Size = new System.Drawing.Size(500, 430);
            this.MainContainer.SplitterDistance = 250;
            this.MainContainer.SplitterWidth = 6;
            this.MainContainer.TabIndex = 14;
            // 
            // MessageSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entityCheckBox);
            this.Controls.Add(this.subscriberListBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.entityLabel);
            this.Controls.Add(this.messageCheckBox);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MessageSubscriber";
            this.Size = new System.Drawing.Size(838, 462);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.MessageExplorer_ConnectionUpdated);
            this.Load += new System.EventHandler(this.MessageExplorer_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ListBox entityListBox;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.ListBox subscriberListBox;
        private System.Windows.Forms.Label entityLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.CheckBox entityCheckBox;
        private System.Windows.Forms.CheckBox messageCheckBox;
        private System.Windows.Forms.SplitContainer MainContainer;
    }
}
