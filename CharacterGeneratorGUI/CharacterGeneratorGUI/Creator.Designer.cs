namespace CharacterGeneratorGUI
{
    partial class Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creator));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCharacterName = new System.Windows.Forms.TextBox();
            this.ButtonCreateCharacter = new System.Windows.Forms.Button();
            this.groupBoxRace = new System.Windows.Forms.GroupBox();
            this.radioButtonTauren = new System.Windows.Forms.RadioButton();
            this.labelStaminaBonusRace = new System.Windows.Forms.Label();
            this.labelIntellectBonusRace = new System.Windows.Forms.Label();
            this.labelAgilityBonusRace = new System.Windows.Forms.Label();
            this.labelStrengthBonusRace = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.radioButtonTroll = new System.Windows.Forms.RadioButton();
            this.radioButtonOrc = new System.Windows.Forms.RadioButton();
            this.radioButtonElf = new System.Windows.Forms.RadioButton();
            this.radioButtonDwarf = new System.Windows.Forms.RadioButton();
            this.radioButtonHuman = new System.Windows.Forms.RadioButton();
            this.groupBoxClass = new System.Windows.Forms.GroupBox();
            this.labelStaminaBonusClass = new System.Windows.Forms.Label();
            this.labelIntellectBonusClass = new System.Windows.Forms.Label();
            this.labelAgilityBonusClass = new System.Windows.Forms.Label();
            this.labelStrengthBonusClass = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.radioButtonShaman = new System.Windows.Forms.RadioButton();
            this.radioButtonMage = new System.Windows.Forms.RadioButton();
            this.radioButtonRogue = new System.Windows.Forms.RadioButton();
            this.radioButtonHunter = new System.Windows.Forms.RadioButton();
            this.radioButtonWarrior = new System.Windows.Forms.RadioButton();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStamina = new System.Windows.Forms.TextBox();
            this.textBoxAgility = new System.Windows.Forms.TextBox();
            this.textBoxIntellect = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStrength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.pictureBoxCharacter = new System.Windows.Forms.PictureBox();
            this.pictureBoxBanner1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBanner2 = new System.Windows.Forms.PictureBox();
            this.buttonCharacterForward = new System.Windows.Forms.Button();
            this.buttonCharacterBack = new System.Windows.Forms.Button();
            this.groupBoxRace.SuspendLayout();
            this.groupBoxClass.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(597, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Give your character a name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxCharacterName
            // 
            this.TextBoxCharacterName.BackColor = System.Drawing.Color.Silver;
            this.TextBoxCharacterName.Location = new System.Drawing.Point(597, 557);
            this.TextBoxCharacterName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCharacterName.Name = "TextBoxCharacterName";
            this.TextBoxCharacterName.Size = new System.Drawing.Size(155, 20);
            this.TextBoxCharacterName.TabIndex = 1;
            this.TextBoxCharacterName.TextChanged += new System.EventHandler(this.TextBoxCharacterName_TextChanged);
            // 
            // ButtonCreateCharacter
            // 
            this.ButtonCreateCharacter.BackColor = System.Drawing.Color.Silver;
            this.ButtonCreateCharacter.Location = new System.Drawing.Point(597, 580);
            this.ButtonCreateCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCreateCharacter.Name = "ButtonCreateCharacter";
            this.ButtonCreateCharacter.Size = new System.Drawing.Size(155, 20);
            this.ButtonCreateCharacter.TabIndex = 8;
            this.ButtonCreateCharacter.Text = "Show Stats";
            this.ButtonCreateCharacter.UseVisualStyleBackColor = false;
            this.ButtonCreateCharacter.Click += new System.EventHandler(this.ButtonCreateCharacter_Click);
            // 
            // groupBoxRace
            // 
            this.groupBoxRace.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxRace.Controls.Add(this.radioButtonTauren);
            this.groupBoxRace.Controls.Add(this.labelStaminaBonusRace);
            this.groupBoxRace.Controls.Add(this.labelIntellectBonusRace);
            this.groupBoxRace.Controls.Add(this.labelAgilityBonusRace);
            this.groupBoxRace.Controls.Add(this.labelStrengthBonusRace);
            this.groupBoxRace.Controls.Add(this.label11);
            this.groupBoxRace.Controls.Add(this.label10);
            this.groupBoxRace.Controls.Add(this.label9);
            this.groupBoxRace.Controls.Add(this.label8);
            this.groupBoxRace.Controls.Add(this.label7);
            this.groupBoxRace.Controls.Add(this.labelDivider);
            this.groupBoxRace.Controls.Add(this.radioButtonTroll);
            this.groupBoxRace.Controls.Add(this.radioButtonOrc);
            this.groupBoxRace.Controls.Add(this.radioButtonElf);
            this.groupBoxRace.Controls.Add(this.radioButtonDwarf);
            this.groupBoxRace.Controls.Add(this.radioButtonHuman);
            this.groupBoxRace.Location = new System.Drawing.Point(9, 21);
            this.groupBoxRace.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRace.Name = "groupBoxRace";
            this.groupBoxRace.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRace.Size = new System.Drawing.Size(150, 174);
            this.groupBoxRace.TabIndex = 10;
            this.groupBoxRace.TabStop = false;
            this.groupBoxRace.Text = "Race";
            // 
            // radioButtonTauren
            // 
            this.radioButtonTauren.AutoSize = true;
            this.radioButtonTauren.Location = new System.Drawing.Point(4, 128);
            this.radioButtonTauren.Name = "radioButtonTauren";
            this.radioButtonTauren.Size = new System.Drawing.Size(59, 17);
            this.radioButtonTauren.TabIndex = 15;
            this.radioButtonTauren.TabStop = true;
            this.radioButtonTauren.Text = "Tauren";
            this.radioButtonTauren.UseVisualStyleBackColor = true;
            this.radioButtonTauren.CheckedChanged += new System.EventHandler(this.radioButtonRaceChanged);
            // 
            // labelStaminaBonusRace
            // 
            this.labelStaminaBonusRace.AutoSize = true;
            this.labelStaminaBonusRace.Location = new System.Drawing.Point(133, 90);
            this.labelStaminaBonusRace.Name = "labelStaminaBonusRace";
            this.labelStaminaBonusRace.Size = new System.Drawing.Size(13, 13);
            this.labelStaminaBonusRace.TabIndex = 14;
            this.labelStaminaBonusRace.Text = "0";
            // 
            // labelIntellectBonusRace
            // 
            this.labelIntellectBonusRace.AutoSize = true;
            this.labelIntellectBonusRace.Location = new System.Drawing.Point(133, 73);
            this.labelIntellectBonusRace.Name = "labelIntellectBonusRace";
            this.labelIntellectBonusRace.Size = new System.Drawing.Size(13, 13);
            this.labelIntellectBonusRace.TabIndex = 13;
            this.labelIntellectBonusRace.Text = "0";
            // 
            // labelAgilityBonusRace
            // 
            this.labelAgilityBonusRace.AutoSize = true;
            this.labelAgilityBonusRace.Location = new System.Drawing.Point(133, 56);
            this.labelAgilityBonusRace.Name = "labelAgilityBonusRace";
            this.labelAgilityBonusRace.Size = new System.Drawing.Size(13, 13);
            this.labelAgilityBonusRace.TabIndex = 12;
            this.labelAgilityBonusRace.Text = "0";
            // 
            // labelStrengthBonusRace
            // 
            this.labelStrengthBonusRace.AutoSize = true;
            this.labelStrengthBonusRace.Location = new System.Drawing.Point(133, 39);
            this.labelStrengthBonusRace.Name = "labelStrengthBonusRace";
            this.labelStrengthBonusRace.Size = new System.Drawing.Size(13, 13);
            this.labelStrengthBonusRace.TabIndex = 11;
            this.labelStrengthBonusRace.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Stamina:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Intellect:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Agility:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Strength:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stat Bonuses:";
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(68, 6);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(2, 166);
            this.labelDivider.TabIndex = 5;
            // 
            // radioButtonTroll
            // 
            this.radioButtonTroll.AutoSize = true;
            this.radioButtonTroll.Location = new System.Drawing.Point(4, 105);
            this.radioButtonTroll.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTroll.Name = "radioButtonTroll";
            this.radioButtonTroll.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTroll.TabIndex = 4;
            this.radioButtonTroll.TabStop = true;
            this.radioButtonTroll.Text = "Troll";
            this.radioButtonTroll.UseVisualStyleBackColor = true;
            this.radioButtonTroll.CheckedChanged += new System.EventHandler(this.radioButtonRaceChanged);
            // 
            // radioButtonOrc
            // 
            this.radioButtonOrc.AutoSize = true;
            this.radioButtonOrc.Location = new System.Drawing.Point(4, 83);
            this.radioButtonOrc.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOrc.Name = "radioButtonOrc";
            this.radioButtonOrc.Size = new System.Drawing.Size(42, 17);
            this.radioButtonOrc.TabIndex = 3;
            this.radioButtonOrc.TabStop = true;
            this.radioButtonOrc.Text = "Orc";
            this.radioButtonOrc.UseVisualStyleBackColor = true;
            this.radioButtonOrc.CheckedChanged += new System.EventHandler(this.radioButtonRaceChanged);
            // 
            // radioButtonElf
            // 
            this.radioButtonElf.AutoSize = true;
            this.radioButtonElf.Location = new System.Drawing.Point(4, 61);
            this.radioButtonElf.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonElf.Name = "radioButtonElf";
            this.radioButtonElf.Size = new System.Drawing.Size(37, 17);
            this.radioButtonElf.TabIndex = 2;
            this.radioButtonElf.TabStop = true;
            this.radioButtonElf.Text = "Elf";
            this.radioButtonElf.UseVisualStyleBackColor = true;
            this.radioButtonElf.CheckedChanged += new System.EventHandler(this.radioButtonRaceChanged);
            // 
            // radioButtonDwarf
            // 
            this.radioButtonDwarf.AutoSize = true;
            this.radioButtonDwarf.Location = new System.Drawing.Point(4, 39);
            this.radioButtonDwarf.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDwarf.Name = "radioButtonDwarf";
            this.radioButtonDwarf.Size = new System.Drawing.Size(53, 17);
            this.radioButtonDwarf.TabIndex = 1;
            this.radioButtonDwarf.TabStop = true;
            this.radioButtonDwarf.Text = "Dwarf";
            this.radioButtonDwarf.UseVisualStyleBackColor = true;
            this.radioButtonDwarf.CheckedChanged += new System.EventHandler(this.radioButtonRaceChanged);
            // 
            // radioButtonHuman
            // 
            this.radioButtonHuman.AutoSize = true;
            this.radioButtonHuman.Location = new System.Drawing.Point(4, 17);
            this.radioButtonHuman.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHuman.Name = "radioButtonHuman";
            this.radioButtonHuman.Size = new System.Drawing.Size(59, 17);
            this.radioButtonHuman.TabIndex = 0;
            this.radioButtonHuman.TabStop = true;
            this.radioButtonHuman.Text = "Human";
            this.radioButtonHuman.UseVisualStyleBackColor = true;
            this.radioButtonHuman.CheckedChanged += new System.EventHandler(this.radioButtonRaceChanged);
            // 
            // groupBoxClass
            // 
            this.groupBoxClass.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxClass.Controls.Add(this.labelStaminaBonusClass);
            this.groupBoxClass.Controls.Add(this.labelIntellectBonusClass);
            this.groupBoxClass.Controls.Add(this.labelAgilityBonusClass);
            this.groupBoxClass.Controls.Add(this.labelStrengthBonusClass);
            this.groupBoxClass.Controls.Add(this.label20);
            this.groupBoxClass.Controls.Add(this.label21);
            this.groupBoxClass.Controls.Add(this.label22);
            this.groupBoxClass.Controls.Add(this.label23);
            this.groupBoxClass.Controls.Add(this.label24);
            this.groupBoxClass.Controls.Add(this.label25);
            this.groupBoxClass.Controls.Add(this.radioButtonShaman);
            this.groupBoxClass.Controls.Add(this.radioButtonMage);
            this.groupBoxClass.Controls.Add(this.radioButtonRogue);
            this.groupBoxClass.Controls.Add(this.radioButtonHunter);
            this.groupBoxClass.Controls.Add(this.radioButtonWarrior);
            this.groupBoxClass.Location = new System.Drawing.Point(825, 21);
            this.groupBoxClass.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxClass.Name = "groupBoxClass";
            this.groupBoxClass.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxClass.Size = new System.Drawing.Size(150, 174);
            this.groupBoxClass.TabIndex = 11;
            this.groupBoxClass.TabStop = false;
            this.groupBoxClass.Text = "Class";
            // 
            // labelStaminaBonusClass
            // 
            this.labelStaminaBonusClass.AutoSize = true;
            this.labelStaminaBonusClass.Location = new System.Drawing.Point(136, 90);
            this.labelStaminaBonusClass.Name = "labelStaminaBonusClass";
            this.labelStaminaBonusClass.Size = new System.Drawing.Size(13, 13);
            this.labelStaminaBonusClass.TabIndex = 24;
            this.labelStaminaBonusClass.Text = "0";
            // 
            // labelIntellectBonusClass
            // 
            this.labelIntellectBonusClass.AutoSize = true;
            this.labelIntellectBonusClass.Location = new System.Drawing.Point(136, 73);
            this.labelIntellectBonusClass.Name = "labelIntellectBonusClass";
            this.labelIntellectBonusClass.Size = new System.Drawing.Size(13, 13);
            this.labelIntellectBonusClass.TabIndex = 23;
            this.labelIntellectBonusClass.Text = "0";
            // 
            // labelAgilityBonusClass
            // 
            this.labelAgilityBonusClass.AutoSize = true;
            this.labelAgilityBonusClass.Location = new System.Drawing.Point(136, 56);
            this.labelAgilityBonusClass.Name = "labelAgilityBonusClass";
            this.labelAgilityBonusClass.Size = new System.Drawing.Size(13, 13);
            this.labelAgilityBonusClass.TabIndex = 22;
            this.labelAgilityBonusClass.Text = "0";
            // 
            // labelStrengthBonusClass
            // 
            this.labelStrengthBonusClass.AutoSize = true;
            this.labelStrengthBonusClass.Location = new System.Drawing.Point(136, 39);
            this.labelStrengthBonusClass.Name = "labelStrengthBonusClass";
            this.labelStrengthBonusClass.Size = new System.Drawing.Size(13, 13);
            this.labelStrengthBonusClass.TabIndex = 21;
            this.labelStrengthBonusClass.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(76, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Stamina:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(76, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Intellect:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(76, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "Agility:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(76, 39);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "Strength:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(76, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 16;
            this.label24.Text = "Stat Bonuses:";
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(71, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(2, 166);
            this.label25.TabIndex = 15;
            // 
            // radioButtonShaman
            // 
            this.radioButtonShaman.AutoSize = true;
            this.radioButtonShaman.Location = new System.Drawing.Point(4, 105);
            this.radioButtonShaman.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonShaman.Name = "radioButtonShaman";
            this.radioButtonShaman.Size = new System.Drawing.Size(64, 17);
            this.radioButtonShaman.TabIndex = 4;
            this.radioButtonShaman.TabStop = true;
            this.radioButtonShaman.Text = "Shaman";
            this.radioButtonShaman.UseVisualStyleBackColor = true;
            this.radioButtonShaman.CheckedChanged += new System.EventHandler(this.radioButtonClassChanged);
            // 
            // radioButtonMage
            // 
            this.radioButtonMage.AutoSize = true;
            this.radioButtonMage.Location = new System.Drawing.Point(4, 83);
            this.radioButtonMage.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMage.Name = "radioButtonMage";
            this.radioButtonMage.Size = new System.Drawing.Size(52, 17);
            this.radioButtonMage.TabIndex = 3;
            this.radioButtonMage.TabStop = true;
            this.radioButtonMage.Text = "Mage";
            this.radioButtonMage.UseVisualStyleBackColor = true;
            this.radioButtonMage.CheckedChanged += new System.EventHandler(this.radioButtonClassChanged);
            // 
            // radioButtonRogue
            // 
            this.radioButtonRogue.AutoSize = true;
            this.radioButtonRogue.Location = new System.Drawing.Point(4, 61);
            this.radioButtonRogue.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRogue.Name = "radioButtonRogue";
            this.radioButtonRogue.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRogue.TabIndex = 2;
            this.radioButtonRogue.TabStop = true;
            this.radioButtonRogue.Text = "Rogue";
            this.radioButtonRogue.UseVisualStyleBackColor = true;
            this.radioButtonRogue.CheckedChanged += new System.EventHandler(this.radioButtonClassChanged);
            // 
            // radioButtonHunter
            // 
            this.radioButtonHunter.AutoSize = true;
            this.radioButtonHunter.Location = new System.Drawing.Point(4, 39);
            this.radioButtonHunter.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHunter.Name = "radioButtonHunter";
            this.radioButtonHunter.Size = new System.Drawing.Size(57, 17);
            this.radioButtonHunter.TabIndex = 1;
            this.radioButtonHunter.TabStop = true;
            this.radioButtonHunter.Text = "Hunter";
            this.radioButtonHunter.UseVisualStyleBackColor = true;
            this.radioButtonHunter.CheckedChanged += new System.EventHandler(this.radioButtonClassChanged);
            // 
            // radioButtonWarrior
            // 
            this.radioButtonWarrior.AutoSize = true;
            this.radioButtonWarrior.Location = new System.Drawing.Point(4, 17);
            this.radioButtonWarrior.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWarrior.Name = "radioButtonWarrior";
            this.radioButtonWarrior.Size = new System.Drawing.Size(59, 17);
            this.radioButtonWarrior.TabIndex = 0;
            this.radioButtonWarrior.TabStop = true;
            this.radioButtonWarrior.Text = "Warrior";
            this.radioButtonWarrior.UseVisualStyleBackColor = true;
            this.radioButtonWarrior.CheckedChanged += new System.EventHandler(this.radioButtonClassChanged);
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxStats.Controls.Add(this.label6);
            this.groupBoxStats.Controls.Add(this.label5);
            this.groupBoxStats.Controls.Add(this.textBoxStamina);
            this.groupBoxStats.Controls.Add(this.textBoxAgility);
            this.groupBoxStats.Controls.Add(this.textBoxIntellect);
            this.groupBoxStats.Controls.Add(this.label4);
            this.groupBoxStats.Controls.Add(this.textBoxStrength);
            this.groupBoxStats.Controls.Add(this.label3);
            this.groupBoxStats.Controls.Add(this.label2);
            this.groupBoxStats.Location = new System.Drawing.Point(825, 488);
            this.groupBoxStats.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxStats.Size = new System.Drawing.Size(150, 102);
            this.groupBoxStats.TabIndex = 12;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stat Selection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stamina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Agility:";
            // 
            // textBoxStamina
            // 
            this.textBoxStamina.BackColor = System.Drawing.Color.Silver;
            this.textBoxStamina.Location = new System.Drawing.Point(124, 67);
            this.textBoxStamina.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStamina.Name = "textBoxStamina";
            this.textBoxStamina.Size = new System.Drawing.Size(22, 20);
            this.textBoxStamina.TabIndex = 16;
            this.textBoxStamina.TextChanged += new System.EventHandler(this.textBoxStamina_TextChanged);
            // 
            // textBoxAgility
            // 
            this.textBoxAgility.BackColor = System.Drawing.Color.Silver;
            this.textBoxAgility.Location = new System.Drawing.Point(124, 37);
            this.textBoxAgility.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAgility.Name = "textBoxAgility";
            this.textBoxAgility.Size = new System.Drawing.Size(22, 20);
            this.textBoxAgility.TabIndex = 13;
            this.textBoxAgility.TextChanged += new System.EventHandler(this.textBoxAgility_TextChanged);
            // 
            // textBoxIntellect
            // 
            this.textBoxIntellect.BackColor = System.Drawing.Color.Silver;
            this.textBoxIntellect.Location = new System.Drawing.Point(52, 67);
            this.textBoxIntellect.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIntellect.Name = "textBoxIntellect";
            this.textBoxIntellect.Size = new System.Drawing.Size(22, 20);
            this.textBoxIntellect.TabIndex = 15;
            this.textBoxIntellect.TextChanged += new System.EventHandler(this.textBoxIntellect_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Intellect:";
            // 
            // textBoxStrength
            // 
            this.textBoxStrength.BackColor = System.Drawing.Color.Silver;
            this.textBoxStrength.Location = new System.Drawing.Point(52, 37);
            this.textBoxStrength.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStrength.Name = "textBoxStrength";
            this.textBoxStrength.Size = new System.Drawing.Size(22, 20);
            this.textBoxStrength.TabIndex = 1;
            this.textBoxStrength.TextChanged += new System.EventHandler(this.textBoxStrength_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Strength:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Distribute stats up to 100:";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(9, 488);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGender.Size = new System.Drawing.Size(150, 102);
            this.groupBoxGender.TabIndex = 13;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(98, 37);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(48, 41);
            this.radioButtonFemale.TabIndex = 14;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "♀";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonGenderChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(5, 37);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(52, 41);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "♂";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonGenderChanged);
            // 
            // pictureBoxCharacter
            // 
            this.pictureBoxCharacter.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxCharacter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCharacter.Image")));
            this.pictureBoxCharacter.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCharacter.Name = "pictureBoxCharacter";
            this.pictureBoxCharacter.Size = new System.Drawing.Size(984, 610);
            this.pictureBoxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCharacter.TabIndex = 9;
            this.pictureBoxCharacter.TabStop = false;
            // 
            // pictureBoxBanner1
            // 
            this.pictureBoxBanner1.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxBanner1.Image = global::CharacterGeneratorGUI.Properties.Resources.BlueBanner;
            this.pictureBoxBanner1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBanner1.Name = "pictureBoxBanner1";
            this.pictureBoxBanner1.Size = new System.Drawing.Size(169, 611);
            this.pictureBoxBanner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner1.TabIndex = 14;
            this.pictureBoxBanner1.TabStop = false;
            // 
            // pictureBoxBanner2
            // 
            this.pictureBoxBanner2.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxBanner2.Image = global::CharacterGeneratorGUI.Properties.Resources.BlueBanner;
            this.pictureBoxBanner2.Location = new System.Drawing.Point(815, 0);
            this.pictureBoxBanner2.Name = "pictureBoxBanner2";
            this.pictureBoxBanner2.Size = new System.Drawing.Size(169, 611);
            this.pictureBoxBanner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner2.TabIndex = 15;
            this.pictureBoxBanner2.TabStop = false;
            // 
            // buttonCharacterForward
            // 
            this.buttonCharacterForward.Location = new System.Drawing.Point(757, 570);
            this.buttonCharacterForward.Name = "buttonCharacterForward";
            this.buttonCharacterForward.Size = new System.Drawing.Size(30, 30);
            this.buttonCharacterForward.TabIndex = 17;
            this.buttonCharacterForward.Text = ">>";
            this.buttonCharacterForward.UseVisualStyleBackColor = true;
            this.buttonCharacterForward.Click += new System.EventHandler(this.buttonCharacterForward_click);
            // 
            // buttonCharacterBack
            // 
            this.buttonCharacterBack.Location = new System.Drawing.Point(562, 570);
            this.buttonCharacterBack.Name = "buttonCharacterBack";
            this.buttonCharacterBack.Size = new System.Drawing.Size(30, 30);
            this.buttonCharacterBack.TabIndex = 18;
            this.buttonCharacterBack.Text = "<<";
            this.buttonCharacterBack.UseVisualStyleBackColor = true;
            this.buttonCharacterBack.Click += new System.EventHandler(this.buttonCharacterBack_click);
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.buttonCharacterBack);
            this.Controls.Add(this.buttonCharacterForward);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.groupBoxClass);
            this.Controls.Add(this.groupBoxRace);
            this.Controls.Add(this.ButtonCreateCharacter);
            this.Controls.Add(this.TextBoxCharacterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBanner1);
            this.Controls.Add(this.pictureBoxBanner2);
            this.Controls.Add(this.pictureBoxCharacter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Creator";
            this.Text = "Character Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRace.ResumeLayout(false);
            this.groupBoxRace.PerformLayout();
            this.groupBoxClass.ResumeLayout(false);
            this.groupBoxClass.PerformLayout();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCharacterName;
        private System.Windows.Forms.Button ButtonCreateCharacter;
        private System.Windows.Forms.PictureBox pictureBoxCharacter;
        private System.Windows.Forms.GroupBox groupBoxRace;
        private System.Windows.Forms.RadioButton radioButtonTroll;
        private System.Windows.Forms.RadioButton radioButtonOrc;
        private System.Windows.Forms.RadioButton radioButtonElf;
        private System.Windows.Forms.RadioButton radioButtonDwarf;
        private System.Windows.Forms.RadioButton radioButtonHuman;
        private System.Windows.Forms.GroupBox groupBoxClass;
        private System.Windows.Forms.RadioButton radioButtonShaman;
        private System.Windows.Forms.RadioButton radioButtonMage;
        private System.Windows.Forms.RadioButton radioButtonRogue;
        private System.Windows.Forms.RadioButton radioButtonHunter;
        private System.Windows.Forms.RadioButton radioButtonWarrior;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStrength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStamina;
        private System.Windows.Forms.TextBox textBoxAgility;
        private System.Windows.Forms.TextBox textBoxIntellect;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelStaminaBonusRace;
        private System.Windows.Forms.Label labelIntellectBonusRace;
        private System.Windows.Forms.Label labelAgilityBonusRace;
        private System.Windows.Forms.Label labelStrengthBonusRace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label labelStaminaBonusClass;
        private System.Windows.Forms.Label labelIntellectBonusClass;
        private System.Windows.Forms.Label labelAgilityBonusClass;
        private System.Windows.Forms.Label labelStrengthBonusClass;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RadioButton radioButtonTauren;
        private System.Windows.Forms.PictureBox pictureBoxBanner1;
        private System.Windows.Forms.PictureBox pictureBoxBanner2;
        private System.Windows.Forms.Button buttonCharacterForward;
        private System.Windows.Forms.Button buttonCharacterBack;
    }
}

