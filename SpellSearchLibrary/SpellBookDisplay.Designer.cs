namespace SpellSearchLibrary
{
    partial class SpellBookDisplay
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
            this.SpellBookGridView = new System.Windows.Forms.DataGridView();
            this.RemoveSpellButton = new System.Windows.Forms.Button();
            this.SpellBookNameLabel = new System.Windows.Forms.Label();
            this.AddSpellsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpellBookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SpellBookGridView
            // 
            this.SpellBookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpellBookGridView.Location = new System.Drawing.Point(12, 37);
            this.SpellBookGridView.Name = "SpellBookGridView";
            this.SpellBookGridView.Size = new System.Drawing.Size(881, 369);
            this.SpellBookGridView.TabIndex = 0;
            this.SpellBookGridView.Text = "dataGridView1";
            // 
            // RemoveSpellButton
            // 
            this.RemoveSpellButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveSpellButton.Location = new System.Drawing.Point(12, 412);
            this.RemoveSpellButton.Name = "RemoveSpellButton";
            this.RemoveSpellButton.Size = new System.Drawing.Size(450, 40);
            this.RemoveSpellButton.TabIndex = 1;
            this.RemoveSpellButton.Text = "Remove Selected Spell";
            this.RemoveSpellButton.UseVisualStyleBackColor = true;
            this.RemoveSpellButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpellBookNameLabel
            // 
            this.SpellBookNameLabel.AutoSize = true;
            this.SpellBookNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpellBookNameLabel.Location = new System.Drawing.Point(12, 9);
            this.SpellBookNameLabel.Name = "SpellBookNameLabel";
            this.SpellBookNameLabel.Size = new System.Drawing.Size(125, 25);
            this.SpellBookNameLabel.TabIndex = 2;
            this.SpellBookNameLabel.Text = "This Is A Bug";
            // 
            // AddSpellsButton
            // 
            this.AddSpellsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSpellsButton.Location = new System.Drawing.Point(468, 412);
            this.AddSpellsButton.Name = "AddSpellsButton";
            this.AddSpellsButton.Size = new System.Drawing.Size(425, 40);
            this.AddSpellsButton.TabIndex = 3;
            this.AddSpellsButton.Text = "Add New Spells";
            this.AddSpellsButton.UseVisualStyleBackColor = true;
            this.AddSpellsButton.Click += new System.EventHandler(this.AddSpellsButton_Click);
            // 
            // SpellBookDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 461);
            this.Controls.Add(this.AddSpellsButton);
            this.Controls.Add(this.SpellBookNameLabel);
            this.Controls.Add(this.RemoveSpellButton);
            this.Controls.Add(this.SpellBookGridView);
            this.Name = "SpellBookDisplay";
            this.Text = "SpellBookDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.SpellBookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SpellBookGridView;
        private System.Windows.Forms.Button RemoveSpellButton;
        private System.Windows.Forms.Label SpellBookNameLabel;
        private System.Windows.Forms.Button AddSpellsButton;
    }
}