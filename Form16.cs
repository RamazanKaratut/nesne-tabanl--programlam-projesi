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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form16;
        private void Form16_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        private void gameTimer(object sender, EventArgs e)
        {
            kuspp.BackColor = Color.Transparent;
            zamankontrol.Start();
            kuspp.Top += gravity;
            altkisimpp.Left -= pipeSpeed;
            ustkisimpp.Left -= pipeSpeed;
            label1.Text = "Skor: " + score;

            if (altkisimpp.Left < -100)
            {
                altkisimpp.Left = 800;
                score++;
            }
            if (ustkisimpp.Left < -100)
            {
                ustkisimpp.Left = 950;
                score++;
            }
            if (kuspp.Bounds.IntersectsWith(altkisimpp.Bounds)
                || kuspp.Bounds.IntersectsWith(ustkisimpp.Bounds)
                || kuspp.Bounds.IntersectsWith(zeminpp.Bounds)
                || kuspp.Top < -25)
            {
                EndGame(score);
            }
        }
        public void EndGame(int skor)
        {
            int skor1 = Convert.ToInt32(skor);
            int eskiskor;
            zamankontrol.Stop();
            label1.Text = "GAME OVER";
            if (kullanici_adi_form16 != "misafir")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT ucankus_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form16", connection))
                {
                    command.Parameters.AddWithValue("@kullanici_adi_form16", kullanici_adi_form16);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            eskiskor = Convert.ToInt32(reader["ucankus_oyunu_skor"].ToString());
                            reader.Close();
                            if (skor1 > eskiskor)
                            {
                                using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET  ucankus_oyunu_skor= @skor1 WHERE kullanici_adi = @kullanici_adi_form16", connection))
                                {
                                    cmd.Parameters.AddWithValue("@kullanici_adi_form16", kullanici_adi_form16);
                                    cmd.Parameters.AddWithValue("@skor1", skor1);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Misafir modunda skor kaydı tutulmamaktadır.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            DialogResult result1 = MessageBox.Show("Yeniden oynamak istiyor musunuz?", "Yeniden Oynama Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                score = 0;
                kuspp.Top = 110;
                altkisimpp.Left = 800;
                ustkisimpp.Left = 950;
                zamankontrol.Start();
                kuspp.Top += gravity;
                altkisimpp.Left -= pipeSpeed;
                ustkisimpp.Left -= pipeSpeed;
                label1.Text = "Skor: " + score;

                if (altkisimpp.Left < -100)
                {
                    altkisimpp.Left = 800;
                    score++;
                }
                if (ustkisimpp.Left < -100)
                {
                    ustkisimpp.Left = 950;
                    score++;
                }
                if (kuspp.Bounds.IntersectsWith(altkisimpp.Bounds)
                    || kuspp.Bounds.IntersectsWith(ustkisimpp.Bounds)
                    || kuspp.Bounds.IntersectsWith(zeminpp.Bounds)
                    || kuspp.Top < -25)
                {
                    EndGame(score);
                }
            }
            if (result1 == DialogResult.No)
            {
                Form14 form14 = new Form14();
                form14.kullanici_adi_form14 = kullanici_adi_form16;
                this.Hide();
                form14.Show();
            }
        }
        private void Form16_MouseDown(object sender, MouseEventArgs e)
        {
            gravity = -15;
        }

        private void Form16_MouseUp(object sender, MouseEventArgs e)
        {
            gravity = 15;
        }
    }
}
