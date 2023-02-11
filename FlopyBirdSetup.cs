using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlopyBirdFRB
{
    public partial class FlopyBirdSetup : Form
    {
        int pSpeed = 8;
        int Gravity = 5;
        int score = 0;





        public FlopyBirdSetup()
        { 

            InitializeComponent();
        }

        private void ScoreTimerrrr(object sender, EventArgs e)
        {
            flopybirdPB.Top += Gravity;
            BottompipePB.Left -= pSpeed;
            TopPipePB.Left -= pSpeed;
            scoreLBL.Text = "Your Score: " + score;
            scoreLBL.Text = score.ToString();

            if (TopPipePB.Left < -150)
            {
                TopPipePB.Left = 800;
                score++;
            }
            if (BottompipePB.Left < -180)
            {
                BottompipePB.Left = 850;
                score++;
            }
            if (score > 5)
            {
                pSpeed = 20;
            }
            if (flopybirdPB.Bounds.IntersectsWith(TopPipePB.Bounds) || flopybirdPB.Bounds.IntersectsWith(BottompipePB.Bounds) || 
                flopybirdPB.Top < -25 || flopybirdPB.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
        }


        private void upkey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                Gravity = 10;
            }
        }

        private void downkey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = -10;
            }
        }
        private void endGame()
        {
            ScoreTimer.Stop();
            scoreLBL.Text = " Game Over!" + score;

        }

     
    }
}
