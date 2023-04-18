
namespace menu_proba
{
    partial class Form4
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
            this.txtScore = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 21);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(94, 24);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score:0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::menu_proba.Properties.Resources.yellowBalloon;
            this.pictureBox5.Location = new System.Drawing.Point(452, 165);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(111, 116);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "balloon";
            this.pictureBox5.Click += new System.EventHandler(this.PopBallon);
            // 
            // bomb
            // 
            this.bomb.Image = global::menu_proba.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(65, 461);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(100, 98);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bomb.TabIndex = 1;
            this.bomb.TabStop = false;
            this.bomb.Click += new System.EventHandler(this.GoBoom);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::menu_proba.Properties.Resources.redHeart;
            this.pictureBox3.Location = new System.Drawing.Point(323, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "balloon";
            this.pictureBox3.Click += new System.EventHandler(this.PopBallon);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::menu_proba.Properties.Resources.redStar;
            this.pictureBox2.Location = new System.Drawing.Point(180, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "balloon";
            this.pictureBox2.Click += new System.EventHandler(this.PopBallon);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::menu_proba.Properties.Resources.pinkBalloon;
            this.pictureBox1.Location = new System.Drawing.Point(31, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "balloon";
            this.pictureBox1.Click += new System.EventHandler(this.PopBallon);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(615, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(651, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button button1;
    }
}