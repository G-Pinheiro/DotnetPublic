using BoardLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacGUI
{
    public partial class Form1 : Form
    {
        Board game = new Board();
        Button[] buttons = new Button[9];

        // 
        public Form1()
        {
            InitializeComponent();
            game = new Board();

            //Implement a loop later
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;

            // Click event to each button
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handleButtonclick;
                buttons[i].Tag = i;
            }
        }

        private void handleButtonclick(object sender, EventArgs e)
        {
            Button clickedButton = (Button) sender;
            //MessageBox.Show("Button " + clickedButton.Tag + " Was clicked");

            int gameSquareNumber = (int)clickedButton.Tag;

            //Insert 1, the players number
            game.Grid[gameSquareNumber] = 1;

            updateBoard();

            if (game.CheckMoves(game.Grid) == false)
            {
                MessageBox.Show("Player 1 wins! ");
                disableAllButtons();
                return;
            }
            else if (game.AvailableMoves(game.Grid) == false)
            {
                MessageBox.Show("No more moves available. ");
                disableAllButtons();
                return;
            }

            //Pc turn
            game.PcTurn(game.Grid);

            updateBoard();
            {
                if (game.CheckMoves(game.Grid) == false)
                {
                    MessageBox.Show("Player 2 wins! ");
                    disableAllButtons();
                    return;
                }
                else if (game.AvailableMoves(game.Grid) == false)
                {
                    MessageBox.Show("No more moves available. ");
                    disableAllButtons();
                    return;
                }
            }
            updateBoard();
        }

        private void disableAllButtons()
        {
            foreach (var item in buttons)
            {
                item.Enabled = false;
            }
        }

        private void enableAllButtons()
        {
            foreach (var item in buttons)
            {
                item.Enabled = true;
                updateBoard();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateBoard();
        }

        private void updateBoard()
        {
            // Assign X or O to the buttons
            // Empty = 0
            // X = 1
            // O = 2
            for (int i = 0; i < game.Grid.Length; i++)
            {
                if (game.Grid[i] == 0)
                {
                    buttons[i].Text = "";
                }
                else if (game.Grid[i] == 1)
                {
                    buttons[i].Text = "X";
                }
                else if (game.Grid[i] == 2)
                {
                    buttons[i].Text = "O";
                }
                else
                    buttons[i].Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            game = new Board();
            enableAllButtons();
        }
    }
}
