using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    class Human : BaseCharacter
    {

        // Parameterless Constructor
        public Human() : base()
        {
        } // end Parameterless Constructor

        public Human(string name, CharacterGender gender, CharacterClass jobClass, int age, 
            string alignmentDescriptor, string alignment) : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            // add one to ALL Ability Scores
            strengthModifier = strength + 1;
            dexterityModifier = dexterity + 1;
            constitutionModifier = constitution + 1;
            intelligenceModifier = intelligence + 1;
            wisdomModifier = wisdom + 1;
            charismaModifier = charisma + 1;

            Age = age;
            AlignmentDescriptor = alignmentDescriptor;
            Alignment = alignment;
            Size = "Medium";
            Speed = 30;
            Languages = languages;
        } // end Constructor
    }
}
