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
            this.toolStripMenu.SuspendLayout();
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
            this.toolStripMenu.Size = new System.Drawing.Size(559, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSample
            // 
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(23, 22);
            // 
            // entityListBox
            // 
            this.entityListBox.FormattingEnabled = true;
            this.entityListBox.Location = new System.Drawing.Point(3, 59);
            this.entityListBox.Name = "entityListBox";
            this.entityListBox.Size = new System.Drawing.Size(150, 238);
            this.entityListBox.TabIndex = 5;
            this.entityListBox.SelectedIndexChanged += new System.EventHandler(this.entityListBox_SelectedIndexChanged);
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.Location = new System.Drawing.Point(160, 59);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(142, 238);
            this.messageListBox.TabIndex = 7;
            this.messageListBox.SelectedIndexChanged += new System.EventHandler(this.messageListBox_SelectedIndexChanged);
            // 
            // subscriberListBox
            // 
            this.subscriberListBox.FormattingEnabled = true;
            this.subscriberListBox.Location = new System.Drawing.Point(308, 59);
            this.subscriberListBox.MaximumSize = new System.Drawing.Size(500, 238);
            this.subscriberListBox.Name = "subscriberListBox";
            this.subscriberListBox.Size = new System.Drawing.Size(351, 238);
            this.subscriberListBox.TabIndex = 8;
            // 
            // entityLabel
            // 
            this.entityLabel.AutoSize = true;
            this.entityLabel.Location = new System.Drawing.Point(18, 40);
            this.entityLabel.Name = "entityLabel";
            this.entityLabel.Size = new System.Drawing.Size(108, 13);
            this.entityLabel.TabIndex = 9;
            this.entityLabel.Text = "Show unused entities";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(178, 40);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(122, 13);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "Show unused messages";
            // 
            // entityCheckBox
            // 
            this.entityCheckBox.AutoSize = true;
            this.entityCheckBox.Location = new System.Drawing.Point(3, 40);
            this.entityCheckBox.Name = "entityCheckBox";
            this.entityCheckBox.Size = new System.Drawing.Size(15, 14);
            this.entityCheckBox.TabIndex = 12;
            this.entityCheckBox.UseVisualStyleBackColor = true;
            this.entityCheckBox.CheckedChanged += new System.EventHandler(this.entityCheckBox_changed);
            // 
            // messageCheckBox
            // 
            this.messageCheckBox.AutoSize = true;
            this.messageCheckBox.Location = new System.Drawing.Point(161, 39);
            this.messageCheckBox.Name = "messageCheckBox";
            this.messageCheckBox.Size = new System.Drawing.Size(15, 14);
            this.messageCheckBox.TabIndex = 13;
            this.messageCheckBox.UseVisualStyleBackColor = true;
            this.messageCheckBox.CheckedChanged += new System.EventHandler(this.messageCheckBox_changed);
            // 
            // MessageSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageCheckBox);
            this.Controls.Add(this.entityCheckBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.entityLabel);
            this.Controls.Add(this.subscriberListBox);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.entityListBox);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MessageSubscriber";
            this.Size = new System.Drawing.Size(559, 300);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
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
    }
}
