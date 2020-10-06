using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    class Gnome : BaseCharacter
    {
        // Parameterless Constructor
        public Gnome() : base()
        {
        } // end Parameterless Constructor

        public Gnome(string name, CharacterGender gender, CharacterClass jobClass, int age, 
            string alignmentDescriptor) : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            intelligenceModifier = intelligence + 2; // add two to intelligence

            // test for age to determine how many years to add to selected age
            if (age <= 20)
            {
                Age = age + 25;
            } // end if for age
            else if (age >= 21 && age <= 40)
            {
                Age = age + 100;
            } // end else if
            else if (age >= 41 && age <= 65)
            {
                Age = age + 225;
            } // end else if
            else
            {
                Age = age + 400;
            }// end else

            Size = "Small";
            Speed = 25;
            AlignmentDescriptor = alignmentDescriptor;
            Alignment = "Good";
            Languages = languages + ", Gnomish";
            RacialProficiencies = "Darkvision, Gnome Cunning";
        } // end Constructor

    }
}
