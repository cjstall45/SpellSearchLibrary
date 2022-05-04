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
    public partial class SearchDisplay : Form
    {
        public Controller Controller { get; set; }
        public SearchDisplay(Controller controller)
        {
            Controller = controller;
            InitializeComponent();
        }



        private void AddToSpellBookButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowDiscriptionButton_Click(object sender, EventArgs e)
        {
            var form = new SpellDiscriptionForm((DisplaySpell)SpellDataGridView.CurrentRow.DataBoundItem);
            form.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Spell> currentSpellList = Controller.Spells;
            if(SpellNameTextBox.Text.Length != 0)
            {
                currentSpellList = Controller.SearchForSpellsByName(currentSpellList, SpellNameTextBox.Text);
            }
            currentSpellList = Controller.SearchForSpellsByLevel(currentSpellList,(int) MinSpellLevelUpDown.Value,(int) MaxSpellLevelUpDown.Value);
            if (CastingTimeComboBox.SelectedItem != null)
            {
                switch (CastingTimeComboBox.SelectedItem.ToString())
                {
                    case "Any":
                        break;
                    case "1 Action":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 1, Model.Enums.CastingUnit.action);
                        break;
                    case "1 Bonus Action":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 1, Model.Enums.CastingUnit.bonus);
                        break;
                    case "1 Reaction":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 1, Model.Enums.CastingUnit.reaction);
                        break;
                    case "1 Minute":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 1, Model.Enums.CastingUnit.minute);
                        break;
                    case "10 Minutes":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 10, Model.Enums.CastingUnit.minute);
                        break;
                    case "1 Hour":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 1, Model.Enums.CastingUnit.hour);
                        break;
                    case "8 Hours":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 8, Model.Enums.CastingUnit.hour);
                        break;
                    case "12 Hours":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 12, Model.Enums.CastingUnit.hour);
                        break;
                    case "24 Hours":
                        currentSpellList = Controller.SearchForSpellsByCastingTime(currentSpellList, 24, Model.Enums.CastingUnit.hour);
                        break;
                    default:
                        break;
                }
            }
            if (SpellSchoolComboBox.SelectedItem != null)
            {
                switch (SpellSchoolComboBox.SelectedItem.ToString())
                {
                    case "Any":
                        break;
                    case "Abjuration":
                        currentSpellList = Controller.SearchForSpellsBySchool(currentSpellList, Model.Enums.SpellSchool.Abjuration);
                        break;
                    case "Conjuration":
                        currentSpellList = Controller.SearchForSpellsBySchool(currentSpellList, Model.Enums.SpellSchool.Conjuration);
                        break;
                    case "Necromancy":
                        currentSpellList = Controller.SearchForSpellsBySchool(currentSpellList, Model.Enums.SpellSchool.Necromancy);
                        break;
                    case "Evocation":
                        currentSpellList = Controller.SearchForSpellsBySchool(currentSpellList, Model.Enums.SpellSchool.Evocation);
                        break;
                    case "Illusion":
                        currentSpellList = Controller.SearchForSpellsBySchool(currentSpellList, Model.Enums.SpellSchool.Illusion);
                        break;
                    case "Transmutation":
                        currentSpellList = Controller.SearchForSpellsBySchool(currentSpellList, Model.Enums.SpellSchool.Transmutation);
                        break;
                    case "Divination":
                        currentSpellList = Controller.SearchForSpellsBySchool(currentSpellList, Model.Enums.SpellSchool.Divination);
                        break;
                    case "Enchantment":
                        currentSpellList = Controller.SearchForSpellsBySchool(currentSpellList, Model.Enums.SpellSchool.Enchantment);
                        break;
                    default:
                        break;
                }
            }
            if(!ComponetsCheckedListBox.CheckedItems.Contains("Any Componets"))
            {
                bool v;
                bool s;
                bool m;
                if (ComponetsCheckedListBox.CheckedItems.Contains("V"))
                {
                    v = true;
                }
                else
                {
                    v = false;
                }
                if (ComponetsCheckedListBox.CheckedItems.Contains("S"))
                {
                    s = true;
                }
                else
                {
                    s = false;
                }
                if (ComponetsCheckedListBox.CheckedItems.Contains("M"))
                {
                    m = true;
                }
                else
                {
                    m = false;
                }
                currentSpellList = Controller.SearchForSpellByComponets(currentSpellList, v, s, m);
            }
            if (ClassComboBox.SelectedItem != null)
            {
                switch (ClassComboBox.SelectedItem.ToString())
                {
                    case "Any":
                        break;
                    case "Bard":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Bard);
                        break;
                    case "Cleric":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Cleric);
                        break;
                    case "Druid":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Druid);
                        break;
                    case "Paladin":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Paladin);
                        break;
                    case "Ranger":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Ranger);
                        break;
                    case "Sorcerer":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Sorcerer);
                        break;
                    case "Warlock":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Warlock);
                        break;
                    case "Wizard":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Wizard);
                        break;
                    case "Artificer":
                        currentSpellList = Controller.SearchForSpellsByClass(currentSpellList, Model.Enums.CharacterClass.Artificer);
                        break;
                    default:
                        break;
                }
            }
            SpellDataGridView.DataSource = Controller.ConvertSpellsToDisplaySpells(currentSpellList);
        }

        private void SearchDisplay_Load(object sender, EventArgs e)
        {
            SpellDataGridView.DataSource = Controller.ConvertSpellsToDisplaySpells(Controller.Spells);
            ComponetsCheckedListBox.SetItemChecked(0, true);
            CastingTimeComboBox.SelectedIndex = 0;
            SpellSchoolComboBox.SelectedIndex = 0;
            ClassComboBox.SelectedIndex = 0;

        }
    }
}
