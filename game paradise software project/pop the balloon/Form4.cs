using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_proba
{
    public partial class Form4 : Form
    {

        int speed;
        int score;
        Random rand = new Random();
        bool gameOver;
        public Form4()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);

            gameTimer.Start();
            this.Focus();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(650, 650);
            AutoScroll = false;
            RestartGame();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (gameOver == true)
            {
                gameTimer.Stop();
                txtScore.Text = "Score: " + score + " Game over, press R to restart";
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    x.Top -= speed;

                    if (x.Top < -100)
                    {
                        x.Top = rand.Next(700, 1000);
                        x.Left = rand.Next(5, 500);
                    }
                    if ((string)x.Tag == "balloon")
                    {
                        if (x.Top < -50)
                        {
                            gameOver = true;
                        }
                        if (bomb.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = rand.Next(700, 1000);
                            x.Left = rand.Next(5, 500);
                        }
                    }
                }
            }
            if (score > 5)
            {
                speed = 6;
            }
            if (score > 15)
            {
                speed = 8;
            }
            if (score > 30)
            {
                speed = 10;
            }
            if (score > 50)
            {
                speed = 13;
            }
        }

        private void PopBallon(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                var balloon = (PictureBox)sender;
                balloon.Top = rand.Next(750, 1000);
                balloon.Left = rand.Next(5, 500);

                score += 1;
            }
        }

        private void GoBoom(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                bomb.Image = Properties.Resources.boom;
                gameOver = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && gameOver == true)
            {
                RestartGame();
            }
        }
        private void RestartGame()
        {
            speed = 5;
            score = 0;
            gameOver = false;

            bomb.Image = Properties.Resources.bomb;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top = rand.Next(750, 1000);
                    x.Left = rand.Next(5, 500);
                }
            }

            gameTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && button1.Focused)
            {
                e.Handled = true;
            }
        }
    }
}
