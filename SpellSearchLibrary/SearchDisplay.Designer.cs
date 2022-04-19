namespace SpellSearchLibrary
{
    partial class SearchDisplay
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
            this.SpellDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SpellNameLabel = new System.Windows.Forms.Label();
            this.SpellNameTextBox = new System.Windows.Forms.TextBox();
            this.SpellLevelLabel = new System.Windows.Forms.Label();
            this.SpellLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.CastingTimeLabel = new System.Windows.Forms.Label();
            this.CastingTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpellDataGridView)).BeginInit();
            this.SearchMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellLevelUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SpellDataGridView
            // 
            this.SpellDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpellDataGridView.Location = new System.Drawing.Point(281, 11);
            this.SpellDataGridView.Name = "SpellDataGridView";
            this.SpellDataGridView.Size = new System.Drawing.Size(1090, 581);
            this.SpellDataGridView.TabIndex = 1;
            this.SpellDataGridView.Text = "dataGridView1";
            // 
            // SearchMenuPanel
            // 
            this.SearchMenuPanel.Controls.Add(this.SpellNameLabel);
            this.SearchMenuPanel.Controls.Add(this.SpellNameTextBox);
            this.SearchMenuPanel.Controls.Add(this.SpellLevelLabel);
            this.SearchMenuPanel.Controls.Add(this.SpellLevelUpDown);
            this.SearchMenuPanel.Controls.Add(this.CastingTimeLabel);
            this.SearchMenuPanel.Controls.Add(this.CastingTimeComboBox);
            this.SearchMenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SearchMenuPanel.Location = new System.Drawing.Point(12, 12);
            this.SearchMenuPanel.Name = "SearchMenuPanel";
            this.SearchMenuPanel.Size = new System.Drawing.Size(263, 580);
            this.SearchMenuPanel.TabIndex = 2;
            // 
            // SpellNameLabel
            // 
            this.SpellNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpellNameLabel.Location = new System.Drawing.Point(3, 0);
            this.SpellNameLabel.Name = "SpellNameLabel";
            this.SpellNameLabel.Size = new System.Drawing.Size(259, 26);
            this.SpellNameLabel.TabIndex = 0;
            this.SpellNameLabel.Text = "Spell Name:";
            this.SpellNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SpellNameLabel.Click += new System.EventHandler(this.SpellNameLabel_Click);
            // 
            // SpellNameTextBox
            // 
            this.SpellNameTextBox.Location = new System.Drawing.Point(3, 29);
            this.SpellNameTextBox.Name = "SpellNameTextBox";
            this.SpellNameTextBox.Size = new System.Drawing.Size(260, 23);
            this.SpellNameTextBox.TabIndex = 1;
            // 
            // SpellLevelLabel
            // 
            this.SpellLevelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpellLevelLabel.Location = new System.Drawing.Point(3, 55);
            this.SpellLevelLabel.Name = "SpellLevelLabel";
            this.SpellLevelLabel.Size = new System.Drawing.Size(254, 26);
            this.SpellLevelLabel.TabIndex = 0;
            this.SpellLevelLabel.Text = "Spell Level:";
            this.SpellLevelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpellLevelUpDown
            // 
            this.SpellLevelUpDown.Location = new System.Drawing.Point(3, 84);
            this.SpellLevelUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.SpellLevelUpDown.Name = "SpellLevelUpDown";
            this.SpellLevelUpDown.Size = new System.Drawing.Size(260, 23);
            this.SpellLevelUpDown.TabIndex = 2;
            // 
            // CastingTimeLabel
            // 
            this.CastingTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CastingTimeLabel.Location = new System.Drawing.Point(3, 110);
            this.CastingTimeLabel.Name = "CastingTimeLabel";
            this.CastingTimeLabel.Size = new System.Drawing.Size(254, 26);
            this.CastingTimeLabel.TabIndex = 0;
            this.CastingTimeLabel.Text = "Casting Time:";
            this.CastingTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CastingTimeComboBox
            // 
            this.CastingTimeComboBox.FormattingEnabled = true;
            this.CastingTimeComboBox.Items.AddRange(new object[] {
            "Action",
            "Bonus Action",
            "Reaction",
            "1 Minute",
            "10 Minutes",
            "1 Hour",
            "8 Hours",
            "12 Hours",
            "24 Hours"});
            this.CastingTimeComboBox.Location = new System.Drawing.Point(3, 139);
            this.CastingTimeComboBox.Name = "CastingTimeComboBox";
            this.CastingTimeComboBox.Size = new System.Drawing.Size(260, 23);
            this.CastingTimeComboBox.TabIndex = 3;
            this.CastingTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 605);
            this.Controls.Add(this.SearchMenuPanel);
            this.Controls.Add(this.SpellDataGridView);
            this.Name = "SearchDisplay";
            this.Text = "SearchDisplay";
            this.Load += new System.EventHandler(this.SearchDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpellDataGridView)).EndInit();
            this.SearchMenuPanel.ResumeLayout(false);
            this.SearchMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellLevelUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView SpellDataGridView;
        private System.Windows.Forms.FlowLayoutPanel SearchMenuPanel;
        private System.Windows.Forms.Label SpellNameLabel;
        private System.Windows.Forms.TextBox SpellNameTextBox;
        private System.Windows.Forms.Label SpellLevelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SpellLevelUpDown;
        private System.Windows.Forms.Label CastingTimeLabel;
        private System.Windows.Forms.ComboBox CastingTimeComboBox;
    }
}