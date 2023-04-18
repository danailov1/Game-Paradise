
namespace menu_proba
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.asteroid12 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.playerMovement = new System.Windows.Forms.Timer(this.components);
            this.asteroidMovement = new System.Windows.Forms.Timer(this.components);
            this.rotationTimer = new System.Windows.Forms.Timer(this.components);
            this.bulletTimer = new System.Windows.Forms.Timer(this.components);
            this.bullet = new System.Windows.Forms.PictureBox();
            this.asteroid13 = new System.Windows.Forms.PictureBox();
            this.asteroid11 = new System.Windows.Forms.PictureBox();
            this.asteroid10 = new System.Windows.Forms.PictureBox();
            this.asteroid9 = new System.Windows.Forms.PictureBox();
            this.asteroid8 = new System.Windows.Forms.PictureBox();
            this.asteroid3 = new System.Windows.Forms.PictureBox();
            this.asteroid4 = new System.Windows.Forms.PictureBox();
            this.asteroid5 = new System.Windows.Forms.PictureBox();
            this.asteroid2 = new System.Windows.Forms.PictureBox();
            this.asteroid6 = new System.Windows.Forms.PictureBox();
            this.asteroid7 = new System.Windows.Forms.PictureBox();
            this.asteroid1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid1)).BeginInit();
            this.SuspendLayout();
            // 
            // asteroid12
            // 
            this.asteroid12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid12.BackgroundImage")));
            this.asteroid12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid12.Location = new System.Drawing.Point(534, 359);
            this.asteroid12.Name = "asteroid12";
            this.asteroid12.Size = new System.Drawing.Size(58, 42);
            this.asteroid12.TabIndex = 27;
            this.asteroid12.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(377, 212);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(19, 45);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 28;
            this.player.TabStop = false;
            // 
            // playerMovement
            // 
            this.playerMovement.Enabled = true;
            this.playerMovement.Interval = 1;
            this.playerMovement.Tick += new System.EventHandler(this.playerMovementEvent);
            // 
            // asteroidMovement
            // 
            this.asteroidMovement.Enabled = true;
            this.asteroidMovement.Interval = 35;
            this.asteroidMovement.Tick += new System.EventHandler(this.asteroidMovement_Tick);
            // 
            // rotationTimer
            // 
            this.rotationTimer.Enabled = true;
            this.rotationTimer.Interval = 125;
            this.rotationTimer.Tick += new System.EventHandler(this.rotationEvent);
            // 
            // bulletTimer
            // 
            this.bulletTimer.Interval = 1;
            this.bulletTimer.Tick += new System.EventHandler(this.bulletTimer_Tick);
            // 
            // bullet
            // 
            this.bullet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bullet.BackgroundImage")));
            this.bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bullet.Image = ((System.Drawing.Image)(resources.GetObject("bullet.Image")));
            this.bullet.Location = new System.Drawing.Point(316, 154);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(7, 7);
            this.bullet.TabIndex = 29;
            this.bullet.TabStop = false;
            this.bullet.Visible = false;
            // 
            // asteroid13
            // 
            this.asteroid13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid13.BackgroundImage")));
            this.asteroid13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid13.Location = new System.Drawing.Point(710, 196);
            this.asteroid13.Name = "asteroid13";
            this.asteroid13.Size = new System.Drawing.Size(48, 42);
            this.asteroid13.TabIndex = 41;
            this.asteroid13.TabStop = false;
            // 
            // asteroid11
            // 
            this.asteroid11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid11.BackgroundImage")));
            this.asteroid11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid11.Location = new System.Drawing.Point(43, 357);
            this.asteroid11.Name = "asteroid11";
            this.asteroid11.Size = new System.Drawing.Size(36, 30);
            this.asteroid11.TabIndex = 40;
            this.asteroid11.TabStop = false;
            // 
            // asteroid10
            // 
            this.asteroid10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid10.BackgroundImage")));
            this.asteroid10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid10.Location = new System.Drawing.Point(98, 221);
            this.asteroid10.Name = "asteroid10";
            this.asteroid10.Size = new System.Drawing.Size(43, 34);
            this.asteroid10.TabIndex = 39;
            this.asteroid10.TabStop = false;
            // 
            // asteroid9
            // 
            this.asteroid9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid9.BackgroundImage")));
            this.asteroid9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid9.Location = new System.Drawing.Point(532, 245);
            this.asteroid9.Name = "asteroid9";
            this.asteroid9.Size = new System.Drawing.Size(39, 25);
            this.asteroid9.TabIndex = 38;
            this.asteroid9.TabStop = false;
            // 
            // asteroid8
            // 
            this.asteroid8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid8.BackgroundImage")));
            this.asteroid8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid8.Location = new System.Drawing.Point(199, 345);
            this.asteroid8.Name = "asteroid8";
            this.asteroid8.Size = new System.Drawing.Size(45, 42);
            this.asteroid8.TabIndex = 37;
            this.asteroid8.TabStop = false;
            // 
            // asteroid3
            // 
            this.asteroid3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid3.BackgroundImage")));
            this.asteroid3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid3.Location = new System.Drawing.Point(513, 28);
            this.asteroid3.Name = "asteroid3";
            this.asteroid3.Size = new System.Drawing.Size(34, 31);
            this.asteroid3.TabIndex = 36;
            this.asteroid3.TabStop = false;
            // 
            // asteroid4
            // 
            this.asteroid4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid4.BackgroundImage")));
            this.asteroid4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid4.Location = new System.Drawing.Point(452, 92);
            this.asteroid4.Name = "asteroid4";
            this.asteroid4.Size = new System.Drawing.Size(58, 42);
            this.asteroid4.TabIndex = 35;
            this.asteroid4.TabStop = false;
            // 
            // asteroid5
            // 
            this.asteroid5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid5.BackgroundImage")));
            this.asteroid5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid5.Location = new System.Drawing.Point(636, 92);
            this.asteroid5.Name = "asteroid5";
            this.asteroid5.Size = new System.Drawing.Size(34, 32);
            this.asteroid5.TabIndex = 34;
            this.asteroid5.TabStop = false;
            // 
            // asteroid2
            // 
            this.asteroid2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid2.BackgroundImage")));
            this.asteroid2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid2.Location = new System.Drawing.Point(238, 28);
            this.asteroid2.Name = "asteroid2";
            this.asteroid2.Size = new System.Drawing.Size(51, 34);
            this.asteroid2.TabIndex = 33;
            this.asteroid2.TabStop = false;
            // 
            // asteroid6
            // 
            this.asteroid6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid6.BackgroundImage")));
            this.asteroid6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid6.Location = new System.Drawing.Point(663, 318);
            this.asteroid6.Name = "asteroid6";
            this.asteroid6.Size = new System.Drawing.Size(49, 42);
            this.asteroid6.TabIndex = 32;
            this.asteroid6.TabStop = false;
            // 
            // asteroid7
            // 
            this.asteroid7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid7.BackgroundImage")));
            this.asteroid7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid7.Location = new System.Drawing.Point(356, 395);
            this.asteroid7.Name = "asteroid7";
            this.asteroid7.Size = new System.Drawing.Size(43, 28);
            this.asteroid7.TabIndex = 31;
            this.asteroid7.TabStop = false;
            // 
            // asteroid1
            // 
            this.asteroid1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asteroid1.BackgroundImage")));
            this.asteroid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.asteroid1.Location = new System.Drawing.Point(67, 53);
            this.asteroid1.Name = "asteroid1";
            this.asteroid1.Size = new System.Drawing.Size(54, 45);
            this.asteroid1.TabIndex = 30;
            this.asteroid1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "score: 0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(783, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 43;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(819, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asteroid13);
            this.Controls.Add(this.asteroid11);
            this.Controls.Add(this.asteroid10);
            this.Controls.Add(this.asteroid9);
            this.Controls.Add(this.asteroid8);
            this.Controls.Add(this.asteroid3);
            this.Controls.Add(this.asteroid4);
            this.Controls.Add(this.asteroid5);
            this.Controls.Add(this.asteroid2);
            this.Controls.Add(this.asteroid6);
            this.Controls.Add(this.asteroid7);
            this.Controls.Add(this.asteroid1);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.player);
            this.Controls.Add(this.asteroid12);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.asteroid12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox asteroid12;
        public System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer playerMovement;
        private System.Windows.Forms.Timer asteroidMovement;
        private System.Windows.Forms.Timer rotationTimer;
        private System.Windows.Forms.Timer bulletTimer;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox asteroid13;
        private System.Windows.Forms.PictureBox asteroid11;
        private System.Windows.Forms.PictureBox asteroid10;
        private System.Windows.Forms.PictureBox asteroid9;
        public System.Windows.Forms.PictureBox asteroid8;
        private System.Windows.Forms.PictureBox asteroid3;
        private System.Windows.Forms.PictureBox asteroid4;
        private System.Windows.Forms.PictureBox asteroid5;
        private System.Windows.Forms.PictureBox asteroid2;
        private System.Windows.Forms.PictureBox asteroid6;
        private System.Windows.Forms.PictureBox asteroid7;
        private System.Windows.Forms.PictureBox asteroid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}