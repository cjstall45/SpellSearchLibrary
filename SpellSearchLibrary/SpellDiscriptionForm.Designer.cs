namespace SpellSearchLibrary
{
    partial class SpellDiscriptionForm
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
            this.SpellNameLable = new System.Windows.Forms.Label();
            this.SpellDiscriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddSpellButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpellNameLable
            // 
            this.SpellNameLable.AutoSize = true;
            this.SpellNameLable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpellNameLable.Location = new System.Drawing.Point(12, 22);
            this.SpellNameLable.Name = "SpellNameLable";
            this.SpellNameLable.Size = new System.Drawing.Size(107, 25);
            this.SpellNameLable.TabIndex = 0;
            this.SpellNameLable.Text = "SpellName";
            // 
            // SpellDiscriptionTextBox
            // 
            this.SpellDiscriptionTextBox.AcceptsReturn = true;
            this.SpellDiscriptionTextBox.AcceptsTab = true;
            this.SpellDiscriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpellDiscriptionTextBox.Location = new System.Drawing.Point(12, 50);
            this.SpellDiscriptionTextBox.Multiline = true;
            this.SpellDiscriptionTextBox.Name = "SpellDiscriptionTextBox";
            this.SpellDiscriptionTextBox.ReadOnly = true;
            this.SpellDiscriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SpellDiscriptionTextBox.Size = new System.Drawing.Size(776, 352);
            this.SpellDiscriptionTextBox.TabIndex = 1;
            // 
            // AddSpellButton
            // 
            this.AddSpellButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSpellButton.Location = new System.Drawing.Point(12, 408);
            this.AddSpellButton.Name = "AddSpellButton";
            this.AddSpellButton.Size = new System.Drawing.Size(776, 30);
            this.AddSpellButton.TabIndex = 2;
            this.AddSpellButton.Text = "Add Spell To Spell Book";
            this.AddSpellButton.UseVisualStyleBackColor = true;
            this.AddSpellButton.Click += new System.EventHandler(this.AddSpellButton_Click);
            // 
            // SpellDiscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddSpellButton);
            this.Controls.Add(this.SpellDiscriptionTextBox);
            this.Controls.Add(this.SpellNameLable);
            this.Name = "SpellDiscriptionForm";
            this.Text = "SpellDiscriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpellNameLable;
        private System.Windows.Forms.TextBox SpellDiscriptionTextBox;
        private System.Windows.Forms.Button AddSpellButton;
    }
}