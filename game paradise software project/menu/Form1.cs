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
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.MdiParent = this;
            newForm.Show();
            newForm.FormClosed += help_FormClosed;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Form3();
            newForm.MdiParent = this;
            newForm.Show();
            newForm.FormClosed += help_FormClosed;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(634, 504);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Form4();
            newForm.MdiParent = this;
            newForm.Show();
            newForm.FormClosed += help_FormClosed;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            ClientSize = new Size(654, 654);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Form5();
            newForm.MdiParent = this;
            newForm.Show();
            newForm.FormClosed += help_FormClosed;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new Form6();
            newForm.MdiParent = this;
            newForm.Show();
            newForm.FormClosed += help_FormClosed;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(799, 264);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newForm = new Form7();
            newForm.MdiParent = this;
            newForm.Show();
            newForm.FormClosed += help_FormClosed;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(664, 764);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new Form8();
            newForm.MdiParent = this;
            newForm.Show();
            newForm.FormClosed += help_FormClosed;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(568, 605);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new Form9();
            newForm.MdiParent = this;
            newForm.FormClosed += help_FormClosed;

            newForm.Show();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(820, 717);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var newForm = new Form10();
            newForm.MdiParent = this;
            newForm.FormClosed += help_FormClosed;

            newForm.Show();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(824, 494);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var newForm = new Form11();
            newForm.MdiParent = this;
            newForm.FormClosed += help_FormClosed;

            newForm.Show();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(816, 545);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var newForm = new Form12();
            newForm.MdiParent = this;
            newForm.FormClosed += help_FormClosed;

            newForm.Show();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(630, 710);

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var newForm = new Form13();
            newForm.MdiParent = this;
            newForm.FormClosed += help_FormClosed;

            newForm.Show();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(804, 604);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var newForm = new Form14();
            newForm.MdiParent = this;
            newForm.FormClosed += help_FormClosed;

            newForm.Show();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            ClientSize = new Size(799, 450);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            var newForm = new Form1();
            newForm.MdiParent = this;
            newForm.Show();
            newForm.FormClosed += help_FormClosed;


            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
        }

        private void help_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            ClientSize = new Size(799, 450);

        }
    }
}
