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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
