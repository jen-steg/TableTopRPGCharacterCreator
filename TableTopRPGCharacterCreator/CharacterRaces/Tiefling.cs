using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    class Tiefling : BaseCharacter
    {
        // Parameterless Constructor
        public Tiefling() : base()
        {
        } // end Parameterless Constructor

        public Tiefling(string name, CharacterGender gender, CharacterClass jobClass, int age, 
            string alignmentDescriptor) : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            intelligenceModifier = intelligence + 1; // add one to intelligence
            charismaModifier = charisma + 2; // add two to charisma

            Age = age; // ages at the same rate and years as Humans
            Size = "Medium";
            Speed = 30;
            AlignmentDescriptor = alignmentDescriptor;
            Alignment = "Evil";
            Languages = languages + ", Infernal";
            RacialProficiencies = "Darkvision, Hellish Resistance, Infernal Legacy";
        } // end Constructor
    } // end class Tiefling
}
