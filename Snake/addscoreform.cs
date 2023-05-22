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
    
    public partial class addscoreform : Form
    {
        public scores scores;
        private int points;
        public addscoreform(int points)
        {
            InitializeComponent();
            this.points = points;
        }

       

        private void addscoreBTN_Click(object sender, EventArgs e)
        {
            SoundPlayer addscore;
            addscore = new SoundPlayer(Properties.Resources.Minions_March);
            addscore.Play();

            DialogResult = DialogResult.OK;
            scores = new scores(nameTB.Text, points);
            this.Close();
            

            
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
