using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class FinalLevel : Form
    {
        private int ticks = 10;

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

            pictureBox1.ImageLocation = @"";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private static void PlaySound()
        {
            SoundPlayer sound = new SoundPlayer();

            //Final level soundtrack composed by David RJ
            sound.SoundLocation = @"";

            sound.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;

            if (ticks == 0) 
            {
                timer1.Stop();

                PlaySound();

                DisplayImage();
            }
        }
    }
}
