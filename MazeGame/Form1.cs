using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            player.Text = "J";

            //Starting point of the arrow
            player.Location = new Point(40, 45);

            this.KeyDown += new KeyEventHandler(MainForm_KeyInput);
        }

        public void MainForm_KeyInput(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                player.Location = new Point(player.Location.X - 5, player.Location.Y);
            }

            if (e.KeyData == Keys.Right)
            {
                player.Location = new Point(player.Location.X + 5, player.Location.Y);
            }

            if (e.KeyData == Keys.Up)
            {
                player.Location = new Point(player.Location.X, player.Location.Y - 5);
            }

            if (e.KeyData == Keys.Down)
            {
                player.Location = new Point(player.Location.X, player.Location.Y + 5);
            }

            //If the arrow touches the borders
            if (topBorder.Bounds.IntersectsWith(player.Bounds) || bottomBorder.Bounds.IntersectsWith(player.Bounds)
             || leftBorder.Bounds.IntersectsWith(player.Bounds) || rightBorder.Bounds.IntersectsWith(player.Bounds))
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            MessageBox.Show("Whoops! I'm going to have to take you back to the beginning");

            //Move the arrow back at the starting point
            player.Location = new Point(40, 45);
        }
    }
}
