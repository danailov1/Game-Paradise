
namespace menu_proba
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_1 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_3 = new System.Windows.Forms.PictureBox();
            this.lbl_kill = new System.Windows.Forms.Label();
            this.lbl_missed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Image = global::menu_proba.Properties.Resources.Untitled_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-54, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(892, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // p_1
            // 
            this.p_1.Image = global::menu_proba.Properties.Resources.yio4gMLBT;
            this.p_1.Location = new System.Drawing.Point(73, 174);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(116, 99);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_1.TabIndex = 1;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.p_1_Click);
            // 
            // p_2
            // 
            this.p_2.Image = global::menu_proba.Properties.Resources.output_onlinegiftools;
            this.p_2.Location = new System.Drawing.Point(331, 73);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(116, 99);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_2.TabIndex = 2;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.p_2_Click);
            // 
            // p_3
            // 
            this.p_3.Image = global::menu_proba.Properties.Resources.bTypX4rnc;
            this.p_3.Location = new System.Drawing.Point(533, 174);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(116, 99);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_3.TabIndex = 3;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.p_3_Click);
            // 
            // lbl_kill
            // 
            this.lbl_kill.AutoSize = true;
            this.lbl_kill.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kill.Location = new System.Drawing.Point(3, 9);
            this.lbl_kill.Name = "lbl_kill";
            this.lbl_kill.Size = new System.Drawing.Size(118, 24);
            this.lbl_kill.TabIndex = 5;
            this.lbl_kill.Text = "Killed: 0";
            // 
            // lbl_missed
            // 
            this.lbl_missed.AutoSize = true;
            this.lbl_missed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_missed.Location = new System.Drawing.Point(3, 48);
            this.lbl_missed.Name = "lbl_missed";
            this.lbl_missed.Size = new System.Drawing.Size(118, 24);
            this.lbl_missed.TabIndex = 6;
            this.lbl_missed.Text = "Missed: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(764, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_missed);
            this.Controls.Add(this.lbl_kill);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox p_1;
        private System.Windows.Forms.PictureBox p_2;
        private System.Windows.Forms.PictureBox p_3;
        private System.Windows.Forms.Label lbl_kill;
        private System.Windows.Forms.Label lbl_missed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}