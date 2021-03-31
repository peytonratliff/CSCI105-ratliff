using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using CharacterGeneratorGUI.Properties;
using System.Media;


//Programmer: Peyton Ratliff
//Purpose: Using C# to generate a fantasy character
//Date: 13 November 2018

namespace CharacterGeneratorGUI
{
    public partial class Creator : Form
    {
        //This line instantiates a new Character class with the default constructor
        Character[] Character = new Character[5];
        int characterNumber = 0;


        public Creator()
        {
            InitializeComponent();
        }


        //This sets some defaults on program startup. This is a noninvasive way to avoid some issues with the code
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)

            {

                Character[i] = new Character();

            }

            buttonCharacterBack.Enabled = false;
            ButtonCreateCharacter.Enabled = true;
            radioButtonHuman.Checked = true;
            radioButtonWarrior.Checked = true;
            radioButtonMale.Checked = true;
            textBoxStrength.Text = "0";
            textBoxIntellect.Text = "0";
            textBoxAgility.Text = "0";
            textBoxStamina.Text = "0";
            SoundPlayer audio = new SoundPlayer();
            audio.SoundLocation = (Application.StartupPath + "\\" + "Kingdoms Will Burn.wav");
            audio.Play();
        }

        //This creates the chatacter's name
        private void TextBoxCharacterName_TextChanged(object sender, EventArgs e)
        {
            //This same simple try/catch routine is used throughout the program. If the data entered is acceptable then the background remains green, otherwise the field goes red.
            try
            {
                string CharacterName = Convert.ToString(TextBoxCharacterName.Text);
                Character[characterNumber].Name = CharacterName;
                TextBoxCharacterName.BackColor = Color.LightGreen;
            }
            catch
            {
                TextBoxCharacterName.BackColor = Color.Red;
            }

        }

        private void ButtonCreateCharacter_Click(object sender, EventArgs e)
        {
            //The creator of the character must keep the distributed stats below 100, though it is ok for the 100 mark to be broken by race/class stat bonuses.
            if (Character[characterNumber].Strength + Character[characterNumber].Agility + Character[characterNumber].Intellect + Character[characterNumber].Stamina > 100)
            {
                MessageBox.Show("Your stats are too high! Keep them below 100");
            }
            else
            {
                //The following if statements check the race/class combo of the created character, and then adds stats accordingly
                if (radioButtonHuman.Checked == true)
                {
                    Character[characterNumber].Strength += 3;
                    Character[characterNumber].Agility += 3;
                    Character[characterNumber].Intellect += 3;
                    Character[characterNumber].Stamina += 3;
                }
                if (radioButtonDwarf.Checked == true)
                {
                    Character[characterNumber].Strength += 4;
                    Character[characterNumber].Agility += 2;
                    Character[characterNumber].Intellect += 2;
                    Character[characterNumber].Stamina += 4;
                }
                if (radioButtonElf.Checked == true)
                {
                    Character[characterNumber].Strength += 2;
                    Character[characterNumber].Agility += 4;
                    Character[characterNumber].Intellect += 4;
                    Character[characterNumber].Stamina += 2;
                }
                if (radioButtonOrc.Checked == true)
                {
                    Character[characterNumber].Strength += 5;
                    Character[characterNumber].Agility += 1;
                    Character[characterNumber].Intellect += 2;
                    Character[characterNumber].Stamina += 3;
                }
                if (radioButtonTroll.Checked == true)
                {
                    Character[characterNumber].Strength += 3;
                    Character[characterNumber].Agility += 4;
                    Character[characterNumber].Intellect += 2;
                    Character[characterNumber].Stamina += 3;
                }
                if (radioButtonTauren.Checked == true)
                {
                    Character[characterNumber].Strength += 4;
                    Character[characterNumber].Agility += 1;
                    Character[characterNumber].Intellect += 3;
                    Character[characterNumber].Stamina += 4;
                }
                if (radioButtonWarrior.Checked == true)
                {
                    Character[characterNumber].Strength += 5;
                    Character[characterNumber].Agility += 1;
                    Character[characterNumber].Intellect += 1;
                    Character[characterNumber].Stamina += 5;
                }
                if (radioButtonHunter.Checked == true)
                {
                    Character[characterNumber].Strength += 2;
                    Character[characterNumber].Agility += 7;
                    Character[characterNumber].Intellect += 2;
                    Character[characterNumber].Stamina += 1;
                }
                if (radioButtonRogue.Checked == true)
                {
                    Character[characterNumber].Strength += 3;
                    Character[characterNumber].Agility += 5;
                    Character[characterNumber].Intellect += 2;
                    Character[characterNumber].Stamina += 2;
                }
                if (radioButtonMage.Checked == true)
                {
                    Character[characterNumber].Strength += 1;
                    Character[characterNumber].Agility += 1;
                    Character[characterNumber].Intellect += 9;
                    Character[characterNumber].Stamina += 1;
                }
                if (radioButtonShaman.Checked == true)
                {
                    Character[characterNumber].Strength += 4;
                    Character[characterNumber].Agility += 1;
                    Character[characterNumber].Intellect += 5;
                    Character[characterNumber].Stamina += 2;
                }





                Stats StatsPage = new Stats();
                StatsPage.Tag = Character[characterNumber];
                StatsPage.Show();
            }
        }

        //The following radio buttons determine the character race, only one may be selected. They all basically do the same thing, so only one is annotated.
        private void RaceChanger(object sender)
        {
            RadioButton Race = (RadioButton)sender;


            if (Race.Name == radioButtonHuman.Name)
            {
                Character[characterNumber].Race = "Human";
                labelStrengthBonusRace.Text = "3";
                labelAgilityBonusRace.Text = "3";
                labelIntellectBonusRace.Text = "3";
                labelStaminaBonusRace.Text = "3";
                //When the race is changed, the character's class is changed to warrior to avoid some issues with class restrictions.
                radioButtonWarrior.Checked = true;
                //Some races can only be certain classes to add some immersion and class/race fantasy to the game.
                radioButtonWarrior.Enabled = true;
                radioButtonHunter.Enabled = true;
                radioButtonRogue.Enabled = true;
                radioButtonMage.Enabled = true;
                radioButtonShaman.Enabled = false;
                pictureBoxBanner1.Image = Resources.BlueBanner;
                pictureBoxBanner2.Image = Resources.BlueBanner;
                groupBoxRace.BackColor = Color.RoyalBlue;
                groupBoxClass.BackColor = Color.RoyalBlue;
                groupBoxGender.BackColor = Color.RoyalBlue;
                groupBoxStats.BackColor = Color.RoyalBlue;
                //The location of the picturebox has to be bumped for the Alliance (blue guys) otherwise the pets of Hunter class clip behind the sidebar.
                pictureBoxCharacter.Location = new Point(-50, 0);
                PictureChanger();
            }

            if (Race.Name == radioButtonDwarf.Name)
            {
                Character[characterNumber].Race = "Dwarf";
                labelStrengthBonusRace.Text = "4";
                labelAgilityBonusRace.Text = "2";
                labelIntellectBonusRace.Text = "2";
                labelStaminaBonusRace.Text = "4";
                radioButtonWarrior.Checked = true;
                radioButtonWarrior.Enabled = true;
                radioButtonHunter.Enabled = true;
                radioButtonRogue.Enabled = true;
                radioButtonMage.Enabled = false;
                radioButtonShaman.Enabled = true;
                pictureBoxBanner1.Image = Resources.BlueBanner;
                pictureBoxBanner2.Image = Resources.BlueBanner;
                groupBoxRace.BackColor = Color.RoyalBlue;
                groupBoxClass.BackColor = Color.RoyalBlue;
                groupBoxGender.BackColor = Color.RoyalBlue;
                groupBoxStats.BackColor = Color.RoyalBlue;
                pictureBoxCharacter.Location = new Point(-50, 0);
                PictureChanger();
            }

            if (Race.Name == radioButtonElf.Name)
            {
                Character[characterNumber].Race = "Elf";
                labelStrengthBonusRace.Text = "2";
                labelAgilityBonusRace.Text = "4";
                labelIntellectBonusRace.Text = "4";
                labelStaminaBonusRace.Text = "2";
                radioButtonWarrior.Checked = true;
                radioButtonWarrior.Enabled = true;
                radioButtonHunter.Enabled = true;
                radioButtonRogue.Enabled = true;
                radioButtonMage.Enabled = true;
                radioButtonShaman.Enabled = false;
                pictureBoxBanner1.Image = Resources.BlueBanner;
                pictureBoxBanner2.Image = Resources.BlueBanner;
                groupBoxRace.BackColor = Color.RoyalBlue;
                groupBoxClass.BackColor = Color.RoyalBlue;
                groupBoxGender.BackColor = Color.RoyalBlue;
                groupBoxStats.BackColor = Color.RoyalBlue;
                pictureBoxCharacter.Location = new Point(-50, 0);
                PictureChanger();
            }

            if (Race.Name == radioButtonOrc.Name)
            {
                Character[characterNumber].Race = "Orc";
                labelStrengthBonusRace.Text = "6";
                labelAgilityBonusRace.Text = "1";
                labelIntellectBonusRace.Text = "2";
                labelStaminaBonusRace.Text = "3";
                radioButtonWarrior.Checked = true;
                radioButtonWarrior.Enabled = true;
                radioButtonHunter.Enabled = true;
                radioButtonRogue.Enabled = false;
                radioButtonMage.Enabled = false;
                radioButtonShaman.Enabled = true;
                pictureBoxBanner1.Image = Resources.RedBanner;
                pictureBoxBanner2.Image = Resources.RedBanner;
                groupBoxRace.BackColor = Color.Firebrick;
                groupBoxClass.BackColor = Color.Firebrick;
                groupBoxGender.BackColor = Color.Firebrick;
                groupBoxStats.BackColor = Color.Firebrick;
                pictureBoxCharacter.Location = new Point(0, 0);
                PictureChanger();
            }

            if (Race.Name == radioButtonTroll.Name)
            {
                Character[characterNumber].Race = "Troll";
                labelStrengthBonusRace.Text = "3";
                labelAgilityBonusRace.Text = "4";
                labelIntellectBonusRace.Text = "2";
                labelStaminaBonusRace.Text = "3";
                radioButtonWarrior.Checked = true;
                radioButtonWarrior.Enabled = true;
                radioButtonHunter.Enabled = true;
                radioButtonRogue.Enabled = true;
                radioButtonMage.Enabled = true;
                radioButtonShaman.Enabled = true;
                pictureBoxBanner1.Image = Resources.RedBanner;
                pictureBoxBanner2.Image = Resources.RedBanner;
                groupBoxRace.BackColor = Color.Firebrick;
                groupBoxClass.BackColor = Color.Firebrick;
                groupBoxGender.BackColor = Color.Firebrick;
                groupBoxStats.BackColor = Color.Firebrick;
                pictureBoxCharacter.Location = new Point(0, 0);
                PictureChanger();
            }

            if (Race.Name == radioButtonTauren.Name)
            {
                Character[characterNumber].Race = "Tauren";
                labelStrengthBonusRace.Text = "4";
                labelAgilityBonusRace.Text = "1";
                labelIntellectBonusRace.Text = "3";
                labelStaminaBonusRace.Text = "4";
                radioButtonWarrior.Checked = true;
                radioButtonWarrior.Enabled = true;
                radioButtonHunter.Enabled = true;
                radioButtonRogue.Enabled = false;
                radioButtonMage.Enabled = false;
                radioButtonShaman.Enabled = true;
                pictureBoxBanner1.Image = Resources.RedBanner;
                pictureBoxBanner2.Image = Resources.RedBanner;
                groupBoxRace.BackColor = Color.Firebrick;
                groupBoxClass.BackColor = Color.Firebrick;
                groupBoxGender.BackColor = Color.Firebrick;
                groupBoxStats.BackColor = Color.Firebrick;
                pictureBoxCharacter.Location = new Point(0, 0);
                PictureChanger();
            }
        }

        private void radioButtonRaceChanged(object sender, EventArgs e)
        {
            RaceChanger(sender);
        }

        //The following radio buttons determine the character class, only one may be selected
        private void ClassChanger(object sender)
        {
            RadioButton Class = (RadioButton)sender;

            if (Class.Name == radioButtonWarrior.Name)
            {
                Character[characterNumber].Class = "Warrior";
                labelStrengthBonusClass.Text = "5";
                labelAgilityBonusClass.Text = "1";
                labelIntellectBonusClass.Text = "1";
                labelStaminaBonusClass.Text = "5";
                PictureChanger();
            }

            if (Class.Name == radioButtonHunter.Name)
            {
                Character[characterNumber].Class = "Hunter";
                labelStrengthBonusClass.Text = "2";
                labelAgilityBonusClass.Text = "7";
                labelIntellectBonusClass.Text = "2";
                labelStaminaBonusClass.Text = "1";
                PictureChanger();
            }

            if (Class.Name == radioButtonRogue.Name)
            {
                Character[characterNumber].Class = "Rogue";
                labelStrengthBonusClass.Text = "3";
                labelAgilityBonusClass.Text = "5";
                labelIntellectBonusClass.Text = "2";
                labelStaminaBonusClass.Text = "2";
                PictureChanger();
            }

            if (Class.Name == radioButtonMage.Name)
            {
                Character[characterNumber].Class = "Mage";
                labelStrengthBonusClass.Text = "1";
                labelAgilityBonusClass.Text = "1";
                labelIntellectBonusClass.Text = "9";
                labelStaminaBonusClass.Text = "1";
                PictureChanger();
            }

            if (Class.Name == radioButtonShaman.Name)
            {
                Character[characterNumber].Class = "Shaman";
                labelStrengthBonusClass.Text = "4";
                labelAgilityBonusClass.Text = "1";
                labelIntellectBonusClass.Text = "5";
                labelStaminaBonusClass.Text = "2";
                PictureChanger();
            }
        }

        private void radioButtonClassChanged(object sender, EventArgs e)
        {
            ClassChanger(sender);
        }

        //These radio buttons determine the character's gender
        private void GenderChanger(object sender)
        {
            RadioButton Gender = (RadioButton)sender;

            if (Gender.Name == radioButtonMale.Name)
            {
                Character[characterNumber].Gender = "male";
                PictureChanger();
            }

            if (Gender.Name == radioButtonFemale.Name)
            {
                Character[characterNumber].Gender = "female";
                PictureChanger();
            }
        }

        private void radioButtonGenderChanged(object sender, EventArgs e)
        {
            GenderChanger(sender);
        }

        //These text boxes set the characters stats
        //The following text boxes are checked for data validity whenever a change occurs
        private void textBoxStrength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Character[characterNumber].Strength = Convert.ToInt32(textBoxStrength.Text);
                textBoxStrength.BackColor = Color.LightGreen;
            }
            catch
            {
                textBoxStrength.BackColor = Color.Red;
            }
        }

        private void textBoxAgility_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Character[characterNumber].Agility = Convert.ToInt32(textBoxAgility.Text);
                textBoxAgility.BackColor = Color.LightGreen;
            }
            catch
            {
                textBoxAgility.BackColor = Color.Red;
            }
        }

        private void textBoxIntellect_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Character[characterNumber].Intellect = Convert.ToInt32(textBoxIntellect.Text);
                textBoxIntellect.BackColor = Color.LightGreen;
            }
            catch
            {
                textBoxIntellect.BackColor = Color.Red;
            }
        }

        private void textBoxStamina_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Character[characterNumber].Stamina = Convert.ToInt32(textBoxStamina.Text);
                textBoxStamina.BackColor = Color.LightGreen;
            }
            catch
            {
                textBoxStamina.BackColor = Color.Red;
            }
        }

        private void PictureChanger()
        {
            if (radioButtonHuman.Checked == true && radioButtonMale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.HumanMaleWarrior;
            }
            if (radioButtonHuman.Checked == true && radioButtonFemale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.HumanFemaleWarrior;
            }


            if (radioButtonHuman.Checked == true && radioButtonMale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.HumanMaleHunter;
            }
            if (radioButtonHuman.Checked == true && radioButtonFemale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.HumanFemaleHunter;
            }


            if (radioButtonHuman.Checked == true && radioButtonMale.Checked == true && radioButtonRogue.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.HumanMaleRogue;
            }
            if (radioButtonHuman.Checked == true && radioButtonFemale.Checked == true && radioButtonRogue.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.HumanFemaleRogue;
            }


            if (radioButtonHuman.Checked == true && radioButtonMale.Checked == true && radioButtonMage.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.HumanMaleMage;
            }
            if (radioButtonHuman.Checked == true && radioButtonFemale.Checked == true && radioButtonMage.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.HumanFemaleMage;
            }


            if (radioButtonDwarf.Checked == true && radioButtonMale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.DwarfMaleWarrior;
            }
            if (radioButtonDwarf.Checked == true && radioButtonFemale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.DwarfFemaleWarrior;
            }


            if (radioButtonDwarf.Checked == true && radioButtonMale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.DwarfMaleHunter;
            }
            if (radioButtonDwarf.Checked == true && radioButtonFemale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.DwarfFemaleHunter;
            }


            if (radioButtonDwarf.Checked == true && radioButtonMale.Checked == true && radioButtonRogue.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.DwarfMaleRogue;
            }
            if (radioButtonDwarf.Checked == true && radioButtonFemale.Checked == true && radioButtonRogue.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.DwarfFemaleRogue;
            }


            if (radioButtonDwarf.Checked == true && radioButtonMale.Checked == true && radioButtonShaman.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.DwarfMaleShaman;
            }
            if (radioButtonDwarf.Checked == true && radioButtonFemale.Checked == true && radioButtonShaman.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.DwarfFemaleShaman;
            }


            if (radioButtonElf.Checked == true && radioButtonMale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.ElfMaleWarrior;
            }
            if (radioButtonElf.Checked == true && radioButtonFemale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.ElfFemaleWarrior;
            }


            if (radioButtonElf.Checked == true && radioButtonMale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.ElfMaleHunter;
            }
            if (radioButtonElf.Checked == true && radioButtonFemale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.ElfFemaleHunter;
            }


            if (radioButtonElf.Checked == true && radioButtonMale.Checked == true && radioButtonRogue.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.ElfMaleRogue;
            }
            if (radioButtonElf.Checked == true && radioButtonFemale.Checked == true && radioButtonRogue.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.ElfFemaleRogue;
            }


            if (radioButtonElf.Checked == true && radioButtonMale.Checked == true && radioButtonMage.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.ElfMaleMage;
            }
            if (radioButtonElf.Checked == true && radioButtonFemale.Checked == true && radioButtonMage.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.ElfFemaleMage;
            }


            if (radioButtonOrc.Checked == true && radioButtonMale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.OrcMaleWarrior;
            }
            if (radioButtonOrc.Checked == true && radioButtonFemale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.OrcFemaleWarrior;
            }


            if (radioButtonOrc.Checked == true && radioButtonMale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.OrcMaleHunter;
            }
            if (radioButtonOrc.Checked == true && radioButtonFemale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.OrcFemaleHunter;
            }


            if (radioButtonOrc.Checked == true && radioButtonMale.Checked == true && radioButtonShaman.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.OrcMaleShaman;
            }
            if (radioButtonOrc.Checked == true && radioButtonFemale.Checked == true && radioButtonShaman.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.OrcFemaleShaman;
            }


            if (radioButtonTroll.Checked == true && radioButtonMale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollMaleWarrior;
            }
            if (radioButtonTroll.Checked == true && radioButtonFemale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollFemaleWarrior;
            }


            if (radioButtonTroll.Checked == true && radioButtonMale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollMaleHunter;
            }
            if (radioButtonTroll.Checked == true && radioButtonFemale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollFemaleHunter;
            }


            if (radioButtonTroll.Checked == true && radioButtonMale.Checked == true && radioButtonRogue.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollMaleRogue;
            }
            if (radioButtonTroll.Checked == true && radioButtonFemale.Checked == true && radioButtonRogue.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollFemaleRogue;
            }


            if (radioButtonTroll.Checked == true && radioButtonMale.Checked == true && radioButtonMage.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollMaleMage;
            }
            if (radioButtonTroll.Checked == true && radioButtonFemale.Checked == true && radioButtonMage.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollFemaleMage;
            }


            if (radioButtonTroll.Checked == true && radioButtonMale.Checked == true && radioButtonShaman.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollMaleShaman;
            }
            if (radioButtonTroll.Checked == true && radioButtonFemale.Checked == true && radioButtonShaman.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TrollFemaleShaman;
            }


            if (radioButtonTauren.Checked == true && radioButtonMale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TaurenMaleWarrior;
            }
            if (radioButtonTauren.Checked == true && radioButtonFemale.Checked == true && radioButtonWarrior.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TaurenFemaleWarrior;
            }


            if (radioButtonTauren.Checked == true && radioButtonMale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TaurenMaleHunter;
            }
            if (radioButtonTauren.Checked == true && radioButtonFemale.Checked == true && radioButtonHunter.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TaurenFemaleHunter;
            }


            if (radioButtonTauren.Checked == true && radioButtonMale.Checked == true && radioButtonShaman.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TaurenMaleShaman;
            }
            if (radioButtonTauren.Checked == true && radioButtonFemale.Checked == true && radioButtonShaman.Checked == true)
            {
                pictureBoxCharacter.Image = Resources.TaurenFemaleShaman;
            }


        }

        private void buttonCharacterBack_click(object sender, EventArgs e)
        {
            characterNumber--;
            buttonCharacterForward.Enabled = true;
            if (characterNumber == 0) buttonCharacterBack.Enabled = false;
            DisplayWhichCharacter();
        }

        private void buttonCharacterForward_click(object sender, EventArgs e)
        {
            characterNumber++;
            buttonCharacterBack.Enabled = true;
            if (characterNumber == 4) buttonCharacterForward.Enabled = false;
            DisplayWhichCharacter();
        }

        private void DisplayWhichCharacter()
        {


            TextBoxCharacterName.Text = Character[characterNumber].Name;
            textBoxStrength.Text = Character[characterNumber].Strength.ToString();
            textBoxAgility.Text = Character[characterNumber].Agility.ToString();
            textBoxIntellect.Text = Character[characterNumber].Intellect.ToString();
            textBoxStamina.Text = Character[characterNumber].Stamina.ToString();

            if (Character[characterNumber].Race == "Human")
            {
                radioButtonHuman.Checked = true;
            }
            if (Character[characterNumber].Race == "Dwarf")
            {
                radioButtonDwarf.Checked = true;
            }
            if (Character[characterNumber].Race == "Elf")
            {
                radioButtonElf.Checked = true;
            }
            if (Character[characterNumber].Race == "Orc")
            {
                radioButtonOrc.Checked = true;
            }
            if (Character[characterNumber].Race == "Troll")
            {
                radioButtonTroll.Checked = true;
            }
            if (Character[characterNumber].Race == "Tauren")
            {
                radioButtonTauren.Checked = true;
            }
            if (Character[characterNumber].Gender == "male")
            {
                radioButtonMale.Checked = true;
            }
            if (Character[characterNumber].Gender == "female")
            {
                radioButtonFemale.Checked = true;
            }
            if (Character[characterNumber].Class == "Warrior")
            {
                radioButtonWarrior.Checked = true;
            }
            if (Character[characterNumber].Class == "Hunter")
            {
                radioButtonHunter.Checked = true;
            }
            if (Character[characterNumber].Class == "Rogue")
            {
                radioButtonRogue.Checked = true;
            }
            if (Character[characterNumber].Class == "Mage")
            {
                radioButtonMage.Checked = true;
            }
            if (Character[characterNumber].Class == "Shaman")
            {
                radioButtonShaman.Checked = true;
            }

            PictureChanger();
        }
    }
}