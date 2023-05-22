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

namespace Snake
{
    public partial class Introduction : Form
    {
        SoundPlayer intromusic, levelupeffect;
        public Introduction()
        {   
            InitializeComponent();
            intromusic = new SoundPlayer(Properties.Resources.minions_banana_song);
            intromusic.Play();
            
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            levelupeffect = new SoundPlayer(Properties.Resources.levelupeffect);
            levelupeffect.Play();

            DateTime now = DateTime.Now;
            while (DateTime.Now.Subtract(now).Seconds < 1)
            {
                // wait for 1 second to display full sound
            }



            TheGame TheGame = new TheGame();            
            TheGame.ShowDialog();
            this.Close();
        }
    }
}
