
namespace menu_proba
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cloud = new System.Windows.Forms.PictureBox();
            this.clouds = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(28, 26);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(94, 24);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score:0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 44);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // trex
            // 
            this.trex.Image = global::menu_proba.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(131, 365);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 2;
            this.trex.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::menu_proba.Properties.Resources.obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(494, 362);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::menu_proba.Properties.Resources.obstacle_2;
            this.pictureBox4.Location = new System.Drawing.Point(659, 375);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // cloud
            // 
            this.cloud.Image = global::menu_proba.Properties.Resources.ezgif_com_gif_maker;
            this.cloud.Location = new System.Drawing.Point(160, 66);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(117, 76);
            this.cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud.TabIndex = 3;
            this.cloud.TabStop = false;
            // 
            // clouds
            // 
            this.clouds.Image = global::menu_proba.Properties.Resources.ezgif_com_gif_maker;
            this.clouds.Location = new System.Drawing.Point(476, 106);
            this.clouds.Name = "clouds";
            this.clouds.Size = new System.Drawing.Size(89, 53);
            this.clouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds.TabIndex = 3;
            this.clouds.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(764, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clouds);
            this.Controls.Add(this.cloud);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtScore);
            this.Name = "Form2";
            this.Text = "Dino Run";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox cloud;
        private System.Windows.Forms.PictureBox clouds;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button button1;
    }
}