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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group_tutorial = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_tutorialSair = new System.Windows.Forms.Button();
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
            this.group_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.group_tutorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.group_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_optionsLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_optionsTentativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.txt_nickname.Text = "Delete me";
            this.txt_nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_homeStart
            // 
            this.bt_homeStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_homeStart.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_homeStart.Location = new System.Drawing.Point(157, 499);
            this.bt_homeStart.Name = "bt_homeStart";
            this.bt_homeStart.Size = new System.Drawing.Size(299, 47);
            this.bt_homeStart.TabIndex = 3;
            this.bt_homeStart.Text = "JOGAR";
            this.bt_homeStart.UseVisualStyleBackColor = false;
            this.bt_homeStart.Click += new System.EventHandler(this.bt_homeStart_Click);
            // 
            // group_game
            // 
            this.group_game.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.group_game.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_game.Controls.Add(this.pictureBox3);
            this.group_game.Controls.Add(this.label1);
            this.group_game.Location = new System.Drawing.Point(-2, -9);
            this.group_game.Name = "group_game";
            this.group_game.Size = new System.Drawing.Size(612, 639);
            this.group_game.TabIndex = 9;
            this.group_game.TabStop = false;
            this.group_game.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Wordle_Tuga.Properties.Resources.wordleLogo;
            this.pictureBox3.Location = new System.Drawing.Point(14, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(585, 165);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // group_tutorial
            // 
            this.group_tutorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.group_tutorial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_tutorial.Controls.Add(this.pictureBox2);
            this.group_tutorial.Controls.Add(this.bt_tutorialSair);
            this.group_tutorial.Location = new System.Drawing.Point(-2, -9);
            this.group_tutorial.Name = "group_tutorial";
            this.group_tutorial.Size = new System.Drawing.Size(612, 639);
            this.group_tutorial.TabIndex = 10;
            this.group_tutorial.TabStop = false;
            this.group_tutorial.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::Wordle_Tuga.Properties.Resources.tutorialImage;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(14, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 568);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bt_tutorialSair
            // 
            this.bt_tutorialSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_tutorialSair.Location = new System.Drawing.Point(524, 21);
            this.bt_tutorialSair.Name = "bt_tutorialSair";
            this.bt_tutorialSair.Size = new System.Drawing.Size(75, 23);
            this.bt_tutorialSair.TabIndex = 0;
            this.bt_tutorialSair.Text = "Sair";
            this.bt_tutorialSair.UseVisualStyleBackColor = true;
            this.bt_tutorialSair.Click += new System.EventHandler(this.bt_tutorialSair_Click);
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
            6,
            0,
            0,
            0});
            this.num_optionsLetras.Minimum = new decimal(new int[] {
            3,
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
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 621);
            this.Controls.Add(this.group_game);
            this.Controls.Add(this.group_home);
            this.Controls.Add(this.group_options);
            this.Controls.Add(this.group_tutorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(625, 660);
            this.Name = "Game";
            this.Text = "Wordle";
            this.group_home.ResumeLayout(false);
            this.group_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_game.ResumeLayout(false);
            this.group_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.group_tutorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.group_options.ResumeLayout(false);
            this.group_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_optionsLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_optionsTentativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_tutorial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_tutorialSair;
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
    }
}

