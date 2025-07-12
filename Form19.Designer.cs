namespace PROJEM
{
    partial class Form19
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            floor = new PictureBox();
            trex = new PictureBox();
            obstacle1 = new PictureBox();
            obstacle2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)floor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle2).BeginInit();
            SuspendLayout();
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.FromArgb(0, 255, 0, 0);
            scoreText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scoreText.Location = new Point(12, 9);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(80, 30);
            scoreText.TabIndex = 4;
            scoreText.Text = "SKOR: ";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameEvent;
            // 
            // floor
            // 
            floor.BackColor = SystemColors.WindowFrame;
            floor.Location = new Point(-12, 452);
            floor.Name = "floor";
            floor.Size = new Size(652, 50);
            floor.SizeMode = PictureBoxSizeMode.StretchImage;
            floor.TabIndex = 0;
            floor.TabStop = false;
            // 
            // trex
            // 
            trex.Image = Properties.Resources.running;
            trex.Location = new Point(122, 390);
            trex.Name = "trex";
            trex.Size = new Size(44, 60);
            trex.SizeMode = PictureBoxSizeMode.StretchImage;
            trex.TabIndex = 1;
            trex.TabStop = false;
            // 
            // obstacle1
            // 
            obstacle1.BackColor = Color.FromArgb(0, 255, 0, 0);
            obstacle1.Image = Properties.Resources.obstacle_1;
            obstacle1.Location = new Point(371, 405);
            obstacle1.Name = "obstacle1";
            obstacle1.Size = new Size(23, 46);
            obstacle1.SizeMode = PictureBoxSizeMode.AutoSize;
            obstacle1.TabIndex = 2;
            obstacle1.TabStop = false;
            obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            obstacle2.BackColor = Color.FromArgb(0, 255, 0, 0);
            obstacle2.Image = Properties.Resources.obstacle_2;
            obstacle2.Location = new Point(534, 400);
            obstacle2.Name = "obstacle2";
            obstacle2.Size = new Size(50, 50);
            obstacle2.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacle2.TabIndex = 3;
            obstacle2.TabStop = false;
            obstacle2.Tag = "obstacle";
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(614, 471);
            Controls.Add(scoreText);
            Controls.Add(obstacle2);
            Controls.Add(obstacle1);
            Controls.Add(trex);
            Controls.Add(floor);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form19";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station - TREX";
            FormClosing += Form19_FormClosing;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)floor).EndInit();
            ((System.ComponentModel.ISupportInitialize)trex).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox floor;
        private PictureBox trex;
        private PictureBox obstacle1;
        private PictureBox obstacle2;
    }
}