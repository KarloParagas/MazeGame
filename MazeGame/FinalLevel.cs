using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class FinalLevel : Form
    {
        private int ticks = 5;

        public FinalLevel()
        {
            InitializeComponent();

            timer1.Start();

            label1.Text = "The more of this there is, the less you see. What is it?";
        }

        private void FinalLevelBtn_Click(object sender, EventArgs e)
        {
            PlaySound();
            DisplayImage();
        }

        private void DisplayImage()
        {
            Controls.Remove(label1);
            Controls.Remove(finalLevelBtn);

            this.BackgroundImage = Properties.Resources.SuccessImage;
        }

        private static void PlaySound()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.MajesticSound);
            sound.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;

            if (ticks == 0) 
            {
                finalLevelBtn.PerformClick();
            }

            if (ticks == -3) 
            {
                MessageBox.Show("Thank you for playing :)");
                Close();
            }
        }
    }
}
