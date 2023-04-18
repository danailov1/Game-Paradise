using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace menu_proba
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.Focus();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            AutoScroll = false;
            ClientSize = new Size(795, 446);

        }
        public class Feedback
        {
            public string Name { get; set; }
            public string Game { get; set; }
            public string Record { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback()
            {
                Name = textBox1.Text,
                Game = textBox2.Text,
                Record = textBox3.Text
            };

            List<Feedback> feedbackList = new List<Feedback>();
            if (File.Exists("feedback.txt"))
            {
                string[] lines = File.ReadAllLines("feedback.txt");
                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    if (fields.Length == 3)
                    {
                        Feedback f = new Feedback()
                        {
                            Name = fields[0],
                            Game = fields[1],
                            Record = fields[2]
                        };
                        feedbackList.Add(f);
                    }
                }
            }

            feedbackList.Add(feedback);

            using (StreamWriter sw = new StreamWriter("feedback.txt"))
            {
                foreach (Feedback f in feedbackList)
                {
                    sw.WriteLine($"{f.Name},{f.Game},{f.Record}");
                }
            }

            dataGridView1.DataSource = feedbackList;
        }


        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 } 
