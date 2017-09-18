using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace play_game
{
    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            SoundPlayer player = new SoundPlayer(Properties.Resources.ding);
            player.Play();

            playgamebutton.Visible = false;
            go.Visible = false;
            startingGame2lable.Visible = false;
            startingGame3lable.Visible = true;
            this.Refresh();
            Thread.Sleep(1000);

            startingGame3lable.Visible = false;
            startingGame2lable.Visible = true;
            this.Refresh();
            Thread.Sleep(1000);

            startingGame2lable.Visible = false;
            startingGame1lable.Visible = true;
            this.Refresh();
            Thread.Sleep(1000);
            startingGame1lable.Visible = false;

            this.BackColor = Color.Green;
            go.Visible = true;

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.Toddler_Laugh);
            player2.Play();
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
