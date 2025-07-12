namespace PROJEM
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label3 = new Label();
            label1 = new Label();
            kaditext = new TextBox();
            button1 = new Button();
            kteltext = new TextBox();
            label2 = new Label();
            kmailtext = new TextBox();
            label4 = new Label();
            ksifretext = new TextBox();
            label5 = new Label();
            ksifreyenidentext = new TextBox();
            label6 = new Label();
            label7 = new Label();
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
            button2.TabIndex = 7;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Location = new Point(61, 104);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 9;
            label1.Text = "Kullanıcı Adı (Max 15 karakter)";
            // 
            // kaditext
            // 
            kaditext.Location = new Point(61, 122);
            kaditext.MaxLength = 15;
            kaditext.Name = "kaditext";
            kaditext.Size = new Size(100, 23);
            kaditext.TabIndex = 1;
            kaditext.KeyPress += kaditext_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(449, 219);
            button1.Name = "button1";
            button1.Size = new Size(185, 53);
            button1.TabIndex = 6;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kteltext
            // 
            kteltext.Location = new Point(61, 249);
            kteltext.MaxLength = 11;
            kteltext.Name = "kteltext";
            kteltext.Size = new Size(100, 23);
            kteltext.TabIndex = 3;
            kteltext.KeyPress += kaditext_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 255, 0, 0);
            label2.Location = new Point(61, 231);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 12;
            label2.Text = "Telefon Numarası (11 karakter)\r\n";
            // 
            // kmailtext
            // 
            kmailtext.Location = new Point(61, 183);
            kmailtext.MaxLength = 35;
            kmailtext.Name = "kmailtext";
            kmailtext.Size = new Size(100, 23);
            kmailtext.TabIndex = 2;
            kmailtext.KeyPress += kaditext_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 255, 0, 0);
            label4.Location = new Point(61, 165);
            label4.Name = "label4";
            label4.Size = new Size(160, 15);
            label4.TabIndex = 14;
            label4.Text = "Mail Adresi (Max 35 karakter)";
            // 
            // ksifretext
            // 
            ksifretext.Location = new Point(251, 183);
            ksifretext.MaxLength = 15;
            ksifretext.Name = "ksifretext";
            ksifretext.PasswordChar = '*';
            ksifretext.Size = new Size(100, 23);
            ksifretext.TabIndex = 4;
            ksifretext.KeyPress += kaditext_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 255, 0, 0);
            label5.Location = new Point(251, 165);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 16;
            label5.Text = "Şifre (Max 15 karakter)";
            // 
            // ksifreyenidentext
            // 
            ksifreyenidentext.Location = new Point(251, 249);
            ksifreyenidentext.MaxLength = 15;
            ksifreyenidentext.Name = "ksifreyenidentext";
            ksifreyenidentext.PasswordChar = '*';
            ksifreyenidentext.Size = new Size(100, 23);
            ksifreyenidentext.TabIndex = 5;
            ksifreyenidentext.KeyPress += ksifreyenidentext_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 255, 0, 0);
            label6.Location = new Point(251, 231);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 18;
            label6.Text = "Şifre Yeniden";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 255, 0, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(456, 156);
            label7.Name = "label7";
            label7.Size = new Size(178, 45);
            label7.TabIndex = 19;
            label7.Text = "Kullanıcı adınızı iyi seçiniz! \r\nBu ad sizin belirteciniz olacak ve \r\nbir daha değiştiremeyeceksiniz.";
            label7.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Pictogrammers_Material_Light_Eye_off_256;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(357, 183);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Pictogrammers_Material_Light_Eye_off_256;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(357, 249);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 21;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 318);
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
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station";
            FormClosing += Form3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox kaditext;
        private Button button1;
        private TextBox kteltext;
        private Label label2;
        private TextBox kmailtext;
        private Label label4;
        private TextBox ksifretext;
        private Label label5;
        private TextBox ksifreyenidentext;
        private Label label6;
        private Label label7;
        private Button button3;
        private Button button4;
    }
}