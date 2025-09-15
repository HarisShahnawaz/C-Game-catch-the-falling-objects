using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatchTheObjects
{
    public partial class Form1 : Form
    {
        PictureBox basket;
        PictureBox fallingObject;
        Timer gameTimer;
        Random rand;
        int score = 0;
        int lives = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 400;
            this.Height = 500;
            this.Text = "Catch the Falling Objects";

            rand = new Random();

            // Basket
            basket = new PictureBox();
            basket.BackColor = Color.Blue;
            basket.Width = 80;
            basket.Height = 20;
            basket.Top = this.ClientSize.Height - basket.Height - 20;
            basket.Left = (this.ClientSize.Width / 2) - (basket.Width / 2);
            this.Controls.Add(basket);

            // Falling Object
            fallingObject = new PictureBox();
            fallingObject.BackColor = Color.Red;
            fallingObject.Width = 30;
            fallingObject.Height = 30;
            ResetObject();
            this.Controls.Add(fallingObject);

            // Labels
            lblScore.Text = "Score: 0";
            lblLives.Text = "Lives: 3";

            // Timer
            gameTimer = new Timer();
            gameTimer.Interval = 20; // ~50 FPS
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            this.KeyDown += Form1_KeyDown;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Move falling object
            fallingObject.Top += 5;

            // If it reaches bottom
            if (fallingObject.Top > this.ClientSize.Height)
            {
                lives--;
                lblLives.Text = "Lives: " + lives;
                ResetObject();

                if (lives <= 0)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Game Over! Final Score: " + score);
                }
            }

            // Check collision
            if (fallingObject.Bounds.IntersectsWith(basket.Bounds))
            {
                score++;
                lblScore.Text = "Score: " + score;
                ResetObject();
            }
        }

        private void ResetObject()
        {
            fallingObject.Top = 0;
            fallingObject.Left = rand.Next(0, this.ClientSize.Width - fallingObject.Width);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Move basket
            if (e.KeyCode == Keys.Left && basket.Left > 0)
            {
                basket.Left -= 20;
            }
            if (e.KeyCode == Keys.Right && basket.Right < this.ClientSize.Width)
            {
                basket.Left += 20;
            }
        }
    }
}
