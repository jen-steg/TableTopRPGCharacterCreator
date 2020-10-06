/* This program was created to allow the process of character creation for the table top game of Dungeons and Dragons
 * to be expedited, while still being as thorough as needed to fully flesh out their gameplay. 
 * Dungeons and Dragons is owned by Wizards of the Coast, a subsidiary of Hasbro.
 * 
 * COPYRIGHT NOTICE	
 * Open	Game License v 1.0a	Copyright 2000,	Wizards	of	the	Coast, LLC.	
 * System Reference	Document 5.1 Copyright 2016, Wizards of	the	Coast, Inc.;	
 * Authors Mike Mearls, Jeremy Crawford, Chris	Perkins, Rodney	Thompson, Peter	Lee, James Wyatt, Robert J.	Schwalb,	
 * Bruce R.	Cordell, Chris Sims, and Steve Townshend, based	on original	material by	E. Gary	Gygax and Dave Arneson.	
 * END OF LICENSE	
 */
using System;
using System.Windows.Forms;

namespace TableTopRPGCharacterCreator
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ButtonCreateCharacter_Click(object sender, EventArgs e)
        {
            // create new instance of the character creation form
            CreateCharacterForm createCharacterForm = new CreateCharacterForm();
            createCharacterForm.Show(); // show the form for character creation

        } // end event handler for Character creation button

        private void ButtonCredits_Click(object sender, EventArgs e)
        {
            // create new instance of the Credits page form
            CreditsPageForm creditsPageForm = new CreditsPageForm();
            creditsPageForm.Show(); // show the form for the credits page

        } // end event handler for the credits page form

    } // end the Form menu partial class

} // end namespace TableTopRPGCharacterCreator
