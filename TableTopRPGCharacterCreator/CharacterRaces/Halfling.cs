using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    class Halfling : BaseCharacter
    {
        // Parameterless Constructor
        public Halfling() : base()
        {
        } // end Parameterless Constructor

        public Halfling(string name, CharacterGender gender, CharacterClass jobClass, int age) : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            dexterityModifier = dexterity + 2; // add two to dexterity
            charismaModifier = charisma + 1; // add one to charisma

            // test for age to determine how many years to add to selected age
            if (age <= 20)
            {
                Age = age + 50;
            } // end if for age
            else if (age >= 21 && age <= 40)
            {
                Age = age + 75;
            } // end else if
            else if (age >= 41 && age <= 65)
            {
                Age = age + 125;
            } // end else if
            else
            {
                Age = age + 150;
            }// end else

            AlignmentDescriptor = "Lawful";
            Alignment = "Good";
            Size = "Small";
            Speed = 25;
            Languages = languages + ", Halfling";
            RacialProficiencies = "Lucky, Brave, Halfling Nimbleness";
        } // end Constructor
    }
}
