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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form8;
        private void button1_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.kullanici_adi_form14 = kullanici_adi_form8;
            this.Hide();
            form14.Show();
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void MevcutPara()
        {
            int mevcutPara;
            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
            connection.Open();
            using (SqlCommand command = new SqlCommand("Select * from kullanicidatabase where kullanici_adi= @KullaniciAdi", connection))
            {
                command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form8);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        mevcutPara = Convert.ToInt32(reader["kullanici_parasi"]);
                        ParaEkle(mevcutPara);
                    }
                    else
                    {
                        MessageBox.Show("Bilgiler uyuşmuyor.");
                    }
                }
            }
            connection.Close();
        }
        void ParaEkle(int mevcutPara)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
            {
                string kartSahibi = kartsahibitext.Text.TrimEnd().ToString(), kullaniciAdi = kullanici_adi_form8, dort1 = dort1text.Text.TrimEnd().ToString(), dort2 = dort2text.Text.TrimEnd().ToString(), dort3 = dort3text.Text.TrimEnd().ToString(), dort4 = dort4text.Text.TrimEnd().ToString(), validthru = validaytext.Text.ToString().TrimEnd(), validthru2 = validyıltext.Text.ToString().TrimEnd(), cvc2 = cvc2text.Text.TrimEnd().TrimEnd(), kullaniciParasi = eklenenparatext.Text.ToString().TrimEnd();
                int yenipara = Convert.ToInt32(kullaniciParasi) + mevcutPara;
                int tarihay = Convert.ToInt32(validaytext.Text.TrimEnd()), tarihyıl = Convert.ToInt32(validyıltext.Text.TrimEnd()), cvc2int = Convert.ToInt32(cvc2text.Text.TrimEnd()), eklenenpara = Convert.ToInt32(eklenenparatext.Text.TrimEnd());

                if (string.IsNullOrEmpty(kartSahibi))
                {
                    MessageBox.Show("Lütfen kart sahibi bilgilerini eksiksiz doldurunuz!");
                }
                else
                {
                    if (dort1.Length == 4 && dort2.Length == 4 && dort3.Length == 4 && dort4.Length == 4)
                    {
                        if (validthru.Length == 2 && validthru2.Length == 2)
                        {
                            if (tarihay < 13 && tarihay > -1 && tarihyıl > 23 && tarihyıl < 99)
                            {
                                if (cvc2.Length == 3)
                                {
                                    if (cvc2int > 0)
                                    {
                                        if (eklenenpara <= 5000 && eklenenpara > 0)
                                        {
                                            connection.Open();
                                            using (SqlCommand command = new SqlCommand("SELECT * FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                                            {
                                                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                                                using (SqlDataReader reader = command.ExecuteReader())
                                                {
                                                    if (reader.Read())
                                                    {
                                                        if (kullaniciAdi == kullanici_adi_form8)
                                                        {
                                                            reader.Close();
                                                            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @kullaniciparasi WHERE kullanici_adi = @KullaniciAdi", connection))
                                                            {
                                                                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                                                                cmd.Parameters.AddWithValue("@kullaniciparasi", yenipara);
                                                                cmd.ExecuteNonQuery();

                                                                MessageBox.Show("Para ekleme işlemi tamamlandı! \nProfil sekmesine aktarılıyorsunuz!");
                                                                Form14 form14 = new Form14();
                                                                form14.kullanici_adi_form14 = kullanici_adi_form8;
                                                                this.Hide();
                                                                form14.Show();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Bilgiler uyuşmuyor.");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Kullanıcı bulunamadı.");
                                                    }
                                                }
                                            }
                                            connection.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Eklenen tutar ekleme limitini aşıyor ya da tutarı yanlış girdiniz!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kart CVC2 kodu geçersiz!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Kart CVC2 kodu hatalı!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kart son kullanım tarihi geçmiş yada geçersiz!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kart son kullanım tarihi hatalı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kart numarası hatalı!");
                    }
                }
            }
        }
        private void paraekletamamla_Click(object sender, EventArgs e)
        {
            MevcutPara();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            KullanıcıParası();
        }
        void KullanıcıParası()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
            connection.Open();
            using (SqlCommand command = new SqlCommand("Select * from kullanicidatabase where kullanici_adi= @KullaniciAdi", connection))
            {
                command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form8);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kullaniciparasilabel.Text = "Mevcut paranız " + reader["kullanici_parasi"].ToString().TrimEnd() + " TL";
                    }
                    else
                    {
                        MessageBox.Show("Bilgiler uyuşmuyor.");
                    }
                }
            }
            connection.Close();
        }

        private void sayı_Kontrol(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
