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
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();

            //Player starting point
            player.Location = new Point(40, 45);

            this.KeyDown += new KeyEventHandler(Level1_KeyInput);
        }

        public void Level1_KeyInput(object sender, KeyEventArgs e)
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

            //If the player touches any of the walls
            //if (collide() == true)
            //{
            //    BackToStart();
            //}

            //If the player reaches the finish line
            if (player.Bounds.IntersectsWith(finish.Bounds)) 
            {
                MessageBox.Show("I am holy, lucky, simple. Fibonacci, odd, and prime. In this riddle, you'll find me, " +
                                "precisely nineteen times.");

                //Activates the next level
                var level2 = new Level2();
                level2.Show();
            }
        }

        private bool collide()
        {
            Label[] walls = { topBorder, rightBorder, bottomBorder, leftBorder,
                              label1, label2, label3, label4, label5, label6, label7, label8,
                              label9, label10, label11, label12, label13, label14, label15, 
                              label16, label17, label18, label19, label20, label21, label22,
                              label23, label24, label25, label26, label27, label28, label29,
                              label30, label31, label32, label33, label34, label35, label36,
                              label37 };

            for (int i = 0; i < walls.Length; i++) 
            {
                if (player.Bounds.IntersectsWith(walls[i].Bounds)) 
                {                      
                    return true;
                }           
            }
            return false;
        }

        private void BackToStart()
        {
            MessageBox.Show("Whoops! I'm going to have to take you back to the beginning");

            //Move the player back at the starting point
            player.Location = new Point(40, 45);
        }
    }
}
