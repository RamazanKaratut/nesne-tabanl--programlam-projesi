namespace PROJEM
{
    partial class Form6
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
            Button button2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label3 = new Label();
            ksifreyenidentext = new TextBox();
            ksifreyenidenlabel = new Label();
            ksifretext = new TextBox();
            ksifrelabel = new Label();
            kmailtext = new TextBox();
            kmaillabel = new Label();
            kteltext = new TextBox();
            ktellabel = new Label();
            button1 = new Button();
            kaditext = new TextBox();
            kadilabel = new Label();
            label1 = new Label();
            kurtarmatext = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Github_Octicons_Arrow_left_24_72;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 255, 0, 0);
            label3.Location = new Point(48, 20);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Geri Dön";
            // 
            // ksifreyenidentext
            // 
            ksifreyenidentext.Location = new Point(215, 247);
            ksifreyenidentext.MaxLength = 15;
            ksifreyenidentext.Name = "ksifreyenidentext";
            ksifreyenidentext.PasswordChar = '*';
            ksifreyenidentext.Size = new Size(100, 23);
            ksifreyenidentext.TabIndex = 6;
            // 
            // ksifreyenidenlabel
            // 
            ksifreyenidenlabel.AutoSize = true;
            ksifreyenidenlabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            ksifreyenidenlabel.Location = new Point(215, 229);
            ksifreyenidenlabel.Name = "ksifreyenidenlabel";
            ksifreyenidenlabel.Size = new Size(100, 15);
            ksifreyenidenlabel.TabIndex = 29;
            ksifreyenidenlabel.Text = "Yeni Şifre Yeniden";
            // 
            // ksifretext
            // 
            ksifretext.Location = new Point(215, 181);
            ksifretext.MaxLength = 15;
            ksifretext.Name = "ksifretext";
            ksifretext.PasswordChar = '*';
            ksifretext.Size = new Size(100, 23);
            ksifretext.TabIndex = 5;
            // 
            // ksifrelabel
            // 
            ksifrelabel.AutoSize = true;
            ksifrelabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            ksifrelabel.Location = new Point(215, 163);
            ksifrelabel.Name = "ksifrelabel";
            ksifrelabel.Size = new Size(149, 15);
            ksifrelabel.TabIndex = 28;
            ksifrelabel.Text = "Yeni Şifre (Max 15 karakter)";
            // 
            // kmailtext
            // 
            kmailtext.Location = new Point(67, 181);
            kmailtext.MaxLength = 25;
            kmailtext.Name = "kmailtext";
            kmailtext.Size = new Size(100, 23);
            kmailtext.TabIndex = 2;
            // 
            // kmaillabel
            // 
            kmaillabel.AutoSize = true;
            kmaillabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            kmaillabel.Location = new Point(67, 163);
            kmaillabel.Name = "kmaillabel";
            kmaillabel.Size = new Size(66, 15);
            kmaillabel.TabIndex = 27;
            kmaillabel.Text = "Mail Adresi";
            // 
            // kteltext
            // 
            kteltext.Location = new Point(67, 247);
            kteltext.MaxLength = 11;
            kteltext.Name = "kteltext";
            kteltext.Size = new Size(100, 23);
            kteltext.TabIndex = 3;
            // 
            // ktellabel
            // 
            ktellabel.AutoSize = true;
            ktellabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            ktellabel.Location = new Point(67, 229);
            ktellabel.Name = "ktellabel";
            ktellabel.Size = new Size(99, 15);
            ktellabel.TabIndex = 26;
            ktellabel.Text = "Telefon Numarası";
            // 
            // button1
            // 
            button1.Location = new Point(427, 209);
            button1.Name = "button1";
            button1.Size = new Size(201, 61);
            button1.TabIndex = 7;
            button1.Text = "Şifreyi Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kaditext
            // 
            kaditext.Location = new Point(67, 120);
            kaditext.MaxLength = 15;
            kaditext.Name = "kaditext";
            kaditext.Size = new Size(100, 23);
            kaditext.TabIndex = 1;
            // 
            // kadilabel
            // 
            kadilabel.AutoSize = true;
            kadilabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            kadilabel.Location = new Point(67, 102);
            kadilabel.Name = "kadilabel";
            kadilabel.Size = new Size(73, 15);
            kadilabel.TabIndex = 25;
            kadilabel.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Location = new Point(215, 102);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 30;
            label1.Text = "Kurtarma Kodunuz";
            // 
            // kurtarmatext
            // 
            kurtarmatext.Location = new Point(215, 120);
            kurtarmatext.Name = "kurtarmatext";
            kurtarmatext.Size = new Size(100, 23);
            kurtarmatext.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Pictogrammers_Material_Light_Eye_off_256;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(321, 181);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 31;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Pictogrammers_Material_Light_Eye_off_256;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(321, 247);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 32;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 318);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(kurtarmatext);
            Controls.Add(label1);
            Controls.Add(ksifreyenidentext);
            Controls.Add(ksifreyenidenlabel);
            Controls.Add(ksifretext);
            Controls.Add(ksifrelabel);
            Controls.Add(kmailtext);
            Controls.Add(kmaillabel);
            Controls.Add(kteltext);
            Controls.Add(ktellabel);
            Controls.Add(button1);
            Controls.Add(kaditext);
            Controls.Add(kadilabel);
            Controls.Add(label3);
            Controls.Add(button2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station";
            FormClosing += Form6_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox ksifreyenidentext;
        private Label ksifreyenidenlabel;
        private TextBox ksifretext;
        private Label ksifrelabel;
        private TextBox kmailtext;
        private Label kmaillabel;
        private TextBox kteltext;
        private Label ktellabel;
        private Button button1;
        private TextBox kaditext;
        private Label kadilabel;
        private Label label1;
        private TextBox kurtarmatext;
        private Button button3;
        private Button button4;
    }
}