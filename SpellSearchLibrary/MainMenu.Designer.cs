namespace SpellSearchLibrary
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SpellBookComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSpellsButton = new System.Windows.Forms.Button();
            this.OpenSpellBookButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenSearchMenuButton = new System.Windows.Forms.Button();
            this.AddSpellBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpellBookComboBox
            // 
            this.SpellBookComboBox.FormattingEnabled = true;
            this.SpellBookComboBox.Location = new System.Drawing.Point(12, 37);
            this.SpellBookComboBox.Name = "SpellBookComboBox";
            this.SpellBookComboBox.Size = new System.Drawing.Size(644, 23);
            this.SpellBookComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Spell Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddSpellsButton
            // 
            this.AddSpellsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSpellsButton.Location = new System.Drawing.Point(365, 66);
            this.AddSpellsButton.Name = "AddSpellsButton";
            this.AddSpellsButton.Size = new System.Drawing.Size(340, 44);
            this.AddSpellsButton.TabIndex = 2;
            this.AddSpellsButton.Text = "Add New Spells ";
            this.AddSpellsButton.UseVisualStyleBackColor = true;
            this.AddSpellsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenSpellBookButton
            // 
            this.OpenSpellBookButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenSpellBookButton.Location = new System.Drawing.Point(12, 66);
            this.OpenSpellBookButton.Name = "OpenSpellBookButton";
            this.OpenSpellBookButton.Size = new System.Drawing.Size(347, 44);
            this.OpenSpellBookButton.TabIndex = 3;
            this.OpenSpellBookButton.Text = "Open Spell Book";
            this.OpenSpellBookButton.UseVisualStyleBackColor = true;
            this.OpenSpellBookButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Or Search Without Spell Book";
            // 
            // OpenSearchMenuButton
            // 
            this.OpenSearchMenuButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenSearchMenuButton.Location = new System.Drawing.Point(12, 141);
            this.OpenSearchMenuButton.Name = "OpenSearchMenuButton";
            this.OpenSearchMenuButton.Size = new System.Drawing.Size(693, 46);
            this.OpenSearchMenuButton.TabIndex = 5;
            this.OpenSearchMenuButton.Text = "Open Search Menu";
            this.OpenSearchMenuButton.UseVisualStyleBackColor = true;
            this.OpenSearchMenuButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddSpellBookButton
            // 
            this.AddSpellBookButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSpellBookButton.Location = new System.Drawing.Point(662, 37);
            this.AddSpellBookButton.Name = "AddSpellBookButton";
            this.AddSpellBookButton.Size = new System.Drawing.Size(43, 23);
            this.AddSpellBookButton.TabIndex = 6;
            this.AddSpellBookButton.Text = "Add ";
            this.AddSpellBookButton.UseVisualStyleBackColor = true;
            this.AddSpellBookButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 209);
            this.Controls.Add(this.AddSpellBookButton);
            this.Controls.Add(this.OpenSearchMenuButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenSpellBookButton);
            this.Controls.Add(this.AddSpellsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpellBookComboBox);
            this.Name = "MainMenu";
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SpellBookComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSpellsButton;
        private System.Windows.Forms.Button OpenSpellBookButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenSearchMenuButton;
        private System.Windows.Forms.Button AddSpellBookButton;
    }
}

