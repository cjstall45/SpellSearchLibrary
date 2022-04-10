namespace SpellSearchLibrary
{
    partial class Form1
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
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxSpellLevelLabel = new System.Windows.Forms.Label();
            this.uxResultsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxLevelUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSearchButton.Location = new System.Drawing.Point(12, 48);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(790, 23);
            this.uxSearchButton.TabIndex = 0;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxLevelUpDown
            // 
            this.uxLevelUpDown.Location = new System.Drawing.Point(12, 12);
            this.uxLevelUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.uxLevelUpDown.Name = "uxLevelUpDown";
            this.uxLevelUpDown.Size = new System.Drawing.Size(37, 23);
            this.uxLevelUpDown.TabIndex = 1;
            // 
            // uxSpellLevelLabel
            // 
            this.uxSpellLevelLabel.AutoSize = true;
            this.uxSpellLevelLabel.Location = new System.Drawing.Point(65, 16);
            this.uxSpellLevelLabel.Name = "uxSpellLevelLabel";
            this.uxSpellLevelLabel.Size = new System.Drawing.Size(62, 15);
            this.uxSpellLevelLabel.TabIndex = 2;
            this.uxSpellLevelLabel.Text = "Spell Level";
            // 
            // uxResultsTextBox
            // 
            this.uxResultsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxResultsTextBox.Location = new System.Drawing.Point(15, 77);
            this.uxResultsTextBox.Multiline = true;
            this.uxResultsTextBox.Name = "uxResultsTextBox";
            this.uxResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResultsTextBox.Size = new System.Drawing.Size(785, 300);
            this.uxResultsTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.uxResultsTextBox);
            this.Controls.Add(this.uxSpellLevelLabel);
            this.Controls.Add(this.uxLevelUpDown);
            this.Controls.Add(this.uxSearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uxLevelUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.NumericUpDown uxLevelUpDown;
        private System.Windows.Forms.Label uxSpellLevelLabel;
        private System.Windows.Forms.TextBox uxResultsTextBox;
    }
}

