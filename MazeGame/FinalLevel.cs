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
        public FinalLevel()
        {
            InitializeComponent();
        }

        private void FinalLevelBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();

            player.SoundLocation = @"";

            player.Play();
        }
    }
}
