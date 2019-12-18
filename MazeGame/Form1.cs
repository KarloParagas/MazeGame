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

            //Player starting point
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

            //If the player touches the borders
            if (topBorder.Bounds.IntersectsWith(player.Bounds) || bottomBorder.Bounds.IntersectsWith(player.Bounds)
             || leftBorder.Bounds.IntersectsWith(player.Bounds) || rightBorder.Bounds.IntersectsWith(player.Bounds))
            {
                GameOver();
            }

            //If the player reaches the finish line
            if (player.Bounds.IntersectsWith(finish.Bounds)) 
            {
                MessageBox.Show("Winner!");

                //Move the player back at the starting point
                player.Location = new Point(40, 45);

            }
        }

        private void GameOver()
        {
            MessageBox.Show("Whoops! I'm going to have to take you back to the beginning");

            //Move the player back at the starting point
            player.Location = new Point(40, 45);
        }
    }
}
