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
    public partial class Level2 : Form
    {
        private int ticks = 90;
        private bool pathOpen = false;

        public Level2()
        {
            InitializeComponent();

            //Start the timer
            timer1.Start();

            player.Location = new Point(55, 561);

            this.KeyDown += new KeyEventHandler(Level2_KeyInput);
        }

        public void Level2_KeyInput(object sender, KeyEventArgs e)
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
            if (collide() == true)
            {
                BackToStart();
            }

            //If the player triggers any of the incorrect numbers
            if (wrongNumber() == true) 
            {
                MessageBox.Show("Wrong number");
            }

            //If the player triggers the correct number
            if (player.Bounds.IntersectsWith(num3.Bounds))
            {
                pathOpen = true;

                timer1.Stop();

                //Removes the door to the finish line
                Controls.Remove(label32);
                
                MessageBox.Show("A door opens...");
            }

            //If the player reaches the finish line
            if (player.Bounds.IntersectsWith(finish.Bounds))
            {
                //Activates the final level
                var finalLevel = new FinalLevel();
                finalLevel.Show();
            }
        }

        private bool wrongNumber()
        {
            Label[] wrongNums = { num1, num2, num4, num5, num6, num7, num8, num9, num10,
                                  num11, num12, num13, num14, num15};

            for (int i = 0; i < wrongNums.Length; i++) 
            {
                if (player.Bounds.IntersectsWith(wrongNums[i].Bounds)) 
                {
                    return true;
                }
            }
            return false;
        }

        private bool collide()
        {
            List<Label> walls = new List<Label>
            { 
              topBorder, rightBorder, bottomBorder, leftBorder,
              label1, label3, label4, label5, label6, label7, label8,
              label9, label10, label11, label12, label13, label14, label15,
              label16, label17, label18, label19, label20, label21, label22,
              label23, label24, label25, label26, label27, label28, label29,
              label30, label31, label32, label33, label34, label35, label36,
              label37 
            };

            if (pathOpen == true) 
            {
                walls.Remove(label32);
            }

            for (int i = 0; i < walls.Count; i++)
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
            MessageBox.Show("Unworthy! Back to the start!");

            //Move the player back at the starting point
            player.Location = new Point(55, 561);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;
            coutdownLbl.Text = ticks.ToString();

            if (ticks == 0) 
            {
                timer1.Stop();

                MessageBox.Show("Out of time!");

                //Move the player back at the starting point
                player.Location = new Point(55, 561);

                ticks = 90;

                Close();
            }
        }
    }
}
