using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourGrapical
{
    public partial class MainForm : Form
    {
        //An instance used by the singleton design.
        private static MainForm instance;

        //A board on which the game is played.
        private GameBoard board;

        //Constructor for the MainFOrm class.
        private MainForm(GameBoard board)
        {
            //Initialize the board.
            this.board = board;

            //Initialize the form components.
            InitializeComponent();
            
            //Set the text fo which player's turn it is (always player 1 at the start of a game).
            this.lPlayer.Text = "Player: " + board.Player1Name;

            //Use double buffering when rendering paint events(removes flickering).
            this.DoubleBuffered = true;
        }

        //Get the instance of MainForm.
        public static MainForm GetInstance(GameBoard board)
        {
            //Check if an instance needs to be made.
            if (instance == null)
                //Make an instance.
                instance = new MainForm(board);

            //Return the instance.
            return instance;
        }

        //Reset the instance (such that a new one has to be created).
        public void Reset()
        {
            //Set the instance to null.
            instance = null;
        }

        //Open the new game window. 
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get an instance of the NewGame form.
            NewGame instance = NewGame.GetInstance();
            //Show the NewGame form.
            instance.Show();

            //Hide the win panel.
            this.pWin.Hide();
            //Hide the form.
            this.Hide();
            //Reset the form instance.
            this.Reset();
        }

        //close the application.
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Force the process to be stopped.
            Environment.Exit(0);
        }

        //Loading the form.
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Pass a reference of the board to the the panel. 
            this.pBoard.InitBoard(board);
        }

        //Make a move.
        private void pBoard_MouseClick(object sender, MouseEventArgs e)
        {
            //Check if there should be another move made.
            if(board.Win == 0)
                //Check if a move was made.
                if(pBoard.MakeMove(e.X))
                    //A move has been made, change the turn to the next player.
                    SwitchPlayer();
            //We can't use else here as we want to check for a win after the move.
            //Check if player 1 has won.
            if(pBoard.Board.Win == 1)
            {
                //Notify player 1 has won.
                this.lPlayer.Text = "Winner is: " + board.Player1Name;
                this.lWinner.Text = "Winner is: " + board.Player1Name + " Click to restart";
                //Show the win promt panel.
                this.pWin.Show();
            }
            //Check if player 2 has won.
            if (pBoard.Board.Win == 2)
            {
                //Notify player 2 has won.
                this.lPlayer.Text = "Winner is: " + board.Player2Name;
                this.lWinner.Text = "Winner is: " + board.Player2Name + " Click to restart";
                //Show the win promt panel.
                this.pWin.Show();
            }
            //Repaint the board.
            pBoard.Refresh();
        }

        //Hover on column. 
        private void pBoard_MouseMove(object sender, MouseEventArgs e)
        {
            //Check if there is no win.
            if (board.Win == 0)
                //Draw a bounding box.
                this.pBoard.drawBoundingBox(e.X);
        }

        //Change the players turn. 
        private void SwitchPlayer()
        {
            //Check if the player is player 1.
            if (this.lPlayer.Text == "Player: " + board.Player1Name)
                //Set the turn to player 2.
                this.lPlayer.Text = "Player: " + board.Player2Name;
            else
                //Set the turn to player 1.
                this.lPlayer.Text = "Player: " + board.Player1Name;
        }

        //Check if the user clicked the win panel.
        private void lWinner_Click(object sender, EventArgs e)
        {
            //Hide the form.
            this.Hide();
            //Show the prompt for a new game.
            NewGame.GetInstance().StartNewGame();
        }

        //Check if the main form is closed.
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Force the process to stop.
            Environment.Exit(0);
        }
    }
}
