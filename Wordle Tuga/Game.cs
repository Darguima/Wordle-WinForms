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
    }
}
