namespace MessageExplorer
{
    partial class ExportSubscribers
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MessageCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SubscriberLabel = new System.Windows.Forms.Label();
            this.MessageEntityCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageNameCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageIdCheckBox = new System.Windows.Forms.CheckBox();
            this.SubscriberMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.SubscriberEntityCheckBox = new System.Windows.Forms.CheckBox();
            this.SubscriberAttributeFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.SubscriberTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.SubscriberNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SubscriberIdCheckBox = new System.Windows.Forms.CheckBox();
            this.EntityCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportDataTextArea = new System.Windows.Forms.RichTextBox();
            this.JsonCsvToggle = new System.Windows.Forms.CheckBox();
            this.CsvHeadersCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CsvHeadersCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.JsonCsvToggle);
            this.splitContainer1.Panel1.Controls.Add(this.MessageCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.MessageLabel);
            this.splitContainer1.Panel1.Controls.Add(this.SubscriberLabel);
            this.splitContainer1.Panel1.Controls.Add(this.MessageEntityCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.MessageNameCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.MessageIdCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.SubscriberMessageCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.SubscriberEntityCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.SubscriberAttributeFilterCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.SubscriberTypeCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.SubscriberNameCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.SubscriberIdCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.EntityCheckBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExportDataTextArea);
            this.splitContainer1.Size = new System.Drawing.Size(600, 365);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // MessageCheckBox
            // 
            this.MessageCheckBox.AutoSize = true;
            this.MessageCheckBox.Checked = true;
            this.MessageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MessageCheckBox.Location = new System.Drawing.Point(17, 24);
            this.MessageCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MessageCheckBox.Name = "MessageCheckBox";
            this.MessageCheckBox.Size = new System.Drawing.Size(112, 17);
            this.MessageCheckBox.TabIndex = 12;
            this.MessageCheckBox.Text = "Include Messages";
            this.MessageCheckBox.UseVisualStyleBackColor = true;
            this.MessageCheckBox.CheckedChanged += new System.EventHandler(this.MessageCheckBox_CheckedChanged);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(15, 227);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(97, 13);
            this.MessageLabel.TabIndex = 11;
            this.MessageLabel.Text = "Message Attributes";
            // 
            // SubscriberLabel
            // 
            this.SubscriberLabel.AutoSize = true;
            this.SubscriberLabel.Location = new System.Drawing.Point(15, 66);
            this.SubscriberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubscriberLabel.Name = "SubscriberLabel";
            this.SubscriberLabel.Size = new System.Drawing.Size(103, 13);
            this.SubscriberLabel.TabIndex = 10;
            this.SubscriberLabel.Text = "Subscriber attributes";
            // 
            // MessageEntityCheckBox
            // 
            this.MessageEntityCheckBox.AutoSize = true;
            this.MessageEntityCheckBox.Checked = true;
            this.MessageEntityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MessageEntityCheckBox.Location = new System.Drawing.Point(17, 291);
            this.MessageEntityCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MessageEntityCheckBox.Name = "MessageEntityCheckBox";
            this.MessageEntityCheckBox.Size = new System.Drawing.Size(52, 17);
            this.MessageEntityCheckBox.TabIndex = 9;
            this.MessageEntityCheckBox.Text = "Entity";
            this.MessageEntityCheckBox.UseVisualStyleBackColor = true;
            this.MessageEntityCheckBox.CheckedChanged += new System.EventHandler(this.MessageEntityCheckBox_CheckedChanged);
            // 
            // MessageNameCheckBox
            // 
            this.MessageNameCheckBox.AutoSize = true;
            this.MessageNameCheckBox.Checked = true;
            this.MessageNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MessageNameCheckBox.Location = new System.Drawing.Point(17, 268);
            this.MessageNameCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MessageNameCheckBox.Name = "MessageNameCheckBox";
            this.MessageNameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.MessageNameCheckBox.TabIndex = 8;
            this.MessageNameCheckBox.Text = "Name";
            this.MessageNameCheckBox.UseVisualStyleBackColor = true;
            this.MessageNameCheckBox.CheckedChanged += new System.EventHandler(this.MessageNameCheckBox_CheckedChanged);
            // 
            // MessageIdCheckBox
            // 
            this.MessageIdCheckBox.AutoSize = true;
            this.MessageIdCheckBox.Checked = true;
            this.MessageIdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MessageIdCheckBox.Location = new System.Drawing.Point(17, 246);
            this.MessageIdCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MessageIdCheckBox.Name = "MessageIdCheckBox";
            this.MessageIdCheckBox.Size = new System.Drawing.Size(35, 17);
            this.MessageIdCheckBox.TabIndex = 7;
            this.MessageIdCheckBox.Text = "Id";
            this.MessageIdCheckBox.UseVisualStyleBackColor = true;
            this.MessageIdCheckBox.CheckedChanged += new System.EventHandler(this.MessageIdCheckBox_CheckedChanged);
            // 
            // SubscriberMessageCheckBox
            // 
            this.SubscriberMessageCheckBox.AutoSize = true;
            this.SubscriberMessageCheckBox.Checked = true;
            this.SubscriberMessageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubscriberMessageCheckBox.Location = new System.Drawing.Point(17, 196);
            this.SubscriberMessageCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SubscriberMessageCheckBox.Name = "SubscriberMessageCheckBox";
            this.SubscriberMessageCheckBox.Size = new System.Drawing.Size(78, 17);
            this.SubscriberMessageCheckBox.TabIndex = 6;
            this.SubscriberMessageCheckBox.Text = "MessageId";
            this.SubscriberMessageCheckBox.UseVisualStyleBackColor = true;
            this.SubscriberMessageCheckBox.CheckedChanged += new System.EventHandler(this.SubscriberMessageCheckBox_CheckedChanged);
            // 
            // SubscriberEntityCheckBox
            // 
            this.SubscriberEntityCheckBox.AutoSize = true;
            this.SubscriberEntityCheckBox.Checked = true;
            this.SubscriberEntityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubscriberEntityCheckBox.Location = new System.Drawing.Point(17, 174);
            this.SubscriberEntityCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SubscriberEntityCheckBox.Name = "SubscriberEntityCheckBox";
            this.SubscriberEntityCheckBox.Size = new System.Drawing.Size(52, 17);
            this.SubscriberEntityCheckBox.TabIndex = 5;
            this.SubscriberEntityCheckBox.Text = "Entity";
            this.SubscriberEntityCheckBox.UseVisualStyleBackColor = true;
            this.SubscriberEntityCheckBox.CheckedChanged += new System.EventHandler(this.SubscriberEntityCheckBox_CheckedChanged);
            // 
            // SubscriberAttributeFilterCheckBox
            // 
            this.SubscriberAttributeFilterCheckBox.AutoSize = true;
            this.SubscriberAttributeFilterCheckBox.Checked = true;
            this.SubscriberAttributeFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubscriberAttributeFilterCheckBox.Location = new System.Drawing.Point(17, 152);
            this.SubscriberAttributeFilterCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SubscriberAttributeFilterCheckBox.Name = "SubscriberAttributeFilterCheckBox";
            this.SubscriberAttributeFilterCheckBox.Size = new System.Drawing.Size(87, 17);
            this.SubscriberAttributeFilterCheckBox.TabIndex = 4;
            this.SubscriberAttributeFilterCheckBox.Text = "Attribute filter";
            this.SubscriberAttributeFilterCheckBox.UseVisualStyleBackColor = true;
            this.SubscriberAttributeFilterCheckBox.CheckedChanged += new System.EventHandler(this.SubscriberAttributeFilterCheckBox_CheckedChanged);
            // 
            // SubscriberTypeCheckBox
            // 
            this.SubscriberTypeCheckBox.AutoSize = true;
            this.SubscriberTypeCheckBox.Checked = true;
            this.SubscriberTypeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubscriberTypeCheckBox.Location = new System.Drawing.Point(17, 129);
            this.SubscriberTypeCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SubscriberTypeCheckBox.Name = "SubscriberTypeCheckBox";
            this.SubscriberTypeCheckBox.Size = new System.Drawing.Size(50, 17);
            this.SubscriberTypeCheckBox.TabIndex = 3;
            this.SubscriberTypeCheckBox.Text = "Type";
            this.SubscriberTypeCheckBox.UseVisualStyleBackColor = true;
            this.SubscriberTypeCheckBox.CheckedChanged += new System.EventHandler(this.SubscriberTypeCheckBox_CheckedChanged);
            // 
            // SubscriberNameCheckBox
            // 
            this.SubscriberNameCheckBox.AutoSize = true;
            this.SubscriberNameCheckBox.Checked = true;
            this.SubscriberNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubscriberNameCheckBox.Location = new System.Drawing.Point(17, 107);
            this.SubscriberNameCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SubscriberNameCheckBox.Name = "SubscriberNameCheckBox";
            this.SubscriberNameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.SubscriberNameCheckBox.TabIndex = 2;
            this.SubscriberNameCheckBox.Text = "Name";
            this.SubscriberNameCheckBox.UseVisualStyleBackColor = true;
            this.SubscriberNameCheckBox.CheckedChanged += new System.EventHandler(this.SubscriberNameCheckBox_CheckedChanged);
            // 
            // SubscriberIdCheckBox
            // 
            this.SubscriberIdCheckBox.AutoSize = true;
            this.SubscriberIdCheckBox.Checked = true;
            this.SubscriberIdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubscriberIdCheckBox.Location = new System.Drawing.Point(17, 84);
            this.SubscriberIdCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SubscriberIdCheckBox.Name = "SubscriberIdCheckBox";
            this.SubscriberIdCheckBox.Size = new System.Drawing.Size(35, 17);
            this.SubscriberIdCheckBox.TabIndex = 1;
            this.SubscriberIdCheckBox.Text = "Id";
            this.SubscriberIdCheckBox.UseVisualStyleBackColor = true;
            this.SubscriberIdCheckBox.CheckedChanged += new System.EventHandler(this.SubscriberIdCheckBox_CheckedChanged);
            // 
            // EntityCheckBox
            // 
            this.EntityCheckBox.AutoSize = true;
            this.EntityCheckBox.Checked = true;
            this.EntityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EntityCheckBox.Location = new System.Drawing.Point(17, 6);
            this.EntityCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EntityCheckBox.Name = "EntityCheckBox";
            this.EntityCheckBox.Size = new System.Drawing.Size(97, 17);
            this.EntityCheckBox.TabIndex = 0;
            this.EntityCheckBox.Text = "Include entities";
            this.EntityCheckBox.UseVisualStyleBackColor = true;
            this.EntityCheckBox.CheckedChanged += new System.EventHandler(this.EntityCheckBox_CheckedChanged);
            // 
            // ExportDataTextArea
            // 
            this.ExportDataTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportDataTextArea.Location = new System.Drawing.Point(2, 3);
            this.ExportDataTextArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ExportDataTextArea.Name = "ExportDataTextArea";
            this.ExportDataTextArea.Size = new System.Drawing.Size(439, 336);
            this.ExportDataTextArea.TabIndex = 1;
            this.ExportDataTextArea.Text = "";
            // 
            // JsonCsvToggle
            // 
            this.JsonCsvToggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.JsonCsvToggle.AutoSize = true;
            this.JsonCsvToggle.Checked = true;
            this.JsonCsvToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.JsonCsvToggle.Location = new System.Drawing.Point(17, 330);
            this.JsonCsvToggle.Name = "JsonCsvToggle";
            this.JsonCsvToggle.Size = new System.Drawing.Size(45, 23);
            this.JsonCsvToggle.TabIndex = 13;
            this.JsonCsvToggle.Text = "JSON";
            this.JsonCsvToggle.UseVisualStyleBackColor = true;
            this.JsonCsvToggle.CheckedChanged += new System.EventHandler(this.JsonCsvToggle_CheckedChanged);
            // 
            // CsvHeadersCheckBox
            // 
            this.CsvHeadersCheckBox.AutoSize = true;
            this.CsvHeadersCheckBox.Checked = true;
            this.CsvHeadersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CsvHeadersCheckBox.Location = new System.Drawing.Point(17, 42);
            this.CsvHeadersCheckBox.Name = "CsvHeadersCheckBox";
            this.CsvHeadersCheckBox.Size = new System.Drawing.Size(102, 17);
            this.CsvHeadersCheckBox.TabIndex = 14;
            this.CsvHeadersCheckBox.Text = "Include headers";
            this.CsvHeadersCheckBox.UseVisualStyleBackColor = true;
            this.CsvHeadersCheckBox.Visible = false;
            this.CsvHeadersCheckBox.CheckedChanged += new System.EventHandler(this.CsvHeadersCheckBox_CheckedChanged);
            // 
            // ExportSubscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ExportSubscribers";
            this.Text = "ExportSubscribers";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox SubscriberMessageCheckBox;
        private System.Windows.Forms.CheckBox SubscriberEntityCheckBox;
        private System.Windows.Forms.CheckBox SubscriberAttributeFilterCheckBox;
        private System.Windows.Forms.CheckBox SubscriberTypeCheckBox;
        private System.Windows.Forms.CheckBox SubscriberNameCheckBox;
        private System.Windows.Forms.CheckBox SubscriberIdCheckBox;
        private System.Windows.Forms.CheckBox EntityCheckBox;
        private System.Windows.Forms.CheckBox MessageEntityCheckBox;
        private System.Windows.Forms.CheckBox MessageNameCheckBox;
        private System.Windows.Forms.CheckBox MessageIdCheckBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label SubscriberLabel;
        private System.Windows.Forms.CheckBox MessageCheckBox;
        private System.Windows.Forms.RichTextBox ExportDataTextArea;
        private System.Windows.Forms.CheckBox JsonCsvToggle;
        private System.Windows.Forms.CheckBox CsvHeadersCheckBox;
    }
}