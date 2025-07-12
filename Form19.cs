using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEM
{
    public partial class Form19 : Form
    {
        bool jumping = false;
        int jumpSpeed = 10;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rnd = new Random();
        public Form19()
        {
            InitializeComponent();
            force = 12;
            trex.Top = floor.Top - trex.Height;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            scoreText.Text = "Score: " + score;
            trex.BackColor = Color.Transparent;
            trex.Image = Properties.Resources.running;
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "obstacle")
                {
                    int position = rnd.Next(600, 1000);
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }
            gameTimer.Start();
        }
        public string kullanici_adi_form19;
        private void Form19_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gameEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;
            scoreText.Text = "Score: " + score;
            if (jumping && force < 0)
            {
                jumping = false;
            }
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        score++;
                    }
                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        int eskiskor;
                        int skor1 = Convert.ToInt32(score);
                        if (kullanici_adi_form19 != "misafir")
                        {
                            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("SELECT trex_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form19", connection))
                            {
                                command.Parameters.AddWithValue("@kullanici_adi_form19", kullanici_adi_form19);
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        eskiskor = Convert.ToInt32(reader["trex_oyunu_skor"].ToString());
                                        reader.Close();
                                        if (skor1 > eskiskor)
                                        {
                                            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET trex_oyunu_skor = @skor1 WHERE kullanici_adi = @kullanici_adi_form19", connection))
                                            {
                                                cmd.Parameters.AddWithValue("@kullanici_adi_form19", kullanici_adi_form19);
                                                cmd.Parameters.AddWithValue("@skor1", skor1);
                                                cmd.ExecuteNonQuery();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Kullanıcı bulunamadı.");
                                    }
                                    connection.Close();
                                }
                            }
                        }
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        DialogResult result = MessageBox.Show("Oyun Bitti Yeniden Başlamak istiyor musunuz?", "Yeniden Başlama Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            resetGame();
                        }
                        else
                        {
                            Form14 form14 = new Form14();
                            form14.kullanici_adi_form14 = kullanici_adi_form19;
                            this.Hide();
                            form14.Show();
                        }
                    }
                }
            }
            if (trex.Top >= 380 && !jumping)
            {
                force = 12;
                trex.Top = floor.Top - trex.Height;
                jumpSpeed = 0;
            }
            if (score >= 10)
            {
                obstacleSpeed = 15;
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                resetGame();
            }
            if (e.KeyCode == Keys.B)
            {
                Form14 form14 = new Form14();
                form14.kullanici_adi_form14 = kullanici_adi_form19;
                this.Hide();
                form14.Show();
            }
            if (jumping)
            {
                jumping = false;
            }
        }
        public void resetGame()
        {

            force = 12;
            trex.Top = floor.Top - trex.Height;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            scoreText.Text = "Score: " + score;
            trex.Image = Properties.Resources.running;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    int position = rnd.Next(600, 1000);
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }
            gameTimer.Start();
        }
    }
}
