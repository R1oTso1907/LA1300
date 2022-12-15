using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VegeterianRun : Form
    {
        
        bool jump;

        int gravity = 20;
        int force;
        int obstaclespeed = 2;
        int score = 0;
        int playerspeed = 5; 


        public VegeterianRun()
        {
            InitializeComponent();
            Menu.Hide();

        }

        private void gameKeydown(object sender, KeyEventArgs e)
        {
            

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = gravity;
                }
            }
        }

        private void gameKeyup(object sender, KeyEventArgs e)
        {
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            obsticale.Left -= obstaclespeed;
            obsticaleAir.Left -= obstaclespeed;
            Player.Left += playerspeed;

            ScoreCounter.Text = "Score: " + score;
            if(obsticaleAir.Left < -10)
            {
                obsticaleAir.Left = 700;
            }

            if(obsticale.Left == 350)
            {
                score++;
            }

            if (obsticale.Left < -10)
            {
                obsticale.Left = 700;
                score++;

                if (score > 5)
                {
                    playerspeed++;
                }
            }

            if (Player.Left > 600)
            {
                Player.Location = new Point(49, 382);
            }
            
            if (jump == true)
            {
                Player.Top -= force;
                force -= 1;
            }

            if (Player.Top + Player.Height >= gameArea.Height)
            {
                Player.Top = gameArea.Height - Player.Height;
                jump = false;
            }
            else
            {
                Player.Top += 5;
            }


            if (Player.Bounds.IntersectsWith(obsticale.Bounds))
            {
                if(obsticale.Left < 100 || obsticale.Left > 500)
                {

                }
                else
                {
                    gameOver();
                }
            }
            if (Player.Bounds.IntersectsWith(obsticaleAir.Bounds))
            {
                if (obsticaleAir.Left < 100 || obsticaleAir.Left > 500)
                {

                }
                else
                {
                    gameOver();
                }
            }
        }
        
       


        private void gameOver()
        {
            gameTimer.Stop();
            Menu.Show();
            Player.Location = new Point(49, 382);
            obsticaleAir.Location = new Point(400, 205);
            obsticale.Location = new Point(600, 305);
        }


        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            score = 0;
            obstaclespeed = 3;
            Menu.Hide();
            gameTimer.Start();
        }
    }
}
