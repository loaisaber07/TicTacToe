using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTakToc
{
    public partial class Form2 : Form
    {
        player p;

        public Form2()
        {
            InitializeComponent();
            p = new player();
            p.name = "o";


        }

        private void p1name_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
            }
        }
        public void setPropertiesName(string n1, string n2)
        {
            this.p1name.Text = n1;
            this.p2name.Text = n2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button1.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button1.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button2.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button2.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button3.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button3.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button4.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button4.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button5.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button5.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button6.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button6.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button7.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button7.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button8.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button8.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (p.name.Equals("o"))
            {
                playerNow.Text = $"{p1name.Text} is playing Now";
                button9.Text = "o";
                p.name = "x";
            }
            else if (p.name.Equals("x"))
            {
                playerNow.Text = $"{p2name.Text} is playing Now";
                button9.Text = "x";
                p.name = "o";
            }
            string win = CheckWin();
            if (win.Equals("o"))
            {
                winner.Text = $"{p1name.Text} is winner";
            }
            else if (win.Equals("x"))
            {
                winner.Text = $"{p2name.Text} is winner";
            }
            else
            {
                winner.Text = $"No one win yet!";
            }

        }
        private string CheckWin()
        {
            // Assuming button1 to button9 are your buttons
            string[] board = {
        button1.Text, button2.Text, button3.Text,
        button4.Text, button5.Text, button6.Text,
        button7.Text, button8.Text, button9.Text
    };

            // Define winning combinations
            int[,] winCombinations = new int[,] {
        { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Rows
        { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columns
        { 0, 4, 8 }, { 2, 4, 6 }              // Diagonals
    };

            // Check each winning combination
            for (int i = 0; i < winCombinations.GetLength(0); i++)
            {
                int a = winCombinations[i, 0];
                int b = winCombinations[i, 1];
                int c = winCombinations[i, 2];

                if (board[a] == board[b] && board[b] == board[c] && board[a] != string.Empty)
                {
                    if (board[a].Equals("o"))
                        MessageBox.Show($"{p1name.Text} is winner"); 
                    if (board[a].Equals("x"))
                        MessageBox.Show($"{p2name.Text} is winner");

                    return board[a]; // Return "O" or "X"
                }
            }

            // No winner found
            return string.Empty; // Return empty string if no winner
        }
    }
}
