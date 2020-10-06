namespace TableTopRPGCharacterCreator
{
    partial class CreateCharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCharacterForm));
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.GroupBoxGender = new System.Windows.Forms.GroupBox();
            this.RadioButtonGenderFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonGenderMale = new System.Windows.Forms.RadioButton();
            this.ComboBoxRace = new System.Windows.Forms.ComboBox();
            this.LabelRace = new System.Windows.Forms.Label();
            this.GroupBoxCharacterName = new System.Windows.Forms.GroupBox();
            this.RaceHelpButton = new System.Windows.Forms.Button();
            this.labelClass = new System.Windows.Forms.Label();
            this.ComboBoxCharacterClass = new System.Windows.Forms.ComboBox();
            this.ClassHelpButton = new System.Windows.Forms.Button();
            this.buttonSaveCharacter = new System.Windows.Forms.Button();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.labelWisdom = new System.Windows.Forms.Label();
            this.labelCharisma = new System.Windows.Forms.Label();
            this.groupBoxAbilityScores = new System.Windows.Forms.GroupBox();
            this.numericUpDownCharisma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWisdom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIntelligence = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownConstitution = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDexterity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStrength = new System.Windows.Forms.NumericUpDown();
            this.disposableAbilityScorePoints = new System.Windows.Forms.TextBox();
            this.labelPointsRemaining = new System.Windows.Forms.Label();
            this.buttonStandardAbility = new System.Windows.Forms.Button();
            this.labelConstitution = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.toolTipCreateCharacterForm = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxAlignment = new System.Windows.Forms.GroupBox();
            this.labelAlignment = new System.Windows.Forms.Label();
            this.labelAlignmentDescriptor = new System.Windows.Forms.Label();
            this.ComboBoxAlignment = new System.Windows.Forms.ComboBox();
            this.ComboBoxAlignmentDescriptor = new System.Windows.Forms.ComboBox();
            this.groupBoxAge = new System.Windows.Forms.GroupBox();
            this.ComboBoxAge = new System.Windows.Forms.ComboBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.groupBoxDraconicAncestry = new System.Windows.Forms.GroupBox();
            this.ComboBoxDraconicAncestry = new System.Windows.Forms.ComboBox();
            this.labelDraconicAncestry = new System.Windows.Forms.Label();
            this.GroupBoxGender.SuspendLayout();
            this.GroupBoxCharacterName.SuspendLayout();
            this.groupBoxAbilityScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrength)).BeginInit();
            this.groupBoxAlignment.SuspendLayout();
            this.groupBoxAge.SuspendLayout();
            this.groupBoxDraconicAncestry.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(6, 27);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(63, 13);
            this.LabelFirstName.TabIndex = 0;
            this.LabelFirstName.Text = "First Name: ";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(75, 24);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(257, 20);
            this.TextBoxFirstName.TabIndex = 1;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(6, 71);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(64, 13);
            this.LabelLastName.TabIndex = 2;
            this.LabelLastName.Text = "Last Name: ";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(75, 68);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(257, 20);
            this.TextBoxLastName.TabIndex = 3;
            // 
            // GroupBoxGender
            // 
            this.GroupBoxGender.Controls.Add(this.RadioButtonGenderFemale);
            this.GroupBoxGender.Controls.Add(this.RadioButtonGenderMale);
            this.GroupBoxGender.Location = new System.Drawing.Point(16, 121);
            this.GroupBoxGender.Name = "GroupBoxGender";
            this.GroupBoxGender.Size = new System.Drawing.Size(351, 71);
            this.GroupBoxGender.TabIndex = 4;
            this.GroupBoxGender.TabStop = false;
            this.GroupBoxGender.Text = "Select a gender: ";
            // 
            // RadioButtonGenderFemale
            // 
            this.RadioButtonGenderFemale.AutoSize = true;
            this.RadioButtonGenderFemale.Location = new System.Drawing.Point(231, 30);
            this.RadioButtonGenderFemale.Name = "RadioButtonGenderFemale";
            this.RadioButtonGenderFemale.Size = new System.Drawing.Size(59, 17);
            this.RadioButtonGenderFemale.TabIndex = 1;
            this.RadioButtonGenderFemale.TabStop = true;
            this.RadioButtonGenderFemale.Text = "Female";
            this.RadioButtonGenderFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonGenderMale
            // 
            this.RadioButtonGenderMale.AutoSize = true;
            this.RadioButtonGenderMale.Location = new System.Drawing.Point(75, 30);
            this.RadioButtonGenderMale.Name = "RadioButtonGenderMale";
            this.RadioButtonGenderMale.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonGenderMale.TabIndex = 0;
            this.RadioButtonGenderMale.TabStop = true;
            this.RadioButtonGenderMale.Text = "Male";
            this.RadioButtonGenderMale.UseVisualStyleBackColor = true;
            // 
            // ComboBoxRace
            // 
            this.ComboBoxRace.FormattingEnabled = true;
            this.ComboBoxRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Half-Elf",
            "Halfling",
            "Human",
            "Dragonborn",
            "Gnome",
            "Tiefling",
            "Half-Orc"});
            this.ComboBoxRace.Location = new System.Drawing.Point(123, 201);
            this.ComboBoxRace.Name = "ComboBoxRace";
            this.ComboBoxRace.Size = new System.Drawing.Size(163, 21);
            this.ComboBoxRace.TabIndex = 5;
            // 
            // LabelRace
            // 
            this.LabelRace.AutoSize = true;
            this.LabelRace.Location = new System.Drawing.Point(13, 204);
            this.LabelRace.Name = "LabelRace";
            this.LabelRace.Size = new System.Drawing.Size(90, 13);
            this.LabelRace.TabIndex = 6;
            this.LabelRace.Text = "Select your race: ";
            // 
            // GroupBoxCharacterName
            // 
            this.GroupBoxCharacterName.Controls.Add(this.LabelFirstName);
            this.GroupBoxCharacterName.Controls.Add(this.TextBoxLastName);
            this.GroupBoxCharacterName.Controls.Add(this.TextBoxFirstName);
            this.GroupBoxCharacterName.Controls.Add(this.LabelLastName);
            this.GroupBoxCharacterName.Location = new System.Drawing.Point(16, 15);
            this.GroupBoxCharacterName.Name = "GroupBoxCharacterName";
            this.GroupBoxCharacterName.Size = new System.Drawing.Size(351, 100);
            this.GroupBoxCharacterName.TabIndex = 7;
            this.GroupBoxCharacterName.TabStop = false;
            this.GroupBoxCharacterName.Text = "Name Your Character";
            // 
            // RaceHelpButton
            // 
            this.RaceHelpButton.Location = new System.Drawing.Point(292, 199);
            this.RaceHelpButton.Name = "RaceHelpButton";
            this.RaceHelpButton.Size = new System.Drawing.Size(75, 23);
            this.RaceHelpButton.TabIndex = 8;
            this.RaceHelpButton.Text = "Race?";
            this.RaceHelpButton.UseVisualStyleBackColor = true;
            this.RaceHelpButton.Click += new System.EventHandler(this.RaceHelpButton_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(13, 240);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(90, 13);
            this.labelClass.TabIndex = 9;
            this.labelClass.Text = "Select your class:";
            // 
            // ComboBoxCharacterClass
            // 
            this.ComboBoxCharacterClass.FormattingEnabled = true;
            this.ComboBoxCharacterClass.Items.AddRange(new object[] {
            "Cleric",
            "Fighter",
            "Rogue",
            "Wizard"});
            this.ComboBoxCharacterClass.Location = new System.Drawing.Point(123, 237);
            this.ComboBoxCharacterClass.Name = "ComboBoxCharacterClass";
            this.ComboBoxCharacterClass.Size = new System.Drawing.Size(163, 21);
            this.ComboBoxCharacterClass.TabIndex = 10;
            // 
            // ClassHelpButton
            // 
            this.ClassHelpButton.Location = new System.Drawing.Point(292, 235);
            this.ClassHelpButton.Name = "ClassHelpButton";
            this.ClassHelpButton.Size = new System.Drawing.Size(75, 23);
            this.ClassHelpButton.TabIndex = 11;
            this.ClassHelpButton.Text = "Class?";
            this.ClassHelpButton.UseVisualStyleBackColor = true;
            this.ClassHelpButton.Click += new System.EventHandler(this.ClassHelpButton_Click);
            // 
            // buttonSaveCharacter
            // 
            this.buttonSaveCharacter.Location = new System.Drawing.Point(414, 446);
            this.buttonSaveCharacter.Name = "buttonSaveCharacter";
            this.buttonSaveCharacter.Size = new System.Drawing.Size(143, 40);
            this.buttonSaveCharacter.TabIndex = 13;
            this.buttonSaveCharacter.Text = "Save Character";
            this.buttonSaveCharacter.UseVisualStyleBackColor = true;
            this.buttonSaveCharacter.Click += new System.EventHandler(this.ButtonSaveCharacter_Click);
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(17, 23);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(53, 13);
            this.labelStrength.TabIndex = 14;
            this.labelStrength.Text = "Strength :";
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.Location = new System.Drawing.Point(16, 51);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(54, 13);
            this.labelDexterity.TabIndex = 16;
            this.labelDexterity.Text = "Dexterity :";
            // 
            // labelWisdom
            // 
            this.labelWisdom.AutoSize = true;
            this.labelWisdom.Location = new System.Drawing.Point(17, 138);
            this.labelWisdom.Name = "labelWisdom";
            this.labelWisdom.Size = new System.Drawing.Size(51, 13);
            this.labelWisdom.TabIndex = 22;
            this.labelWisdom.Text = "Wisdom :";
            // 
            // labelCharisma
            // 
            this.labelCharisma.AutoSize = true;
            this.labelCharisma.Location = new System.Drawing.Point(17, 168);
            this.labelCharisma.Name = "labelCharisma";
            this.labelCharisma.Size = new System.Drawing.Size(56, 13);
            this.labelCharisma.TabIndex = 24;
            this.labelCharisma.Text = "Charisma :";
            // 
            // groupBoxAbilityScores
            // 
            this.groupBoxAbilityScores.Controls.Add(this.numericUpDownCharisma);
            this.groupBoxAbilityScores.Controls.Add(this.numericUpDownWisdom);
            this.groupBoxAbilityScores.Controls.Add(this.numericUpDownIntelligence);
            this.groupBoxAbilityScores.Controls.Add(this.numericUpDownConstitution);
            this.groupBoxAbilityScores.Controls.Add(this.numericUpDownDexterity);
            this.groupBoxAbilityScores.Controls.Add(this.numericUpDownStrength);
            this.groupBoxAbilityScores.Controls.Add(this.disposableAbilityScorePoints);
            this.groupBoxAbilityScores.Controls.Add(this.labelPointsRemaining);
            this.groupBoxAbilityScores.Controls.Add(this.buttonStandardAbility);
            this.groupBoxAbilityScores.Controls.Add(this.labelStrength);
            this.groupBoxAbilityScores.Controls.Add(this.labelDexterity);
            this.groupBoxAbilityScores.Controls.Add(this.labelCharisma);
            this.groupBoxAbilityScores.Controls.Add(this.labelConstitution);
            this.groupBoxAbilityScores.Controls.Add(this.labelIntelligence);
            this.groupBoxAbilityScores.Controls.Add(this.labelWisdom);
            this.groupBoxAbilityScores.Location = new System.Drawing.Point(392, 15);
            this.groupBoxAbilityScores.Name = "groupBoxAbilityScores";
            this.groupBoxAbilityScores.Size = new System.Drawing.Size(187, 251);
            this.groupBoxAbilityScores.TabIndex = 26;
            this.groupBoxAbilityScores.TabStop = false;
            this.groupBoxAbilityScores.Text = "Ability Scores";
            // 
            // numericUpDownCharisma
            // 
            this.numericUpDownCharisma.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDownCharisma.Location = new System.Drawing.Point(91, 161);
            this.numericUpDownCharisma.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownCharisma.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCharisma.Name = "numericUpDownCharisma";
            this.numericUpDownCharisma.ReadOnly = true;
            this.numericUpDownCharisma.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownCharisma.TabIndex = 36;
            this.numericUpDownCharisma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCharisma.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCharisma.ValueChanged += new System.EventHandler(this.NumericUpDownCharisma_ValueChanged);
            // 
            // numericUpDownWisdom
            // 
            this.numericUpDownWisdom.Location = new System.Drawing.Point(91, 131);
            this.numericUpDownWisdom.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownWisdom.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownWisdom.Name = "numericUpDownWisdom";
            this.numericUpDownWisdom.ReadOnly = true;
            this.numericUpDownWisdom.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownWisdom.TabIndex = 35;
            this.numericUpDownWisdom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownWisdom.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownWisdom.ValueChanged += new System.EventHandler(this.NumericUpDownWisdom_ValueChanged);
            // 
            // numericUpDownIntelligence
            // 
            this.numericUpDownIntelligence.Location = new System.Drawing.Point(91, 102);
            this.numericUpDownIntelligence.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownIntelligence.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownIntelligence.Name = "numericUpDownIntelligence";
            this.numericUpDownIntelligence.ReadOnly = true;
            this.numericUpDownIntelligence.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownIntelligence.TabIndex = 34;
            this.numericUpDownIntelligence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntelligence.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownIntelligence.ValueChanged += new System.EventHandler(this.NumericUpDownIntelligence_ValueChanged);
            // 
            // numericUpDownConstitution
            // 
            this.numericUpDownConstitution.Location = new System.Drawing.Point(91, 73);
            this.numericUpDownConstitution.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownConstitution.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownConstitution.Name = "numericUpDownConstitution";
            this.numericUpDownConstitution.ReadOnly = true;
            this.numericUpDownConstitution.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownConstitution.TabIndex = 33;
            this.numericUpDownConstitution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownConstitution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownConstitution.ValueChanged += new System.EventHandler(this.NumericUpDownConstitution_ValueChanged);
            // 
            // numericUpDownDexterity
            // 
            this.numericUpDownDexterity.Location = new System.Drawing.Point(91, 44);
            this.numericUpDownDexterity.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownDexterity.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownDexterity.Name = "numericUpDownDexterity";
            this.numericUpDownDexterity.ReadOnly = true;
            this.numericUpDownDexterity.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownDexterity.TabIndex = 32;
            this.numericUpDownDexterity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownDexterity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownDexterity.ValueChanged += new System.EventHandler(this.NumericUpDownDexterity_ValueChanged);
            // 
            // numericUpDownStrength
            // 
            this.numericUpDownStrength.Location = new System.Drawing.Point(91, 16);
            this.numericUpDownStrength.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownStrength.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownStrength.Name = "numericUpDownStrength";
            this.numericUpDownStrength.ReadOnly = true;
            this.numericUpDownStrength.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownStrength.TabIndex = 31;
            this.numericUpDownStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownStrength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownStrength.ValueChanged += new System.EventHandler(this.NumericUpDownStrength_ValueChanged);
            // 
            // disposableAbilityScorePoints
            // 
            this.disposableAbilityScorePoints.Location = new System.Drawing.Point(107, 193);
            this.disposableAbilityScorePoints.Name = "disposableAbilityScorePoints";
            this.disposableAbilityScorePoints.ReadOnly = true;
            this.disposableAbilityScorePoints.Size = new System.Drawing.Size(38, 20);
            this.disposableAbilityScorePoints.TabIndex = 30;
            // 
            // labelPointsRemaining
            // 
            this.labelPointsRemaining.AutoSize = true;
            this.labelPointsRemaining.Location = new System.Drawing.Point(6, 196);
            this.labelPointsRemaining.Name = "labelPointsRemaining";
            this.labelPointsRemaining.Size = new System.Drawing.Size(95, 13);
            this.labelPointsRemaining.TabIndex = 29;
            this.labelPointsRemaining.Text = "Points Remaining :";
            // 
            // buttonStandardAbility
            // 
            this.buttonStandardAbility.Location = new System.Drawing.Point(59, 219);
            this.buttonStandardAbility.Name = "buttonStandardAbility";
            this.buttonStandardAbility.Size = new System.Drawing.Size(75, 23);
            this.buttonStandardAbility.TabIndex = 28;
            this.buttonStandardAbility.Text = "Standard";
            this.buttonStandardAbility.UseVisualStyleBackColor = true;
            this.buttonStandardAbility.Click += new System.EventHandler(this.ButtonStandardAbility_Click);
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.Location = new System.Drawing.Point(17, 80);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Size = new System.Drawing.Size(68, 13);
            this.labelConstitution.TabIndex = 18;
            this.labelConstitution.Text = "Constitution :";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Location = new System.Drawing.Point(17, 109);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(67, 13);
            this.labelIntelligence.TabIndex = 20;
            this.labelIntelligence.Text = "Intelligence :";
            // 
            // groupBoxAlignment
            // 
            this.groupBoxAlignment.Controls.Add(this.labelAlignment);
            this.groupBoxAlignment.Controls.Add(this.labelAlignmentDescriptor);
            this.groupBoxAlignment.Controls.Add(this.ComboBoxAlignment);
            this.groupBoxAlignment.Controls.Add(this.ComboBoxAlignmentDescriptor);
            this.groupBoxAlignment.Location = new System.Drawing.Point(18, 269);
            this.groupBoxAlignment.Name = "groupBoxAlignment";
            this.groupBoxAlignment.Size = new System.Drawing.Size(348, 74);
            this.groupBoxAlignment.TabIndex = 27;
            this.groupBoxAlignment.TabStop = false;
            this.groupBoxAlignment.Text = "Alignment :";
            // 
            // labelAlignment
            // 
            this.labelAlignment.AutoSize = true;
            this.labelAlignment.Location = new System.Drawing.Point(229, 16);
            this.labelAlignment.Name = "labelAlignment";
            this.labelAlignment.Size = new System.Drawing.Size(59, 13);
            this.labelAlignment.TabIndex = 3;
            this.labelAlignment.Text = "Alignment :";
            // 
            // labelAlignmentDescriptor
            // 
            this.labelAlignmentDescriptor.AutoSize = true;
            this.labelAlignmentDescriptor.Location = new System.Drawing.Point(37, 16);
            this.labelAlignmentDescriptor.Name = "labelAlignmentDescriptor";
            this.labelAlignmentDescriptor.Size = new System.Drawing.Size(110, 13);
            this.labelAlignmentDescriptor.TabIndex = 2;
            this.labelAlignmentDescriptor.Text = "Alignment Descriptor :";
            // 
            // ComboBoxAlignment
            // 
            this.ComboBoxAlignment.FormattingEnabled = true;
            this.ComboBoxAlignment.Items.AddRange(new object[] {
            "Good",
            "Evil",
            "Neutral"});
            this.ComboBoxAlignment.Location = new System.Drawing.Point(185, 37);
            this.ComboBoxAlignment.Name = "ComboBoxAlignment";
            this.ComboBoxAlignment.Size = new System.Drawing.Size(145, 21);
            this.ComboBoxAlignment.TabIndex = 1;
            // 
            // ComboBoxAlignmentDescriptor
            // 
            this.ComboBoxAlignmentDescriptor.FormattingEnabled = true;
            this.ComboBoxAlignmentDescriptor.Items.AddRange(new object[] {
            "Chaotic",
            "Lawful",
            "Neutral"});
            this.ComboBoxAlignmentDescriptor.Location = new System.Drawing.Point(16, 37);
            this.ComboBoxAlignmentDescriptor.Name = "ComboBoxAlignmentDescriptor";
            this.ComboBoxAlignmentDescriptor.Size = new System.Drawing.Size(155, 21);
            this.ComboBoxAlignmentDescriptor.TabIndex = 0;
            // 
            // groupBoxAge
            // 
            this.groupBoxAge.Controls.Add(this.ComboBoxAge);
            this.groupBoxAge.Controls.Add(this.labelAge);
            this.groupBoxAge.Location = new System.Drawing.Point(391, 278);
            this.groupBoxAge.Name = "groupBoxAge";
            this.groupBoxAge.Size = new System.Drawing.Size(187, 64);
            this.groupBoxAge.TabIndex = 28;
            this.groupBoxAge.TabStop = false;
            this.groupBoxAge.Text = "Age :";
            // 
            // ComboBoxAge
            // 
            this.ComboBoxAge.FormattingEnabled = true;
            this.ComboBoxAge.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.ComboBoxAge.Location = new System.Drawing.Point(12, 26);
            this.ComboBoxAge.Name = "ComboBoxAge";
            this.ComboBoxAge.Size = new System.Drawing.Size(89, 21);
            this.ComboBoxAge.TabIndex = 2;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(114, 28);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(52, 13);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "years old.";
            // 
            // groupBoxDraconicAncestry
            // 
            this.groupBoxDraconicAncestry.Controls.Add(this.labelDraconicAncestry);
            this.groupBoxDraconicAncestry.Controls.Add(this.ComboBoxDraconicAncestry);
            this.groupBoxDraconicAncestry.Location = new System.Drawing.Point(18, 359);
            this.groupBoxDraconicAncestry.Name = "groupBoxDraconicAncestry";
            this.groupBoxDraconicAncestry.Size = new System.Drawing.Size(200, 100);
            this.groupBoxDraconicAncestry.TabIndex = 29;
            this.groupBoxDraconicAncestry.TabStop = false;
            this.groupBoxDraconicAncestry.Text = "Draconic Ancestry :";
            // 
            // ComboBoxDraconicAncestry
            // 
            this.ComboBoxDraconicAncestry.FormattingEnabled = true;
            this.ComboBoxDraconicAncestry.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brass",
            "Bronze",
            "Copper",
            "Gold",
            "Green",
            "Red",
            "Silver",
            "White"});
            this.ComboBoxDraconicAncestry.Location = new System.Drawing.Point(13, 52);
            this.ComboBoxDraconicAncestry.Name = "ComboBoxDraconicAncestry";
            this.ComboBoxDraconicAncestry.Size = new System.Drawing.Size(167, 21);
            this.ComboBoxDraconicAncestry.TabIndex = 0;
            // 
            // labelDraconicAncestry
            // 
            this.labelDraconicAncestry.AutoSize = true;
            this.labelDraconicAncestry.Location = new System.Drawing.Point(18, 26);
            this.labelDraconicAncestry.Name = "labelDraconicAncestry";
            this.labelDraconicAncestry.Size = new System.Drawing.Size(162, 13);
            this.labelDraconicAncestry.TabIndex = 30;
            this.labelDraconicAncestry.Text = "Select your Draconic Ancestors :";
            // 
            // CreateCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(737, 517);
            this.Controls.Add(this.groupBoxDraconicAncestry);
            this.Controls.Add(this.groupBoxAge);
            this.Controls.Add(this.groupBoxAlignment);
            this.Controls.Add(this.groupBoxAbilityScores);
            this.Controls.Add(this.buttonSaveCharacter);
            this.Controls.Add(this.ClassHelpButton);
            this.Controls.Add(this.ComboBoxCharacterClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.RaceHelpButton);
            this.Controls.Add(this.GroupBoxCharacterName);
            this.Controls.Add(this.LabelRace);
            this.Controls.Add(this.ComboBoxRace);
            this.Controls.Add(this.GroupBoxGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateCharacterForm";
            this.Text = "Create Your Character";
            this.GroupBoxGender.ResumeLayout(false);
            this.GroupBoxGender.PerformLayout();
            this.GroupBoxCharacterName.ResumeLayout(false);
            this.GroupBoxCharacterName.PerformLayout();
            this.groupBoxAbilityScores.ResumeLayout(false);
            this.groupBoxAbilityScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrength)).EndInit();
            this.groupBoxAlignment.ResumeLayout(false);
            this.groupBoxAlignment.PerformLayout();
            this.groupBoxAge.ResumeLayout(false);
            this.groupBoxAge.PerformLayout();
            this.groupBoxDraconicAncestry.ResumeLayout(false);
            this.groupBoxDraconicAncestry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.GroupBox GroupBoxGender;
        private System.Windows.Forms.RadioButton RadioButtonGenderFemale;
        private System.Windows.Forms.RadioButton RadioButtonGenderMale;
        private System.Windows.Forms.ComboBox ComboBoxRace;
        private System.Windows.Forms.Label LabelRace;
        private System.Windows.Forms.GroupBox GroupBoxCharacterName;
        private System.Windows.Forms.Button RaceHelpButton;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox ComboBoxCharacterClass;
        private System.Windows.Forms.Button ClassHelpButton;
        private System.Windows.Forms.Button buttonSaveCharacter;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.Label labelWisdom;
        private System.Windows.Forms.Label labelCharisma;
        private System.Windows.Forms.GroupBox groupBoxAbilityScores;
        private System.Windows.Forms.Button buttonStandardAbility;
        private System.Windows.Forms.TextBox disposableAbilityScorePoints;
        private System.Windows.Forms.Label labelPointsRemaining;
        private System.Windows.Forms.Label labelConstitution;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.NumericUpDown numericUpDownStrength;
        private System.Windows.Forms.NumericUpDown numericUpDownDexterity;
        private System.Windows.Forms.NumericUpDown numericUpDownConstitution;
        private System.Windows.Forms.NumericUpDown numericUpDownIntelligence;
        private System.Windows.Forms.NumericUpDown numericUpDownWisdom;
        private System.Windows.Forms.NumericUpDown numericUpDownCharisma;
        private System.Windows.Forms.ToolTip toolTipCreateCharacterForm;
        private System.Windows.Forms.GroupBox groupBoxAlignment;
        private System.Windows.Forms.Label labelAlignment;
        private System.Windows.Forms.Label labelAlignmentDescriptor;
        private System.Windows.Forms.ComboBox ComboBoxAlignment;
        private System.Windows.Forms.ComboBox ComboBoxAlignmentDescriptor;
        private System.Windows.Forms.GroupBox groupBoxAge;
        private System.Windows.Forms.ComboBox ComboBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.GroupBox groupBoxDraconicAncestry;
        private System.Windows.Forms.Label labelDraconicAncestry;
        private System.Windows.Forms.ComboBox ComboBoxDraconicAncestry;
    }
}