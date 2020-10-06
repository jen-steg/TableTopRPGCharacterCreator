using System;
using System.Windows.Forms;
using TableTopRPGCharacterCreator.CharacterRaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TableTopRPGCharacterCreator
{
    public partial class CreateCharacterForm : Form
    {
        
        public CreateCharacterForm()
        {
            InitializeComponent();
            // only need one tooltip instance for the form
            // set the tool tips for brief explanations on stats and buttons
            toolTipCreateCharacterForm.SetToolTip(ClassHelpButton, "Detailed descriptions about each job class.");
            toolTipCreateCharacterForm.SetToolTip(RaceHelpButton, "Detailed descriptions about each race.");
            toolTipCreateCharacterForm.SetToolTip(buttonStandardAbility,
                "This gives you the standardized six values as listed in the player guide.");
            toolTipCreateCharacterForm.SetToolTip(labelStrength, "Strength measures your character's muscle and physical power.");
            toolTipCreateCharacterForm.SetToolTip(labelDexterity, "Dexterity measures hand-eye coordination, agility, reflexes, " +
                "and balance.");
            toolTipCreateCharacterForm.SetToolTip(labelConstitution, "Constitution represents a character's health, stamina, " +
                "and vital force.");
            toolTipCreateCharacterForm.SetToolTip(labelIntelligence, "Intelligence determines how well your character learns " +
                "and reasons.");
            toolTipCreateCharacterForm.SetToolTip(labelWisdom, "Wisdom describes a character's willpower, common sense, " +
                "perception, and intuition.");
            toolTipCreateCharacterForm.SetToolTip(labelCharisma, "Charisma measures a character's force of personality, " +
                "persuasiveness, personal magnetism, ability to lead, and physical attractiveness.");
            toolTipCreateCharacterForm.SetToolTip(labelAlignmentDescriptor, "The degree to which your morals are good, " +
                "evil or neutral.");
            toolTipCreateCharacterForm.SetToolTip(labelAlignment, "Good, Evil, or Neutral.");
            // on load hide the draconic ancestry groupbox
            groupBoxDraconicAncestry.Hide();
        }

        public void ModifyStats()
        {
            int[] numericUpDownArray = { (int)numericUpDownStrength.Value, (int)numericUpDownDexterity.Value,
                    (int)numericUpDownConstitution.Value, (int)numericUpDownIntelligence.Value,
                (int)numericUpDownWisdom.Value, (int)numericUpDownCharisma.Value};
            int i = 0;
            foreach (int var in numericUpDownArray)
            {
                MethodsForStats.abilityScoresArray[i] = var;
                i++;
            }

        }
        #region NumericUpDown fields for value changed
        private void NumericUpDownCharisma_ValueChanged(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(numericUpDownCharisma.Value);
            //MessageBox.Show(j.ToString());      //Testing functionality
            int i = (int)numericUpDownCharisma.Value;
            // MessageBox.Show(i.ToString());      //Testing functionality
            disposableAbilityScorePoints.Text = MethodsForStats.ModifyDisposableAbilityScorePoints(i, j, out int f).ToString();
            // if disposableAbilityScorePoints is 0 then set stat to its previous value
            if (f > 0) numericUpDownCharisma.Value = f;
            else
            {
                ModifyStats();
            }
            if (numericUpDownCharisma.Value == 4)
            {
                disposableAbilityScorePoints.Text = "53";
            }
            if (numericUpDownCharisma.Value == 5)
            {
                disposableAbilityScorePoints.Text = "52";
            }
            if (numericUpDownCharisma.Value == 6)
            {
                disposableAbilityScorePoints.Text = "51";
            }
            if (numericUpDownCharisma.Value == 7)
            {
                disposableAbilityScorePoints.Text = "50";
            }
        }

        private void NumericUpDownWisdom_ValueChanged(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(numericUpDownWisdom.Value);
            //MessageBox.Show(j.ToString());      //Testing functionality
            int i = Convert.ToInt32(numericUpDownWisdom.Value);
            //MessageBox.Show(i.ToString());      //Testing functionality
            disposableAbilityScorePoints.Text =
                MethodsForStats.ModifyDisposableAbilityScorePoints(i, j, out int f).ToString();
            // if disposableAbilityScorePoints is 0 then set stat to its previous value
            if (f > 0)
            {
                numericUpDownWisdom.Value = f;
            } // end if
            else
            {
                ModifyStats();
            } // end else
        }

        private void NumericUpDownIntelligence_ValueChanged(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(numericUpDownIntelligence.Value);
            //MessageBox.Show(j.ToString());      //Testing functionality
            int i = Convert.ToInt32(numericUpDownIntelligence.Value);
            //MessageBox.Show(i.ToString());      //Testing functionality
            int f;
            disposableAbilityScorePoints.Text =
                MethodsForStats.ModifyDisposableAbilityScorePoints(i, j, out f).ToString();
            // if disposableAbilityScorePoints is 0 then set stat to its previous value
            if (f > 0)
            {
                numericUpDownIntelligence.Value = f;
            } // end if
            else
            {
                ModifyStats();
            } // end else
        }

        private void NumericUpDownConstitution_ValueChanged(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(numericUpDownConstitution.Value);
            //MessageBox.Show(j.ToString());      //Testing functionality
            int i = Convert.ToInt32(numericUpDownConstitution.Value);
            //MessageBox.Show(i.ToString());      //Testing functionality
            disposableAbilityScorePoints.Text =
                MethodsForStats.ModifyDisposableAbilityScorePoints(i, j, out int f).ToString();
            // if disposableAbilityScorePoints is 0 then set stat to its previous value
            if (f > 0)
            {
                numericUpDownConstitution.Value = f;
            } // end if
            else
            {
                ModifyStats();
            } // end else
        }

        private void NumericUpDownDexterity_ValueChanged(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(numericUpDownDexterity.Value);
            //MessageBox.Show(j.ToString());      //Testing functionality
            int i = (int)numericUpDownDexterity.Value;
            //MessageBox.Show(i.ToString());      //Testing functionality
            disposableAbilityScorePoints.Text =
                MethodsForStats.ModifyDisposableAbilityScorePoints(i, j, out int f).ToString();
            // if disposableAbilityScorePoints is 0 then set stat to its previous value
            if (f > 0)
            {
                numericUpDownDexterity.Value = f;
            } // end if
            else
            {
                ModifyStats();
            } // end else
        }

        private void NumericUpDownStrength_ValueChanged(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(numericUpDownStrength.Value);
            //MessageBox.Show(j.ToString());      //Testing functionality
            int i = (int)numericUpDownStrength.Value;
            //MessageBox.Show(i.ToString());      //Testing functionality
            disposableAbilityScorePoints.Text =
                MethodsForStats.ModifyDisposableAbilityScorePoints(i, j, out int f).ToString();
            // if disposableAbilityScorePoints is 0 then set stat to its previous value
            if (f > 0)
            {
                numericUpDownStrength.Value = f;
            } // end if

            else
            {
                ModifyStats();
            } // end else
            if (numericUpDownStrength.Value == 4)
            {
                disposableAbilityScorePoints.Text = "49";
            } // end if
            if (numericUpDownStrength.Value == 5)
            {
                disposableAbilityScorePoints.Text = "48";
            } // end if
            if (numericUpDownStrength.Value == 6)
            {
                disposableAbilityScorePoints.Text = "47";
            } // end if
            if (numericUpDownStrength.Value == 7)
            {
                disposableAbilityScorePoints.Text = "46";
            } // end if
            if (numericUpDownStrength.Value == 8)
            {
                disposableAbilityScorePoints.Text = "45";
            } // end if
            if (numericUpDownStrength.Value == 9)
            {
                disposableAbilityScorePoints.Text = "44";
            } // end if
            if (numericUpDownStrength.Value == 10)
            {
                disposableAbilityScorePoints.Text = "43";
            } // end if
        }
        #endregion

        private void ButtonStandardAbility_Click(object sender, EventArgs e)
        {
            // when selecting the standard option for ability scores
            // both the label and the ability score points will vanish
            labelPointsRemaining.Hide();
            disposableAbilityScorePoints.Hide();
            // set authorized standard values for six attributes 
            // as 15, 14, 13, 12, 10, 8 respectively
            numericUpDownStrength.Value = 15;
            numericUpDownStrength.Increment = 0; // after being set, do not allow change
            numericUpDownDexterity.Value = 14;
            numericUpDownDexterity.Increment = 0; // after being set, do not allow change
            numericUpDownConstitution.Value = 13;
            numericUpDownConstitution.Increment = 0; // after being set, do not allow change
            numericUpDownIntelligence.Value = 12;
            numericUpDownIntelligence.Increment = 0; // after being set, do not allow change
            numericUpDownWisdom.Value = 10;
            numericUpDownWisdom.Increment = 0; // after being set, do not allow change
            numericUpDownCharisma.Value = 8;
            numericUpDownCharisma.Increment = 0; // after being set, do not allow change
        }
        private void RaceHelpButton_Click(object sender, EventArgs e)
        {
            // create new instance of the race description form
            RaceDescriptionsForm raceDescriptionsForm = new RaceDescriptionsForm();
            raceDescriptionsForm.Show(); // show the form
        }

        private void ClassHelpButton_Click(object sender, EventArgs e)
        {
            // create new instance of the class description form
            ClassDescriptionsForm classDescriptionsForm = new ClassDescriptionsForm();
            classDescriptionsForm.Show();
        }

        private void ButtonSaveCharacter_Click(object sender, EventArgs e)
        {
            // capture all of the information from the form
            // validate fields and make sure they're not empty
            if (String.IsNullOrEmpty(TextBoxFirstName.Text) || TextBoxLastName.Text[0] == ' ' )
            {
                // output message to remind user to enter name
                MessageBox.Show("Please enter the character's name. Please note that names cannot begin with spaces.");
                return;
            } // end if statement for name validation

            // verify that user selected gender
            if(this.RadioButtonGenderMale.Checked == false && this.RadioButtonGenderFemale.Checked == false)
            {
                // output message to remind user to select gender
                MessageBox.Show("Please select a gender.");
                return;
            } // end if statement for gender validation
            string characterGender = (string)(this.RadioButtonGenderMale.Checked ? "Male" : "Female");
            // get user selected race
            if(ComboBoxRace.SelectedIndex < 0)
            {
                //if nothing was selected
                MessageBox.Show("Please select a race.");
            } // end if
            else
            {
                // something was selected, get that 
                string userRaceSelection = ComboBoxRace.SelectedItem.ToString();
                if(userRaceSelection == "Dragonborn" & ComboBoxDraconicAncestry.SelectedIndex < 0)
                {
                    // if the user selects dragonborn, show the draconic ancestry groupbox and make them select one
                    groupBoxDraconicAncestry.Show();
                    MessageBox.Show("Please select your draconic ancestors.");
                }
                // MessageBox.Show(userRaceSelection);       // Testing for functionality
            } // end else
            // get user selected class
            if(ComboBoxCharacterClass.SelectedIndex < 0)
            {
                // if nothing was selected
                MessageBox.Show("Please select a job class for your character.");
            } // end if
            else
            {
                // something was selected, get that 
                string userJobClassSelection = ComboBoxCharacterClass.SelectedItem.ToString();
                // MessageBox.Show(userJobClassSelection);       // Testing for functionality
            } // end else
            if (ComboBoxAlignmentDescriptor.SelectedIndex < 0 & ComboBoxAlignment.SelectedIndex < 0)
            {
                // if nothing was selected
                MessageBox.Show("Please select a complete alignment for your character.");
            } // end if
            else
            {
                // something was selected, get that 
                string userAlignD = ComboBoxAlignmentDescriptor.SelectedItem.ToString();
                string userAlign = ComboBoxAlignment.SelectedItem.ToString();
            } // end else
            // create the player
            string name = TextBoxFirstName.Text + TextBoxLastName.Text;
            CharacterGender charGender;
            if(this.RadioButtonGenderMale.Checked == true)
            {
                // if the radio button for male gender is selected
                charGender = CharacterGender.Male;
            } // end if
            else 
            {
                // if the radio button for female gender is selected
                charGender = CharacterGender.Female;
            } // end else
            
            if (ComboBoxAge.SelectedIndex < -1)
            {
                MessageBox.Show("Please enter an age.");
            } // end if
            else
            {
                int userAge = Convert.ToInt32(ComboBoxAge.SelectedItem.ToString());
            }

            /*CharacterClass charJobClass;
            if (ComboBoxCharacterClass.SelectedItem.ToString() == "Cleric")
            {
                charJobClass = CharacterClass.Cleric; // cleric is selected
            } // end if
            else if (ComboBoxCharacterClass.SelectedItem.ToString() == "Fighter")
            {
                charJobClass = CharacterClass.Fighter; // fighter is selected
            } // end else if
            else if (ComboBoxCharacterClass.SelectedItem.ToString() == "Rogue")
            {
                charJobClass = CharacterClass.Rogue; // rogue is selected
            } // end else if
            else if (ComboBoxCharacterClass.SelectedItem.ToString() == "Wizard")
            {
                charJobClass = CharacterClass.Wizard; // wizard is selected
            } // end else if
            */

            string userAlignment = ComboBoxAlignmentDescriptor.Text + ComboBoxAlignment.Text;
            #region Checking Draconic Ancestry
            /*DraconicAncestry dAncestry;
            if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Black")
            {
                dAncestry = DraconicAncestry.Black; // black is selected
            } // end if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Blue")
            {
                dAncestry = DraconicAncestry.Blue; // blue is selected
            } // end else if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Brass")
            {
                dAncestry = DraconicAncestry.Brass; // brass is selected
            } // end else if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Bronze")
            {
                dAncestry = DraconicAncestry.Bronze; // bronze is selected
            } // end else if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Copper")
            {
                dAncestry = DraconicAncestry.Copper; // copper is selected
            } // end else if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Gold")
            {
                dAncestry = DraconicAncestry.Gold; // gold is selected
            } // end else if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Green")
            {
                dAncestry = DraconicAncestry.Green; // green is selected
            } // end else if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Red")
            {
                dAncestry = DraconicAncestry.Red; // red is selected
            } // end else if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "Silver")
            {
                dAncestry = DraconicAncestry.Silver; // silver is selected
            } // end else if
            else if (ComboBoxDraconicAncestry.SelectedItem.ToString() == "White")
            {
                dAncestry = DraconicAncestry.White; // white is selected
            } // end else if*/
            #endregion
            //string name, CharacterGender gender, CharacterClass jobClass, string alignment, DraconicAncestry ancestry
            /*Human myCharacter = new Human(name, charGender, charJobClass, userAlignD, userAlign);
            MessageBox.Show(myCharacter.CharacterName + "\n" + myCharacter.CharacterClass + "\n" +
                myCharacter.AlignmentDescriptor + " " + myCharacter.Alignment + "\n" + myCharacter.Age + " years old" +
                myCharacter.Size + " size\n" + "Strength : " + myCharacter.Strength + "\nDexterity : " + myCharacter.Dexterity
                + "\nConstitution : " + myCharacter.Constitution + "\nIntelligence : " + myCharacter.Intelligence
                + "\nWisdom : " + myCharacter.Wisdom + "\nCharisma : " + myCharacter.Charisma);*/ //15, 14, 13, 12, 10, 8
            MessageBox.Show($"Name : {name}\n{charGender}\nAge: {ComboBoxAge.Text}\nClass: {ComboBoxCharacterClass.Text}" +
                $"\n{ComboBoxAlignmentDescriptor.Text} {ComboBoxAlignment.Text}\nStrength : {numericUpDownStrength.Text}" +
                $"\nDexterity: {numericUpDownDexterity.TextAlign}\nConstitution : {numericUpDownConstitution.Text}" +
                $"\nIntelligence : {numericUpDownIntelligence.Text}\nWisdom : {numericUpDownWisdom.Text}\nCharisma : {numericUpDownCharisma.Text}");
        }

       

    }
}
