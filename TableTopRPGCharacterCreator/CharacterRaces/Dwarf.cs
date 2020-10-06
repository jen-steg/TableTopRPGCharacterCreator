using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    class Dwarf : BaseCharacter
    {
        // Parameterless Constructor
        public Dwarf()
            : base()
        {
        } // end Parameterless Constructor

        public Dwarf(string name, CharacterGender gender, CharacterClass jobClass, int age, string alignment)
        : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            strengthModifier = strength + 2; // add two to strength
            constitutionModifier = constitution + 2; // add two to constitution
            
            // test for age to determine how many years to add to selected age
            if( age <= 20 )
            {
                Age = age + 50;
            } // end if for age
            else if (age >= 21 && age <= 40)
            {
                Age = age + 100;
            } // end else if
            else if ( age >= 41 && age <= 65)
            {
                Age = age + 150;
            } // end else if
            else
            {
                Age = age + 200;
            }// end else
            AlignmentDescriptor = "Lawful";
            Alignment = alignment; 
            Size = "Medium";
            Speed = 25;
            Languages = languages + ", Dwarven" ; // add Dwarven to base class languages
            RacialProficiencies = "Darkvision, Dwarven Resilience, Stonecunning";
            WeaponProficiencies = "Smith's tools, Brewer's supplies, or Mason's tools";
        } // end Constructor
    }
}
