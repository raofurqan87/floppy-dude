using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floppy_Dude
{
    public partial class Form1 : Form
    {

        int brickSpeed = 5;
        int gravity = 3;
        int score = 0;
        Button restartButton = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restartButton.Text = "Restart";
            restartButton.Size = new Size(100, 40);
            restartButton.Location = new Point(300, 300);
            restartButton.Visible = false;
            restartButton.Click += new EventHandler(restartGame);
            this.Controls.Add(restartButton);
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            floppyDude.Top += gravity;
            brick1.Left -= brickSpeed;
            brick2.Left -= brickSpeed;
            brick3.Left -= brickSpeed;
            scoreLabel.Text = "Score: " + score;

            if (brick1.Left < -150)
            {
                brick1.Left = 800;
                score++;
            }
            if (brick2.Left < -180)
            {
                brick2.Left = 800;
                score++;
            }
            if (brick3.Left < -180)
            {
                brick3.Left = 950;
                score++;
            }
            if (floppyDude.Bounds.IntersectsWith(brick1.Bounds) || floppyDude.Bounds.IntersectsWith(brick2.Bounds) || floppyDude.Bounds.IntersectsWith(brick3.Bounds) || floppyDude.Bounds.IntersectsWith(skyCloud.Bounds) || floppyDude.Bounds.IntersectsWith(groundGrass.Bounds) || floppyDude.Top < -25)
            {
                endGame();
            }
            if (score > 5)
            {
                brickSpeed = 10;
            }
        }

        private void gameKeyisUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameKeyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }
        private void restartGame(object sender, EventArgs e)
        {
            gameTimer.Stop();
            score = 0;
            brickSpeed = 5;
            gravity = 3;
            floppyDude.Top = 200;
            floppyDude.Left = 100;
            brick1.Left = 800;
            brick2.Left = 950;
            brick3.Left = 1100;
            restartButton.Visible = false;
            gameTimer.Start();
            this.Focus();
        }
        private void endGame()
        {
            gameTimer.Stop();
            restartButton.Visible = true;
        }
    }
}
