
namespace menu_proba
{
    partial class Form11
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
            this.gameTImer = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtScore.Location = new System.Drawing.Point(12, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(106, 24);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTImer
            // 
            this.gameTImer.Interval = 20;
            this.gameTImer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Yellow;
            this.ball.Location = new System.Drawing.Point(377, 297);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 23);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(347, 492);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 32);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(773, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(809, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTImer;
        private System.Windows.Forms.Button button1;
    }
}