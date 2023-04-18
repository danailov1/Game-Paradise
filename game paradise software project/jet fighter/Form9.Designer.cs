
namespace menu_proba
{
    partial class Form9
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(20, 22);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "0";
            // 
            // bullet
            // 
            this.bullet.Image = global::menu_proba.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(639, 396);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(7, 27);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.Image = global::menu_proba.Properties.Resources.png_transparent_airplane_fighter_aircraft_heavy_bomber_jet_aircraft_fighter_jet_fighter_aircraft_airplane_fictional_character_removebg_preview;
            this.enemyThree.Location = new System.Drawing.Point(576, 57);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(74, 104);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyThree.TabIndex = 2;
            this.enemyThree.TabStop = false;
            // 
            // enemyOne
            // 
            this.enemyOne.Image = global::menu_proba.Properties.Resources.png_transparent_airplane_fighter_aircraft_heavy_bomber_jet_aircraft_fighter_jet_fighter_aircraft_airplane_fictional_character_removebg_preview;
            this.enemyOne.Location = new System.Drawing.Point(109, 57);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(74, 104);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyOne.TabIndex = 2;
            this.enemyOne.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.Image = global::menu_proba.Properties.Resources.png_transparent_airplane_fighter_aircraft_heavy_bomber_jet_aircraft_fighter_jet_fighter_aircraft_airplane_fictional_character_removebg_preview;
            this.enemyTwo.Location = new System.Drawing.Point(342, 57);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(74, 104);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyTwo.TabIndex = 2;
            this.enemyTwo.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::menu_proba.Properties.Resources.plane_preview;
            this.player.Location = new System.Drawing.Point(317, 526);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(774, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(810, 674);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.player);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Button button1;
    }
}