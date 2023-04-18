
namespace menu_proba
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.gornaTruba = new System.Windows.Forms.PictureBox();
            this.dolnaTruba2 = new System.Windows.Forms.PictureBox();
            this.gornaTruba2 = new System.Windows.Forms.PictureBox();
            this.dolnaTruba = new System.Windows.Forms.PictureBox();
            this.zemq = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.birdMovement = new System.Windows.Forms.Timer(this.components);
            this.podskachane = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gornaTruba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolnaTruba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gornaTruba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolnaTruba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemq)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(258, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 534);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(308, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 523);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bird.BackgroundImage")));
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Location = new System.Drawing.Point(80, 200);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(48, 42);
            this.bird.TabIndex = 15;
            this.bird.TabStop = false;
            // 
            // gornaTruba
            // 
            this.gornaTruba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gornaTruba.BackgroundImage")));
            this.gornaTruba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gornaTruba.Location = new System.Drawing.Point(145, 105);
            this.gornaTruba.Name = "gornaTruba";
            this.gornaTruba.Size = new System.Drawing.Size(78, 264);
            this.gornaTruba.TabIndex = 16;
            this.gornaTruba.TabStop = false;
            // 
            // dolnaTruba2
            // 
            this.dolnaTruba2.BackColor = System.Drawing.Color.Transparent;
            this.dolnaTruba2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dolnaTruba2.BackgroundImage")));
            this.dolnaTruba2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dolnaTruba2.Location = new System.Drawing.Point(324, 140);
            this.dolnaTruba2.Name = "dolnaTruba2";
            this.dolnaTruba2.Size = new System.Drawing.Size(78, 264);
            this.dolnaTruba2.TabIndex = 17;
            this.dolnaTruba2.TabStop = false;
            // 
            // gornaTruba2
            // 
            this.gornaTruba2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gornaTruba2.BackgroundImage")));
            this.gornaTruba2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gornaTruba2.Location = new System.Drawing.Point(408, 140);
            this.gornaTruba2.Name = "gornaTruba2";
            this.gornaTruba2.Size = new System.Drawing.Size(78, 264);
            this.gornaTruba2.TabIndex = 18;
            this.gornaTruba2.TabStop = false;
            // 
            // dolnaTruba
            // 
            this.dolnaTruba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dolnaTruba.BackgroundImage")));
            this.dolnaTruba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dolnaTruba.Location = new System.Drawing.Point(492, 140);
            this.dolnaTruba.Name = "dolnaTruba";
            this.dolnaTruba.Size = new System.Drawing.Size(78, 264);
            this.dolnaTruba.TabIndex = 19;
            this.dolnaTruba.TabStop = false;
            // 
            // zemq
            // 
            this.zemq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zemq.BackgroundImage")));
            this.zemq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zemq.Location = new System.Drawing.Point(-7, 473);
            this.zemq.Name = "zemq";
            this.zemq.Size = new System.Drawing.Size(652, 134);
            this.zemq.TabIndex = 20;
            this.zemq.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // birdMovement
            // 
            this.birdMovement.Enabled = true;
            this.birdMovement.Interval = 1;
            this.birdMovement.Tick += new System.EventHandler(this.birdFlyingEvent);
            // 
            // podskachane
            // 
            this.podskachane.Interval = 1;
            this.podskachane.Tick += new System.EventHandler(this.skachane);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Score:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(524, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(560, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zemq);
            this.Controls.Add(this.dolnaTruba);
            this.Controls.Add(this.gornaTruba2);
            this.Controls.Add(this.dolnaTruba2);
            this.Controls.Add(this.gornaTruba);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gornaTruba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolnaTruba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gornaTruba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolnaTruba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox gornaTruba;
        private System.Windows.Forms.PictureBox dolnaTruba2;
        private System.Windows.Forms.PictureBox gornaTruba2;
        private System.Windows.Forms.PictureBox dolnaTruba;
        private System.Windows.Forms.PictureBox zemq;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer birdMovement;
        private System.Windows.Forms.Timer podskachane;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}