namespace PROJEM
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label1 = new Label();
            button1 = new Button();
            kartsahibitext = new TextBox();
            label2 = new Label();
            dort3text = new TextBox();
            dort1text = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dort2text = new TextBox();
            dort4text = new TextBox();
            cvc2text = new TextBox();
            label3 = new Label();
            validaytext = new TextBox();
            paraekletamamla = new Button();
            kullaniciparasilabel = new Label();
            label6 = new Label();
            eklenenparatext = new TextBox();
            validyıltext = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 8;
            label1.Text = "Geri Dön";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Github_Octicons_Arrow_left_24_72;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ControlDark;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kartsahibitext
            // 
            kartsahibitext.Location = new Point(81, 80);
            kartsahibitext.MaxLength = 30;
            kartsahibitext.Name = "kartsahibitext";
            kartsahibitext.Size = new Size(100, 23);
            kartsahibitext.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 255, 0, 0);
            label2.Location = new Point(81, 62);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 10;
            label2.Text = "Kart sahibi bilgileri";
            // 
            // dort3text
            // 
            dort3text.Location = new Point(293, 139);
            dort3text.MaxLength = 4;
            dort3text.Name = "dort3text";
            dort3text.Size = new Size(100, 23);
            dort3text.TabIndex = 5;
            dort3text.TextAlign = HorizontalAlignment.Center;
            dort3text.KeyPress += sayı_Kontrol;
            // 
            // dort1text
            // 
            dort1text.Location = new Point(81, 140);
            dort1text.MaxLength = 4;
            dort1text.Name = "dort1text";
            dort1text.Size = new Size(100, 23);
            dort1text.TabIndex = 3;
            dort1text.TextAlign = HorizontalAlignment.Center;
            dort1text.KeyPress += sayı_Kontrol;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 255, 0, 0);
            label4.Location = new Point(81, 122);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 12;
            label4.Text = "Kart numarası";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 255, 0, 0);
            label5.Location = new Point(81, 242);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 14;
            label5.Text = "CVC2 Kodu";
            // 
            // dort2text
            // 
            dort2text.Location = new Point(187, 139);
            dort2text.MaxLength = 4;
            dort2text.Name = "dort2text";
            dort2text.Size = new Size(100, 23);
            dort2text.TabIndex = 4;
            dort2text.TextAlign = HorizontalAlignment.Center;
            dort2text.KeyPress += sayı_Kontrol;
            // 
            // dort4text
            // 
            dort4text.Location = new Point(399, 139);
            dort4text.MaxLength = 4;
            dort4text.Name = "dort4text";
            dort4text.Size = new Size(100, 23);
            dort4text.TabIndex = 6;
            dort4text.TextAlign = HorizontalAlignment.Center;
            dort4text.KeyPress += sayı_Kontrol;
            // 
            // cvc2text
            // 
            cvc2text.Location = new Point(81, 260);
            cvc2text.MaxLength = 3;
            cvc2text.Name = "cvc2text";
            cvc2text.Size = new Size(100, 23);
            cvc2text.TabIndex = 9;
            cvc2text.TextAlign = HorizontalAlignment.Center;
            cvc2text.KeyPress += sayı_Kontrol;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 255, 0, 0);
            label3.Location = new Point(81, 182);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 17;
            label3.Text = "VALID THRU";
            // 
            // validaytext
            // 
            validaytext.Location = new Point(81, 200);
            validaytext.MaxLength = 2;
            validaytext.Name = "validaytext";
            validaytext.Size = new Size(40, 23);
            validaytext.TabIndex = 7;
            validaytext.TextAlign = HorizontalAlignment.Center;
            validaytext.KeyPress += sayı_Kontrol;
            // 
            // paraekletamamla
            // 
            paraekletamamla.Location = new Point(428, 234);
            paraekletamamla.Name = "paraekletamamla";
            paraekletamamla.Size = new Size(184, 49);
            paraekletamamla.TabIndex = 10;
            paraekletamamla.Text = "Para ekleme işlemini tamamla";
            paraekletamamla.UseVisualStyleBackColor = true;
            paraekletamamla.Click += paraekletamamla_Click;
            // 
            // kullaniciparasilabel
            // 
            kullaniciparasilabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kullaniciparasilabel.AutoSize = true;
            kullaniciparasilabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            kullaniciparasilabel.Location = new Point(399, 20);
            kullaniciparasilabel.Name = "kullaniciparasilabel";
            kullaniciparasilabel.RightToLeft = RightToLeft.Yes;
            kullaniciparasilabel.Size = new Size(88, 15);
            kullaniciparasilabel.TabIndex = 21;
            kullaniciparasilabel.Text = "Mevcut paranız";
            kullaniciparasilabel.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 255, 0, 0);
            label6.Location = new Point(242, 62);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 22;
            label6.Text = "Eklenilecek tutar";
            // 
            // eklenenparatext
            // 
            eklenenparatext.Location = new Point(242, 80);
            eklenenparatext.MaxLength = 4;
            eklenenparatext.Name = "eklenenparatext";
            eklenenparatext.Size = new Size(100, 23);
            eklenenparatext.TabIndex = 2;
            eklenenparatext.TextAlign = HorizontalAlignment.Center;
            eklenenparatext.KeyPress += sayı_Kontrol;
            // 
            // validyıltext
            // 
            validyıltext.Location = new Point(137, 200);
            validyıltext.MaxLength = 2;
            validyıltext.Name = "validyıltext";
            validyıltext.Size = new Size(44, 23);
            validyıltext.TabIndex = 8;
            validyıltext.TextAlign = HorizontalAlignment.Center;
            validyıltext.KeyPress += sayı_Kontrol;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(0, 255, 0, 0);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(123, 200);
            label7.Name = "label7";
            label7.Size = new Size(11, 23);
            label7.TabIndex = 25;
            label7.Text = "/";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 255, 0, 0);
            label8.Location = new Point(348, 83);
            label8.Name = "label8";
            label8.Size = new Size(160, 15);
            label8.TabIndex = 26;
            label8.Text = "Para yatırma limitiniz 5000 TL";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 318);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(validyıltext);
            Controls.Add(eklenenparatext);
            Controls.Add(label6);
            Controls.Add(kullaniciparasilabel);
            Controls.Add(paraekletamamla);
            Controls.Add(validaytext);
            Controls.Add(label3);
            Controls.Add(cvc2text);
            Controls.Add(dort4text);
            Controls.Add(label5);
            Controls.Add(dort2text);
            Controls.Add(label4);
            Controls.Add(dort1text);
            Controls.Add(dort3text);
            Controls.Add(label2);
            Controls.Add(kartsahibitext);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station";
            FormClosing += Form8_FormClosing;
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox kartsahibitext;
        private Label label2;
        private TextBox dort3text;
        private TextBox dort1text;
        private Label label4;
        private Label label5;
        private TextBox dort2text;
        private TextBox dort4text;
        private TextBox cvc2text;
        private Label label3;
        private TextBox validaytext;
        private Button paraekletamamla;
        private Label kullaniciparasilabel;
        private Label label6;
        private TextBox eklenenparatext;
        private TextBox validyıltext;
        private Label label7;
        private Label label8;
    }
}