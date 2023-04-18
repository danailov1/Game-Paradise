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
    public partial class Form8 : Form
    {
        bool gameOver = false;
        int Xaxis = 540;
        int Yaxis = -120;
        int Xaxis2 = 240;
        int Yaxis2 = -50;
        int XaxisBird = 80;
        int YaxisBird = 200;
        int YaxisBird2 = 0;
        int score = 0;
        int score2 = 0;
        public Form8()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.Focus();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(564, 601);
            AutoScroll = false;

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            gameOver = false;
            Xaxis -= 2;
            Xaxis2 -= 2;
            pictureBox1.Location = new Point(Xaxis + 90, Yaxis);
            pictureBox2.Location = new Point(Xaxis2 + 90, Yaxis2);
            gornaTruba.Location = new Point(Xaxis, Yaxis);
            dolnaTruba.Location = new Point(Xaxis, Yaxis + 400);
            gornaTruba2.Location = new Point(Xaxis2, Yaxis2);
            dolnaTruba2.Location = new Point(Xaxis2, Yaxis2 + 400);

            if (bird.Bounds.IntersectsWith(pictureBox1.Bounds) || bird.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer1.Enabled = true;
            }
            if (Xaxis == -90)
            {
                Random tubePos = new Random();
                Yaxis = tubePos.Next(-205, -15);
                Xaxis = 540;
            }
            if (Xaxis2 == -90)
            {
                Random tubePos2 = new Random();
                Yaxis2 = tubePos2.Next(-205, -15);
                Xaxis2 = 540;
            }
            if (bird.Bounds.IntersectsWith(dolnaTruba.Bounds) ||
                bird.Bounds.IntersectsWith(dolnaTruba2.Bounds) ||
                bird.Bounds.IntersectsWith(gornaTruba.Bounds) ||
                bird.Bounds.IntersectsWith(gornaTruba2.Bounds) ||
                bird.Bounds.IntersectsWith(zemq.Bounds))
            {
                gameOver = true;
                podskachane.Enabled = false;
                birdMovement.Enabled = false;
                timer1.Enabled = false;
                gameTimer.Enabled = false;
                score = 0;
                label1.Text = "Score: " + score;
                Xaxis = 540;
                Yaxis = -120;
                Xaxis2 = 240;
                Yaxis2 = -50;
                XaxisBird = 80;
                YaxisBird = 200;
                YaxisBird2 = 0;
            }

        }

        private void birdFlyingEvent(object sender, EventArgs e)
        {
            YaxisBird += 2;
            YaxisBird2 = YaxisBird;
            bird.Location = new Point(XaxisBird, YaxisBird);
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && gameOver == false)
            {
                podskachane.Enabled = true;
                birdMovement.Enabled = false;
            }
            if (e.KeyCode == Keys.R && gameOver == true)
            {
                podskachane.Enabled = true;
                birdMovement.Enabled = true;
                gameTimer.Enabled = true;
                gameOver = false;
            }
            if (e.KeyCode == Keys.Space && button1.Focused)
            {
                e.Handled = true;
            }
        }
        private void skachane(object sender, EventArgs e)
        {
            YaxisBird2 -= 2;
            bird.Location = new Point(XaxisBird, YaxisBird2);
            if (YaxisBird2 <= YaxisBird - 55)
            {
                birdMovement.Enabled = true;
                podskachane.Enabled = false;
                YaxisBird = YaxisBird2;
            }
        }

        private void timerEvent(object sender, EventArgs e)
        {
            score2++;
            if (score2 == 4)
            {
                score2 = 0;
                score++;
                label1.Text = "Score: " + score;
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
