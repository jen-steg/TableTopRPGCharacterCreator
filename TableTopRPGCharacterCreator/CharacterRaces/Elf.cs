using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    class Elf :BaseCharacter
    {
        // Parameterless Constructor
        public Elf() : base()
        {
        } // end Parameterless Constructor

        public Elf(string name, CharacterGender gender, CharacterClass jobClass,  int age, string alignment) : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            wisdomModifier = wisdom + 1; // add one to wisdom
                dexterityModifier = dexterity + 2; // add two to dexterity

                // test for age to determine how many years to add to selected age
                if (age <= 20)
                {
                    Age = age + 150;
                } // end if for age
                else if (age >= 21 && age <= 40)
                {
                    Age = age + 300;
                } // end else if
                else if (age >= 41 && age <= 65)
                {
                    Age = age + 400;
                } // end else if
                else
                {
                    Age = age + 600;
                }// end else

                AlignmentDescriptor = "Chaotic";
                Alignment = alignment; 
                Size = "Medium";
                Speed = 35;
                Languages = languages + ", Elvish"; // add Elvish to base class languages
                RacialProficiencies = "Darkvision, Keen Senses, Fey Ancestry, Trance, Mask of the Wild";
                WeaponProficiencies = "Long sword, short sword, shortbow, and longbow";
            } // end Constructor
        
    }
}
