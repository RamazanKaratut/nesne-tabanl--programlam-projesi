namespace PROJEM
{
    partial class Form21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            label1 = new Label();
            pcsecimpp = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            bilgisayarpuan = new Label();
            oyuncupuan = new Label();
            tasbutton = new Button();
            kagitbuton = new Button();
            makasbuton = new Button();
            oynabuton = new Button();
            kazananlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pcsecimpp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 189);
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 15;
            label1.Text = "Bilgisayar Seçimi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pcsecimpp
            // 
            pcsecimpp.Location = new Point(340, 22);
            pcsecimpp.Name = "pcsecimpp";
            pcsecimpp.Size = new Size(120, 150);
            pcsecimpp.SizeMode = PictureBoxSizeMode.StretchImage;
            pcsecimpp.TabIndex = 14;
            pcsecimpp.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.makas;
            pictureBox3.Location = new Point(500, 241);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.kağıt;
            pictureBox2.Location = new Point(340, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.taş;
            pictureBox1.Location = new Point(180, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 189);
            label2.Name = "label2";
            label2.BackColor = Color.FromArgb(0, 255, 0, 0);
            label2.Size = new Size(79, 15);
            label2.TabIndex = 16;
            label2.Text = "3 olan kazanır";
            // 
            // bilgisayarpuan
            // 
            bilgisayarpuan.AutoSize = true;
            bilgisayarpuan.Location = new Point(683, 80);
            bilgisayarpuan.Name = "bilgisayarpuan";
            bilgisayarpuan.Size = new Size(89, 15);
            bilgisayarpuan.TabIndex = 17;
            bilgisayarpuan.BackColor = Color.FromArgb(0, 255, 0, 0);
            bilgisayarpuan.Text = "Bilgisayar skoru";
            // 
            // oyuncupuan
            // 
            oyuncupuan.AutoSize = true;
            oyuncupuan.Location = new Point(683, 321);
            oyuncupuan.Name = "oyuncupuan";
            oyuncupuan.Size = new Size(82, 15);
            oyuncupuan.BackColor = Color.FromArgb(0, 255, 0, 0);
            oyuncupuan.TabIndex = 18;
            oyuncupuan.Text = "Sizin skorunuz";
            // 
            // tasbutton
            // 
            tasbutton.Location = new Point(180, 397);
            tasbutton.Name = "tasbutton";
            tasbutton.Size = new Size(120, 29);
            tasbutton.TabIndex = 11;
            tasbutton.Text = "Taş";
            tasbutton.UseVisualStyleBackColor = true;
            tasbutton.Click += tasbutton_Click;
            // 
            // kagitbuton
            // 
            kagitbuton.Location = new Point(340, 397);
            kagitbuton.Name = "kagitbuton";
            kagitbuton.Size = new Size(120, 29);
            kagitbuton.TabIndex = 12;
            kagitbuton.Text = "Kağıt";
            kagitbuton.UseVisualStyleBackColor = true;
            kagitbuton.Click += kagitbuton_Click;
            // 
            // makasbuton
            // 
            makasbuton.Location = new Point(500, 397);
            makasbuton.Name = "makasbuton";
            makasbuton.Size = new Size(120, 29);
            makasbuton.TabIndex = 13;
            makasbuton.Text = "Makas";
            makasbuton.UseVisualStyleBackColor = true;
            makasbuton.Click += makasbuton_Click;
            // 
            // oynabuton
            // 
            oynabuton.Location = new Point(683, 382);
            oynabuton.Name = "oynabuton";
            oynabuton.Size = new Size(89, 44);
            oynabuton.TabIndex = 19;
            oynabuton.Text = "Başlat";
            oynabuton.UseVisualStyleBackColor = true;
            oynabuton.Click += oynabuton_Click;
            // 
            // kazananlabel
            // 
            kazananlabel.AutoSize = true;
            kazananlabel.Location = new Point(683, 189);
            kazananlabel.Name = "kazananlabel";
            kazananlabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            kazananlabel.Size = new Size(51, 15);
            kazananlabel.TabIndex = 20;
            kazananlabel.Text = "Kazanan";
            // 
            // Form21
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(kazananlabel);
            Controls.Add(oynabuton);
            Controls.Add(oyuncupuan);
            Controls.Add(bilgisayarpuan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pcsecimpp);
            Controls.Add(makasbuton);
            Controls.Add(kagitbuton);
            Controls.Add(tasbutton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form21";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station - Taş Kağıt Makas";
            FormClosing += Form21_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pcsecimpp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pcsecimpp;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label bilgisayarpuan;
        private Label oyuncupuan;
        private Button tasbutton;
        private Button kagitbuton;
        private Button makasbuton;
        private Button oynabuton;
        private Label kazananlabel;
    }
}