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
    public partial class NewGame : Form
    {
        //the instance of NewGame used for the singleton design.
        private static NewGame instance;

        //constructor for the NewGame class.
        private NewGame()
        {
            //initialize the form components.
            InitializeComponent();
        }

        //get the singleton instance. 
        public static NewGame GetInstance()
        {
            //check if an instance needs to be made
            if (instance == null)
                //make an instance
                instance = new NewGame();

            //return the instance.
            return instance;
        }

        //remove the singleton instance.
        public void Reset()
        {
            //set instance to null (A new one needs to be created for the next access).
            instance = null;
        }

        //the game needs to be started
        private void bStart_Click(object sender, EventArgs e)
        {
            //obtain the information from the form. 
            String player1Name = this.tPlayer1.Text;
            String player2Name = this.tPlayer2.Text;
            byte rows = Byte.Parse(this.tRows.Text);
            byte columns = Byte.Parse(this.tColumns.Text);

            //Create a gameboard with the information from the form. 
            GameBoard board = new GameBoard(player1Name, player2Name, rows, columns);

            //create a game window with the new board. 
            MainForm instance = MainForm.GetInstance(board);

            //show the game window and close this window. 
            instance.Show();
            this.Hide();
            this.Reset();
        }

        //The game needs to be quit.
        private void BCancel_Click(object sender, EventArgs e)
        {
            //force the process to quit. 
            Environment.Exit(0);
        }

        //Reset the form such that new information can be inserted for a next game. 
        public void StartNewGame()
        {
            //reset the instance of MainForm
            MainForm.GetInstance(null).Reset();
            //show a newgame form. 
            this.Show();
        }
    }
}
