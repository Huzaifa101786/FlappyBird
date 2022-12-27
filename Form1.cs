using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlappyBird
{
    public partial class FlappyBird : Form
    {
        int pipespeed = 7;
        int gravity = 5;
        int score = 0;

        public FlappyBird()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipe_down.Left-= pipespeed;
            pipe_up.Left-= pipespeed;
            Score.Text = "Score: "+score.ToString();
            
            if(pipe_down.Left < -150)
            {
                pipe_down.Left = 600;
                score++;
            }

            if (pipe_up.Left < -100)
            {
                pipe_up.Left = 850;
                score++;
            }
            if (bird.Bounds.IntersectsWith(pipe_down.Bounds) || bird.Bounds.IntersectsWith(pipe_up.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endgame();  
                
            }
        }
        private void endgame()
        {
            game_timer.Stop();
            
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity= -7;
            }

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 7 ;
            }
        }
    }
}
