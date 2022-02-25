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
            this.group_tutorial = new System.Windows.Forms.GroupBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_tutorial = new System.Windows.Forms.Button();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.group_home = new System.Windows.Forms.GroupBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.group_tutorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_tutorial
            // 
            this.group_tutorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_tutorial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_tutorial.Controls.Add(this.bt_sair);
            this.group_tutorial.Location = new System.Drawing.Point(-2, -9);
            this.group_tutorial.Name = "group_tutorial";
            this.group_tutorial.Size = new System.Drawing.Size(612, 639);
            this.group_tutorial.TabIndex = 7;
            this.group_tutorial.TabStop = false;
            this.group_tutorial.Visible = false;
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(262, 534);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 0;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Wordle_Tuga.Properties.Resources.Wordle;
            this.pictureBox1.Location = new System.Drawing.Point(14, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_start
            // 
            this.bt_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_start.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_start.Location = new System.Drawing.Point(157, 499);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(299, 47);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "JOGAR";
            this.bt_start.UseVisualStyleBackColor = false;
            // 
            // bt_tutorial
            // 
            this.bt_tutorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_tutorial.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_tutorial.Location = new System.Drawing.Point(157, 405);
            this.bt_tutorial.Name = "bt_tutorial";
            this.bt_tutorial.Size = new System.Drawing.Size(299, 47);
            this.bt_tutorial.TabIndex = 1;
            this.bt_tutorial.Text = "TUTORIAL";
            this.bt_tutorial.UseVisualStyleBackColor = false;
            this.bt_tutorial.Click += new System.EventHandler(this.bt_tutorial_Click);
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
            this.txt_nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // group_home
            // 
            this.group_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_home.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_home.Controls.Add(this.lbl_1);
            this.group_home.Controls.Add(this.pictureBox1);
            this.group_home.Controls.Add(this.bt_start);
            this.group_home.Controls.Add(this.bt_tutorial);
            this.group_home.Controls.Add(this.txt_nickname);
            this.group_home.Location = new System.Drawing.Point(-2, -9);
            this.group_home.Name = "group_home";
            this.group_home.Size = new System.Drawing.Size(612, 639);
            this.group_home.TabIndex = 6;
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
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 621);
            this.Controls.Add(this.group_home);
            this.Controls.Add(this.group_tutorial);
            this.MinimumSize = new System.Drawing.Size(625, 660);
            this.Name = "Game";
            this.Text = "Wordle";
            this.group_tutorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_home.ResumeLayout(false);
            this.group_home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_tutorial;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_tutorial;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.GroupBox group_home;
        private System.Windows.Forms.Label lbl_1;
    }
}

