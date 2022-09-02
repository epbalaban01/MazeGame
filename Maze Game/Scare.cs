using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Scare : Form
    {
        public Scare()
        {
            InitializeComponent();
            LoadWindow();
        }

        private void CloseWindowsEvent(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadWindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
