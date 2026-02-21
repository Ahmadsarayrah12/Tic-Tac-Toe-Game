using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        int order = 1;



        void ResetGame()
        {


            order = 1;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            pictureBox1.Tag = null;
            pictureBox2.Tag = null;
            pictureBox3.Tag = null;
            pictureBox4.Tag = null;
            pictureBox5.Tag = null;
            pictureBox6.Tag = null;
            pictureBox7.Tag = null;
            pictureBox8.Tag = null;
            pictureBox9.Tag = null;
            lblCurrentPlayer.Text = "Current Player: X";
            resetColor();


        }

        bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        void CurrentPlayer()
        {
            if (IsOdd(order))
            {
                lblCurrentPlayer.Text = "Current Player: X";
            }
            else
            {
                lblCurrentPlayer.Text = "Current Player: O";
            }
        }

        bool IsDraw()
        {
            return order == 9 && !CheckWinner();
        }


        bool WhoWinnerOrDraw()
        {
            if (CheckWinner())
            {
                if (IsOdd(order))
                {
                    MessageBox.Show("Player1 X wins!");
                }
                else
                {
                    MessageBox.Show("Player2 O wins!");
                }
                ResetGame();
                return true;
            }
            else if (IsDraw())
            {
                lblCurrentPlayer.Text = "End Game!";
                MessageBox.Show("It's a draw!");
                
                ResetGame();
                return true;

            }
            return false;

        }


        void CheckOrder(object sender)
        {
            PictureBox clickedImage = sender as PictureBox;

            if (clickedImage == null) return;

            if (clickedImage.Image != null) return;


            if (IsOdd(order))
            {
                clickedImage.Image = Resources.X_;
                clickedImage.Tag = "X";
            }
            else
            {
                clickedImage.Image = Resources.O;
                clickedImage.Tag = "O";
            }


            if (WhoWinnerOrDraw())
            {
                return;
            }
            order++;
            CurrentPlayer();

        }

        bool CheckWinner(PictureBox p1, PictureBox p2, PictureBox p3)
        {

            if ((p1.Tag == p2.Tag) && (p2.Tag == p3.Tag) && p1.Tag != null)
            {

                p1.BackColor = Color.Green;
                p2.BackColor = Color.Green;
                p3.BackColor = Color.Green;

                return true;
            }
            return false;
        }

        void resetColor()
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
        }
        bool CheckWinner()
        {

            if (CheckWinner(pictureBox1, pictureBox2, pictureBox3))
            {

                return true;
            }

            if (CheckWinner(pictureBox4, pictureBox5, pictureBox6))
            {
                return true;
            }
            if (CheckWinner(pictureBox7, pictureBox8, pictureBox9))
            {
                return true;
            }

            if (CheckWinner(pictureBox1, pictureBox4, pictureBox7))
            {
                return true;
            }
            if (CheckWinner(pictureBox2, pictureBox5, pictureBox8))
            {
                return true;
            }
            if (CheckWinner(pictureBox3, pictureBox6, pictureBox9))
            {
                return true;
            }

            if (CheckWinner(pictureBox1, pictureBox5, pictureBox9))
            {
                return true;

            }

            if (CheckWinner(pictureBox3, pictureBox5, pictureBox7))
            {
                return true;
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ResetGame();

        }



        private void Player_Click(object sender, MouseEventArgs e)
        {
            CheckOrder(sender);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnReset.Visible = true;
            pnlXO.Visible = true;
        }

 
    }


}
