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
    public partial class Form13 : Form
    {
        List<Color> colors; 

        Random rnd = new Random(); 

        Random blockPosition = new Random(); 

        int blockColor = 0; 

        int i; 

        int speed = 5;

        int score = 0; 

        bool gameOver = false; 

        int location;
        public Form13()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.Focus();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(800, 600);
            RestartGame();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            foreach (Control x in gameDisplay.Controls)
            {
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "block")
                    {
                        x.Top += speed;


                        if (x.Top + x.Height > this.ClientSize.Height)
                        {

                            location = blockPosition.Next(400, 600) + (3 * blockPosition.Next(150, 250));

                            x.Top = location * -1;

                            blockColor = rnd.Next(colors.Count);

                            x.BackColor = colors[blockColor];

                            score += 1;
                        }

                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                           
                            if (player.BackColor != x.BackColor)
                            {
                                
                                ScoreList.Items.Insert(0, "Scored: " + score + " at" + string.Format(" {0:HH:mm tt}", DateTime.Now));
                               
                                gameTimer.Stop(); 

                                gameOver = true; 
                            }
                        }
                    }
                }
            }

            if (score > 10)
            {
                speed = 12;
            }

        }

        private void RestartGame()
        {
            block1.Top = -200; 
            block2.Top = -750; 
            gameOver = false;

            colors = new List<Color> { Color.Red, Color.White, Color.Purple, Color.Yellow };

            i = 0; 
            gameTimer.Start();
            speed = 8; 
            score = 0;

            txtScore.Text = "Score: " + score;
        }

        private void gameDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Space && gameOver == false)
            {
                i++; 

              
                if (i > colors.Count - 1)
                {
                   
                    i = 0;
                }

                player.BackColor = colors[i];

            }

            if (e.KeyChar == (char)Keys.R || e.KeyChar == char.ToLower((char)Keys.R) && gameOver == true)
            {
                
                RestartGame();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && button1.Focused)
            {
                e.Handled = true;
            }
        }
    }
}
