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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ŞifreDeğiştir();
        }
        void ŞifreDeğiştir()
        {
            bool deneme2 = true;
            using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
            {
                string KullaniciAdi = kaditext.Text.TrimEnd().ToString(), KullaniciSifresi = ksifretext.Text.TrimEnd().ToString(), KullaniciSifresiYeniden = ksifreyenidentext.Text.TrimEnd().ToString(), kullaniciemail = kmailtext.Text.TrimEnd().ToString(), kullanicitelefon = kteltext.Text.ToString().TrimEnd();
                if (KullaniciSifresi.Length <= 15)
                {
                    if (string.IsNullOrEmpty(KullaniciAdi) || string.IsNullOrEmpty(KullaniciSifresi) || string.IsNullOrEmpty(KullaniciSifresiYeniden) || string.IsNullOrEmpty(kullaniciemail) || string.IsNullOrEmpty(kullanicitelefon))
                    {
                        MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
                    }
                    else
                    {
                        if (KullaniciSifresi == KullaniciSifresiYeniden)
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("SELECT * FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                            {
                                command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        if (kurtarmatext.Text == reader["kullanici_rastgele_sayisi"].ToString().TrimEnd() && kullanicitelefon == reader["kullanici_telefon_no"].ToString().TrimEnd() && kullaniciemail == reader["kullanici_email"].ToString().TrimEnd())
                                        {
                                            reader.Close();
                                            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET kullanici_sifresi = @KullaniciSifresi, kullanici_kayit_sifresi = @KullaniciKayitSifresi WHERE kullanici_adi = @KullaniciAdi", connection))
                                            {
                                                cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                                cmd.Parameters.AddWithValue("@KullaniciSifresi", KullaniciSifresi);
                                                cmd.Parameters.AddWithValue("@KullaniciKayitSifresi", KullaniciSifresiYeniden);
                                                cmd.ExecuteNonQuery();
                                            }
                                            MessageBox.Show("Şifre değiştirme işlemi gerçekleştirildi");
                                            Form2 form2 = new Form2();
                                            this.Hide();
                                            form2.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Bilgiler uyuşmuyor yada kurtarma kodunuz geçersiz.");
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
                            MessageBox.Show("Girilen şifreler aynı olmalıdır!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Girilen şifrenin uzunluğuna dikkat ediniz!");
                }
            }
        }
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
