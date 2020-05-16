namespace PacManLv
{
    partial class Game
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
            this.Klucis = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.TimerKlucisMove = new System.Windows.Forms.Timer(this.components);
            this.TimerKlucisAnimate = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimerEnemyAnimate = new System.Windows.Forms.Timer(this.components);
            this.TimerKlucisMelt = new System.Windows.Forms.Timer(this.components);
            this.TimerEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Klucis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // Klucis
            // 
            this.Klucis.BackColor = System.Drawing.Color.Lime;
            this.Klucis.Location = new System.Drawing.Point(133, 68);
            this.Klucis.Name = "Klucis";
            this.Klucis.Size = new System.Drawing.Size(100, 100);
            this.Klucis.TabIndex = 0;
            this.Klucis.TabStop = false;
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.Red;
            this.Food.Location = new System.Drawing.Point(377, 138);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(30, 30);
            this.Food.TabIndex = 1;
            this.Food.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Fuchsia;
            this.Enemy.Location = new System.Drawing.Point(554, 138);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(50, 50);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            // 
            // TimerKlucisMove
            // 
            this.TimerKlucisMove.Interval = 20;
            this.TimerKlucisMove.Tick += new System.EventHandler(this.TimerKlucisMove_Tick);
            // 
            // TimerKlucisAnimate
            // 
            this.TimerKlucisAnimate.Tick += new System.EventHandler(this.TimerKlucisAnimate_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(72, 30);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "Score";
            // 
            // TimerEnemyAnimate
            // 
            this.TimerEnemyAnimate.Tick += new System.EventHandler(this.TimerEnemyAnimate_Tick);
            // 
            // TimerKlucisMelt
            // 
            this.TimerKlucisMelt.Tick += new System.EventHandler(this.TimerKlucisMelt_Tick);
            // 
            // TimerEnemyMove
            // 
            this.TimerEnemyMove.Interval = 20;
            this.TimerEnemyMove.Tick += new System.EventHandler(this.TimerEnemyMove_Tick);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.GameOverLabel.Location = new System.Drawing.Point(288, 93);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(260, 59);
            this.GameOverLabel.TabIndex = 4;
            this.GameOverLabel.Text = "Game Over";
            this.GameOverLabel.Visible = false;
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RestartButton.Location = new System.Drawing.Point(612, 207);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(150, 50);
            this.RestartButton.TabIndex = 5;
            this.RestartButton.Text = "RESTART";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Klucis);
            this.Name = "Game";
            this.Text = "7";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Klucis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Klucis;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer TimerKlucisMove;
        private System.Windows.Forms.Timer TimerKlucisAnimate;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer TimerEnemyAnimate;
        private System.Windows.Forms.Timer TimerKlucisMelt;
        private System.Windows.Forms.Timer TimerEnemyMove;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Button RestartButton;
    }
}

