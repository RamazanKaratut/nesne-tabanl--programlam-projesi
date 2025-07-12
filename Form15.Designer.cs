namespace PROJEM
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            label1 = new Label();
            oynananoyunlabel = new Label();
            kadilabel = new Label();
            kullanicipp = new PictureBox();
            skorlabel = new Label();
            label2 = new Label();
            geridon = new Button();
            oyunfoto = new PictureBox();
            oynabuton = new Button();
            ikikisilikoyna = new Button();
            ((System.ComponentModel.ISupportInitialize)kullanicipp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oyunfoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Location = new Point(242, 197);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Yüksek Skor:";
            // 
            // oynananoyunlabel
            // 
            oynananoyunlabel.AutoSize = true;
            oynananoyunlabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            oynananoyunlabel.Location = new Point(242, 108);
            oynananoyunlabel.Name = "oynananoyunlabel";
            oynananoyunlabel.Size = new Size(87, 15);
            oynananoyunlabel.TabIndex = 2;
            oynananoyunlabel.Text = "Oynanan Oyun";
            // 
            // kadilabel
            // 
            kadilabel.AutoSize = true;
            kadilabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            kadilabel.Location = new Point(585, 108);
            kadilabel.Name = "kadilabel";
            kadilabel.Size = new Size(73, 15);
            kadilabel.TabIndex = 3;
            kadilabel.Text = "Kullanıcı Adı";
            // 
            // kullanicipp
            // 
            kullanicipp.BackColor = Color.FromArgb(0, 255, 0, 0);
            kullanicipp.BackgroundImageLayout = ImageLayout.Stretch;
            kullanicipp.Image = Properties.Resources.Mahm0udwally_All_Flat_User_128;
            kullanicipp.InitialImage = null;
            kullanicipp.Location = new Point(585, 12);
            kullanicipp.Name = "kullanicipp";
            kullanicipp.Size = new Size(75, 75);
            kullanicipp.SizeMode = PictureBoxSizeMode.StretchImage;
            kullanicipp.TabIndex = 4;
            kullanicipp.TabStop = false;
            // 
            // skorlabel
            // 
            skorlabel.AutoSize = true;
            skorlabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            skorlabel.Location = new Point(351, 197);
            skorlabel.Name = "skorlabel";
            skorlabel.Size = new Size(43, 15);
            skorlabel.TabIndex = 5;
            skorlabel.Text = "Skor ??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 255, 0, 0);
            label2.Location = new Point(48, 20);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 10;
            label2.Text = "Geri Dön";
            // 
            // geridon
            // 
            geridon.BackgroundImage = Properties.Resources.Github_Octicons_Arrow_left_24_72;
            geridon.BackgroundImageLayout = ImageLayout.Stretch;
            geridon.ForeColor = SystemColors.ControlDark;
            geridon.Location = new Point(12, 12);
            geridon.Name = "geridon";
            geridon.Size = new Size(30, 30);
            geridon.TabIndex = 9;
            geridon.UseVisualStyleBackColor = true;
            geridon.Click += geridon_Click;
            // 
            // oyunfoto
            // 
            oyunfoto.Image = Properties.Resources.Ionic_Ionicons_Game_controller_512;
            oyunfoto.Location = new Point(12, 63);
            oyunfoto.Name = "oyunfoto";
            oyunfoto.Size = new Size(224, 228);
            oyunfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            oyunfoto.TabIndex = 11;
            oyunfoto.TabStop = false;
            // 
            // oynabuton
            // 
            oynabuton.Location = new Point(397, 235);
            oynabuton.Name = "oynabuton";
            oynabuton.Size = new Size(96, 31);
            oynabuton.TabIndex = 12;
            oynabuton.Text = "Oyna";
            oynabuton.UseVisualStyleBackColor = true;
            oynabuton.Click += oynabuton_Click;
            // 
            // ikikisilikoyna
            // 
            ikikisilikoyna.Location = new Point(523, 235);
            ikikisilikoyna.Name = "ikikisilikoyna";
            ikikisilikoyna.Size = new Size(96, 31);
            ikikisilikoyna.TabIndex = 13;
            ikikisilikoyna.Text = "2 Kişi Oyna";
            ikikisilikoyna.UseVisualStyleBackColor = true;
            ikikisilikoyna.Click += ikikisilikoyna_Click;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 318);
            Controls.Add(ikikisilikoyna);
            Controls.Add(oynabuton);
            Controls.Add(oyunfoto);
            Controls.Add(label2);
            Controls.Add(geridon);
            Controls.Add(skorlabel);
            Controls.Add(kullanicipp);
            Controls.Add(kadilabel);
            Controls.Add(oynananoyunlabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form15";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station";
            FormClosing += Form15_FormClosing;
            Load += Form15_Load;
            ((System.ComponentModel.ISupportInitialize)kullanicipp).EndInit();
            ((System.ComponentModel.ISupportInitialize)oyunfoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label oynananoyunlabel;
        private Label kadilabel;
        private PictureBox kullanicipp;
        private Label skorlabel;
        private Label label2;
        private Button geridon;
        private PictureBox oyunfoto;
        private Button oynabuton;
        private Button ikikisilikoyna;
    }
}