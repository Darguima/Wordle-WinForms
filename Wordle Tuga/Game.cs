using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle_Tuga
{
    public partial class Game : Form
    {
        List<String> triedWords  = new List<String>();
        String currentWordTry = "";
        List<Label> currentLabelsTry = new List<Label>();

        bool isTimeGame;
        int triesAmount, lettersAmount;

        public Game()
        {
            InitializeComponent();
        }

        private void bt_homeStart_Click(object sender, EventArgs e)
        {
            group_home.Visible = false;
            group_options.Visible = true;
        }

        private void bt_homeTutorial_Click(object sender, EventArgs e)
        {
            group_home.Visible = false;
            group_tutorial.Visible = true;
        }

        private void bt_tutorialSair_Click(object sender, EventArgs e)
        {
            group_tutorial.Visible = false;
            group_home.Visible = true;
        }

        private void bt_optionsStart_Click(object sender, EventArgs e)
        {
            isTimeGame = radio_optionsTentativas.Checked;

            triesAmount = (int)num_optionsTentativas.Value;
            lettersAmount = (int)num_optionsLetras.Value;

            group_options.Visible = false;
            group_game.Visible = true;
        }

        private void bt_optionsSair_Click(object sender, EventArgs e)
        {
            group_options.Visible = false;
            group_home.Visible = true;
        }

        private void radio_optionsTentativas_CheckedChanged(object sender, EventArgs e)
        {
            lb_tentativas.Visible = true;
            num_optionsTentativas.Visible = true;
        }

        private void radio_optionsTempo_CheckedChanged(object sender, EventArgs e)
        {
            lb_tentativas.Visible = false;
            num_optionsTentativas.Visible = false;
        }

        private void group_game_VisibleChanged(object sender, EventArgs e)
        {
            var groupBox = (GroupBox) sender;

            if (groupBox.Visible) {
                generateNewWordTry();
            }
        }

        private void generateNewWordTry ()
        {
            currentLabelsTry.Clear();
            currentWordTry = "";

            const int LABEL_SIZE = 80;
            int labelSpacement = (scroll_game.Width - (LABEL_SIZE * lettersAmount)) / (lettersAmount + 1);

            int numbersOfTries = triedWords.Count;

            for (int i = 0; i < lettersAmount; i++)
            {
                var wordLetter = new Label
                {
                    AutoSize = false,
                    Size = new Size(LABEL_SIZE, LABEL_SIZE),

                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 16),

                    Location = new Point(labelSpacement + (labelSpacement + LABEL_SIZE) * i, ((LABEL_SIZE + 20) * (numbersOfTries)) - scroll_game.VerticalScroll.Value),

                    Text = "",
                    BackColor = Color.FromArgb(107, 170, 100)
                };

                scroll_game.Controls.Add(wordLetter);
                currentLabelsTry.Add(wordLetter);
            }

            scroll_game.ScrollControlIntoView(currentLabelsTry[0]);
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (group_game.Visible)
            {
                if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 67 && e.KeyChar <= 122)
                {
                    if (currentWordTry.Length < lettersAmount)
                    {
                        currentWordTry += e.KeyChar.ToString();
                        currentLabelsTry[currentWordTry.Length - 1].Text = e.KeyChar.ToString();
                    }
                }

                else if (e.KeyChar == (char)Keys.Back) // backspace
                {
                    if (currentWordTry != "")
                    {
                        currentWordTry = currentWordTry.Remove(currentWordTry.Length - 1);
                        currentLabelsTry[currentWordTry.Length].Text = "";
                    }
                }

                else if (e.KeyChar == 13) // enter
                {
                    if (currentWordTry.Length == lettersAmount)
                    {
                        triedWords.Add(currentWordTry);
                        generateNewWordTry();

                    }
                }
            }
        }

    }
}
