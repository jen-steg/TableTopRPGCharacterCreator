using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopRPGCharacterCreator.CharacterRaces
{
    // Gender doesn't affect classes, but all have access to it
    public enum CharacterGender { Male, Female, Unknown }

    public enum CharacterClass { Cleric, Fighter, Rogue, Wizard, Unknown}
    // base class for inheritance only
    public abstract class BaseCharacter
    {
        // set region for easier readability
        #region Fields

        protected Random random; // used for random number generation

        protected string characterName; // user entered name
        protected CharacterGender gender; // user selected gender
        protected CharacterClass jobClass; // user selected job class

        // Ability Scores and their respective modifiers
        protected int strength;
        protected int strengthModifier; // spells cast (future expansion)
        protected int dexterity;
        protected int dexterityModifier; // spells cast (future expansion)
        protected int constitution;
        protected int constitutionModifier; // spells cast (future expansion)
        protected int intelligence;
        protected int intelligenceModifier; // spells cast (future expansion)
        protected int wisdom;
        protected int wisdomModifier; // spells cast (future expansion)
        protected int charisma;
        protected int charismaModifier; // spells cast (future expansion)
        protected int healthPoints;
        protected int healthPointsModifier; // spells cast (future expansion)

        protected int age;
        protected string alignmentDescriptor; // Chaotic, Neutral, or Lawful
        protected string alignment; // Good, Neutral, or Evil
        protected string size;
        protected int speed;
        protected string languages;
        protected string racialProficiencies;
        protected string weaponProficiencies;
        #endregion

        #region Properties
        public CharacterGender CharacterGender
        {
            get { return gender; }
            protected set { gender = value; }
        } // end property for gender

        public CharacterClass CharacterClass
        {
            get { return jobClass; }
            protected set { jobClass = value; }
        } // end property for job class

        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        } // end property for characterName

        public int Strength
        {
            get { return strength + strengthModifier; }
            set { strength = value; }
        } // end property for strength

        public int Dexterity
        {
            get { return dexterity + dexterityModifier; }
            set { dexterity = value; }
        } // end property for dexterity

        public int Constitution
        {
            get { return constitution + constitutionModifier; }
            set { constitution = value; }
        } // end property for constitution

        public int Intelligence
        {
            get { return intelligence + intelligenceModifier; }
            set { intelligence = value; }
        } // end property for intelligence

        public int Wisdom
        {
            get { return wisdom + wisdomModifier; }
            set { wisdom = value; }
        } // end property for wisdom

        public int Charisma
        {
            get { return charisma + charismaModifier; }
            set { charisma = value; }
        } // end property for charisma

        public int HealthPoints
        {
            get { return healthPoints + healthPointsModifier; }
            protected set { healthPoints = value; }
        } // end property for healthPoints

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string AlignmentDescriptor
        {
            get { return alignmentDescriptor; }
            set { alignmentDescriptor = value; }
        } // end property for alignmentDescriptor
        public string Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        } // end property for alignment

        public string Size
        {
            get { return size; }
            set { size = value; }
        } // end property for size

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        } // end property for speed

        public string Languages
        {
            get { return languages; }
            set { languages = value; }
        } // end property for language list

        public string RacialProficiencies
        {
            get { return racialProficiencies; }
            set { racialProficiencies = value; }
        } // end property for racial proficiencies list

        public string WeaponProficiencies
        {
            get { return weaponProficiencies; }
            set { weaponProficiencies = value; }
        } // end property for weapon proficiencies list
        #endregion

        #region Constructor
        // base character constructor
        public BaseCharacter()
        {
            // set initial property values 
            CharacterName = "";
            CharacterGender = CharacterGender.Unknown;
            CharacterClass = CharacterClass.Unknown;
            Strength = 0;
            Dexterity = 0;
            Constitution = 0;
            Intelligence = 0;
            Wisdom = 0;
            Charisma = 0;
            HealthPoints = 0;
            Alignment = "";
            Size = "";
            Speed = 0;
            Languages = "Common"; // all races speak one guaranteed language - Common
            RacialProficiencies = "";
            WeaponProficiencies = "";
        } // end constructor with default values for BaseCharacter class

        #endregion
    }
}
