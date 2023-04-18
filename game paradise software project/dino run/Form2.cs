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
    public partial class Form2 : Form
    {
        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        public Form2()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            gameTimer.Start();
            this.Focus();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(795, 446);
            AutoScroll = false;


        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;

            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (trex.Top > 364 && jumping == false)
            {
                force = 12;
                trex.Top = 365;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }
                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        txtScore.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }

                    cloud.Left += 1;
                    if (cloud.Left > this.Width)
                        cloud.Left = -cloud.Width;

                    clouds.Left += 1;
                    if (clouds.Left > this.Width)
                        clouds.Left = -clouds.Width;
                }
            }
           
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
            if (e.KeyCode == Keys.Space && button1.Focused)
            {
                e.Handled = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = " Score: " + score;
            trex.Image = Properties.Resources.running;
            isGameOver = false;
            trex.Top = 365;

            foreach (Control x in this.Controls)
            {
                if ((x is PictureBox && (string)x.Tag == "obstacle"))
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }
            }

            gameTimer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
