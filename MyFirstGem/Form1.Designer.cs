namespace MyFirstGem
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTow = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Transparent;
            this.enemyOne.Image = ((System.Drawing.Image)(resources.GetObject("enemyOne.Image")));
            this.enemyOne.Location = new System.Drawing.Point(37, 35);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(100, 85);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // enemyTow
            // 
            this.enemyTow.BackColor = System.Drawing.Color.Transparent;
            this.enemyTow.Image = ((System.Drawing.Image)(resources.GetObject("enemyTow.Image")));
            this.enemyTow.Location = new System.Drawing.Point(266, 35);
            this.enemyTow.Name = "enemyTow";
            this.enemyTow.Size = new System.Drawing.Size(100, 85);
            this.enemyTow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemyTow.TabIndex = 0;
            this.enemyTow.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.BackColor = System.Drawing.Color.Transparent;
            this.enemyThree.Image = ((System.Drawing.Image)(resources.GetObject("enemyThree.Image")));
            this.enemyThree.Location = new System.Drawing.Point(490, 35);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(100, 85);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemyThree.TabIndex = 0;
            this.enemyThree.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bullet.BackColor = System.Drawing.Color.White;
            this.bullet.Image = ((System.Drawing.Image)(resources.GetObject("bullet.Image")));
            this.bullet.Location = new System.Drawing.Point(308, 458);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(7, 27);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 0;
            this.bullet.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(256, 491);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(12, 200);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(610, 175);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTemerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 601);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTow);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.txtScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fighter jet shooter game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTow;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

