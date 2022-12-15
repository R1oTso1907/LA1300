namespace WindowsFormsApp1
{
    partial class VegeterianRun
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameArea = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.restart = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.obsticaleAir = new System.Windows.Forms.PictureBox();
            this.obsticale = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.gameArea.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticaleAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameArea.Controls.Add(this.obsticaleAir);
            this.gameArea.Controls.Add(this.Menu);
            this.gameArea.Controls.Add(this.ScoreCounter);
            this.gameArea.Controls.Add(this.obsticale);
            this.gameArea.Controls.Add(this.Player);
            this.gameArea.Location = new System.Drawing.Point(-4, -2);
            this.gameArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(608, 358);
            this.gameArea.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.restart);
            this.Menu.Controls.Add(this.Quit);
            this.Menu.Location = new System.Drawing.Point(195, 99);
            this.Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu.Size = new System.Drawing.Size(159, 138);
            this.Menu.TabIndex = 7;
            this.Menu.TabStop = false;
            this.Menu.Text = "MENU";
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(38, 38);
            this.restart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(95, 31);
            this.restart.TabIndex = 8;
            this.restart.Text = "Restart";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Quit
            // 
            this.Quit.AutoSize = true;
            this.Quit.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(53, 83);
            this.Quit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(63, 31);
            this.Quit.TabIndex = 7;
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCounter.Location = new System.Drawing.Point(233, 13);
            this.ScoreCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(91, 31);
            this.ScoreCounter.TabIndex = 3;
            this.ScoreCounter.Text = "Score: ";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ground.Location = new System.Drawing.Point(-1, 353);
            this.ground.Margin = new System.Windows.Forms.Padding(2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(604, 20);
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // obsticaleAir
            // 
            this.obsticaleAir.Image = global::WindowsFormsApp1.Properties.Resources.t_bone_21;
            this.obsticaleAir.Location = new System.Drawing.Point(330, 227);
            this.obsticaleAir.Name = "obsticaleAir";
            this.obsticaleAir.Size = new System.Drawing.Size(55, 52);
            this.obsticaleAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obsticaleAir.TabIndex = 8;
            this.obsticaleAir.TabStop = false;
            // 
            // obsticale
            // 
            this.obsticale.BackColor = System.Drawing.Color.Transparent;
            this.obsticale.Image = global::WindowsFormsApp1.Properties.Resources.fleisch_png1;
            this.obsticale.Location = new System.Drawing.Point(534, 305);
            this.obsticale.Margin = new System.Windows.Forms.Padding(2);
            this.obsticale.Name = "obsticale";
            this.obsticale.Size = new System.Drawing.Size(48, 49);
            this.obsticale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obsticale.TabIndex = 2;
            this.obsticale.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::WindowsFormsApp1.Properties.Resources.affefigur3;
            this.Player.Location = new System.Drawing.Point(13, 305);
            this.Player.Margin = new System.Windows.Forms.Padding(2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(42, 54);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // VegeterianRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.gameArea);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VegeterianRun";
            this.Text = "VegeterianRun";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyup);
            this.gameArea.ResumeLayout(false);
            this.gameArea.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticaleAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox obsticale;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Label Quit;
        private System.Windows.Forms.Label restart;
        private System.Windows.Forms.PictureBox obsticaleAir;
    }
}

