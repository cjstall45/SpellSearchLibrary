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
    public partial class SpellDiscriptionForm : Form
    {
        public SpellDiscriptionForm(DisplaySpell DisplayedSpell)
        {
            InitializeComponent();
            SpellNameLable.Text = DisplayedSpell.Name;
            foreach (string s in DisplayedSpell.Entries)
            {
                SpellDiscriptionTextBox.Text += s;
                SpellDiscriptionTextBox.Text += Environment.NewLine;
                
            }
        }

        private void AddSpellButton_Click(object sender, EventArgs e)
        {

        }

    }
}
