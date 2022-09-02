using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Maze_Game
{
    public partial class Form1 : Form
    {

        SoundPlayer player = new SoundPlayer();
        SoundPlayer scare = new SoundPlayer();


        public Form1()
        {
            InitializeComponent();
        }

        private void ScarePlayer(object sender, EventArgs e)
        {

        }

        private void ShowScreamWindow(object sender, EventArgs e)
        {
            Scare scaryWindow = new Scare();
            scaryWindow.Show();
            player.Stop();
            scare.Play();
        }

        private void StartButtonEvent(object sender, EventArgs e)
        {
            StartGame();
        }

        private void FormMouseEvent(object sender, EventArgs e)
        {
            EndGame();
        }

        private void StartGame()
        {
            StartButton.Enabled = false;
            player.Stream = Properties.Resources.bg_music;
            scare.Stream = Properties.Resources.scare;
            player.PlayLooping();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Enabled = true;
                    x.MouseDown += X_MouseDown;

                    if(x.Tag == null)
                    {
                        x.BackColor = Color.LightBlue;
                    }
                }
               
            }
        }

        private void X_MouseDown(object sender, MouseEventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {
            foreach (Control x in this.Controls)
            {
                StartButton.Enabled = true;
                if (x is PictureBox)
                {
                    x.Enabled = false;
                    

                    if (x.Tag == null)
                    {
                        x.BackColor = Color.Black;
                    }
                }

            }
        }
    }
}
