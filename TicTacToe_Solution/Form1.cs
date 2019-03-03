using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Players
        {
            public static string player1 { get; set; }
            public static string player2 { get; set; }
            public static int p1_points { get; set; }
            public static int p2_points { get; set; }
            public static int max_points { get; set; }
            
        }
        public static string[] square = new string[10];
        public static int player = 1;
        public static string mark;
        public static Color color;

        private void pannel(bool status)
        {
            game_pannel.Enabled = status;
            player_pannel.Enabled = status;
        }
        private void errorBox(int type, string comment)
        {
            MessageBox.Show(comment, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool checkInputs()
        {
            if (tbPlayer1.TextLength != 0)
            {
                if (tbPlayer2.TextLength != 0)
                {
                    return true;
                }
                else
                {
                    errorBox(1, "Inserire il nome del secondo giocartore!");
                    return false;
                }
            }
            else
            {
                errorBox(1, "Inserire il nome del primo giocatore!");
                return false;
            }
        }
        private void resetAll()
        {
            square[0] = "o";
            square[1] = "1";
            square[2] = "2";
            square[3] = "3";
            square[4] = "4";
            square[5] = "5";
            square[6] = "6";
            square[7] = "7";
            square[8] = "8";
            square[9] = "9";

            slot_1.Text = "1";
            slot_2.Text = "2";
            slot_3.Text = "3";
            slot_4.Text = "4";
            slot_5.Text = "5";
            slot_6.Text = "6";
            slot_7.Text = "7";
            slot_8.Text = "8";
            slot_9.Text = "9";

            Players.p1_points = 0;
            Players.p2_points = 0;
            lPlayer1.Text = Players.player1 + ": 0";
            lPlayer2.Text = Players.player2 + ": 0";

            slot_1.FlatAppearance.BorderColor = Color.White;
            slot_1.ForeColor = Color.White;

            slot_2.FlatAppearance.BorderColor = Color.White;
            slot_2.ForeColor = Color.White;

            slot_3.FlatAppearance.BorderColor = Color.White;
            slot_3.ForeColor = Color.White;

            slot_4.FlatAppearance.BorderColor = Color.White;
            slot_4.ForeColor = Color.White;

            slot_5.FlatAppearance.BorderColor = Color.White;
            slot_5.ForeColor = Color.White;

            slot_6.FlatAppearance.BorderColor = Color.White;
            slot_6.ForeColor = Color.White;

            slot_7.FlatAppearance.BorderColor = Color.White;
            slot_7.ForeColor = Color.White;

            slot_8.FlatAppearance.BorderColor = Color.White;
            slot_8.ForeColor = Color.White;

            slot_9.FlatAppearance.BorderColor = Color.White;
            slot_9.ForeColor = Color.White;
        }
        private void reset()
        {
            square[0] = "o";
            square[1] = "1";
            square[2] = "2";
            square[3] = "3";
            square[4] = "4";
            square[5] = "5";
            square[6] = "6";
            square[7] = "7";
            square[8] = "8";
            square[9] = "9";

            slot_1.Text = "1";
            slot_2.Text = "2";
            slot_3.Text = "3";
            slot_4.Text = "4";
            slot_5.Text = "5";
            slot_6.Text = "6";
            slot_7.Text = "7";
            slot_8.Text = "8";
            slot_9.Text = "9";

            slot_1.FlatAppearance.BorderColor = Color.White;
            slot_1.ForeColor = Color.White;

            slot_2.FlatAppearance.BorderColor = Color.White;
            slot_2.ForeColor = Color.White;

            slot_3.FlatAppearance.BorderColor = Color.White;
            slot_3.ForeColor = Color.White;

            slot_4.FlatAppearance.BorderColor = Color.White;
            slot_4.ForeColor = Color.White;

            slot_5.FlatAppearance.BorderColor = Color.White;
            slot_5.ForeColor = Color.White;

            slot_6.FlatAppearance.BorderColor = Color.White;
            slot_6.ForeColor = Color.White;

            slot_7.FlatAppearance.BorderColor = Color.White;
            slot_7.ForeColor = Color.White;

            slot_8.FlatAppearance.BorderColor = Color.White;
            slot_8.ForeColor = Color.White;

            slot_9.FlatAppearance.BorderColor = Color.White;
            slot_9.ForeColor = Color.White;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pannel(false);
            first_pannel.BringToFront();
        }

        private void bGameStart_Click(object sender, EventArgs e)
        {

            if (checkInputs() == true)
            {
                Players.player1 = tbPlayer1.Text;
                Players.player2 = tbPlayer2.Text;
                Players.max_points = Convert.ToInt16(tbPoints.Value);

                lPlayer1.Text = Players.player1 + ": " + Players.p1_points;
                lPlayer2.Text = Players.player2 + ": " + Players.p2_points;
                lMaxPoints.Text = "Punteggio massimo: " + Players.max_points;

                first_pannel.SendToBack();
                first_pannel.Hide();
                pannel(true);
                getPlayerCur();

                reset();

            }
        }
        private int getPlayerCur()
        {
            if (player == 1)
            {
                player++;
                lPlayerCur.Text = Players.player1;
                mark = "X";
                lmark.Text = "X";
                color = Color.Goldenrod;
                lmark.ForeColor = color;

            }
            else if (player == 2)
            {
                player--;
                lPlayerCur.Text = Players.player2;
                mark = "O";
                lmark.Text = "O";
                color = Color.MediumSeaGreen;
                lmark.ForeColor = color;
            }
            return player;
        }

        private int getGameStatus()
        {
            if (square[1] == square[2] && square[2] == square[3])
            {
                return 1;
            }
            else if (square[4] == square[5] && square[5] == square[6])
            {
                return 1;
            }
            else if (square[7] == square[8] && square[8] == square[9])
            {
                return 1;
            }
            else if (square[1] == square[4] && square[4] == square[7])
            {
                return 1;
            } 
            else if (square[2] == square[5] && square[5] == square[8])
            {
                return 1;
            }
            else if (square[3] == square[6] && square[6] == square[9])
            {
                return 1;
            }
            else if (square[1] == square[5] && square[5] == square[9])
            {
                return 1;
            }
            else if (square[3] == square[5] && square[5] == square[7])
            {
                return 1;
            }
            else if (square[1] != "1" && square[2] != "2" && square[3] != "3"
                && square[4] != "4" && square[5] != "5" && square[6] != "6"
                && square[7] != "7" && square[8] != "8" && square[9] != "9")
            {
                return 0;
            }
            else
            {
                return -1;
            }
                
        }

        private void checkWin(int game_status)
        {
            if (game_status != -1)
            {
                if (game_status == 1)
                {
                    if (player == 1)
                    {
                        
                        MessageBox.Show("Il giocatore " + Players.player1 + " ha vinto il round", "STATO PARTITA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Players.p1_points += 1;
                        lPlayer1.Text = Players.player1 + ": " + Players.p1_points;
                        reset();
                    }
                    else if (player == 2)
                    {
                        
                        MessageBox.Show("Il giocatore " + Players.player2 + " ha vinto il round", "STATO PARTITA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Players.p2_points += 1;
                        lPlayer2.Text = Players.player2 + ": " + Players.p2_points;
                        reset();
                    }

                    if (Players.max_points == Players.p1_points)
                    {
                        MessageBox.Show("Il giocatore " + Players.player1 + " ha vinto la partita", "STATO PARTITA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Players.max_points == Players.p2_points)
                    {
                        MessageBox.Show("Il giocatore " + Players.player2 + " ha vinto la partita", "STATO PARTITA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Parità", "STATO PARTITA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
        }

        private void makeMark(int button)
        {
            switch (button)
            {
                case 1:
                    slot_1.Text = mark;
                    square[1] = mark;
                    slot_1.FlatAppearance.BorderColor = color;
                    slot_1.ForeColor = color;
                    break;
                case 2:
                    slot_2.Text = mark;
                    square[2] = mark;
                    slot_2.FlatAppearance.BorderColor = color;
                    slot_2.ForeColor = color;
                    break;
                case 3:
                    slot_3.Text = mark;
                    square[3] = mark;
                    slot_3.FlatAppearance.BorderColor = color;
                    slot_3.ForeColor = color;
                    break;
                case 4:
                    slot_4.Text = mark;
                    square[4] = mark;
                    slot_4.FlatAppearance.BorderColor = color;
                    slot_4.ForeColor = color;
                    break;
                case 5:
                    slot_5.Text = mark;
                    square[5] = mark;
                    slot_5.FlatAppearance.BorderColor = color;
                    slot_5.ForeColor = color;
                    break;
                case 6:
                    slot_6.Text = mark;
                    square[6] = mark;
                    slot_6.FlatAppearance.BorderColor = color;
                    slot_6.ForeColor = color;
                    break;
                case 7:
                    slot_7.Text = mark;
                    square[7] = mark;
                    slot_7.FlatAppearance.BorderColor = color;
                    slot_7.ForeColor = color;
                    break;
                case 8:
                    slot_8.Text = mark;
                    square[8] = mark;
                    slot_8.FlatAppearance.BorderColor = color;
                    slot_8.ForeColor = color;
                    break;
                case 9:
                    slot_9.Text = mark;
                    square[9] = mark;
                    slot_9.FlatAppearance.BorderColor = color;
                    slot_9.ForeColor = color;
                    break;
                default:
                    break;
                
            }
        }
        private void slot_1_Click(object sender, EventArgs e)
        {
            makeMark(1);
            getPlayerCur();
            checkWin(getGameStatus());
        }

        private void slot_2_Click(object sender, EventArgs e)
        {
            makeMark(2);
            getPlayerCur();
            checkWin(getGameStatus());

        }

        private void slot_3_Click(object sender, EventArgs e)
        {
            makeMark(3);
            getPlayerCur();
            checkWin(getGameStatus());
        }

        private void slot_4_Click(object sender, EventArgs e)
        {
            makeMark(4);
            getPlayerCur();
            checkWin(getGameStatus());
        }

        private void slot_5_Click(object sender, EventArgs e)
        {
            makeMark(5);
            getPlayerCur();
            checkWin(getGameStatus());
        }

        private void slot_6_Click(object sender, EventArgs e)
        {
            makeMark(6);
            getPlayerCur();
            checkWin(getGameStatus());
        }

        private void slot_7_Click(object sender, EventArgs e)
        {
            makeMark(7);
            getPlayerCur();
            checkWin(getGameStatus());

        }

        private void slot_8_Click(object sender, EventArgs e)
        {
            makeMark(8);
            getPlayerCur();
            checkWin(getGameStatus());
        }

        private void slot_9_Click(object sender, EventArgs e)
        {
            makeMark(9);
            getPlayerCur();
            checkWin(getGameStatus());
        }

        private void bReload_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
