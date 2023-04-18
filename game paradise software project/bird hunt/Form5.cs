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
    public partial class Form5 : Form
    {
        public Form5()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form5_KeyDown);
            timer1.Start();
            this.Focus();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(795, 446);
            AutoScroll = false;

            Bitmap bmp = new Bitmap(Properties.Resources.Untitled_removebg_preview__1_);
            Cursor crsr = new Cursor(bmp.GetHicon());
            this.Cursor = crsr;
        }
        int kill, missed;
        bool isGameOver = false;

        void Game_Result()
        {
            if (lbl_missed.Text == "Missed : 5")
            {
                lbl_kill.Text = "Killed: " + kill + " Game over, press R to restart";
                timer1.Stop();
                isGameOver = true;

            }
        }

        void Birds()
        {
            if (p_1.Left < 0)
            {
                p_1.Left = 650;
                p_1.Image = Properties.Resources.yio4gMLBT;
            }
            if (p_2.Left < 0)
            {
                p_2.Left = 650;
                p_2.Image = Properties.Resources.bTypX4rnc;
            }
            if (p_3.Left < 0)
            {
                p_3.Left = 650;
                p_3.Image = Properties.Resources.output_onlinegiftools;
            }
            p_1.Left -= 5;
            p_2.Left -= 5;
            p_3.Left -= 5;
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Birds();
            Game_Result();
        }

        private void p_3_Click(object sender, EventArgs e)
        {
            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_3.Image = Properties.Resources.image_removebg_preview;
        }

        private void p_2_Click(object sender, EventArgs e)
        {

            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_2.Image = Properties.Resources.image_removebg_preview;
        }

        private void p_1_Click(object sender, EventArgs e)
        {

            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_1.Image = Properties.Resources.image_removebg_preview;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            missed++;
            lbl_missed.Text = "Missed : " + missed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                kill = 0;
                missed = 0;
                lbl_kill.Text = "Killed : " + kill;
                lbl_missed.Text = "Missed : " + missed;
                timer1.Start();
                isGameOver = false;
            }
            if (e.KeyCode == Keys.Space && button1.Focused)
            {
                e.Handled = true;
            }
        }
    }
}
