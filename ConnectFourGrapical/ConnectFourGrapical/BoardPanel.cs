using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConnectFourGrapical
{
    public class BoardPanel : Panel
    {
        //The ratio between the size of a cell and the size of the white tile circle. 
        private const decimal tanRatio = 0.8M;

        //The last column highlighted by the bounding box.
        private int lastColumn;

        //Brushes used for drawing
        private Brush bBlue = new SolidBrush(Color.Blue);
        private Brush bWhite = new SolidBrush(Color.White);
        private Brush bRed = new SolidBrush(Color.Red);
        private Brush bYellow = new SolidBrush(Color.Yellow);

        //The gameboard on which the game is played.
        private GameBoard board;

        //Initialize the board.
        public void InitBoard(GameBoard board)
        {
            //copy the reference to the gameoard.
            this.Board = board;
            
            //initialize the brushes.
            this.bBlue = new SolidBrush(Color.Blue);
            this.bWhite = new SolidBrush(Color.White);
            this.bRed = new SolidBrush(Color.Red);
            this.bYellow = new SolidBrush(Color.Yellow);

            //Use double buffering when rendering paint events(removes flickering).
            this.DoubleBuffered = true;
        }

        //Define what happens when the panel is repainted.
        protected override void OnPaint(PaintEventArgs e)
        {
            //Calculate the size of the individual cell. 
            int cellY = this.Size.Height / this.Board.Rows;
            int cellX = this.Size.Width / this.Board.Columns;

            //Enumerate trough all the cells of the board.
            for (int i = 0; i < this.Board.Columns; i++)
                for (int j = 0; j < this.Board.Rows; j++)
                {
                    //Calculate bounds of the cell
                    Rectangle rectBox = new Rectangle(new Point(i * cellX, j * cellY), new Size(cellX, cellY));

                    //get the size of the circle tile.
                    int tanSize = getSmallest((int)Math.Round(cellX * tanRatio), (int)Math.Round(cellY * tanRatio));

                    //Find the top left corner for the circle. 
                    int pointX = (int)Math.Round((Double)(i * cellX + cellX / 2) - tanSize / 2);
                    int pointY = (int)Math.Round((Double)(j * cellY + cellY / 2) - tanSize / 2);

                    //Create a rectangle for the circle tile.
                    Rectangle rectCircle = new Rectangle(new Point(pointX, pointY), 
                                                         new Size(tanSize, tanSize));

                    //Draw the cell.
                    e.Graphics.FillRectangle(this.bBlue, rectBox);
                    //Check if the cell has no tile in it
                    if(Board.States[j,i] == 0)
                        //Paint the cell white.
                        e.Graphics.FillEllipse(this.bWhite, rectCircle);

                    //Check if the cell has a tile from player 1. 
                    else if (Board.States[j, i] == 1)
                        //Paint the cell red.
                        e.Graphics.FillEllipse(this.bRed, rectCircle);
                    //The cell has a tile from player 2. 
                    else
                        //Paint the cell red.
                        e.Graphics.FillEllipse(this.bYellow, rectCircle);
                }
        }

        //draws the bounding box around the column for a given x value. 
        public void drawBoundingBox(int x)
        {
            //Calculate the size of a single cell
            double cellX = this.Size.Width / this.Board.Columns;

            //Calculate the cell which was clicked
            int nColumn = (int)Math.Floor((Double)x / cellX);

            //Check if the column is different from the last column for which a bounding box was drawn.
            if (nColumn != this.lastColumn)
            {
                //Repaint the panel.
                this.Refresh();

                //Create a graphics object.
                Graphics g = CreateGraphics();

                //Create a pen for the bounding box.
                Pen pRed = new Pen(Color.Red, 3);

                //Check if the column sits in the total number of columns.
                if (nColumn < this.Board.Columns)
                {
                    //Create the bounding box bounderies.
                    Rectangle rect = new Rectangle(new Point((int)(nColumn * cellX), 0),
                                                   new Size((int)cellX, this.Size.Height));

                    //Draw the bounding box.
                    g.DrawRectangle(pRed, rect);
                }
            }
            //Set the last column equal to the current column.
            this.lastColumn = nColumn;
        }

        //Allow a player to make a move on the board.
        public Boolean MakeMove(int mousePosition) {
            //Obtain the width of a cell.
            double cellX = this.Size.Width / this.Board.Columns;

            //obtain the column number for mousePosition.
            int nColumn = (int)Math.Floor((Double)mousePosition / cellX);

            //Make a move on the board. 
            return Board.Move(nColumn);
        }

        //return the smallest of 2 numbers.
        private int getSmallest(int first, int second)
        {
            //return the smallest number.
            return first > second ? second : first; 
        }

        //properties
        public GameBoard Board { get => board; set => board = value; }
    }
}
