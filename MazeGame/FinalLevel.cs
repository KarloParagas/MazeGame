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
            Scream();
        }

        private void FinalLevel_Load(object sender, EventArgs e)
        {
            Scream();
        }

        private static void Scream()
        {
            SoundPlayer scream = new SoundPlayer("C:\\Users\\karlo\\Desktop\\ProjectsForFun\\MazeGame\\MazeGame\\Scream.wav");
            scream.Play();
        }
    }
}
