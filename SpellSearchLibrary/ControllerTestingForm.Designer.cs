namespace SpellSearchLibrary
{
    partial class ControllerTestingForm
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
            this.RunTestButton = new System.Windows.Forms.Button();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RunTestButton
            // 
            this.RunTestButton.Location = new System.Drawing.Point(4, 329);
            this.RunTestButton.Name = "RunTestButton";
            this.RunTestButton.Size = new System.Drawing.Size(797, 48);
            this.RunTestButton.TabIndex = 0;
            this.RunTestButton.Text = "RunTest";
            this.RunTestButton.UseVisualStyleBackColor = true;
            this.RunTestButton.Click += new System.EventHandler(this.RunTestButton_Click);
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(1, 4);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayTextBox.Size = new System.Drawing.Size(799, 325);
            this.DisplayTextBox.TabIndex = 1;
            // 
            // ControllerTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.RunTestButton);
            this.Name = "ControllerTestingForm";
            this.Text = "ControllerTestingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunTestButton;
        private System.Windows.Forms.TextBox DisplayTextBox;
    }
}