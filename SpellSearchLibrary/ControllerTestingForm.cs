using SpellSearchLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpellSearchLibrary
{
    public partial class ControllerTestingForm : Form
    {
        private Controller controller;
        public ControllerTestingForm(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void RunTestButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Spell s in controller.Spells)
            {
                DisplayTextBox.Text += s.name;
                DisplayTextBox.Text += Environment.NewLine;
            }
        }
    }
}
