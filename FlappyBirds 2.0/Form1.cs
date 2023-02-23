using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvents(object sender, EventArgs e)
        {
            flappybirds.Top += gravity;
            pipeButton.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = score.ToString();
            if(pipeButton.Left < -150)
            {
                pipeButton.Left = 900;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if(flappybirds.Bounds.IntersectsWith(pipeButton.Bounds) || flappybirds.Bounds.IntersectsWith(pipeTop.Bounds)
                || flappybirds.Bounds.IntersectsWith(ground.Bounds) || flappybirds.Top < -25)
            {
                endGame();
            }
            if(score>5)
            {
                pipeSpeed = 15; 
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8  ;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "Game Over!";
        }
    }
}
