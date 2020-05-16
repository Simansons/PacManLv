using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManLv
{
    public partial class Game : Form
    {
        int klucisStep = 5;
        int enemyStep = 3;
        int verVelocity = 0;
        int horVelocity = 0;
        int klucisImage = 1;
        int enemyImage = 1;
        int score = 0;
        int verEnemyVelocity = 0;
        int horEnemyVelocity = 0;
        string klucisDirection = "right";
        string enemyDirection = "down";
        Random Rand = new Random();

        public Game()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetRandomEnemyDirection()
        {
            int directionCode = Rand.Next(1, 5);
            if (directionCode == 1)
            {
                enemyDirection = "right";
                verEnemyVelocity = 0;
                horEnemyVelocity = enemyStep;
            }
            else if (directionCode == 2)
            {
                enemyDirection = "down";
                verEnemyVelocity = enemyStep;
                horEnemyVelocity = 0;
            }
            else if (directionCode == 3)
            {
                enemyDirection = "left";
                verEnemyVelocity = 0;
                horEnemyVelocity = -enemyStep;

            }
            else if (directionCode == 4)
            {
                enemyDirection = "up";
                verEnemyVelocity = -enemyStep;
                horEnemyVelocity = 0;
            }
        }

        private void SetupGame()
        {
            Klucis.BackColor = Color.Transparent;
            Klucis.SizeMode = PictureBoxSizeMode.StretchImage;
            Klucis.Width = 50;
            Klucis.Height = 50;
            Food.BackColor = Color.Green;
            Food.BackColor = Color.Transparent;
            Food.Image = Properties.Resources.food_3;
            Food.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy.BackColor = Color.Transparent;
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy.Width = 40;
            Enemy.Height = 40;
            this.BackColor = Color.Blue;

            SetRandomEnemyDirection();

            UpdateScoreLabel();

            //initializing timers
            TimerKlucisMove.Start();
            TimerKlucisAnimate.Start();
            TimerEnemyAnimate.Start();
            TimerEnemyMove.Start();
            
        }

        private void KlucisFoodCollision()
        {
            if (Klucis.Bounds.IntersectsWith(Food.Bounds))
            {
                score += 100;
                RandomizeFood();
                UpdateScoreLabel();
            }
        }

        private void UpdateScoreLabel()
        {
            ScoreLabel.Text = "Score: " + score;
        }

        private void RandomizeFood()
        {
            Food.Top = Rand.Next(0, ClientRectangle.Height - Food.Height);
            Food.Left = Rand.Next(0, ClientRectangle.Width - Food.Width);
            Food.Image = (Image)Properties.Resources.ResourceManager.GetObject("food_" + Rand.Next(1, 5));           
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {                
                verVelocity = -klucisStep;
                horVelocity = 0;
                klucisDirection = "up";
            }
            if (e.KeyCode == Keys.Down)
            {
                verVelocity = klucisStep;
                horVelocity = 0;
                klucisDirection = "down";
            }
            if (e.KeyCode == Keys.Left)
            {
                verVelocity = 0;
                horVelocity = -klucisStep;
                klucisDirection = "left";
            }
            if (e.KeyCode == Keys.Right)
            {
                verVelocity = 0;
                horVelocity = klucisStep;
                klucisDirection = "right";
            }
            SetRandomEnemyDirection();
        }

        private void KlucisBorderCollision()
        {
            if (Klucis.Top + Klucis.Height < 0)
            {
                Klucis.Top = ClientRectangle.Height;
            }
            if (Klucis.Top > ClientRectangle.Height)
            {
                Klucis.Top = 0 - Klucis.Height;
            }
            if (Klucis.Left + Klucis.Width < 0)
            {
                Klucis.Left = ClientRectangle.Width;
            }
            if (Klucis.Left > ClientRectangle.Width)
            {
                Klucis.Left = 0 - Klucis.Width;
            }
        }

        private void EnemyBorderColision()
        {
            if (Enemy.Top < 0)
            {
                verEnemyVelocity = enemyStep;
            }
            if (Enemy.Top > ClientRectangle.Height - Enemy.Height)
            {
                verEnemyVelocity = -enemyStep;
            }
            if (Enemy.Left < 0)
            {
                horEnemyVelocity = enemyStep;
            }
            if (Enemy.Left > ClientRectangle.Width - Enemy.Width)
            {
                horEnemyVelocity = -enemyStep;
            }
        }

        private void KlucisEnemyCollision()
        {
            if (Klucis.Bounds.IntersectsWith(Enemy.Bounds))
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            TimerKlucisMove.Stop();
            TimerKlucisAnimate.Stop();
            TimerEnemyAnimate.Stop();
            TimerEnemyMove.Stop();
            Enemy.Visible = false;
            Food.Visible = false;
            klucisImage = 0;
            TimerKlucisMelt.Start();
        }

        private void TimerKlucisMove_Tick(object sender, EventArgs e)
        {
            Klucis.Top += verVelocity;
            Klucis.Left += horVelocity;
            KlucisBorderCollision();
            KlucisFoodCollision();
            KlucisEnemyCollision();
        }

        private void TimerKlucisAnimate_Tick(object sender, EventArgs e)
        {
            string klucisImageName;
            klucisImageName = "pacman_" + klucisDirection + "_" + klucisImage;
            Klucis.Image = (Image)Properties.Resources.ResourceManager.GetObject(klucisImageName);
            klucisImage += 1;
            if (klucisImage > 4)
            {
                klucisImage = 1;
            }
        }

        private void TimerEnemyAnimate_Tick(object sender, EventArgs e)
        {
            string enemyImageName;
            enemyImageName = "enemy_" + enemyDirection + "_" + enemyImage;
            Enemy.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemyImageName);
            enemyImage += 1;
            if (enemyImage > 2)
            {
                enemyImage = 1;
            }
        }

        private void TimerKlucisMelt_Tick(object sender, EventArgs e)
        {
            string klucisImageName;
            klucisImageName = "pacman_melt_" + klucisImage;
            Klucis.Image = (Image)Properties.Resources.ResourceManager.GetObject(klucisImageName);
            klucisImage += 1;
            if (klucisImage > 14)
            {
                TimerKlucisMelt.Stop();
                GameOverLabel.Visible = true;
                RestartButton.Visible = true;                
            }
        }

        private void TimerEnemyMove_Tick(object sender, EventArgs e)
        {
            Enemy.Top += verEnemyVelocity;
            Enemy.Left += horEnemyVelocity;
            EnemyBorderColision();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
