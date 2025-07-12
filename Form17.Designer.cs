namespace PROJEM
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            labelxo = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(129, 163);
            button1.Name = "button1";
            button1.Size = new Size(55, 53);
            button1.TabIndex = 1;
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += XOXtiklama;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(190, 163);
            button2.Name = "button2";
            button2.Size = new Size(55, 53);
            button2.TabIndex = 2;
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += XOXtiklama;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(251, 163);
            button3.Name = "button3";
            button3.Size = new Size(55, 53);
            button3.TabIndex = 3;
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += XOXtiklama;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(129, 222);
            button4.Name = "button4";
            button4.Size = new Size(55, 53);
            button4.TabIndex = 4;
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += XOXtiklama;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F);
            button5.ForeColor = SystemColors.WindowText;
            button5.Location = new Point(190, 222);
            button5.Name = "button5";
            button5.Size = new Size(55, 53);
            button5.TabIndex = 5;
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += XOXtiklama;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 18F);
            button6.ForeColor = SystemColors.WindowText;
            button6.Location = new Point(251, 222);
            button6.Name = "button6";
            button6.Size = new Size(55, 53);
            button6.TabIndex = 6;
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += XOXtiklama;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 18F);
            button7.ForeColor = SystemColors.WindowText;
            button7.Location = new Point(129, 281);
            button7.Name = "button7";
            button7.Size = new Size(55, 53);
            button7.TabIndex = 7;
            button7.TextAlign = ContentAlignment.TopCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += XOXtiklama;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 18F);
            button8.ForeColor = SystemColors.WindowText;
            button8.Location = new Point(190, 281);
            button8.Name = "button8";
            button8.Size = new Size(55, 53);
            button8.TabIndex = 8;
            button8.TextAlign = ContentAlignment.TopCenter;
            button8.UseVisualStyleBackColor = true;
            button8.Click += XOXtiklama;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 18F);
            button9.ForeColor = SystemColors.WindowText;
            button9.Location = new Point(251, 281);
            button9.Name = "button9";
            button9.Size = new Size(55, 53);
            button9.TabIndex = 9;
            button9.TextAlign = ContentAlignment.TopCenter;
            button9.UseVisualStyleBackColor = true;
            button9.Click += XOXtiklama;
            // 
            // labelxo
            // 
            labelxo.AutoSize = true;
            labelxo.BackColor = Color.FromArgb(0, 255, 0, 0);
            labelxo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelxo.Location = new Point(190, 85);
            labelxo.Name = "labelxo";
            labelxo.Size = new Size(41, 45);
            labelxo.TabIndex = 10;
            labelxo.Text = "X";
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GTAVI_Background_Trailer_1_1024x576;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(434, 419);
            Controls.Add(labelxo);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form17";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Station - XOX";
            FormClosing += Form17_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label labelxo;
    }
}