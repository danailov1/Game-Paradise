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
    public partial class Form10 : Form
    {
        bool up, right, down, left;
        bool isGameOver = false;

        bool rotateLeft, rotateRight;

        int a = 15;
        int b = 47;
        int c = -40;
        int d = 7;
        int bulletRotation = 0;
        int score = 0;
        int bulletX;
        int bulletY;
        int playerSpeed = 5;

        int asteroid1XSpeed;
        int asteroid1YSpeed;

        int asteroid2XSpeed;
        int asteroid2YSpeed;

        int asteroid3XSpeed;
        int asteroid3YSpeed;

        int asteroid4XSpeed;
        int asteroid4YSpeed;

        int asteroid5XSpeed;
        int asteroid5YSpeed;

        int asteroid6XSpeed;
        int asteroid6YSpeed;

        int asteroid7XSpeed;
        int asteroid7YSpeed;

        int asteroid8XSpeed;
        int asteroid8YSpeed;

        int asteroid9XSpeed;
        int asteroid9YSpeed;

        int asteroid10XSpeed;
        int asteroid10YSpeed;

        int asteroid11XSpeed;
        int asteroid11YSpeed;

        int asteroid12XSpeed;
        int asteroid12YSpeed;

        int asteroid13XSpeed;
        int asteroid13YSpeed;

        Random rnd = new Random();
        public Form10()
        {

            this.KeyPreview = true;
            InitializeComponent();
            this.Focus();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(820, 490);
            AutoScroll = false;


        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) up = true;
            if (e.KeyCode == Keys.S) down = true;
            if (e.KeyCode == Keys.D) right = true;
            if (e.KeyCode == Keys.A) left = true;
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                if (bulletRotation == 0)
                {
                    player.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                    player.Size = new Size(19, 45);
                }
                if (bulletRotation == 1 || bulletRotation == -3)
                {
                    player.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    player.Size = new Size(19, 45);
                }
                if (bulletRotation == 2 || bulletRotation == -2)
                {
                    player.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    player.Size = new Size(19, 45);
                }
                if (bulletRotation == 3 || bulletRotation == -1)
                {
                    player.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    player.Size = new Size(19, 45);
                }
                if (bulletRotation == 4 || bulletRotation == -4) bulletRotation = 0;
                resetGame();
            }
            if (e.KeyCode == Keys.N) rotateLeft = true;
            if (e.KeyCode == Keys.M) rotateRight = true;
            if (e.KeyCode == Keys.Space)
            {
                bulletX = player.Location.X;
                bulletY = player.Location.Y;
                bulletTimer.Start();
                a = 15;
                b = 47;
                c = 15;
                d = 7;
            }
            if (e.KeyCode == Keys.Space && button1.Focused)
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) up = false;
            if (e.KeyCode == Keys.S) down = false;
            if (e.KeyCode == Keys.D) right = false;
            if (e.KeyCode == Keys.A) left = false;
            if (e.KeyCode == Keys.N) rotateLeft = false;
            if (e.KeyCode == Keys.M) rotateRight = false;
        }

        private void bulletTimer_Tick(object sender, EventArgs e)
        {
            bullet.Visible = true;
            if (bulletRotation == 0)
            {
                bullet.Location = new Point(bulletX + 7, bulletY - a);
                a += 10;
                if (bullet.Location.Y < -10)
                {
                    bullet.Visible = false;
                    bulletTimer.Stop();

                }
            }
            if (bulletRotation == 1 || bulletRotation == -3)
            {
                bullet.Location = new Point(bulletX + b, bulletY + 7);
                b += 10;
                if (bullet.Location.Y < -10)
                {
                    bullet.Visible = false;
                    bulletTimer.Stop();

                }
            }
            if (bulletRotation == 2 || bulletRotation == -2)
            {
                bullet.Location = new Point(bulletX + 7, bulletY - c + 50);
                c -= 10;
                if (bullet.Location.Y < -10)
                {
                    bullet.Visible = false;
                    bulletTimer.Stop();
                }
            }
            if (bulletRotation == 3 || bulletRotation == -1)
            {
                bullet.Location = new Point(bulletX + d, bulletY + 5);
                d -= 15;
                if (bullet.Location.Y > 460)
                {
                    bullet.Visible = false;
                    bulletTimer.Stop();
                }
            }
            if (bulletRotation == 4 || bulletRotation == -4) bulletRotation = 0;
        }

        private void rotationEvent(object sender, EventArgs e)
        {
            if (rotateLeft == true)
            {
                player.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                bulletRotation--;
            }
            if (rotateRight == true)
            {
                player.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                bulletRotation++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asteroidMovement_Tick(object sender, EventArgs e)
        {

            asteroid1XSpeed = rnd.Next(-15, 16);
            asteroid1YSpeed = rnd.Next(-15, 16);

            asteroid2XSpeed = rnd.Next(-10, 11);
            asteroid2YSpeed = rnd.Next(-10, 11);

            asteroid3XSpeed = rnd.Next(-10, 11);
            asteroid3YSpeed = rnd.Next(-10, 11);

            asteroid4XSpeed = rnd.Next(-14, 11);
            asteroid4YSpeed = rnd.Next(-14, 11);

            asteroid5XSpeed = rnd.Next(-15, 11);
            asteroid5YSpeed = rnd.Next(-15, 11);

            asteroid6XSpeed = rnd.Next(-11, 11);
            asteroid6YSpeed = rnd.Next(-11, 11);

            asteroid7XSpeed = rnd.Next(-12, 11);
            asteroid7YSpeed = rnd.Next(-12, 11);

            asteroid8XSpeed = rnd.Next(-17, 11);
            asteroid8YSpeed = rnd.Next(-17, 11);

            asteroid9XSpeed = rnd.Next(-18, 11);
            asteroid9YSpeed = rnd.Next(-18, 11);

            asteroid10XSpeed = rnd.Next(-11, 11);
            asteroid10YSpeed = rnd.Next(-11, 11);

            asteroid11XSpeed = rnd.Next(-12, 11);
            asteroid11YSpeed = rnd.Next(-12, 11);

            asteroid12XSpeed = rnd.Next(-12, 11);
            asteroid12YSpeed = rnd.Next(-13, 11);

            asteroid13XSpeed = rnd.Next(-13, 11);
            asteroid13YSpeed = rnd.Next(-14, 11);


            asteroid1.Left += asteroid1XSpeed;
            asteroid1.Top += asteroid1YSpeed;

            asteroid2.Left += asteroid2XSpeed;
            asteroid2.Top += asteroid2YSpeed;

            asteroid3.Top += asteroid3YSpeed;
            asteroid3.Left += asteroid3XSpeed;

            asteroid4.Top += asteroid4YSpeed;
            asteroid4.Left += asteroid4XSpeed;

            asteroid5.Top += asteroid5YSpeed;
            asteroid5.Left += asteroid5XSpeed;

            asteroid6.Top += asteroid6YSpeed;
            asteroid6.Left += asteroid6XSpeed;

            asteroid7.Top += asteroid7YSpeed;
            asteroid7.Left += asteroid7XSpeed;

            asteroid8.Top += asteroid8YSpeed;
            asteroid8.Left += asteroid8XSpeed;

            asteroid9.Top += asteroid9YSpeed;
            asteroid9.Left += asteroid9XSpeed;

            asteroid10.Top += asteroid10YSpeed;
            asteroid10.Left += asteroid10XSpeed;

            asteroid11.Top += asteroid11YSpeed;
            asteroid11.Left += asteroid11XSpeed;

            asteroid12.Top += asteroid12YSpeed;
            asteroid12.Left += asteroid12XSpeed;

            asteroid13.Top += asteroid13YSpeed;
            asteroid13.Left += asteroid13XSpeed;

            if (asteroid1.Left < -asteroid1.Width)
            {
                asteroid1.Left = this.Width;
            }
            if (asteroid1.Left > this.Width)
            {
                asteroid1.Left = -asteroid1.Width;
            }
            if (asteroid1.Top < -asteroid1.Height)
            {
                asteroid1.Top = this.Height;
            }
            if (asteroid1.Top > this.Height)
            {
                asteroid1.Top = -asteroid1.Height;
            }


            if (asteroid2.Left < -asteroid2.Width)
            {
                asteroid2.Left = this.Width;
            }
            if (asteroid2.Left > this.Width)
            {
                asteroid2.Left = -asteroid2.Width;
            }
            if (asteroid2.Top < -asteroid2.Height)
            {
                asteroid2.Top = this.Height;
            }
            if (asteroid2.Top > this.Height)
            {
                asteroid2.Top = -asteroid2.Height;
            }

            if (asteroid3.Left < -asteroid3.Width)
            {
                asteroid3.Left = this.Width;
            }
            if (asteroid3.Left > this.Width)
            {
                asteroid3.Left = -asteroid3.Width;
            }
            if (asteroid3.Top < -asteroid3.Height)
            {
                asteroid3.Top = this.Height;
            }
            if (asteroid3.Top > this.Height)
            {
                asteroid3.Top = -asteroid3.Height;
            }


            if (asteroid4.Left < -asteroid4.Width)
            {
                asteroid4.Left = this.Width;
            }
            if (asteroid4.Left > this.Width)
            {
                asteroid4.Left = -asteroid4.Width;
            }
            if (asteroid4.Top < -asteroid4.Height)
            {
                asteroid4.Top = this.Height;
            }
            if (asteroid4.Top > this.Height)
            {
                asteroid4.Top = -asteroid4.Height;
            }


            if (asteroid5.Left < -asteroid5.Width)
            {
                asteroid5.Left = this.Width;
            }
            if (asteroid5.Left > this.Width)
            {
                asteroid5.Left = -asteroid5.Width;
            }
            if (asteroid5.Top < -asteroid5.Height)
            {
                asteroid5.Top = this.Height;
            }
            if (asteroid5.Top > this.Height)
            {
                asteroid5.Top = -asteroid5.Height;
            }

            if (asteroid6.Left < -asteroid6.Width)
            {
                asteroid6.Left = this.Width;
            }
            if (asteroid6.Left > this.Width)
            {
                asteroid6.Left = -asteroid6.Width;
            }
            if (asteroid6.Top < -asteroid6.Height)
            {
                asteroid6.Top = this.Height;
            }
            if (asteroid6.Top > this.Height)
            {
                asteroid6.Top = -asteroid6.Height;
            }

            if (asteroid7.Left < -asteroid7.Width)
            {
                asteroid7.Left = this.Width;
            }
            if (asteroid7.Left > this.Width)
            {
                asteroid7.Left = -asteroid7.Width;
            }
            if (asteroid7.Top < -asteroid7.Height)
            {
                asteroid7.Top = this.Height;
            }
            if (asteroid7.Top > this.Height)
            {
                asteroid7.Top = -asteroid7.Height;
            }

            if (asteroid8.Left < -asteroid8.Width)
            {
                asteroid8.Left = this.Width;
            }
            if (asteroid8.Left > this.Width)
            {
                asteroid8.Left = -asteroid8.Width;
            }
            if (asteroid8.Top < -asteroid8.Height)
            {
                asteroid8.Top = this.Height;
            }
            if (asteroid8.Top > this.Height)
            {
                asteroid8.Top = -asteroid8.Height;
            }

            if (asteroid9.Left < -asteroid9.Width)
            {
                asteroid9.Left = this.Width;
            }
            if (asteroid9.Left > this.Width)
            {
                asteroid9.Left = -asteroid9.Width;
            }
            if (asteroid9.Top < -asteroid9.Height)
            {
                asteroid9.Top = this.Height;
            }
            if (asteroid9.Top > this.Height)
            {
                asteroid9.Top = -asteroid9.Height;
            }

            if (asteroid10.Left < -asteroid10.Width)
            {
                asteroid10.Left = this.Width;
            }
            if (asteroid10.Left > this.Width)
            {
                asteroid10.Left = -asteroid10.Width;
            }
            if (asteroid10.Top < -asteroid10.Height)
            {
                asteroid10.Top = this.Height;
            }
            if (asteroid10.Top > this.Height)
            {
                asteroid10.Top = -asteroid10.Height;
            }

            if (asteroid11.Left < -asteroid11.Width)
            {
                asteroid11.Left = this.Width;
            }
            if (asteroid11.Left > this.Width)
            {
                asteroid11.Left = -asteroid11.Width;
            }
            if (asteroid11.Top < -asteroid11.Height)
            {
                asteroid11.Top = this.Height;
            }
            if (asteroid11.Top > this.Height)
            {
                asteroid11.Top = -asteroid11.Height;
            }

            if (asteroid12.Left < -asteroid12.Width)
            {
                asteroid12.Left = this.Width;
            }
            if (asteroid12.Left > this.Width)
            {
                asteroid12.Left = -asteroid12.Width;
            }
            if (asteroid12.Top < -asteroid12.Height)
            {
                asteroid12.Top = this.Height;
            }
            if (asteroid12.Top > this.Height)
            {
                asteroid12.Top = -asteroid12.Height;
            }

            if (asteroid13.Left < -asteroid13.Width)
            {
                asteroid13.Left = this.Width;
            }
            if (asteroid13.Left > this.Width)
            {
                asteroid13.Left = -asteroid13.Width;
            }
            if (asteroid13.Top < -asteroid13.Height)
            {
                asteroid13.Top = this.Height;
            }
            if (asteroid13.Top > this.Height)
            {
                asteroid13.Top = -asteroid13.Height;
            }
        }

        private void playerMovementEvent(object sender, EventArgs e)
        {
            if (bulletRotation == 0) player.Size = new Size(19, 45);
            if (bulletRotation == 1 || bulletRotation == -3) player.Size = new Size(45, 19);
            if (bulletRotation == 2 || bulletRotation == -2) player.Size = new Size(19, 45);
            if (bulletRotation == 3 || bulletRotation == -1) player.Size = new Size(45, 19);
            if (bulletRotation == 4 || bulletRotation == -4) bulletRotation = 0;
            if (left == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (right == true && player.Left < this.Width - player.Width)
            {
                player.Left += playerSpeed;
            }
            if (up == true && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }
            if (down == true && player.Top + player.Height < this.Height)
            {
                player.Top += playerSpeed;
            }
            if (asteroid1.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid2.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid3.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid4.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid5.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid6.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid7.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid8.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid9.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid10.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid11.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid12.Bounds.IntersectsWith(bullet.Bounds) ||
asteroid13.Bounds.IntersectsWith(bullet.Bounds))
            {
                score++;
                bullet.Visible = false;
                bulletTimer.Stop();
            }
            if (asteroid1.Bounds.IntersectsWith(player.Bounds) ||
                asteroid2.Bounds.IntersectsWith(player.Bounds) ||
                asteroid3.Bounds.IntersectsWith(player.Bounds) ||
                asteroid4.Bounds.IntersectsWith(player.Bounds) ||
                asteroid5.Bounds.IntersectsWith(player.Bounds) ||
                asteroid6.Bounds.IntersectsWith(player.Bounds) ||
                asteroid7.Bounds.IntersectsWith(player.Bounds) ||
                asteroid8.Bounds.IntersectsWith(player.Bounds) ||
                asteroid9.Bounds.IntersectsWith(player.Bounds) ||
                asteroid10.Bounds.IntersectsWith(player.Bounds) ||
                asteroid11.Bounds.IntersectsWith(player.Bounds) ||
                asteroid12.Bounds.IntersectsWith(player.Bounds) ||
                asteroid13.Bounds.IntersectsWith(player.Bounds))
            {
                playerMovement.Enabled = false;
                asteroidMovement.Enabled = false;
                rotationTimer.Enabled = false;
                bulletTimer.Enabled = false;
                gameOver();
            }
            if (asteroid1.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid1.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid1.Left = -asteroid1.Width;
                }
                if (i == 2)
                {
                    asteroid1.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid1.Top = -asteroid1.Height;
                }
            }
            if (asteroid2.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid2.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid2.Left = -asteroid2.Width;
                }
                if (i == 2)
                {
                    asteroid2.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid2.Top = -asteroid2.Height;
                }
            }
            if (asteroid3.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid3.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid3.Left = -asteroid3.Width;
                }
                if (i == 2)
                {
                    asteroid3.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid3.Top = -asteroid3.Height;
                }
            }
            if (asteroid4.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid4.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid4.Left = -asteroid4.Width;
                }
                if (i == 2)
                {
                    asteroid4.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid4.Top = -asteroid4.Height;
                }
            }
            if (asteroid5.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid5.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid5.Left = -asteroid5.Width;
                }
                if (i == 2)
                {
                    asteroid5.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid5.Top = -asteroid5.Height;
                }
            }
            if (asteroid6.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid6.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid6.Left = -asteroid6.Width;
                }
                if (i == 2)
                {
                    asteroid6.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid6.Top = -asteroid6.Height;
                }
            }
            if (asteroid7.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid7.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid7.Left = -asteroid7.Width;
                }
                if (i == 2)
                {
                    asteroid7.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid7.Top = -asteroid7.Height;
                }
            }
            if (asteroid8.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid8.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid8.Left = -asteroid8.Width;
                }
                if (i == 2)
                {
                    asteroid8.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid8.Top = -asteroid8.Height;
                }
            }
            if (asteroid9.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid9.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid9.Left = -asteroid9.Width;
                }
                if (i == 2)
                {
                    asteroid9.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid9.Top = -asteroid9.Height;
                }
            }
            if (asteroid11.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid11.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid11.Left = -asteroid11.Width;
                }
                if (i == 2)
                {
                    asteroid11.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid11.Top = -asteroid11.Height;
                }
            }
            if (asteroid10.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid10.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid10.Left = -asteroid10.Width;
                }
                if (i == 2)
                {
                    asteroid10.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid10.Top = -asteroid10.Height;
                }
            }
            if (asteroid12.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid12.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid12.Left = -asteroid12.Width;
                }
                if (i == 2)
                {
                    asteroid12.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid12.Top = -asteroid12.Height;
                }
            }
            if (asteroid13.Bounds.IntersectsWith(bullet.Bounds))
            {
                Random rnd = new Random();
                int i = rnd.Next(0, 4);
                if (i == 0)
                {
                    asteroid13.Left = this.Width;
                }
                if (i == 1)
                {
                    asteroid13.Left = -asteroid13.Width;
                }
                if (i == 2)
                {
                    asteroid13.Top = this.Height;
                }
                if (i == 3)
                {
                    asteroid13.Top = -asteroid13.Height;
                }
            }
            label1.Text = "score: " + score;
        }
        private void gameOver()
        {
            isGameOver = true;
        }
        private void resetGame()
        {
            player.Location = new Point(377, 212);
            asteroid1.Location = new Point(88, 55);
            asteroid2.Location = new Point(259, 30);
            asteroid3.Location = new Point(534, 30);
            asteroid4.Location = new Point(473, 94);
            asteroid5.Location = new Point(657, 94);
            asteroid6.Location = new Point(684, 320);
            asteroid7.Location = new Point(377, 397);
            asteroid8.Location = new Point(220, 347);
            asteroid9.Location = new Point(553, 247);
            asteroid10.Location = new Point(119, 223);
            asteroid11.Location = new Point(64, 359);
            asteroid12.Location = new Point(534, 359);
            asteroid13.Location = new Point(731, 198);
            playerMovement.Enabled = true;
            score = 0;
            bulletRotation = 0;
            asteroidMovement.Enabled = true;
            rotationTimer.Enabled = true;
            bulletTimer.Enabled = true;
            isGameOver = false;
            a = 15;
            b = 47;
            c = 15;
            d = 7;
        }
    }
}
