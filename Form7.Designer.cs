namespace PROJEM
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label7 = new Label();
            ksifreyenidentext = new TextBox();
            label6 = new Label();
            ksifretext = new TextBox();
            label5 = new Label();
            kmailtext = new TextBox();
            label4 = new Label();
            kteltext = new TextBox();
            label2 = new Label();
            button1 = new Button();
            kaditext = new TextBox();
            label1 = new Label();
            label3 = new Label();
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
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 255, 0, 0);
            label7.Location = new Point(408, 188);
            label7.Name = "label7";
            label7.Size = new Size(218, 15);
            label7.TabIndex = 33;
            label7.Text = "Hesap Silme işleminden geri dönülemez";
            label7.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ksifreyenidentext
            // 
            ksifreyenidentext.Location = new Point(237, 246);
            ksifreyenidentext.MaxLength = 15;
            ksifreyenidentext.Name = "ksifreyenidentext";
            ksifreyenidentext.PasswordChar = '*';
            ksifreyenidentext.Size = new Size(100, 23);
            ksifreyenidentext.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 255, 0, 0);
            label6.Location = new Point(237, 228);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 32;
            label6.Text = "Şifre Yeniden";
            // 
            // ksifretext
            // 
            ksifretext.Location = new Point(237, 180);
            ksifretext.MaxLength = 15;
            ksifretext.Name = "ksifretext";
            ksifretext.PasswordChar = '*';
            ksifretext.Size = new Size(100, 23);
            ksifretext.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 255, 0, 0);
            label5.Location = new Point(237, 162);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 31;
            label5.Text = "Şifre";
            // 
            // kmailtext
            // 
            kmailtext.Location = new Point(89, 180);
            kmailtext.MaxLength = 25;
            kmailtext.Name = "kmailtext";
            kmailtext.Size = new Size(100, 23);
            kmailtext.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 255, 0, 0);
            label4.Location = new Point(89, 162);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 30;
            label4.Text = "Mail Adresi";
            // 
            // kteltext
            // 
            kteltext.Location = new Point(89, 246);
            kteltext.MaxLength = 11;
            kteltext.Name = "kteltext";
            kteltext.Size = new Size(100, 23);
            kteltext.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 255, 0, 0);
            label2.Location = new Point(89, 228);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 29;
            label2.Text = "Telefon Numarası";
            // 
            // button1
            // 
            button1.Location = new Point(423, 216);
            button1.Name = "button1";
            button1.Size = new Size(185, 53);
            button1.TabIndex = 25;
            button1.Text = "Hesap Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kaditext
            // 
            kaditext.Location = new Point(89, 119);
            kaditext.MaxLength = 15;
            kaditext.Name = "kaditext";
            kaditext.Size = new Size(100, 23);
            kaditext.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Location = new Point(89, 101);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 28;
            label1.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 255, 0, 0);
            label3.Location = new Point(48, 20);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 27;
            label3.Text = "Geri Dön";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Pictogrammers_Material_Light_Eye_off1;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(343, 180);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 34;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Pictogrammers_Material_Light_Eye_off2;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(342, 246);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 35;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(676, 322);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(ksifreyenidentext);
            Controls.Add(label6);
            Controls.Add(ksifretext);
            Controls.Add(label5);
            Controls.Add(kmailtext);
            Controls.Add(label4);
            Controls.Add(kteltext);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(kaditext);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station";
            FormClosing += Form7_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox ksifreyenidentext;
        private Label label6;
        private TextBox ksifretext;
        private Label label5;
        private TextBox kmailtext;
        private Label label4;
        private TextBox kteltext;
        private Label label2;
        private Button button1;
        private TextBox kaditext;
        private Label label1;
        private Label label3;
        private Button button3;
        private Button button4;
    }
}