using System;
using System.Media;
using System.Windows.Forms;


namespace Snake
{
    public partial class TheGame : Form
    {

        Snake mySnake;
        Board mainBoard;
        Entity entities;
        
        
        SoundPlayer themesong,finisheffect; // -FORM1, -FORM2,-playbutton,-FINISH BTN ,-SAVE YOUR SCORE BTN

        /*
         Creative features, diagonal movement, wrap ard board, W A S D Q E Z C movement, List top 5
         Difficulty features, borders tht kills, speeds up snake,
        */




        string mode;
        Timer clock;
        int duration; //How long the game has been running
        private int speed = 500; //250ms DEV MODE
        private int score;
        private int espeed;
        int level;




        // A SNAKE GAME THAT DOESNT RESET THE SNAKE BUT RETAIN ITS LENGTH.
        // JAM THE SNAKE AT THE BORDER WHEN USING DIAGNOLS
        // HAVE A REWEARD THAT CAN SLOW DOWN THE TIME WHEN ALL ORBS IS EATEN
        // HAVE A "REWARD THAT CAN SPEED UP THE TIME
        // TIME HERE REFERS TO THE REFRESH RATE


        public TheGame()
        {
            //OCCURS ONLY ONCE SO DO NOT CHANGE ANYTHING IN HERE FOR ANY LEVELUPS
            InitializeComponent();
            //You don't have to worry about the auto-size
            this.AutoSize = true;       //The size of the Form will autoadjust.
            boardPanel.AutoSize = true; //The size of the panel grouping all the squares will auto-adjust

            //Set up the main board

            //Set up the game timer at the given speed
            clock = new Timer();
            clock.Interval = speed; //Set the clock to tick every 500ms
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.

            mainBoard = new Board(this, 10, 20);

            duration = 0;
            score = 0;
            level = 1; // DEV MODE


            themesong = new SoundPlayer(Properties.Resources.Minions_March);
            themesong.Play();

            //themesong.LoadAsync();

            entities = new Entity(3,0, mainBoard);   //<--- Generate n * 3 apples
            
            modeLBL.Text = mode;
            

            //gotoNextLevel(level, espeed); //APPLE WILL ALWAYS BE 3 TIMES MORE
            
            mySnake = new Snake(mainBoard);

        }

        private void gotoNextLevel(int nextLevel, int espeed)
        {

            //mainBoard = null;
            //mySnake = null;

            //mainBoard = new Board(this, 20, 20);
            mySnake = new Snake(mainBoard);



            mode = "REST";
            this.speed = this.speed + espeed;
            
            //every 2 levels the speed up by 50
            if (nextLevel %2 == 0) 
            {
                this.speed = this.speed - 100;
            }
            
            try
            {
                clock.Interval = this.speed;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Gru went too fast and his minions can't catch up!", "Too fast");
                GameOver();
            }
            
            //System.ArgumentOutOfRangeException
            speedLBL.Text = Convert.ToString(this.speed); //show speed

            int random = (new Random()).Next(1, 4);
            entities = new Entity(nextLevel * 3, random , mainBoard);   //<--- Generate n * 3 apples

        }



        private void upleftBTN_Click(object sender, EventArgs e)
        {
            mode = "UP-LEFT";
        }

        private void uprightBTN_Click(object sender, EventArgs e)
        {
            mode = "UP-RIGHT";
        }

        private void downleftBTN_Click(object sender, EventArgs e)
        {
            mode = "D-LEFT";
        }

        private void downrightBTN_Click(object sender, EventArgs e)
        {
            mode = "D-RIGHT";
        }

        private void upBTN_Click(object sender, EventArgs e)
        {
            mode = "UP";  //Just record the mode. The moving will be done in refresh method
        }

        private void downBTN_Click(object sender, EventArgs e)
        {
            mode = "DOWN";
        }

        private void leftBTN_Click(object sender, EventArgs e)
        {
            mode = "LEFT";
        }

        private void rightBTN_Click(object sender, EventArgs e)
        {
            mode = "RIGHT";
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {

            mySnake.move(mode); //Move the snake based on mode
            modeLBL.Text = mode;

            mainBoard.draw();
            mySnake.draw();

            entities.draw();  //<----- draw apples            
            

            //increment the duration by amount of time that has passed
            //this method is called every speed mi0llisecond
            duration += speed;
            timerLBL.Text = Convert.ToString(duration / 1000); //Show time passed


            //Check if snke is biting itself. If so, call GameOver.
            if (mySnake.checkEatItself() == true)
            {
                GameOver();
            }

            // EAT BOOST
            else if (entities.CheckIFSnakeHeadEatBoost(mySnake.getHeadPosition()) == true)
            {
                //score = score + eatappleposition
                //eatBoost.Play();
                espeed = espeed + entities.eatBoostAtPostion(mySnake.getHeadPosition());
            }

            //EAT NBOOST
            else if (entities.CheckIFSnakeHeadEatSlows(mySnake.getHeadPosition()) == true)
            {
                //score = score + eatappleposition
                //eatBoost.Play();
                espeed = espeed + entities.eatSlowtAtPostion(mySnake.getHeadPosition());
            }

            else if (entities.CheckIFSnakeHeadHitWall(mySnake.getHeadPosition()) == true)
            {
                
                GameOver();
            }


            // EAT BANANA
            else if (entities.checkIFSnakeHeadEatApple(mySnake.getHeadPosition()) == true)
            {
                //eatBanana.Play();

                score += entities.eatAppleAtPostion(mySnake.getHeadPosition());

                label4.Text = Convert.ToString(score);




                if (entities.noMoreApples() == true)
                {
                    clock.Stop();
                    level++;
                    levelLBL.Text = Convert.ToString(level);
                    gotoNextLevel(level, espeed);
                    MessageBox.Show("Press the start button to go to Level " + level, "Congrats");
                }
                else
                {
                    //Length the snake and continue with the Game
                    mySnake.extendBody();
                }
            }

        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            clock.Start();

        }

        private void pauseBTN_Click(object sender, EventArgs e)
        {
            clock.Stop();
        }

        private void GameOver()
        {
            clock.Stop();
            //MessageBox.Show("Your time taken is " + duration/1000 + " seconds. Bye Bye", "Game Over");

            MessageBox.Show(" got " + score + " points.");


            //SHOW LEADERBOARD
            scoreboard scoreboard = new scoreboard(score);
            scoreboard.ShowDialog();

            //AND LOAD SCORE
            // ADD SCORE?? 
            //THEN SAVE

            this.Close();


        }

        private void finishBTN_Click(object sender, EventArgs e)
        {
            finisheffect = new SoundPlayer(Properties.Resources.Minion_What_Sound_Effect);
            finisheffect.Play();
            MessageBox.Show("Thanks for playing", "Finish");
            this.Close();

            scoreboard scoreboard = new scoreboard(score);
            scoreboard.ShowDialog();

        }


















































































        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.W)
            {
                mode = "UP";
                return true;
            }

            if (keyData == Keys.S)
            {
                mode = "DOWN";
                return true;
            }

            if (keyData == Keys.A)
            {
                mode = "LEFT";
                return true;
            }

            if (keyData == Keys.D)
            {
                mode = "RIGHT";
                return true;
            }

            if (keyData == Keys.E)
            {
                mode = "UP-RIGHT";
                return true;
            }

            if (keyData == Keys.Q)
            {
                mode = "UP-LEFT";
                return true;
            }

            if (keyData == Keys.C)
            {
                mode = "D-RIGHT";
                return true;
            }

            if (keyData == Keys.Z)
            {
                mode = "D-LEFT";
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
