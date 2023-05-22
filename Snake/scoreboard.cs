using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Snake
{
    public partial class scoreboard : Form
    {
        SoundPlayer startsound;
        scoreset Scoreset = new scoreset();
        //always change when the scoreboard loads after a gameover
        private int points;

        public scoreboard(int points)
        {
            
            InitializeComponent();
            //this.Scoreset = scoreset;
            this.points = points;
            
            

            theDGV.ColumnCount = 2;
            theDGV.Columns[0].HeaderText = "Name";
            theDGV.Columns[1].HeaderText = "Points";


            theDGV.AllowUserToAddRows = false;
            theDGV.AllowUserToDeleteRows = false;
            theDGV.MultiSelect = false;
            theDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            theDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            load();

        }

        private void refreshDGV()
        {
            theDGV.Rows.Clear(); // Clear the DGV first before redisplay
            for (int i = 0; i < 5 /*Scoreset.getSize()*/; i++)
            {
                theDGV.Rows.Add();
                theDGV.Rows[i].Cells[0].Value = Scoreset.GetScores(i).getname();
                theDGV.Rows[i].Cells[1].Value = Scoreset.GetScores(i).getpts();

            }
        }

       

        //Add in scores button
        private void savescore_Click(object sender, EventArgs e)
        {
            startsound = new SoundPlayer(Properties.Resources.Minion_Hehehe_Sound_Effect);
            startsound.Play();
            // ADD STRAIGHT TO THE DGV
            // TO ANOTHER POP UP! 
            addscoreform addscore = new addscoreform(points);
            addscore.ShowDialog();

            if (addscore.DialogResult == DialogResult.OK)  
                                                   
            {


                /*1*/
                if (points > Scoreset.GetScores(0).getpts())
                {
                    Scoreset.insertscore(0, addscore.scores);
                }

                /*2*/
                else if (points > Scoreset.GetScores(1).getpts())
                {
                    Scoreset.insertscore(1, addscore.scores);  
                }

                /*3*/
                else if (points > Scoreset.GetScores(2).getpts())
                {
                    Scoreset.insertscore(2, addscore.scores);
                }

                /*4*/
                else if (points > Scoreset.GetScores(3).getpts())
                {
                    Scoreset.insertscore(3, addscore.scores);
                }

                /*5*/
                else if (points > Scoreset.GetScores(4).getpts())
                {
                    Scoreset.insertscore(4, addscore.scores);
                }


                // REFRESH THE DGV                               
                refreshDGV();   
            }
            // WHERE YOU CAN FILL IN YOUR NAME AND YOUR POINTS IS ALREADY SET.

            // THEN SAVE THE WHOLE DGV TO NOTEPAD

            StreamWriter streamWriter = new System.IO.StreamWriter(@"C:\temp\scores.txt");
            System.IO.StreamWriter file = streamWriter;
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= theDGV.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= theDGV.Columns.Count - 1; c++)
                    {
                        sLine = sLine + theDGV.Rows[r].Cells[c].Value;
                        if (c != theDGV.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + ",";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }


                file.Close();

            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
            MessageBox.Show("Your score has been added", "Saved Score", MessageBoxButtons.OK);


            // DOES NOT AFFECT PREVIOUS SAVE.
            // IT JUST ADDS ON TO THE PREVIOUS SAVED SCORED
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load()
        {
            {
                //USE STREAM READER TO READ THE FILE,
                //AFTERWARDS ADD TO DGV BY REFRESH DGV METHOD

                try
                {
                    StreamReader streamReader = new System.IO.StreamReader(@"C:\temp\scores.txt");



                    String oneline;
                    oneline = streamReader.ReadLine();

                    while (oneline != null)   //As line as oneLine is not empty
                    {
                        string[] Scorelist;
                        Scorelist = oneline.Split(',');

                        scores p = new scores(Scorelist[0] , Convert.ToInt32(Scorelist[1]));
                        Scoreset.addscore(p);

                        oneline = streamReader.ReadLine(); //Read in the next line and repeat
                    }



                    streamReader.Close();
                    refreshDGV();
                }

                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("There is no text file", "Error");
                }

                catch (System.IO.DirectoryNotFoundException)
                {
                    MessageBox.Show("There is no tmp directory", "Error");
                }
            }
        }

        private void theDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
