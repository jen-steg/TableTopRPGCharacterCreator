using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    class HalfElf : BaseCharacter
    {
        // Parameterless Constructor
        public HalfElf() : base()
        {
        } // end Parameterless Constructor

        public HalfElf(string name, CharacterGender gender, CharacterClass jobClass, int age, 
            string alignment) : base()      
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            charismaModifier = charisma + 2; // add two to charisma
            intelligenceModifier = intelligence + 1; // add one to intelligence
            dexterityModifier = dexterity + 1; // add one to dexterity

            // test for age to determine how many years to add to selected age
            if (age <= 20)
            {
                Age = age + 25;
            } // end if for age
            else if (age >= 21 && age <= 40)
            {
                Age = age + 50;
            } // end else if
            else if (age >= 41 && age <= 65)
            {
                Age = age + 75;
            } // end else if
            else
            {
                Age = age + 100;
            }// end else

            AlignmentDescriptor = "Chaotic";
            Alignment = alignment; 
            Size = "Medium";
            Speed = 30;
            Languages = languages + ", Elvish"; // add Elvish to base class languages
            RacialProficiencies = "Darkvision, Fey Ancestry";
            WeaponProficiencies = "Long sword, short sword, shortbow, and longbow";
        } // end Constructor

    }
}
