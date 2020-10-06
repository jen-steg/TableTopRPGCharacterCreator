using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    public enum DraconicAncestry { Black, Blue, Brass, Bronze, Copper, Gold, Green, Red, Silver, White }
    class Dragonborn : BaseCharacter
    {
        #region Fields
        protected DraconicAncestry ancestry; // user selected dragon breed
        #endregion

        #region Properties
        public DraconicAncestry Ancestry
        {
            get { return ancestry; }
            protected set { ancestry = value; }
        } // end property for Dracoinc Ancestry
        #endregion
        // Parameterless Constructor
        public Dragonborn() : base()
        {
        } // end Parameterless Constructor

        public Dragonborn(string name, CharacterGender gender) : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
        }
        // Constructor
        public Dragonborn(string name, CharacterGender gender, CharacterClass jobClass, string alignment, DraconicAncestry ancestry) : base()
        {
            CharacterName = name; // set property of character name to the user given name
            CharacterGender = gender; // set property of the gender to the user selected gender
            CharacterClass = jobClass; // set property of the job class to the user selected class

            strengthModifier = strength + 2; // add two to strength
            charismaModifier = charisma + 1; // add one to charisma

            // test for age to determine how many years to add to selected age
            if (age <= 10)
            {
                Age = age + 10;
            } // end if for age
            else if (age >= 21 && age <= 40)
            {
                Age = age - 10;
            } // end else if
            else if (age >= 41 && age <= 65)
            {
                Age = age - 15;
            } // end else if
            else
            {
                Age = age - 20;
            }// end else

            Alignment = "Chaotic" + alignment;
            Size = "Medium";
            Speed = 30;
            Ancestry = ancestry;
            Languages = languages + ", Draconic";
        } // end Constructor
    }
}
