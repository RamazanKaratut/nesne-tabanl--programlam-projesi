using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEM
{
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KayıtOl();
        }
        void KayıtOl()
        {
            int Kullaniciparasi = 0;
            using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
            {
                bool deneme1 = false;
                string KullaniciAdi = kaditext.Text.TrimEnd().ToString(), KullaniciSifresi = ksifretext.Text.TrimEnd().ToString(), kullaniciMail = kmailtext.Text.TrimEnd().ToString(), kullanicisifreyeniden = ksifreyenidentext.Text.TrimEnd().ToString(), kullanicitelefon = kteltext.Text.TrimEnd().ToString();

                if (KullaniciAdi.Length <= 15 && KullaniciSifresi.Length <= 15 && kullaniciMail.Length <= 35 && kullanicitelefon.Length == 11)
                {
                    if (string.IsNullOrEmpty(KullaniciAdi) || string.IsNullOrEmpty(KullaniciSifresi) || string.IsNullOrEmpty(kullanicisifreyeniden) || string.IsNullOrEmpty(kullaniciMail) || string.IsNullOrEmpty(kullanicitelefon))
                    {
                        MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
                    }
                    else
                    {
                        if (KullaniciSifresi == kullanicisifreyeniden)
                        {
                            if (kullaniciMail.Contains("@") && kullaniciMail.Contains(".com"))
                            {

                                connection.Open();
                                // Kullanıcı adı, e-Mail ve telefon kontrolü
                                using (SqlCommand command = new SqlCommand("SELECT * FROM kullanicidatabase", connection))
                                {
                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            if (KullaniciAdi == reader["kullanici_adi"].ToString().TrimEnd())
                                            {
                                                MessageBox.Show("Kullanıcı adı kullanılıyor");
                                                deneme1 = true;
                                                return; // Kontrolü bitir ve metodu sonlandır
                                            }
                                        }
                                    }
                                }
                                // Kullanıcıyı ekle
                                if (deneme1 == false)
                                {
                                    Random random = new Random();
                                    int maxdeğer = (int)Math.Pow(10, 10) - 1;
                                    int mindeğer = (int)Math.Pow(10, 9);
                                    int KurtarmaKodu = random.Next(mindeğer, maxdeğer);
                                    MessageBox.Show($"Kayıt Başarılı!\nKurtarma kodunuzu kaydetmeyi unutmayınız aksi halde hesabınızın şifresini unutmanız halinde hesabınızı kurtaramazsınız!\nKurtarma kodunuz: {KurtarmaKodu}");
                                    using (SqlCommand cmd = new SqlCommand("INSERT INTO kullanicidatabase(kullanici_adi, kullanici_sifresi, kullanici_kayit_sifresi, kullanici_email, kullanici_telefon_no, kullanici_parasi, kullanici_rastgele_sayisi) VALUES(@KullaniciAdi, @KullaniciSifresi, @kullanicisifreyeniden, @kullaniciMail, @kullanicitelefon, @Kullaniciparasi, @KurtarmaKodu)", connection))
                                    {
                                        cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                        cmd.Parameters.AddWithValue("@KullaniciSifresi", KullaniciSifresi);
                                        cmd.Parameters.AddWithValue("@kullanicisifreyeniden", kullanicisifreyeniden);
                                        cmd.Parameters.AddWithValue("@kullaniciMail", kullaniciMail);
                                        cmd.Parameters.AddWithValue("@kullanicitelefon", kullanicitelefon);
                                        cmd.Parameters.AddWithValue("@Kullaniciparasi", Kullaniciparasi);
                                        cmd.Parameters.AddWithValue("@KurtarmaKodu", KurtarmaKodu.ToString().TrimEnd());
                                        cmd.ExecuteNonQuery();
                                    }

                                    // Kullanıcıyı kütüphaneye ekle
                                    using (SqlCommand command1 = new SqlCommand("INSERT INTO kullanicikutuphanesidatabase(kullanici_adi) VALUES (@KullaniciAdi)", connection))
                                    {
                                        command1.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                        command1.ExecuteNonQuery();
                                    }
                                    Form2 form2 = new Form2();
                                    this.Hide();
                                    form2.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mail adresi bilgisi yanlış!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Şifreler uyuşmuyor.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Girilen bilgilerin doğruluğunu dikkate alınız!");
                }
            }
        }

        private void kaditext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("\t");
            }
        }

        private void ksifreyenidentext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                KayıtOl();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ksifreyenidentext.PasswordChar == '*')
                ksifreyenidentext.PasswordChar = '\0';
            else
                ksifreyenidentext.PasswordChar = '*';
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ksifretext.PasswordChar == '*')
                ksifretext.PasswordChar = '\0';
            else
                ksifretext.PasswordChar = '*';
        }
    }
}
