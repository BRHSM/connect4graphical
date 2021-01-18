using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGrapical
{
    public class GameBoard
    {
        //String used to store the name of the first player.
        private string player1Name;

        //String used to store the name of the second player.
        private string player2Name;

        //integer used to store the number of rows the board contains.
        private byte rows;

        //integer us to store the number of columns the board contains.
        private byte columns;

        //integer used to store the amount of moves made on the board.
        private int moves;

        //byte used to store player win. 0 for no winner, 1 for player 
        //1 and 2 for player 2
        private byte win;

        //byte array used to store states of the board. 0 for empty, 
        //1 for player 1 and 2 for player 2
        private byte[,] states;

        //Constructor for the GameBoard class.
        public GameBoard(string player1Name, string player2Name, byte rows, byte columns)
        {
            //Assign the passed variables. 
            this.Player1Name = player1Name;
            this.Player2Name = player2Name;
            this.Rows = rows;
            this.Columns = columns;
            
            //Create the array object.
            this.States = new byte[Rows,Columns];

            //assume no moves have been made
            this.Moves = 0;

            //assume there is no winner
            this.Win = 0;

            //initialize the board (all states are 0).
            this.initializeBoard();
        }

        //set all states of the board to 0
        private void initializeBoard()
        {
            //loop through all states of the 2 dimensional matrix.
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                {
                    //assign 0 to the state.
                    States[i, j] = 0;
                }
        }

        //set a state of the board to a certain player.
        public bool Move(int x)
        {
            //assume there has been no spot for a dish found yet.
            bool found = false;
            //enumerate bottom up through each row until a spot has been found.
            for (int i = Rows - 1; i >= 0 && !found; i--)
            {
                //check if for the column x there is a free spot for a dich
                if (States[i,x] == 0) {
                    //A spot has been found.
                    found = true;
                    //assign the state for the player to the spot. 
                    States[i, x] = (byte)(((Moves++) % 2) + 1);
                    //check if this move is a winning move.
                    this.checkWin(x, i);
                }
            }
            //return found(I.E. a valid move has been made or not). 
            return found;
        }

        //function used to check if a moe made to the board is a winning move.
        private void checkWin(int x, int y)
        {
            //Obtain the state of the latest move;
            byte state = this.States[y, x];
            //instantiate a bi-Dimential signed byte aray used to store directions.
            sbyte[,] directionSteps = { {1, 1}, {1, 0}, {0, 1}, {1, -1} };

            //The number of consecutive similar states.
            byte matchedConsec = 0;

            //enumerate through the 4 directrions
            for (int i = 0; i < 4; i++)
            {
                //enumerate trhough the 7 tiles in each direction with as 4th tile the 
                //last placed tile. 
                for (int j = -3; j < 4; j++)
                {
                    //convert direction and tile number to actual coordinates for the
                    //board
                    byte xCoord = (byte) (x + (j * directionSteps[i, 0]));
                    byte yCoord = (byte) (y + (j * directionSteps[i, 1]));
         
                    //check if the tile is on the board and has the same state as the last layed tile.
                    if (this.IsInsideOfGrid(yCoord, xCoord) && this.States[yCoord, xCoord] == state)
                    {
                        //there has been a match, increase the number of consecutive matches.
                        matchedConsec++;

                        //check if there are 4 matches in a row (win condition)
                        if (matchedConsec == 4)
                        {
                            //win. 4 same states in a row!
                            this.Win = state;
                        }
                    }
                    else
                    {
                        //the tile can't be matched, therefor the number of consecutive matches is reset.
                        matchedConsec = 0;
                    }
                }
            }
        }

        //Check if an x, y configuration is inside the grid.
        private bool IsInsideOfGrid(byte yCheck, byte xCheck)
        {
            return xCheck >= 0 && xCheck < this.Columns && yCheck >= 0 && yCheck < this.Rows;
        }

        //Properties
        public string Player1Name { get => player1Name; set => player1Name = value; }
        public string Player2Name { get => player2Name; set => player2Name = value; }
        public byte Rows { get => rows; set => rows = value; }
        public byte Columns { get => columns; set => columns = value; }
        public byte[,] States { get => states; set => states = value; }
        public byte Win { get => win; set => win = value; }
        public int Moves { get => moves; set => moves = value; }
    }
}
