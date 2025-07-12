using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEM
{
    public partial class Form7 : Form
    {
        public string Kullanici_adi_form7;
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.kullanici_adi_form14 = Kullanici_adi_form7;
            this.Hide();
            form14.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Kullanici_adi_form7 == kaditext.Text.TrimEnd().ToString())
            {
                HesapSil();
            }
            else
            {
                MessageBox.Show("Bilgilerinizde hata mevcut!");
            }
        }
        void HesapSil()
        {
            DialogResult result = MessageBox.Show("Hesap silme işlemini gerçekten yapmak istiyor musunuz?", "Hesap Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
                {
                    string KullaniciAdi = kaditext.Text.TrimEnd().ToString(), KullaniciSifresi = ksifretext.Text.TrimEnd().ToString(), KullaniciSifresiYeniden = ksifreyenidentext.Text.TrimEnd().ToString(), kullaniciemail = kmailtext.Text.TrimEnd().ToString(), kullanicitelefon = kteltext.Text.ToString().TrimEnd();

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
                                        if (kullanicitelefon == reader["kullanici_telefon_no"].ToString().TrimEnd() && kullaniciemail == reader["kullanici_email"].ToString().TrimEnd() && KullaniciSifresi == reader["kullanici_sifresi"].ToString().TrimEnd() && KullaniciSifresiYeniden == reader["kullanici_kayit_sifresi"].ToString().TrimEnd())
                                        {
                                            reader.Close();

                                            using (SqlCommand cmd = new SqlCommand("DELETE FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                                            {
                                                cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                                cmd.ExecuteNonQuery();
                                            }
                                            using (SqlCommand cmd1 = new SqlCommand("DELETE FROM kullanicikutuphanesidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                                            {
                                                cmd1.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                                cmd1.ExecuteNonQuery();
                                            }
                                            MessageBox.Show("Hesap başarıyla silindi");
                                            Form2 form2 = new Form2();
                                            this.Hide();
                                            form2.Show();
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
                        }
                        else
                        {
                            MessageBox.Show("Girilen şifreler aynı olmalıdır!");
                        }
                    }
                }
            }
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
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
