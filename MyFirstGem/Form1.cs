using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGem
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, shooting, isGameOver;
        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            reseGame();
        }

        private void mainGameTemerEvent(object sender, EventArgs e)
        {
            txtScore.Text = score.ToString();
            enemyOne.Top += enemySpeed;
            enemyTow.Top += enemySpeed;
            enemyThree.Top += enemySpeed;

            // Player movement logic starts
            if(enemyOne.Top > 655 || enemyTow.Top > 655 || enemyThree.Top > 655)
            {
                gameOver();
            }

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if(goRight == true && player.Left < 510)
            {
                player.Left += playerSpeed;
            }
            // Player movement logic ends
            if(shooting== true)
            {
                bulletSpeed = 15;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }
            if(bullet.Top < -20)
            {
                shooting = false;
            }
        }

        private void keyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode== Keys.Right)
            {
                goRight = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Space || shooting == false)
            {
                shooting = true;
                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Left /4);
            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                reseGame(); 
            }
        }
        private void reseGame()
        {
            gameTimer.Start();
            enemySpeed = 4;

            enemyOne.Left = rnd.Next(20, 525);
            enemyTow.Left = rnd.Next(20, 525);
            enemyThree.Left = rnd.Next(20, 525);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTow.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;

            txtScore.Text = score.ToString();
        }
        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + "Game Over!!" + Environment.NewLine + "Press Enter to try again.";

        }
    }
}
