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
            this.MinSpellLevelLable = new System.Windows.Forms.Label();
            this.MinSpellLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxSpellLevelLabel = new System.Windows.Forms.Label();
            this.MaxSpellLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.CastingTimeLabel = new System.Windows.Forms.Label();
            this.CastingTimeComboBox = new System.Windows.Forms.ComboBox();
            this.SpellSchoolLabel = new System.Windows.Forms.Label();
            this.SpellSchoolComboBox = new System.Windows.Forms.ComboBox();
            this.SpellComponetsLabel = new System.Windows.Forms.Label();
            this.ComponetsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CasterClassLable = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowDiscriptionButton = new System.Windows.Forms.Button();
            this.AddToSpellBookButton = new System.Windows.Forms.Button();
            this.SearchOptionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpellDataGridView)).BeginInit();
            this.SearchMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpellLevelUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpellLevelUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SpellDataGridView
            // 
            this.SpellDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpellDataGridView.Location = new System.Drawing.Point(281, 11);
            this.SpellDataGridView.Name = "SpellDataGridView";
            this.SpellDataGridView.ReadOnly = true;
            this.SpellDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpellDataGridView.Size = new System.Drawing.Size(1363, 547);
            this.SpellDataGridView.TabIndex = 1;
            this.SpellDataGridView.Text = "dataGridView1";
            // 
            // SearchMenuPanel
            // 
            this.SearchMenuPanel.Controls.Add(this.SpellNameLabel);
            this.SearchMenuPanel.Controls.Add(this.SpellNameTextBox);
            this.SearchMenuPanel.Controls.Add(this.MinSpellLevelLable);
            this.SearchMenuPanel.Controls.Add(this.MinSpellLevelUpDown);
            this.SearchMenuPanel.Controls.Add(this.MaxSpellLevelLabel);
            this.SearchMenuPanel.Controls.Add(this.MaxSpellLevelUpDown);
            this.SearchMenuPanel.Controls.Add(this.CastingTimeLabel);
            this.SearchMenuPanel.Controls.Add(this.CastingTimeComboBox);
            this.SearchMenuPanel.Controls.Add(this.SpellSchoolLabel);
            this.SearchMenuPanel.Controls.Add(this.SpellSchoolComboBox);
            this.SearchMenuPanel.Controls.Add(this.SpellComponetsLabel);
            this.SearchMenuPanel.Controls.Add(this.ComponetsCheckedListBox);
            this.SearchMenuPanel.Controls.Add(this.CasterClassLable);
            this.SearchMenuPanel.Controls.Add(this.ClassComboBox);
            this.SearchMenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SearchMenuPanel.Location = new System.Drawing.Point(15, 39);
            this.SearchMenuPanel.Name = "SearchMenuPanel";
            this.SearchMenuPanel.Padding = new System.Windows.Forms.Padding(1);
            this.SearchMenuPanel.Size = new System.Drawing.Size(260, 446);
            this.SearchMenuPanel.TabIndex = 2;
            this.SearchMenuPanel.WrapContents = false;
            // 
            // SpellNameLabel
            // 
            this.SpellNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpellNameLabel.Location = new System.Drawing.Point(4, 1);
            this.SpellNameLabel.Name = "SpellNameLabel";
            this.SpellNameLabel.Size = new System.Drawing.Size(254, 26);
            this.SpellNameLabel.TabIndex = 0;
            this.SpellNameLabel.Text = "Spell Name:";
            this.SpellNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpellNameTextBox
            // 
            this.SpellNameTextBox.Location = new System.Drawing.Point(4, 30);
            this.SpellNameTextBox.Name = "SpellNameTextBox";
            this.SpellNameTextBox.Size = new System.Drawing.Size(254, 23);
            this.SpellNameTextBox.TabIndex = 1;
            // 
            // MinSpellLevelLable
            // 
            this.MinSpellLevelLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinSpellLevelLable.Location = new System.Drawing.Point(4, 56);
            this.MinSpellLevelLable.Name = "MinSpellLevelLable";
            this.MinSpellLevelLable.Size = new System.Drawing.Size(254, 26);
            this.MinSpellLevelLable.TabIndex = 0;
            this.MinSpellLevelLable.Text = "Minimum Spell Level";
            this.MinSpellLevelLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MinSpellLevelUpDown
            // 
            this.MinSpellLevelUpDown.Location = new System.Drawing.Point(4, 85);
            this.MinSpellLevelUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.MinSpellLevelUpDown.Name = "MinSpellLevelUpDown";
            this.MinSpellLevelUpDown.Size = new System.Drawing.Size(254, 23);
            this.MinSpellLevelUpDown.TabIndex = 2;
            // 
            // MaxSpellLevelLabel
            // 
            this.MaxSpellLevelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxSpellLevelLabel.Location = new System.Drawing.Point(4, 111);
            this.MaxSpellLevelLabel.Name = "MaxSpellLevelLabel";
            this.MaxSpellLevelLabel.Size = new System.Drawing.Size(254, 26);
            this.MaxSpellLevelLabel.TabIndex = 0;
            this.MaxSpellLevelLabel.Text = "Maximum Spell Level:";
            this.MaxSpellLevelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MaxSpellLevelUpDown
            // 
            this.MaxSpellLevelUpDown.Location = new System.Drawing.Point(4, 140);
            this.MaxSpellLevelUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.MaxSpellLevelUpDown.Name = "MaxSpellLevelUpDown";
            this.MaxSpellLevelUpDown.Size = new System.Drawing.Size(254, 23);
            this.MaxSpellLevelUpDown.TabIndex = 2;
            this.MaxSpellLevelUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // CastingTimeLabel
            // 
            this.CastingTimeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CastingTimeLabel.Location = new System.Drawing.Point(4, 166);
            this.CastingTimeLabel.Name = "CastingTimeLabel";
            this.CastingTimeLabel.Size = new System.Drawing.Size(254, 26);
            this.CastingTimeLabel.TabIndex = 0;
            this.CastingTimeLabel.Text = "Casting Time:";
            this.CastingTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CastingTimeComboBox
            // 
            this.CastingTimeComboBox.DisplayMember = "Any";
            this.CastingTimeComboBox.FormattingEnabled = true;
            this.CastingTimeComboBox.Items.AddRange(new object[] {
            "Any",
            "1 Action",
            "1 Bonus Action",
            "1 Reaction",
            "1 Minute",
            "10 Minutes",
            "1 Hour",
            "8 Hours",
            "12 Hours",
            "24 Hours"});
            this.CastingTimeComboBox.Location = new System.Drawing.Point(4, 195);
            this.CastingTimeComboBox.Name = "CastingTimeComboBox";
            this.CastingTimeComboBox.Size = new System.Drawing.Size(254, 23);
            this.CastingTimeComboBox.TabIndex = 3;
            // 
            // SpellSchoolLabel
            // 
            this.SpellSchoolLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpellSchoolLabel.Location = new System.Drawing.Point(4, 221);
            this.SpellSchoolLabel.Name = "SpellSchoolLabel";
            this.SpellSchoolLabel.Size = new System.Drawing.Size(254, 26);
            this.SpellSchoolLabel.TabIndex = 0;
            this.SpellSchoolLabel.Text = "Spell School:";
            this.SpellSchoolLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpellSchoolComboBox
            // 
            this.SpellSchoolComboBox.FormattingEnabled = true;
            this.SpellSchoolComboBox.Items.AddRange(new object[] {
            "Any",
            "Conjuration",
            "Necromancy",
            "Evocation",
            "Abjuration",
            "Transmutation",
            "Divination",
            "Enchantment",
            "Illusion"});
            this.SpellSchoolComboBox.Location = new System.Drawing.Point(4, 250);
            this.SpellSchoolComboBox.Name = "SpellSchoolComboBox";
            this.SpellSchoolComboBox.Size = new System.Drawing.Size(254, 23);
            this.SpellSchoolComboBox.TabIndex = 3;
            // 
            // SpellComponetsLabel
            // 
            this.SpellComponetsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpellComponetsLabel.Location = new System.Drawing.Point(4, 276);
            this.SpellComponetsLabel.Name = "SpellComponetsLabel";
            this.SpellComponetsLabel.Size = new System.Drawing.Size(254, 26);
            this.SpellComponetsLabel.TabIndex = 0;
            this.SpellComponetsLabel.Text = "Spell Componets:";
            this.SpellComponetsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ComponetsCheckedListBox
            // 
            this.ComponetsCheckedListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComponetsCheckedListBox.FormattingEnabled = true;
            this.ComponetsCheckedListBox.Items.AddRange(new object[] {
            "Any Componets",
            "V",
            "S",
            "M"});
            this.ComponetsCheckedListBox.Location = new System.Drawing.Point(4, 305);
            this.ComponetsCheckedListBox.Name = "ComponetsCheckedListBox";
            this.ComponetsCheckedListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComponetsCheckedListBox.Size = new System.Drawing.Size(254, 84);
            this.ComponetsCheckedListBox.TabIndex = 4;
            // 
            // CasterClassLable
            // 
            this.CasterClassLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CasterClassLable.Location = new System.Drawing.Point(4, 392);
            this.CasterClassLable.Name = "CasterClassLable";
            this.CasterClassLable.Size = new System.Drawing.Size(254, 26);
            this.CasterClassLable.TabIndex = 0;
            this.CasterClassLable.Text = "Caster Class:";
            this.CasterClassLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Items.AddRange(new object[] {
            "Any",
            "Bard",
            "Cleric",
            "Druid",
            "Paladin",
            "Ranger",
            "Sorcerer",
            "Warlock",
            "Wizard",
            "Artificer"});
            this.ClassComboBox.Location = new System.Drawing.Point(4, 421);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(254, 23);
            this.ClassComboBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(15, 564);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(261, 29);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowDiscriptionButton
            // 
            this.ShowDiscriptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowDiscriptionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowDiscriptionButton.Location = new System.Drawing.Point(1004, 564);
            this.ShowDiscriptionButton.Name = "ShowDiscriptionButton";
            this.ShowDiscriptionButton.Size = new System.Drawing.Size(640, 29);
            this.ShowDiscriptionButton.TabIndex = 6;
            this.ShowDiscriptionButton.Text = "Show Spell Discription";
            this.ShowDiscriptionButton.UseVisualStyleBackColor = true;
            this.ShowDiscriptionButton.Click += new System.EventHandler(this.ShowDiscriptionButton_Click);
            // 
            // AddToSpellBookButton
            // 
            this.AddToSpellBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToSpellBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToSpellBookButton.Location = new System.Drawing.Point(281, 564);
            this.AddToSpellBookButton.Name = "AddToSpellBookButton";
            this.AddToSpellBookButton.Size = new System.Drawing.Size(717, 29);
            this.AddToSpellBookButton.TabIndex = 7;
            this.AddToSpellBookButton.Text = "Add To Spell Book";
            this.AddToSpellBookButton.UseVisualStyleBackColor = true;
            this.AddToSpellBookButton.Click += new System.EventHandler(this.AddToSpellBookButton_Click);
            // 
            // SearchOptionsLabel
            // 
            this.SearchOptionsLabel.AutoSize = true;
            this.SearchOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchOptionsLabel.Location = new System.Drawing.Point(15, 11);
            this.SearchOptionsLabel.Name = "SearchOptionsLabel";
            this.SearchOptionsLabel.Size = new System.Drawing.Size(199, 25);
            this.SearchOptionsLabel.TabIndex = 8;
            this.SearchOptionsLabel.Text = "Spell Search Options:";
            // 
            // SearchDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 605);
            this.Controls.Add(this.SearchOptionsLabel);
            this.Controls.Add(this.AddToSpellBookButton);
            this.Controls.Add(this.ShowDiscriptionButton);
            this.Controls.Add(this.SearchMenuPanel);
            this.Controls.Add(this.SpellDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Name = "SearchDisplay";
            this.Text = "SearchDisplay";
            this.Load += new System.EventHandler(this.SearchDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpellDataGridView)).EndInit();
            this.SearchMenuPanel.ResumeLayout(false);
            this.SearchMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpellLevelUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpellLevelUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SpellDataGridView;
        private System.Windows.Forms.FlowLayoutPanel SearchMenuPanel;
        private System.Windows.Forms.Label SpellNameLabel;
        private System.Windows.Forms.TextBox SpellNameTextBox;
        private System.Windows.Forms.Label MinSpellLevelLable;
        private System.Windows.Forms.NumericUpDown MinSpellLevelUpDown;
        private System.Windows.Forms.Label CastingTimeLabel;
        private System.Windows.Forms.ComboBox CastingTimeComboBox;
        private System.Windows.Forms.Label SpellSchoolLabel;
        private System.Windows.Forms.ComboBox SpellSchoolComboBox;
        private System.Windows.Forms.Label SpellComponetsLabel;
        private System.Windows.Forms.CheckedListBox ComponetsCheckedListBox;
        private System.Windows.Forms.Label CasterClassLable;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ShowDiscriptionButton;
        private System.Windows.Forms.Button AddToSpellBookButton;
        private System.Windows.Forms.Label SearchOptionsLabel;
        private System.Windows.Forms.Label MaxSpellLevelLabel;
        private System.Windows.Forms.NumericUpDown MaxSpellLevelUpDown;
    }
}