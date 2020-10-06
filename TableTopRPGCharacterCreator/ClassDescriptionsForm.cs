using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTopRPGCharacterCreator
{
    public partial class ClassDescriptionsForm : Form
    {
        public ClassDescriptionsForm()
        {
            InitializeComponent();
            InitializeDataGridViewCSpells();
            InitializeDataGridViewWSpells();
            InitializeDataGridViewRogue();
        }
        private void InitializeDataGridViewCSpells()
        {
            // create unbound DataGridView 
            string[] cSpellRow0 = { "1st", "+2", "Spellcasting, Divine Domain",
                "3", "2", "-", "-", "-", "-", "-", "-", "-", "-" }; // cleric level 1
            string[] cSpellRow1 = { "2nd", "+2", "Channel Divinity(1/rest), Divine Domain feature",
                "3", "3", "-", "-", "-", "-", "-", "-", "-", "-" }; // cleric level 2
            string[] cSpellRow2 = { "3rd", "+2", "-",
                "3", "4", "2", "-", "-", "-", "-", "-", "-", "-" }; // cleric level 3
            string[] cSpellRow3 = { "4th", "+2", "Ability Score Improvement",
                "4", "4", "3", "-", "-", "-", "-", "-", "-", "-" }; // cleric level 4
            string[] cSpellRow4 = { "5th", "+3", "Destroy Undead(CR1/2)",
                "4", "4", "3", "2", "-", "-", "-", "-", "-", "-" }; // cleric level 5
            string[] cSpellRow5 = { "6th", "+3", "Channel Divinity(2/rest), Divine Domain feature",
                "4", "4", "3", "3", "-", "-", "-", "-", "-", "-" }; // cleric level 6
            string[] cSpellRow6 = { "7th", "+3", "-",
                "4", "4", "3", "3", "1", "-", "-", "-", "-", "-" }; // cleric level 7
            string[] cSpellRow7 = { "8th", "+3", "Ability Score Improvement, Destroy Undead(CR1), Divine Domain feature",
                "4", "4", "3", "3", "2", "-", "-", "-", "-", "-" }; // cleric level 8
            string[] cSpellRow8 = { "9th", "+4", "-",
                "4", "4", "3", "3", "3", "1", "—", "—", "—", "—" }; // cleric level 9
            string[] cSpellRow9 = { "10th", "+4", "Divine Intervention",
                "5", "4", "3", "3", "3", "2", "—", "—", "—", "—"}; // cleric level 10
            string[] cSpellRow10 = { "11th", "+4", "Destroy Undead(CR2)",
                "5", "4", "3", "3", "3", "2", "1", "—", "—", "—" }; // cleric level 11
            string[] cSpellRow11 = { "12th", "+4", "Ability Score Improvement",
                "5", "4", "3", "3", "3", "2", "1", "—", "—", "—" }; // cleric level 12
            string[] cSpellRow12 = { "13th", "+5", "-",
                "5", "4", "3", "3", "3", "2", "1", "1", "—", "—" }; // cleric level 13
            string[] cSpellRow13 = { "14th", "+5", "Destroy Undead(CR3)",
                "5", "4", "3", "3", "3", "2", "1", "1", "—", "—" }; // cleric level 14
            string[] cSpellRow14 = { "15th", "+5", "-",
                "5", "4", "3", "3", "3", "2", "1", "1", "1", "—" }; // cleric level 15
            string[] cSpellRow15 = { "16th", "+5", "Spellcasting, Divine Domain",
               "5", "4", "3", "3", "3", "2", "1", "1", "1", "—" }; // cleric level 16
            string[] cSpellRow16 = { "17th", "+6", "Destroy Undead(CR4), Divine Domain feature",
                "5", "4", "3", "3", "3", "2", "1", "1", "1", "1" }; // cleric level 17
            string[] cSpellRow17 = { "18th", "+6", "Channel Divinity(3/rest)",
                "5", "4", "3", "3", "3", "3", "1", "1", "1", "1" }; // cleric level 18
            string[] cSpellRow18 = { "19th", "+6", "Ability Score Improvement",
                "5", "4", "3", "3", "3", "3", "2", "1", "1", "1" }; // cleric level 19
            string[] cSpellRow19 = { "20th", "+6", "Divine Intervention Improvement",
                "5", "4", "3", "3", "3", "3", "2", "2", "1", "1" }; // cleric level 20

            // make an array full of the rows above
            object[] cRows = new object[] {cSpellRow0, cSpellRow1, cSpellRow2, cSpellRow3, cSpellRow4, cSpellRow5,
            cSpellRow6, cSpellRow7, cSpellRow8, cSpellRow9, cSpellRow10, cSpellRow11, cSpellRow12, cSpellRow13,
            cSpellRow14, cSpellRow15, cSpellRow16, cSpellRow17, cSpellRow18, cSpellRow19};

            // use a loop to fill in each row of the DataGridView for the cleric spells
            foreach(string[] cRowArray in cRows){
                dataGridViewCSpells.Rows.Add(cRowArray);
            } // end foreach for filling rows 
        } // end method for initializing the cleric spell DataGridView

        private void InitializeDataGridViewWSpells()
        {
            // create unbound DataGridView 
            string[] wSpellRow0 = { "1st", "+2", "Spellcasting", "Arcane Recovery", 
                "3", "2", "-", "-", "-", "-", "-", "-", "-", "-" }; // wizard level 1
            string[] wSpellRow1 = { "2nd", "+2", "Arcane Tradition",
                "3", "3", "-", "-", "-", "-", "-", "-", "-", "-" }; // wizard level 2
            string[] wSpellRow2 = { "3rd", "+2", "—",
                "3", "4", "2", "-", "-", "-", "-", "-", "-", "-"  }; // wizard level 3
            string[] wSpellRow3 = { "4th", "+2", "Ability Score Improvement",
                "4", "4", "3", "-", "-", "-", "-", "-", "-", "-" }; // wizard level 4
            string[] wSpellRow4 = { "5th", "+3", "—",
                "4", "4", "3", "2", "-", "-", "-", "-", "-", "-" }; // wizard level 5
            string[] wSpellRow5 = { "6th", "+3", "Arcane Tradition feature",
                "4", "4", "3", "3", "-", "-", "-", "-", "-", "-" }; // wizard level 6
            string[] wSpellRow6 = { "7th", "+3", "—",
                "4", "4", "3", "3", "1", "-", "-", "-", "-", "-" }; // wizard level 7
            string[] wSpellRow7 = { "8th", "+3", "Ability Score Improvement",
                "4", "4", "3", "3", "2", "-", "-", "-", "-", "-" }; // wizard level 8
            string[] wSpellRow8 = { "9th", "+4", "—",
                "4", "4", "3", "3", "3", "1", "—", "—", "—", "—" }; // wizard level 9
            string[] wSpellRow9 = { "10th", "+4", "Arcane Tradition feature",
                "5", "4", "3", "3", "3", "2", "—", "—", "—", "—" }; // wizard level 10
            string[] wSpellRow10 = { "11th", "+4", "—",
                "5", "4", "3", "3", "3", "2", "1", "—", "—", "—" }; // wizard level 11
            string[] wSpellRow11 = { "12th", "+4", "Ability Score Improvement",
                "5", "4", "3", "3", "3", "2", "1", "—", "—", "—" }; // wizard level 12
            string[] wSpellRow12 = { "13th", "+5", "—",
                "5", "4", "3", "3", "3", "2", "1", "1", "—", "—" }; // wizard level 13
            string[] wSpellRow13 = { "14th", "+5", "Arcane Tradition feature",
                "5", "4", "3", "3", "3", "2", "1", "1", "—", "—"  }; // wizard level 14
            string[] wSpellRow14 = { "15th", "+5", "—",
                "5", "4", "3", "3", "3", "2", "1", "1", "1", "—" }; // wizard level 15
            string[] wSpellRow15 = { "16th", "+5", "Ability Score Improvement",
               "5", "4", "3", "3", "3", "2", "1", "1", "1", "—" }; // wizard level 16
            string[] wSpellRow16 = { "17th", "+6", "—",
                "5", "4", "3", "3", "3", "2", "1", "1", "1", "1" }; // wizard level 17
            string[] wSpellRow17 = { "18th", "+6", "Spell Mastery",
                "5", "4", "3", "3", "3", "3", "1", "1", "1", "1"  }; // wizard level 18
            string[] wSpellRow18 = { "19th", "+6", "Ability Score Improvement",
               "5", "4", "3", "3", "3", "2", "1", "1", "1", "1" }; // wizard level 19
            string[] wSpellRow19 = { "20th", "+6", "Signature Spell",
                "5", "4", "3", "3", "3", "3", "2", "2", "1", "1" }; // wizard level 20

            // make an array full of the rows above
            object[] wRows = new object[] {wSpellRow0, wSpellRow1, wSpellRow2, wSpellRow3, wSpellRow4, wSpellRow5,
            wSpellRow6, wSpellRow7, wSpellRow8, wSpellRow9, wSpellRow10, wSpellRow11, wSpellRow12, wSpellRow13,
            wSpellRow14, wSpellRow15, wSpellRow16, wSpellRow17, wSpellRow18, wSpellRow19};

            // use a loop to fill in each row of the DataGridView for the wizard spells
            foreach (string[] wRowArray in wRows)
            {
                dataGridViewWSpells.Rows.Add(wRowArray);
            } // end foreach for filling rows 
        } // end method for initializing the wizard spell DataGridView

        private void InitializeDataGridViewRogue()
        {
            // create unbound DataGridView 
            string[] rogueRow0 = { "1st", "+2", "1d6", "Expertise, Sneak Attack, Thieves’ Cant" }; // rogue level 1
            string[] rogueRow1 = { "2nd", "+2", "1d6", "Cunning Action" }; // rogue level 2
            string[] rogueRow2 = { "3rd", "+2", "2d6", "Roguish Archetype" }; // rogue level 3
            string[] rogueRow3 = { "4th", "+2", "2d6", "Ability Score Improvement" }; // rogue level 4
            string[] rogueRow4 = { "5th", "+3", "3d6", "Uncanny Dodge" }; // rogue level 5
            string[] rogueRow5 = { "6th", "+3", "3d6", "Expertise" }; // rogue level 6
            string[] rogueRow6 = { "7th", "+3", "4d6", "Evasion" }; // rogue level 7
            string[] rogueRow7 = { "8th", "+3", "4d6", "Ability Score Improvement" }; // rogue level 8
            string[] rogueRow8 = { "9th", "+4", "5d6", "Roguish Archetype feature" }; // rogue level 9
            string[] rogueRow9 = { "10th", "+4", "5d6", "Ability Score Improvement" }; // rogue level 10
            string[] rogueRow10 = { "11th", "+4", "6d6", "Reliable Talent" }; // rogue level 11
            string[] rogueRow11 = { "12th", "+4", "6d6", "Ability Score Improvement" }; // rogue level 12
            string[] rogueRow12 = { "13th", "+5", "7d6", "Roguish Archetype feature" }; // rogue level 13
            string[] rogueRow13 = { "14th", "+5", "7d6", "Blindsense" }; // rogue level 14
            string[] rogueRow14 = { "15th", "+5", "8d6", "Slippery Mind" }; // rogue level 15
            string[] rogueRow15 = { "16th", "+5", "8d6", "Ability Score Improvement" }; // rogue level 16
            string[] rogueRow16 = { "17th", "+6", "9d6", "Roguish Archetype feature" }; // rogue level 17
            string[] rogueRow17 = { "18th", "+6", "9d6", "Elusive" }; // rogue level 18
            string[] rogueRow18 = { "19th", "+6", "10d6", "Ability Score Improvement" }; // rogue level 19
            string[] rogueRow19 = { "20th", "+6", "10d6", "Stroke of Luck" }; // rogue level 20

            // make an array full of the rows above
            object[] rogueRows = new object[] {rogueRow0, rogueRow1, rogueRow2, rogueRow3, rogueRow4, rogueRow5,
            rogueRow6, rogueRow7, rogueRow8, rogueRow9, rogueRow10,rogueRow11, rogueRow12, rogueRow13,
            rogueRow14, rogueRow15, rogueRow16, rogueRow17, rogueRow18, rogueRow19};

            // use a loop to fill in each row of the DataGridView for the wizard spells
            foreach (string[] rogueRowArray in rogueRows)
            {
                dataGridViewRogue.Rows.Add(rogueRowArray);
            } // end foreach for filling rows 
        }
    }
}
