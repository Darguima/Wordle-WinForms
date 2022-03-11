namespace Wordle_Tuga
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.group_home = new System.Windows.Forms.GroupBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_homeTutorial = new System.Windows.Forms.Button();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.bt_homeStart = new System.Windows.Forms.Button();
            this.group_game = new System.Windows.Forms.GroupBox();
            this.bt_gameStatistics = new System.Windows.Forms.PictureBox();
            this.lb_gameStatus = new System.Windows.Forms.Label();
            this.bt_gameSair = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.scroll_game = new System.Windows.Forms.Panel();
            this.group_statistics = new System.Windows.Forms.GroupBox();
            this.lb_statsLostGamesPercent = new System.Windows.Forms.Label();
            this.lb_statsWinGamesPercent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_statsLostGames = new System.Windows.Forms.Label();
            this.lb_statsTriesAmount = new System.Windows.Forms.Label();
            this.lb_statsWonGames = new System.Windows.Forms.Label();
            this.lb_statsPlayedGames = new System.Windows.Forms.Label();
            this.lb_statsNick = new System.Windows.Forms.Label();
            this.group_options = new System.Windows.Forms.GroupBox();
            this.radio_optionsTempo = new System.Windows.Forms.RadioButton();
            this.radio_optionsTentativas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tentativas = new System.Windows.Forms.Label();
            this.num_optionsLetras = new System.Windows.Forms.NumericUpDown();
            this.num_optionsTentativas = new System.Windows.Forms.NumericUpDown();
            this.bt_optionsStart = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bt_optionsSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.group_tutorial = new System.Windows.Forms.GroupBox();
            this.bt_tutorialSair = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.group_winner = new System.Windows.Forms.GroupBox();
            this.lb_winnerMessage_1 = new System.Windows.Forms.Label();
            this.bt_winnerVoltar = new System.Windows.Forms.Button();
            this.lb_winnerMessage_2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel_winnerWord = new System.Windows.Forms.Panel();
            this.group_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_gameStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.group_statistics.SuspendLayout();
            this.group_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_optionsLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_optionsTentativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.group_tutorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.group_winner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // group_home
            // 
            this.group_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.group_home.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_home.Controls.Add(this.lbl_1);
            this.group_home.Controls.Add(this.pictureBox1);
            this.group_home.Controls.Add(this.bt_homeTutorial);
            this.group_home.Controls.Add(this.txt_nickname);
            this.group_home.Controls.Add(this.bt_homeStart);
            this.group_home.Location = new System.Drawing.Point(-2, -9);
            this.group_home.Name = "group_home";
            this.group_home.Size = new System.Drawing.Size(612, 639);
            this.group_home.TabIndex = 7;
            this.group_home.TabStop = false;
            // 
            // lbl_1
            // 
            this.lbl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(208, 270);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(196, 23);
            this.lbl_1.TabIndex = 4;
            this.lbl_1.Text = "Nickname";
            this.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Wordle_Tuga.Properties.Resources.wordleLogo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_homeTutorial
            // 
            this.bt_homeTutorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_homeTutorial.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_homeTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_homeTutorial.Location = new System.Drawing.Point(157, 405);
            this.bt_homeTutorial.Name = "bt_homeTutorial";
            this.bt_homeTutorial.Size = new System.Drawing.Size(299, 47);
            this.bt_homeTutorial.TabIndex = 1;
            this.bt_homeTutorial.Text = "TUTORIAL";
            this.bt_homeTutorial.UseVisualStyleBackColor = false;
            this.bt_homeTutorial.Click += new System.EventHandler(this.bt_homeTutorial_Click);
            // 
            // txt_nickname
            // 
            this.txt_nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(208, 296);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(196, 26);
            this.txt_nickname.TabIndex = 2;
            this.txt_nickname.Text = "Guest";
            this.txt_nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_homeStart
            // 
            this.bt_homeStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_homeStart.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_homeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_homeStart.Location = new System.Drawing.Point(157, 499);
            this.bt_homeStart.Name = "bt_homeStart";
            this.bt_homeStart.Size = new System.Drawing.Size(299, 47);
            this.bt_homeStart.TabIndex = 3;
            this.bt_homeStart.Text = "🎮   JOGAR   🎮";
            this.bt_homeStart.UseVisualStyleBackColor = false;
            this.bt_homeStart.Click += new System.EventHandler(this.bt_homeStart_Click);
            // 
            // group_game
            // 
            this.group_game.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.group_game.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_game.Controls.Add(this.bt_gameStatistics);
            this.group_game.Controls.Add(this.lb_gameStatus);
            this.group_game.Controls.Add(this.bt_gameSair);
            this.group_game.Controls.Add(this.line);
            this.group_game.Controls.Add(this.pictureBox3);
            this.group_game.Controls.Add(this.scroll_game);
            this.group_game.Controls.Add(this.group_statistics);
            this.group_game.Location = new System.Drawing.Point(-2, -9);
            this.group_game.Name = "group_game";
            this.group_game.Size = new System.Drawing.Size(612, 639);
            this.group_game.TabIndex = 9;
            this.group_game.TabStop = false;
            this.group_game.Visible = false;
            this.group_game.VisibleChanged += new System.EventHandler(this.group_game_VisibleChanged);
            // 
            // bt_gameStatistics
            // 
            this.bt_gameStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bt_gameStatistics.Image = global::Wordle_Tuga.Properties.Resources.statisticsIcon;
            this.bt_gameStatistics.Location = new System.Drawing.Point(489, 20);
            this.bt_gameStatistics.Name = "bt_gameStatistics";
            this.bt_gameStatistics.Size = new System.Drawing.Size(36, 36);
            this.bt_gameStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_gameStatistics.TabIndex = 15;
            this.bt_gameStatistics.TabStop = false;
            this.bt_gameStatistics.Click += new System.EventHandler(this.bt_gameStatistics_Click);
            // 
            // lb_gameStatus
            // 
            this.lb_gameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gameStatus.Location = new System.Drawing.Point(50, 42);
            this.lb_gameStatus.Name = "lb_gameStatus";
            this.lb_gameStatus.Size = new System.Drawing.Size(163, 26);
            this.lb_gameStatus.TabIndex = 12;
            this.lb_gameStatus.Text = "gameStatus";
            this.lb_gameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_gameSair
            // 
            this.bt_gameSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_gameSair.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_gameSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gameSair.Location = new System.Drawing.Point(531, 19);
            this.bt_gameSair.Name = "bt_gameSair";
            this.bt_gameSair.Size = new System.Drawing.Size(75, 38);
            this.bt_gameSair.TabIndex = 11;
            this.bt_gameSair.Text = "Sair";
            this.bt_gameSair.UseVisualStyleBackColor = false;
            this.bt_gameSair.Click += new System.EventHandler(this.bt_gameSair_Click);
            // 
            // line
            // 
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Location = new System.Drawing.Point(54, 71);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(500, 2);
            this.line.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Wordle_Tuga.Properties.Resources.favicon;
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(600, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // scroll_game
            // 
            this.scroll_game.AutoScroll = true;
            this.scroll_game.Location = new System.Drawing.Point(54, 76);
            this.scroll_game.Name = "scroll_game";
            this.scroll_game.Size = new System.Drawing.Size(500, 542);
            this.scroll_game.TabIndex = 3;
            // 
            // group_statistics
            // 
            this.group_statistics.Controls.Add(this.lb_statsLostGamesPercent);
            this.group_statistics.Controls.Add(this.lb_statsWinGamesPercent);
            this.group_statistics.Controls.Add(this.label9);
            this.group_statistics.Controls.Add(this.label1);
            this.group_statistics.Controls.Add(this.lb_statsLostGames);
            this.group_statistics.Controls.Add(this.lb_statsTriesAmount);
            this.group_statistics.Controls.Add(this.lb_statsWonGames);
            this.group_statistics.Controls.Add(this.lb_statsPlayedGames);
            this.group_statistics.Controls.Add(this.lb_statsNick);
            this.group_statistics.Location = new System.Drawing.Point(54, 76);
            this.group_statistics.Name = "group_statistics";
            this.group_statistics.Size = new System.Drawing.Size(500, 542);
            this.group_statistics.TabIndex = 14;
            this.group_statistics.TabStop = false;
            this.group_statistics.Text = "Statistics";
            this.group_statistics.Visible = false;
            // 
            // lb_statsLostGamesPercent
            // 
            this.lb_statsLostGamesPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statsLostGamesPercent.Location = new System.Drawing.Point(376, 408);
            this.lb_statsLostGamesPercent.Name = "lb_statsLostGamesPercent";
            this.lb_statsLostGamesPercent.Size = new System.Drawing.Size(80, 80);
            this.lb_statsLostGamesPercent.TabIndex = 8;
            this.lb_statsLostGamesPercent.Text = "xx%";
            this.lb_statsLostGamesPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_statsWinGamesPercent
            // 
            this.lb_statsWinGamesPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statsWinGamesPercent.Location = new System.Drawing.Point(48, 408);
            this.lb_statsWinGamesPercent.Name = "lb_statsWinGamesPercent";
            this.lb_statsWinGamesPercent.Size = new System.Drawing.Size(80, 80);
            this.lb_statsWinGamesPercent.TabIndex = 7;
            this.lb_statsWinGamesPercent.Text = "xx%";
            this.lb_statsWinGamesPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 80);
            this.label9.TabIndex = 6;
            this.label9.Text = "Perdas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ganhos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_statsLostGames
            // 
            this.lb_statsLostGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statsLostGames.Location = new System.Drawing.Point(2, 213);
            this.lb_statsLostGames.Name = "lb_statsLostGames";
            this.lb_statsLostGames.Size = new System.Drawing.Size(491, 43);
            this.lb_statsLostGames.TabIndex = 4;
            this.lb_statsLostGames.Text = "Jogos Perdidos: ";
            this.lb_statsLostGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_statsTriesAmount
            // 
            this.lb_statsTriesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statsTriesAmount.Location = new System.Drawing.Point(2, 176);
            this.lb_statsTriesAmount.Name = "lb_statsTriesAmount";
            this.lb_statsTriesAmount.Size = new System.Drawing.Size(491, 43);
            this.lb_statsTriesAmount.TabIndex = 3;
            this.lb_statsTriesAmount.Text = "Total de Tentativas: ";
            this.lb_statsTriesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_statsWonGames
            // 
            this.lb_statsWonGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statsWonGames.Location = new System.Drawing.Point(2, 133);
            this.lb_statsWonGames.Name = "lb_statsWonGames";
            this.lb_statsWonGames.Size = new System.Drawing.Size(491, 43);
            this.lb_statsWonGames.TabIndex = 2;
            this.lb_statsWonGames.Text = "Jogos Ganhos: ";
            this.lb_statsWonGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_statsPlayedGames
            // 
            this.lb_statsPlayedGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statsPlayedGames.Location = new System.Drawing.Point(2, 92);
            this.lb_statsPlayedGames.Name = "lb_statsPlayedGames";
            this.lb_statsPlayedGames.Size = new System.Drawing.Size(491, 43);
            this.lb_statsPlayedGames.TabIndex = 1;
            this.lb_statsPlayedGames.Text = "Jogos Jogados: ";
            this.lb_statsPlayedGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_statsNick
            // 
            this.lb_statsNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statsNick.Location = new System.Drawing.Point(6, 17);
            this.lb_statsNick.Name = "lb_statsNick";
            this.lb_statsNick.Size = new System.Drawing.Size(488, 40);
            this.lb_statsNick.TabIndex = 0;
            this.lb_statsNick.Text = "Nickname";
            this.lb_statsNick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_options
            // 
            this.group_options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.group_options.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_options.Controls.Add(this.radio_optionsTempo);
            this.group_options.Controls.Add(this.radio_optionsTentativas);
            this.group_options.Controls.Add(this.label2);
            this.group_options.Controls.Add(this.lb_tentativas);
            this.group_options.Controls.Add(this.num_optionsLetras);
            this.group_options.Controls.Add(this.num_optionsTentativas);
            this.group_options.Controls.Add(this.bt_optionsStart);
            this.group_options.Controls.Add(this.pictureBox4);
            this.group_options.Controls.Add(this.bt_optionsSair);
            this.group_options.Location = new System.Drawing.Point(-2, -9);
            this.group_options.Name = "group_options";
            this.group_options.Size = new System.Drawing.Size(612, 639);
            this.group_options.TabIndex = 11;
            this.group_options.TabStop = false;
            this.group_options.Visible = false;
            // 
            // radio_optionsTempo
            // 
            this.radio_optionsTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio_optionsTempo.AutoSize = true;
            this.radio_optionsTempo.Location = new System.Drawing.Point(364, 239);
            this.radio_optionsTempo.Name = "radio_optionsTempo";
            this.radio_optionsTempo.Size = new System.Drawing.Size(92, 17);
            this.radio_optionsTempo.TabIndex = 1;
            this.radio_optionsTempo.Text = "Jogar a tempo";
            this.radio_optionsTempo.UseVisualStyleBackColor = true;
            this.radio_optionsTempo.CheckedChanged += new System.EventHandler(this.radio_optionsTempo_CheckedChanged);
            // 
            // radio_optionsTentativas
            // 
            this.radio_optionsTentativas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio_optionsTentativas.AutoSize = true;
            this.radio_optionsTentativas.Checked = true;
            this.radio_optionsTentativas.Location = new System.Drawing.Point(157, 239);
            this.radio_optionsTentativas.Name = "radio_optionsTentativas";
            this.radio_optionsTentativas.Size = new System.Drawing.Size(109, 17);
            this.radio_optionsTentativas.TabIndex = 0;
            this.radio_optionsTentativas.TabStop = true;
            this.radio_optionsTentativas.Text = "Jogar a tentativas";
            this.radio_optionsTentativas.UseVisualStyleBackColor = true;
            this.radio_optionsTentativas.CheckedChanged += new System.EventHandler(this.radio_optionsTentativas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(248, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Letras";
            // 
            // lb_tentativas
            // 
            this.lb_tentativas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tentativas.Location = new System.Drawing.Point(248, 382);
            this.lb_tentativas.Name = "lb_tentativas";
            this.lb_tentativas.Size = new System.Drawing.Size(110, 15);
            this.lb_tentativas.TabIndex = 7;
            this.lb_tentativas.Text = "Tentativas";
            // 
            // num_optionsLetras
            // 
            this.num_optionsLetras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_optionsLetras.Location = new System.Drawing.Point(251, 336);
            this.num_optionsLetras.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_optionsLetras.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_optionsLetras.Name = "num_optionsLetras";
            this.num_optionsLetras.Size = new System.Drawing.Size(110, 20);
            this.num_optionsLetras.TabIndex = 1;
            this.num_optionsLetras.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num_optionsTentativas
            // 
            this.num_optionsTentativas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_optionsTentativas.Location = new System.Drawing.Point(251, 400);
            this.num_optionsTentativas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_optionsTentativas.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_optionsTentativas.Name = "num_optionsTentativas";
            this.num_optionsTentativas.Size = new System.Drawing.Size(110, 20);
            this.num_optionsTentativas.TabIndex = 5;
            this.num_optionsTentativas.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // bt_optionsStart
            // 
            this.bt_optionsStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_optionsStart.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_optionsStart.Location = new System.Drawing.Point(157, 556);
            this.bt_optionsStart.Name = "bt_optionsStart";
            this.bt_optionsStart.Size = new System.Drawing.Size(299, 47);
            this.bt_optionsStart.TabIndex = 4;
            this.bt_optionsStart.Text = "JOGAR";
            this.bt_optionsStart.UseVisualStyleBackColor = false;
            this.bt_optionsStart.Click += new System.EventHandler(this.bt_optionsStart_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::Wordle_Tuga.Properties.Resources.wordleLogo;
            this.pictureBox4.Location = new System.Drawing.Point(14, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(585, 165);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // bt_optionsSair
            // 
            this.bt_optionsSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_optionsSair.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_optionsSair.Location = new System.Drawing.Point(157, 484);
            this.bt_optionsSair.Name = "bt_optionsSair";
            this.bt_optionsSair.Size = new System.Drawing.Size(299, 47);
            this.bt_optionsSair.TabIndex = 10;
            this.bt_optionsSair.Text = "VOLTAR";
            this.bt_optionsSair.UseVisualStyleBackColor = false;
            this.bt_optionsSair.Click += new System.EventHandler(this.bt_optionsSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descobre o palavra em algumas tentativas ou em contra relógio.";
            // 
            // group_tutorial
            // 
            this.group_tutorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.group_tutorial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_tutorial.Controls.Add(this.bt_tutorialSair);
            this.group_tutorial.Controls.Add(this.pictureBox6);
            this.group_tutorial.Controls.Add(this.pictureBox5);
            this.group_tutorial.Controls.Add(this.pictureBox2);
            this.group_tutorial.Controls.Add(this.label8);
            this.group_tutorial.Controls.Add(this.label7);
            this.group_tutorial.Controls.Add(this.label6);
            this.group_tutorial.Controls.Add(this.label5);
            this.group_tutorial.Controls.Add(this.label4);
            this.group_tutorial.Controls.Add(this.label3);
            this.group_tutorial.Location = new System.Drawing.Point(-2, -9);
            this.group_tutorial.Name = "group_tutorial";
            this.group_tutorial.Size = new System.Drawing.Size(612, 639);
            this.group_tutorial.TabIndex = 10;
            this.group_tutorial.TabStop = false;
            this.group_tutorial.Visible = false;
            // 
            // bt_tutorialSair
            // 
            this.bt_tutorialSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_tutorialSair.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_tutorialSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tutorialSair.Location = new System.Drawing.Point(524, 21);
            this.bt_tutorialSair.Name = "bt_tutorialSair";
            this.bt_tutorialSair.Size = new System.Drawing.Size(75, 47);
            this.bt_tutorialSair.TabIndex = 10;
            this.bt_tutorialSair.Text = "Sair";
            this.bt_tutorialSair.UseVisualStyleBackColor = false;
            this.bt_tutorialSair.Click += new System.EventHandler(this.bt_tutorialSair_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Wordle_Tuga.Properties.Resources.tutorialImage3;
            this.pictureBox6.Location = new System.Drawing.Point(33, 533);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(317, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Wordle_Tuga.Properties.Resources.tutorialImage2;
            this.pictureBox5.Location = new System.Drawing.Point(33, 410);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(317, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Wordle_Tuga.Properties.Resources.tutorialImage1;
            this.pictureBox2.Location = new System.Drawing.Point(33, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "A letra E não faz parte da palavra.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "A letra S está na palavra, mas na posição errada.";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "A letra T está na palavra e na posição correta.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 47);
            this.label5.TabIndex = 3;
            this.label5.Text = "Depois de cada tentativa, a cor dos quadrados irá mudar de acordo com os seguinte" +
    "s exemplos:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 47);
            this.label4.TabIndex = 2;
            this.label4.Text = "Escolhe o número de letras da palavra, e caso jogues com tentativas, o número das" +
    " mesmas.";
            // 
            // group_winner
            // 
            this.group_winner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_winner.Controls.Add(this.lb_winnerMessage_1);
            this.group_winner.Controls.Add(this.bt_winnerVoltar);
            this.group_winner.Controls.Add(this.lb_winnerMessage_2);
            this.group_winner.Controls.Add(this.pictureBox7);
            this.group_winner.Controls.Add(this.panel_winnerWord);
            this.group_winner.Location = new System.Drawing.Point(-2, -9);
            this.group_winner.Name = "group_winner";
            this.group_winner.Size = new System.Drawing.Size(612, 639);
            this.group_winner.TabIndex = 12;
            this.group_winner.TabStop = false;
            this.group_winner.Visible = false;
            // 
            // lb_winnerMessage_1
            // 
            this.lb_winnerMessage_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_winnerMessage_1.Location = new System.Drawing.Point(54, 201);
            this.lb_winnerMessage_1.Name = "lb_winnerMessage_1";
            this.lb_winnerMessage_1.Size = new System.Drawing.Size(500, 78);
            this.lb_winnerMessage_1.TabIndex = 7;
            this.lb_winnerMessage_1.Text = "Parabéns / Perdeste";
            this.lb_winnerMessage_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_winnerVoltar
            // 
            this.bt_winnerVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_winnerVoltar.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_winnerVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bt_winnerVoltar.Location = new System.Drawing.Point(157, 556);
            this.bt_winnerVoltar.Name = "bt_winnerVoltar";
            this.bt_winnerVoltar.Size = new System.Drawing.Size(299, 47);
            this.bt_winnerVoltar.TabIndex = 5;
            this.bt_winnerVoltar.Text = "Voltar";
            this.bt_winnerVoltar.UseVisualStyleBackColor = false;
            this.bt_winnerVoltar.Click += new System.EventHandler(this.bt_winnerVoltar_Click);
            // 
            // lb_winnerMessage_2
            // 
            this.lb_winnerMessage_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_winnerMessage_2.Location = new System.Drawing.Point(54, 287);
            this.lb_winnerMessage_2.Name = "lb_winnerMessage_2";
            this.lb_winnerMessage_2.Size = new System.Drawing.Size(500, 78);
            this.lb_winnerMessage_2.TabIndex = 2;
            this.lb_winnerMessage_2.Text = "Score do Jogo";
            this.lb_winnerMessage_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::Wordle_Tuga.Properties.Resources.wordleLogo;
            this.pictureBox7.Location = new System.Drawing.Point(14, 19);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(585, 165);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // panel_winnerWord
            // 
            this.panel_winnerWord.AutoScroll = true;
            this.panel_winnerWord.Location = new System.Drawing.Point(56, 410);
            this.panel_winnerWord.Name = "panel_winnerWord";
            this.panel_winnerWord.Size = new System.Drawing.Size(500, 80);
            this.panel_winnerWord.TabIndex = 8;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 621);
            this.Controls.Add(this.group_game);
            this.Controls.Add(this.group_home);
            this.Controls.Add(this.group_options);
            this.Controls.Add(this.group_tutorial);
            this.Controls.Add(this.group_winner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(625, 660);
            this.Name = "Game";
            this.Text = "Wordle";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.group_home.ResumeLayout(false);
            this.group_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_gameStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.group_statistics.ResumeLayout(false);
            this.group_options.ResumeLayout(false);
            this.group_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_optionsLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_optionsTentativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.group_tutorial.ResumeLayout(false);
            this.group_tutorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.group_winner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_home;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_homeTutorial;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Button bt_homeStart;
        private System.Windows.Forms.GroupBox group_game;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox group_options;
        private System.Windows.Forms.RadioButton radio_optionsTempo;
        private System.Windows.Forms.RadioButton radio_optionsTentativas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tentativas;
        private System.Windows.Forms.NumericUpDown num_optionsLetras;
        private System.Windows.Forms.NumericUpDown num_optionsTentativas;
        private System.Windows.Forms.Button bt_optionsStart;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_optionsSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox group_tutorial;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_tutorialSair;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Panel scroll_game;
        private System.Windows.Forms.GroupBox group_winner;
        private System.Windows.Forms.Label lb_winnerMessage_2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button bt_gameSair;
        private System.Windows.Forms.Button bt_winnerVoltar;
        private System.Windows.Forms.Label lb_gameStatus;
        private System.Windows.Forms.GroupBox group_statistics;
        private System.Windows.Forms.Label lb_statsNick;
        private System.Windows.Forms.Label lb_statsLostGames;
        private System.Windows.Forms.Label lb_statsTriesAmount;
        private System.Windows.Forms.Label lb_statsWonGames;
        private System.Windows.Forms.Label lb_statsPlayedGames;
        private System.Windows.Forms.Label lb_statsLostGamesPercent;
        private System.Windows.Forms.Label lb_statsWinGamesPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bt_gameStatistics;
        private System.Windows.Forms.Label lb_winnerMessage_1;
        private System.Windows.Forms.Panel panel_winnerWord;
    }
}

