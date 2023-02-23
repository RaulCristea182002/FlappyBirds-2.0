namespace RacingGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeButton = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappybirds = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybirds)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.Location = new System.Drawing.Point(1, 327);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(799, 125);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // pipeButton
            // 
            this.pipeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeButton.BackgroundImage")));
            this.pipeButton.Location = new System.Drawing.Point(485, 213);
            this.pipeButton.Name = "pipeButton";
            this.pipeButton.Size = new System.Drawing.Size(47, 118);
            this.pipeButton.TabIndex = 1;
            this.pipeButton.TabStop = false;
            this.pipeButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pipeTop
            // 
            this.pipeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeTop.BackgroundImage")));
            this.pipeTop.Location = new System.Drawing.Point(625, 0);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(45, 112);
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // flappybirds
            // 
            this.flappybirds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flappybirds.BackgroundImage")));
            this.flappybirds.Location = new System.Drawing.Point(70, 167);
            this.flappybirds.Name = "flappybirds";
            this.flappybirds.Size = new System.Drawing.Size(46, 36);
            this.flappybirds.TabIndex = 3;
            this.flappybirds.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(101, 42);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(71, 13);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvents);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.flappybirds);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeButton);
            this.Controls.Add(this.ground);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "FlappyBirdsGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybirds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeButton;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox flappybirds;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

