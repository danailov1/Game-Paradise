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
    public partial class Form9 : Form
    {


        bool goLeft, goRight, shooting, isGameOver;
        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();

        public Form9()
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
            ClientSize = new Size(816, 713);
            AutoScroll = false;
            ResetGame();
        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && button1.Focused)
            {
                e.Handled = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2);

            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                ResetGame();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = score.ToString();


            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;


            if (enemyOne.Top > 710 || enemyTwo.Top > 710 || enemyThree.Top > 710)
            {
                gameOver();
            }



            // player movement logic starts

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 688)
            {
                player.Left += playerSpeed;
            }
            // player movement logic ends

            if (shooting == true)
            {
                bulletSpeed = 30;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -650;
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -750;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;
            }

            if (score == 5)
            {
                enemySpeed = 7;
            }
            if (score == 10)
            {
                enemySpeed = 9;
            }
        }
        private void ResetGame()
        {
            gameTimer.Start();
            enemySpeed = 6;


            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;


            txtScore.Text = score.ToString();
        }
        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + "Game Over!!" + Environment.NewLine + "Press R to try again.";

        }
    }
}
