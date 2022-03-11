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
        Statistics statistics = new Statistics();

        Words words = new Words();
        String winnerWord;

        List<String> triedWords  = new List<String>();
        String currentWordTry = "";
        List<Label> currentLabelsTry = new List<Label>();

        bool isTimeGame;
        int triesAmount, lettersAmount;
        float gameTime;
        
        Timer GameTimer = new Timer{Interval = (10)};

        public Game()
        {
            InitializeComponent();
 
            GameTimer.Tick += new EventHandler((object _, EventArgs __) => {
                gameTime += 10;
                lb_gameStatus.Text = $"Tempo: {String.Format("{0:0.00}", gameTime / 600)}";
            });
        }

        private void bt_homeStart_Click(object sender, EventArgs e)
        {
            group_home.Visible = false;
            group_options.Visible = true;

            if (txt_nickname.Text == "") txt_nickname.Text = "Guest";
            statistics.CurrentNickname = txt_nickname.Text;
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
            isTimeGame = radio_optionsTempo.Checked;

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
                winnerWord = words.randomWord(lettersAmount);

                if (isTimeGame)
                { 
                    GameTimer.Start();

                    lb_gameStatus.Text = $"Tempo: {gameTime}";
                }
                else
                {
                    lb_gameStatus.Text = $"Tentativas: {triedWords.Count} / {triesAmount}";    
                }

                //MessageBox.Show($"Palavra Certa: {winnerWord}");
                generateNewWordTry();
            }
        }

        private void bt_gameSair_Click(object sender, EventArgs e)
        {
            group_game.Visible = false;
            group_home.Visible = true;

            resetGame();
        }

        private void generateNewWordTry ()
        {
            currentLabelsTry.Clear();
            currentWordTry = "";

            const int LABEL_SIZE = 62;
            const int LABEL_SPACEMENT = 8;
            int lateralSpacement = ((scroll_game.Width - (LABEL_SIZE * lettersAmount)) - (LABEL_SPACEMENT * (lettersAmount - 1))) / 2;

            int numbersOfTries = triedWords.Count;

            for (int i = 0; i < lettersAmount; i++)
            {
                var wordLetter = new Label
                {
                    AutoSize = false,
                    Size = new Size(LABEL_SIZE, LABEL_SIZE),

                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 20, FontStyle.Bold),

                    Location = new Point(lateralSpacement + (LABEL_SPACEMENT + LABEL_SIZE) * i, ((LABEL_SIZE + 20) * (numbersOfTries)) - scroll_game.VerticalScroll.Value),

                    Text = "",
                    BackColor = Color.FromArgb(255, 255, 255),
                    BorderStyle = BorderStyle.FixedSingle,
                };

                scroll_game.Controls.Add(wordLetter);
                currentLabelsTry.Add(wordLetter);
            }

            scroll_game.ScrollControlIntoView(currentLabelsTry[0]);
        }

        private void resetGame ()
        {
            triedWords = new List<String>();
            currentWordTry = "";
            currentLabelsTry = new List<Label>();

            gameTime = 0;
            GameTimer.Stop();

            group_statistics.Visible = false;

            scroll_game.Controls.Clear();
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (group_game.Visible)
            {
                if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 67 && e.KeyChar <= 122)
                {
                    if (currentWordTry.Length < lettersAmount)
                    {
                        currentWordTry += e.KeyChar.ToString().ToUpper();
                        currentLabelsTry[currentWordTry.Length - 1].Text = e.KeyChar.ToString().ToUpper();
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
                        if (triedWords.Contains(currentWordTry))
                        {
                            MessageBox.Show("Palavra já tentada!");
                            return;
                        }
                        else if (!words.wordExists(currentWordTry))
                        {
                            MessageBox.Show("Essa palavra não está na nossa lista!");
                            return;
                        }
                        else {
                            bool wordCorrect = wordScore();

                            if (wordCorrect)
                            {
                                lb_winnerMessage_1.Text = "Parabéns";
                                lb_winnerMessage_1.ForeColor = Color.FromArgb(107, 170, 100);

                                lb_winnerMessage_2.Text = isTimeGame
                                ?  $"Ganhaste em {String.Format("{0:0.00}", gameTime / 600)} segundos com {triedWords.Count + 1} tentativas!!!" 
                                : $"Ganhaste em {triedWords.Count + 1} tentativas!!!";
                            }
                            else if (!isTimeGame && triesAmount == triedWords.Count + 1)
                            {
                                lb_winnerMessage_1.Text = "Perdeste";
                                lb_winnerMessage_1.ForeColor = Color.Red;

                                lb_winnerMessage_2.Text = $"Excedeste as tuas {triesAmount} tentativas!!!";
                            }
                            else
                            {
                                lb_gameStatus.Text = $"Tentativas: {triedWords.Count + 1} / {triesAmount}";
                                triedWords.Add(currentWordTry);
                                generateNewWordTry();
                                return;
                            }
                            
                            GameTimer.Stop();

                            panel_winnerWord.Controls.Clear();
                            int i = 0;
                            currentLabelsTry.ForEach(label => {
                                label.Top = 0;
                                label.Text = winnerWord[i].ToString();
                                label.BackColor = Color.FromArgb(107, 170, 100);

                                panel_winnerWord.Controls.Add(label);
                                i++;
                            });

                            statistics.storeGame(wordCorrect, triedWords.Count + 1);

                            resetGame();

                            group_game.Visible = false;
                            group_winner.Visible = true;
                        }
                    }
                }
            }
        }

        private bool wordScore ()
        {
            bool wordCorrect = true;

            for (int i = 0; i < currentLabelsTry.Count; i++)
            {
                Label label = currentLabelsTry[i];
                label.BorderStyle = BorderStyle.None;


                if (label.Text == winnerWord[i].ToString())
                {
                    label.BackColor = Color.FromArgb(107, 170, 100);
                }
                else if (winnerWord.Contains(label.Text))
                {
                    label.BackColor = Color.FromArgb(201, 180, 88);
                    wordCorrect = false;
                }
                else
                {
                    label.BackColor = Color.FromArgb(120, 124, 126);
                    wordCorrect = false;
                }
            }

            return wordCorrect;
        }

        private void bt_gameStatistics_Click(object sender, EventArgs e)
        {
            group_statistics.Visible = !group_statistics.Visible;
            scroll_game.Visible = !scroll_game.Visible;

            if (group_statistics.Visible)
            {
                lb_statsNick.Text = statistics.CurrentNickname;

                lb_statsPlayedGames.Text = $"Jogos Jogados: {statistics.currentPlayer.gamesPlayed}";
                lb_statsWonGames.Text = $"Jogos Ganhos: {statistics.currentPlayer.gamesWon}";
                lb_statsTriesAmount.Text = $"Total de Tentativas: {statistics.currentPlayer.totalAmountTries}";
                lb_statsLostGames.Text = $"Jogos Perdidos: {statistics.currentPlayer.gamesLost}";

                lb_statsWinGamesPercent.Text = statistics.currentPlayer.gamesPlayed != 0 
                    ? $"{(statistics.currentPlayer.gamesWon * 100) / statistics.currentPlayer.gamesPlayed}%"
                    : "0%";
                lb_statsLostGamesPercent.Text = statistics.currentPlayer.gamesPlayed != 0
                    ? $"{(statistics.currentPlayer.gamesLost * 100) / statistics.currentPlayer.gamesPlayed}%"
                    : "0%";
            }
        }

        private void bt_winnerVoltar_Click(object sender, EventArgs e)
        {
            group_winner.Visible = false;
            group_home.Visible = true;
        }
    }
}
