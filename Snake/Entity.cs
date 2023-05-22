using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class Entity
    {
        List<Position> appleList;
        List<Position> wall;
        List<Position> boosts;
        List<Position> slows;
        Board mainBoard;

        public Entity(int size, int obstruction, Board mainBoard)
        {
            this.mainBoard = mainBoard;
            appleList = new List<Position>();
            wall = new List<Position>();
            boosts = new List<Position>();
            slows = new List<Position>();

            switch (obstruction) // The different types of "maps" created to be used in the game to make it harder
            {
                case 0: // empty map
                    {

                    }
                    break;
                case 1: // map 1
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            // starting col is 0 and rol is 0

                            wall.Add(new Position(1 + i , 2)); 
                            wall.Add(new Position(6 + i , 2));

                            wall.Add(new Position(1 + i, 6));
                            wall.Add(new Position(6 + i, 6));

                            wall.Add(new Position(1 + i, 10));
                            wall.Add(new Position(6 + i, 10));

                            wall.Add(new Position(1 + i, 14));
                            wall.Add(new Position(6 + i, 14));

                            wall.Add(new Position(1 + i, 18));
                            wall.Add(new Position(6 + i, 18));

                        }

                        slows.Add(new Position(7,4));
                        slows.Add(new Position(7, 16));
                        boosts.Add(new Position(5, 10));
                        
                        break;
                    }

                case 2: // map 2
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            wall.Add(new Position(3 + i, 9));

                            wall.Add(new Position(2, 2 + i));
                            wall.Add(new Position(7, 2 + i));

                            wall.Add(new Position(2, 14 + i));
                            wall.Add(new Position(7, 14 + i));

                        }

                        boosts.Add(new Position(2, 9));
                        boosts.Add(new Position(1, 9));
                        boosts.Add(new Position(0, 9));
                        slows.Add(new Position(7, 9));
                        slows.Add(new Position(8, 9));
                        slows.Add(new Position(9, 9));

                        break;
                    }

                case 3: // map 3
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            wall.Add(new Position(0 + i, 10));
                            wall.Add(new Position(6 + i, 9));

                            wall.Add(new Position(1 + i, 1 + i));
                            wall.Add(new Position(8 - i, 1 + i));

                            wall.Add(new Position(1 + i, 19 - i));
                            wall.Add(new Position(8 - i, 19 - i));


                        }

                        boosts.Add(new Position(4, 3));
                        slows.Add(new Position(5, 3));

                        boosts.Add(new Position(4, 17));
                        slows.Add(new Position(5, 17));
                        break;
                    }
            }
            
            for (int i = 0; i < size; i++)
            {
                int rowNo, colNo;

                //Generate an apple at random position but not duplicated
                do
                {
                    //Generate a random number between 1 and MaxRowNo
                    rowNo = (new Random()).Next(1, mainBoard.getMaxRowNo() + 1);

                    //Generate a random number between 1 and MaxColNo
                    colNo = (new Random()).Next(1, mainBoard.getMaxColNo() + 1);

                } while (isDuplicate(rowNo, colNo) == true);

                appleList.Add(new Position(rowNo, colNo));
                //appleList.
            }
        }
        public Boolean isDuplicate(int row, int col)
        {
            Boolean result = false;

            for (int i=0;i< appleList.Count;i++)
            {
                if (appleList[i].getRowNo() == row && appleList[i].getColNo() == col)
                    result = true;
            }

            for (int i = 0; i < wall.Count; i++)
            {
                if (wall[i].getRowNo() == row && wall[i].getColNo() == col)
                    result = true;
            }

            return result;
        }
        
        public void draw()
        {
            for (int i = 0; i < appleList.Count; i++)
            {
                mainBoard.draw(appleList[i], Properties.Resources.banana);
            }
            for (int i = 0; i < wall.Count; i++)
            {
                mainBoard.draw(wall[i], Properties.Resources.purpleminion);
            }
            for (int i = 0; i < boosts.Count; i++)
            {
                mainBoard.draw(boosts[i], Properties.Resources.Boost);
            }
            for (int i = 0; i < slows.Count; i++)
            {
                mainBoard.draw(slows[i], Properties.Resources.NBoost);
            }
        }

        public Boolean checkIFSnakeHeadEatApple(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < appleList.Count; i++)
            {
                if (snakeHead.getRowNo() == appleList[i].getRowNo() && snakeHead.getColNo() == appleList[i].getColNo())
                    result = true;
            }
            return result;
        }

        public int eatAppleAtPostion(Position p)
        {
            
            //applelist[i].getRowNo() applelist[i].getColNo()
            // Add in your code here to remove the apple at Position p from appleList
            for (int i = 0; i < appleList.Count; i++)
            {
                if (p.getRowNo() == appleList[i].getRowNo() && p.getColNo() == appleList[i].getColNo())
                {
                    appleList.RemoveAt(i);
                }
                   
            }

            return 50;  //50 points per apple
        }

        public int eatBoostAtPostion(Position p)
        {

            //applelist[i].getRowNo() applelist[i].getColNo()
            // Add in your code here to remove the apple at Position p from appleList
            for (int i = 0; i < boosts.Count; i++)
            {
                if (p.getRowNo() == boosts[i].getRowNo() && p.getColNo() == boosts[i].getColNo())
                {
                    boosts.RemoveAt(i);
                }

            }
            return -50;  //50 points per apple
        }

        public int eatSlowtAtPostion(Position p)
        {

            //applelist[i].getRowNo() applelist[i].getColNo()
            // Add in your code here to remove the apple at Position p from appleList
            for (int i = 0; i < slows.Count; i++)
            {
                if (p.getRowNo() == slows[i].getRowNo() && p.getColNo() == slows[i].getColNo())
                {
                    slows.RemoveAt(i);
                }

            }



            return 50;  //50 points per apple
        }

        public Boolean CheckIFSnakeHeadHitWall(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < wall.Count; i++)
            {
                if (snakeHead.getRowNo() == wall[i].getRowNo() && snakeHead.getColNo() == wall[i].getColNo())
                    result = true;
            }
            return result;
        }

        public Boolean CheckIFSnakeHeadEatBoost(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < boosts.Count; i++)
            {
                if (snakeHead.getRowNo() == boosts[i].getRowNo() && snakeHead.getColNo() == boosts[i].getColNo())
                    result = true;
            }
            return result;
        }

        public Boolean CheckIFSnakeHeadEatSlows(Position snakeHead)
        {
            Boolean result = false;

            for (int i = 0; i < slows.Count; i++)
            {
                if (snakeHead.getRowNo() == slows[i].getRowNo() && snakeHead.getColNo() == slows[i].getColNo())
                    result = true;
            }
            return result;
        }
        public Boolean noMoreApples()
        {
            if (appleList.Count > 0)
                return false;
            else
                return true;
        }
    }
}
