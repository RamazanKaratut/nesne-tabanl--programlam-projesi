namespace PROJEM
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            kadilabel = new Label();
            panel1 = new Panel();
            label1 = new Label();
            skorlabel = new Label();
            baslabuton = new Button();
            kazankaybetlabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // kadilabel
            // 
            kadilabel.AutoSize = true;
            kadilabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            kadilabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kadilabel.Location = new Point(622, 105);
            kadilabel.Name = "kadilabel";
            kadilabel.Size = new Size(71, 15);
            kadilabel.TabIndex = 0;
            kadilabel.Text = "Kullanıcı adı";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 255, 0, 0);
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(622, 257);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 2;
            label1.Text = "Skor:";
            // 
            // skorlabel
            // 
            skorlabel.AutoSize = true;
            skorlabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            skorlabel.Font = new Font("Segoe UI", 14.25F);
            skorlabel.Location = new Point(719, 257);
            skorlabel.Name = "skorlabel";
            skorlabel.Size = new Size(22, 25);
            skorlabel.TabIndex = 3;
            skorlabel.Text = "0";
            // 
            // baslabuton
            // 
            baslabuton.Location = new Point(622, 507);
            baslabuton.Name = "baslabuton";
            baslabuton.Size = new Size(171, 57);
            baslabuton.TabIndex = 4;
            baslabuton.Text = "Başla";
            baslabuton.UseVisualStyleBackColor = true;
            baslabuton.Click += baslabuton_Click;
            // 
            // kazankaybetlabel
            // 
            kazankaybetlabel.AutoSize = true;
            kazankaybetlabel.BackColor = Color.FromArgb(0, 255, 0, 0);
            kazankaybetlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kazankaybetlabel.Location = new Point(622, 365);
            kazankaybetlabel.Name = "kazankaybetlabel";
            kazankaybetlabel.Size = new Size(170, 37);
            kazankaybetlabel.TabIndex = 5;
            kazankaybetlabel.Text = "KAYBETTİNİZ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 577);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.BackColor = Color.FromArgb(0, 255, 0, 0);
            label2.TabIndex = 6;
            label2.Text = "Geri Dön";
            label2.Click += label2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 601);
            Controls.Add(label2);
            Controls.Add(kazankaybetlabel);
            Controls.Add(baslabuton);
            Controls.Add(skorlabel);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(kadilabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station - Yılan Oyunu";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            KeyDown += Form4_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kadilabel;
        private Panel panel1;
        private Label label1;
        private Label skorlabel;
        private Button baslabuton;
        private Label kazankaybetlabel;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}