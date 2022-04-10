using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellSearchLibrary
{
    public partial class Form1 : Form
    {
        private Controller controller;
        public Form1(Controller controls)
        {
            InitializeComponent();
            controller = controls;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            var results = controller.GetSpellsByLevel((int) uxLevelUpDown.Value);
            StringBuilder sb = new StringBuilder();
            foreach(var spell in results)
            {
                sb.Append(spell.name + "\n");
            }
            uxResultsTextBox.Text = sb.ToString();
        }
    }
}
