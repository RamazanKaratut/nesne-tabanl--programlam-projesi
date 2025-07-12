namespace PROJEM
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            ustkisimpp = new PictureBox();
            kuspp = new PictureBox();
            altkisimpp = new PictureBox();
            zeminpp = new PictureBox();
            zamankontrol = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ustkisimpp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kuspp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)altkisimpp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zeminpp).BeginInit();
            SuspendLayout();
            // 
            // ustkisimpp
            // 
            ustkisimpp.Image = Properties.Resources.boruüst2;
            ustkisimpp.Location = new Point(493, -81);
            ustkisimpp.Name = "ustkisimpp";
            ustkisimpp.Size = new Size(71, 265);
            ustkisimpp.SizeMode = PictureBoxSizeMode.StretchImage;
            ustkisimpp.TabIndex = 0;
            ustkisimpp.TabStop = false;
            // 
            // kuspp
            // 
            kuspp.Image = Properties.Resources.kuş;
            kuspp.Location = new Point(24, 160);
            kuspp.Name = "kuspp";
            kuspp.Size = new Size(79, 57);
            kuspp.SizeMode = PictureBoxSizeMode.StretchImage;
            kuspp.TabIndex = 1;
            kuspp.TabStop = false;
            // 
            // altkisimpp
            // 
            altkisimpp.Image = Properties.Resources.broualt2;
            altkisimpp.Location = new Point(387, 319);
            altkisimpp.Name = "altkisimpp";
            altkisimpp.Size = new Size(71, 250);
            altkisimpp.SizeMode = PictureBoxSizeMode.StretchImage;
            altkisimpp.TabIndex = 3;
            altkisimpp.TabStop = false;
            // 
            // zeminpp
            // 
            zeminpp.Image = Properties.Resources.cimen2;
            zeminpp.Location = new Point(-2, 492);
            zeminpp.Name = "zeminpp";
            zeminpp.Size = new Size(652, 89);
            zeminpp.SizeMode = PictureBoxSizeMode.StretchImage;
            zeminpp.TabIndex = 5;
            zeminpp.TabStop = false;
            // 
            // zamankontrol
            // 
            zamankontrol.Enabled = true;
            zamankontrol.Interval = 20;
            zamankontrol.Tick += gameTimer;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 6;
            label1.Text = "Skor";
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 128, 187);
            ClientSize = new Size(649, 581);
            Controls.Add(label1);
            Controls.Add(zeminpp);
            Controls.Add(altkisimpp);
            Controls.Add(kuspp);
            Controls.Add(ustkisimpp);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form16";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station - Uçan Kuş";
            FormClosing += Form16_FormClosing;
            MouseDown += Form16_MouseDown;
            MouseUp += Form16_MouseUp;
            ((System.ComponentModel.ISupportInitialize)ustkisimpp).EndInit();
            ((System.ComponentModel.ISupportInitialize)kuspp).EndInit();
            ((System.ComponentModel.ISupportInitialize)altkisimpp).EndInit();
            ((System.ComponentModel.ISupportInitialize)zeminpp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ustkisimpp;
        private PictureBox kuspp;
        private PictureBox altkisimpp;
        private PictureBox zeminpp;
        private System.Windows.Forms.Timer zamankontrol;
        private Label label1;
    }
}