
namespace menu_proba
{
    partial class Form13
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
            this.gameDisplay = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.ScoreList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.gameDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDisplay
            // 
            this.gameDisplay.BackColor = System.Drawing.Color.Black;
            this.gameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameDisplay.Controls.Add(this.player);
            this.gameDisplay.Controls.Add(this.block1);
            this.gameDisplay.Controls.Add(this.block2);
            this.gameDisplay.Location = new System.Drawing.Point(2, 1);
            this.gameDisplay.Name = "gameDisplay";
            this.gameDisplay.Size = new System.Drawing.Size(460, 608);
            this.gameDisplay.TabIndex = 1;
            this.gameDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.gameDisplay_Paint);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(212, 472);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(47, 31);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Yellow;
            this.block1.Location = new System.Drawing.Point(-33, 85);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(518, 30);
            this.block1.TabIndex = 0;
            this.block1.TabStop = false;
            this.block1.Tag = "block";
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Red;
            this.block2.Location = new System.Drawing.Point(-33, 204);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(518, 30);
            this.block2.TabIndex = 0;
            this.block2.TabStop = false;
            this.block2.Tag = "block";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(567, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(88, 24);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // ScoreList
            // 
            this.ScoreList.Enabled = false;
            this.ScoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreList.FormattingEnabled = true;
            this.ScoreList.ItemHeight = 18;
            this.ScoreList.Location = new System.Drawing.Point(479, 52);
            this.ScoreList.Name = "ScoreList";
            this.ScoreList.Size = new System.Drawing.Size(287, 418);
            this.ScoreList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Press Space key to change colour\r\n\r\nPress R to restart game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(742, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreList);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.gameDisplay);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.down);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPressed);
            this.gameDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameDisplay;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.ListBox ScoreList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button button1;
    }
}