namespace PROJEM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            kaditext = new TextBox();
            ksifretext = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            ilerlemebari = new ProgressBar();
            ilk80 = new System.Windows.Forms.Timer(components);
            son20 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            linkLabel3 = new LinkLabel();
            SuspendLayout();
            // 
            // kaditext
            // 
            kaditext.Location = new Point(121, 112);
            kaditext.MaxLength = 15;
            kaditext.Name = "kaditext";
            kaditext.Size = new Size(100, 23);
            kaditext.TabIndex = 1;
            kaditext.KeyPress += kaditext_KeyPress;
            // 
            // ksifretext
            // 
            ksifretext.Location = new Point(121, 207);
            ksifretext.MaxLength = 15;
            ksifretext.Name = "ksifretext";
            ksifretext.PasswordChar = '*';
            ksifretext.Size = new Size(100, 23);
            ksifretext.TabIndex = 2;
            ksifretext.KeyPress += ksifretext_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Location = new Point(121, 94);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 255, 0, 0);
            label2.Location = new Point(121, 189);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // button1
            // 
            button1.Location = new Point(406, 214);
            button1.Name = "button1";
            button1.Size = new Size(184, 49);
            button1.TabIndex = 3;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(0, 255, 0, 0);
            linkLabel1.ForeColor = SystemColors.Control;
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(122, 248);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi unuttum?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.FromArgb(0, 255, 0, 0);
            linkLabel2.ForeColor = SystemColors.Control;
            linkLabel2.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel2.Location = new Point(249, 248);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(48, 15);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Kaydol?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // ilerlemebari
            // 
            ilerlemebari.Location = new Point(216, 141);
            ilerlemebari.Name = "ilerlemebari";
            ilerlemebari.Size = new Size(219, 36);
            ilerlemebari.TabIndex = 8;
            // 
            // ilk80
            // 
            ilk80.Interval = 1000;
            ilk80.Tick += ilk80_Tick;
            // 
            // son20
            // 
            son20.Tick += son20_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 255, 0, 0);
            button2.BackgroundImage = Properties.Resources.Pictogrammers_Material_Light_Eye_off_256;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = Color.FromArgb(0, 255, 0, 0);
            button2.Location = new Point(227, 207);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.FromArgb(0, 255, 0, 0);
            linkLabel3.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel3.Location = new Point(518, 196);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(72, 15);
            linkLabel3.TabIndex = 11;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Misafir Girişi";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 318);
            Controls.Add(linkLabel3);
            Controls.Add(button2);
            Controls.Add(ilerlemebari);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ksifretext);
            Controls.Add(kaditext);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox kaditext;
        private TextBox ksifretext;
        private Label label1;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private ProgressBar ilerlemebari;
        private System.Windows.Forms.Timer ilk80;
        private System.Windows.Forms.Timer son20;
        private Button button2;
        private LinkLabel linkLabel3;
    }
}