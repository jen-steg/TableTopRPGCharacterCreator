using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TableTopRPGCharacterCreator.CharacterRaces
{
    class HalfOrc : BaseCharacter
    {
        // Parameterless Constructor
        public HalfOrc() : base()
        {
        } // end Parameterless Constructor

        public HalfOrc(string name, CharacterGender gender, CharacterClass jobClass, int age) : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            strengthModifier = strength + 2; // add two to strength
            constitutionModifier = constitution + 1; // add one to constitution

            if(age < 14)
            {
                Age = age + 14;
            } // end if
            else if (age <= 25)
            {
                Age = age - 5;
            } // end else if
            else if (age <= 45)
            {
                Age = age - 15;
            } // end else if
            else if (age <= 65)
            {
                Age = age - 20;
            } // end else if
            else
            {
                Age = age - 25;
            } // end else

            AlignmentDescriptor = "Chaotic";
            Alignment = alignment;
            Size = "Medium";
            Speed = 30;
            RacialProficiencies = "Darkvision, Menacing, Relentless Endurance, Savage Attacks";
            Languages = languages + ", Orc";
        } // end Constructor
    }
}
