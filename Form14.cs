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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form14;
        private void Form14_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void magazabutonu_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.kullanici_adi_form13 = kullanici_adi_form14;
            this.Hide();
            form13.Show();
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            if (kullanici_adi_form14 != "misafir")
            {
                KullanıcıPP();
                KullanıcıAdı();
                KullanıcıParası();
                OyunlarText();
                Gerekliler();
            }
            if(kullanici_adi_form14 == "misafir")
            {
                kadilabel.Text = "Misafir";
                kullaniciparasilabel.Text = "0 TL";
            }
        }
        void Gerekliler()
        {
            comboBox1.Text = "KÜTÜPHANE";
            comboBox2.Text = "PROFİL BİLGİLERİ";
        }
        void KullanıcıPP()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT kullanici_pp FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form14);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["kullanici_pp"] != DBNull.Value)
                            {
                                byte[] fotoBinary = (byte[])reader["kullanici_pp"];
                                MemoryStream ms = new MemoryStream(fotoBinary);
                                kullanicipp.Image = Image.FromStream(ms);
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
        }
        void KullanıcıAdı()
        {
            kadilabel.Text = kullanici_adi_form14;
        }
        void KullanıcıParası()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
            connection.Open();
            using (SqlCommand command = new SqlCommand("Select * from kullanicidatabase where kullanici_adi= @KullaniciAdi", connection))
            {
                command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form14);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kullaniciparasilabel.Text = reader["kullanici_parasi"].ToString().TrimEnd() + " TL";
                    }
                    else
                    {
                        MessageBox.Show("Bilgiler uyuşmuyor.");
                    }
                }
            }
            connection.Close();
        }
        void OyunlarText()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
            connection.Open();
            using (SqlCommand command = new SqlCommand("Select * from kullanicidatabase where kullanici_adi= @KullaniciAdi", connection))
            {
                command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form14);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["yilan_oyunu_skor"] == DBNull.Value)
                        {
                            yilanoyunbuton.Text = "Mevcut Değil";
                            yilanoyunbuton.Enabled = false;
                        }
                        else
                        {
                            yilanoyunbuton.Text = "Oyunu Oyna";
                        }
                        if (reader["trex_oyunu_skor"] == DBNull.Value)
                        {
                            trexbuton.Text = "Mevcut Değil";
                            trexbuton.Enabled = false;
                        }
                        else
                        {
                            trexbuton.Text = "Oyunu Oyna";
                        }
                        if (reader["mayin_oyunu_skor"] == DBNull.Value)
                        {
                            mayıntarlasibuton.Text = "Mevcut Değil";
                            mayıntarlasibuton.Enabled = false;
                        }
                        else
                        {
                            mayıntarlasibuton.Text = "Oyunu Oyna";
                        }
                        if (reader["ucankus_oyunu_skor"] == DBNull.Value)
                        {
                            flappybuton.Text = "Mevcut Değil";
                            flappybuton.Enabled = false;
                        }
                        else
                        {
                            flappybuton.Text = "Oyunu Oyna";
                        }
                        if (reader["adamasmaca_oyunu_skor"] == DBNull.Value)
                        {
                            adamasmacabutonu.Text = "Mevcut Değil";
                            adamasmacabutonu.Enabled = false;
                        }
                        else
                        {
                            adamasmacabutonu.Text = "Oyunu Oyna";
                        }
                        if (reader["xox_oyunu_skor"] == DBNull.Value)
                        {
                            xoxbuton.Text = "Mevcut Değil";
                            xoxbuton.Enabled = false;
                        }
                        else
                        {
                            xoxbuton.Text = "Oyunu Oyna";
                        }
                        if (reader["tkm_oyunu_skor"] == DBNull.Value)
                        {
                            tkmbuton.Text = "Mevcut Değil";
                            tkmbuton.Enabled = false;
                        }
                        else
                        {
                            tkmbuton.Text = "Oyunu Oyna";
                        }
                        if (reader["esbulma_oyunu_skor"] == DBNull.Value)
                        {
                            esbulmabuton.Text = "Mevcut Değil";
                            esbulmabuton.Enabled = false;
                        }
                        else
                        {
                            esbulmabuton.Text = "Oyunu Oyna";
                        }
                    }
                }
            }
        }
        private void OyunOynaButonlar(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.kullanici_adi_form15 = kullanici_adi_form14;

            if (sender is Button tiklananbuton)
            {
                DialogResult result1 = MessageBox.Show("Bu oyunu oynamak istiyor musunuz?", "Oynama Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {

                    if (tiklananbuton == yilanoyunbuton)
                    {
                        form15.oynanan_oyun = "yılan";
                        this.Hide();
                        form15.Show();
                    }
                    if (tiklananbuton == flappybuton)
                    {
                        form15.oynanan_oyun = "uçankuş";
                        this.Hide();
                        form15.Show();
                    }
                    if (tiklananbuton == mayıntarlasibuton)
                    {
                        form15.oynanan_oyun = "mayıntarlası";
                        this.Hide();
                        form15.Show();
                    }
                    if (tiklananbuton == trexbuton)
                    {
                        form15.oynanan_oyun = "trex";
                        this.Hide();
                        form15.Show();
                    }
                    if (tiklananbuton == adamasmacabutonu)
                    {
                        form15.oynanan_oyun = "adamasmaca";
                        this.Hide();
                        form15.Show();
                    }
                    if (tiklananbuton == xoxbuton)
                    {
                        form15.oynanan_oyun = "xox";
                        this.Hide();
                        form15.Show();
                    }
                    if (tiklananbuton == tkmbuton)
                    {
                        form15.oynanan_oyun = "tkm";
                        this.Hide();
                        form15.Show();
                    }
                    if (tiklananbuton == esbulmabuton)
                    {
                        form15.oynanan_oyun = "eşbulma";
                        this.Hide();
                        form15.Show();
                    }
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form13 form13 = new Form13();
                form13.kullanici_adi_form13 = kullanici_adi_form14;
                this.Hide();
                form13.Show();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                return;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                //ŞİFRE
                bool sifredegisim = true;
                string yeniŞifre = Microsoft.VisualBasic.Interaction.InputBox("Yeni şifrenizi giriniz:", "Şifre Değiştir");
                if (string.IsNullOrEmpty(yeniŞifre))
                {
                    MessageBox.Show("Lütfen boş bırakmayınız", "Bilgi Değişim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (yeniŞifre.Length <= 15)
                {
                    sifredegisim = false;
                }
                if (sifredegisim == true)
                {
                    MessageBox.Show("Şifre kabul edilebilir şekilde değil.\nEn az bir tane büyük harf kullanın ve şifre uzunluğunun 15'i geçmediğine emin olun", "Bilgi Hatası Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (kullanici_adi_form14 != "misafir")
                {
                    if (sifredegisim == false)
                    {
                        string yenisifre = yeniŞifre;
                        string KullaniciAdi = kullanici_adi_form14.TrimEnd();
                        using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("SELECT * FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                            {
                                command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        reader.Close();
                                        using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET kullanici_sifresi = @yeniŞifre, kullanici_kayit_sifresi = @yenisifre WHERE kullanici_adi = @KullaniciAdi", connection))
                                        {
                                            cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                            cmd.Parameters.AddWithValue("@yenisifre", yenisifre.TrimEnd());
                                            cmd.Parameters.AddWithValue("@yeniŞifre", yeniŞifre.TrimEnd());
                                            cmd.ExecuteNonQuery();
                                        }
                                        MessageBox.Show("Şifre değiştirme işlemi gerçekleştirildi");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Şifre değiştirilirken hata oluştu.");
                                    }
                                }
                            }
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Misafir modundan çıkınız.","Misafir Modu",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (comboBox2.SelectedIndex == 1)
            {
                //MAİL
                bool emailkayit = true;
                string yeniMail = Microsoft.VisualBasic.Interaction.InputBox("Yeni Mail adresinizi giriniz:", "Mail Adresi Değiştir");
                if (string.IsNullOrEmpty(yeniMail))
                {
                    MessageBox.Show("Lütfen boş bırakmayınız", "Bilgi Değişim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (yeniMail.Contains("@") && yeniMail.Contains(".com") && yeniMail.Length <= 25)
                {
                    emailkayit = false;
                }
                if (emailkayit == true)
                {
                    MessageBox.Show("Mail adresinin doğruluğuna dikkat ediniz.", "Mail Doğruluğu İhlali", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (emailkayit == false)
                {
                    if (kullanici_adi_form14 != "misafir")
                    {
                        string KullaniciAdi = kullanici_adi_form14.TrimEnd();
                        using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("SELECT * FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                            {
                                command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        reader.Close();

                                        using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET kullanici_email = @yeniMail WHERE kullanici_adi = @KullaniciAdi", connection))
                                        {
                                            cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                            cmd.Parameters.AddWithValue("@yeniMail", yeniMail.TrimEnd());
                                            cmd.ExecuteNonQuery();
                                        }
                                        MessageBox.Show("Mail adresi değiştirme işlemi gerçekleştirildi");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Mail adresi değiştirilirken hata oluştu.");
                                    }
                                }
                            }
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Misafir modundan çıkınız.", "Misafir Modu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (comboBox2.SelectedIndex == 2)
            {
                //TELNO
                string yenitel = Microsoft.VisualBasic.Interaction.InputBox("Yeni telefon numaranızı giriniz:", "Telefon Numarası Değiştir");
                bool telnodegisim = true;
                if (string.IsNullOrEmpty(yenitel))
                {
                    MessageBox.Show("Lütfen boş bırakmayınız", "Bilgi Değişim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (yenitel.Length == 11)
                {
                    telnodegisim = false;
                }
                if (telnodegisim == true)
                {
                    MessageBox.Show("Telefon numaranızın doğruluğuna dikkat ediniz.", "Şifre Doğruluğu İhlali", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (telnodegisim == false)
                {
                    if (kullanici_adi_form14 != "misafir")
                    {
                        string KullaniciAdi = kullanici_adi_form14.TrimEnd();
                        using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("SELECT * FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                            {
                                command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        reader.Close();

                                        using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET kullanici_telefon_no = @yenitel WHERE kullanici_adi = @KullaniciAdi", connection))
                                        {
                                            cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                                            cmd.Parameters.AddWithValue("@yenitel", yenitel.TrimEnd());
                                            cmd.ExecuteNonQuery();
                                        }
                                        MessageBox.Show("Telefon numarası değiştirme işlemi gerçekleştirildi");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Telefon numarası değiştirilirken hata oluştu.");
                                    }
                                }
                            }
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Misafir modundan çıkınız.", "Misafir Modu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (comboBox2.SelectedIndex == 3)
            {
                string imagepath;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Resim Seç";
                openFileDialog.Filter = "Jpeg Dosyaları(*.jpeg)|*.jpeg| Jpg Dosyaları (*.jpg)|*.jpg| Png Dosyaları(*.png)|*.png| Gif Dosyaları(*.gif)|*.gif| Tif Dosyaları (*.tif)|*tif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    kullanicipp.Image = Image.FromFile(openFileDialog.FileName);
                    imagepath = openFileDialog.FileName;
                    FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                    BinaryReader reader1 = new BinaryReader(fileStream);
                    byte[] resim = reader1.ReadBytes((int)fileStream.Length);
                    reader1.Close();
                    fileStream.Close();
                    if (kullanici_adi_form14 != "misafir")
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("UPDATE kullanicidatabase SET kullanici_pp = @images WHERE kullanici_adi = @KullaniciAdi", connection))
                            {
                                command.Parameters.Add("@images", SqlDbType.Image, resim.Length).Value = resim;
                                command.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = kullanici_adi_form14;
                                command.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Misafir modundan çıkınız. \n Profil fotoğrafınız sadece şimdilik değişti!", "Misafir Modu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    MessageBox.Show("Profil fotoğrafınız güncellendi.");
                }
            }
            if (comboBox2.SelectedIndex == 4)
            {
                //PARA EKLE
                Form8 form8 = new Form8();
                form8.kullanici_adi_form8 = kullanici_adi_form14;
                this.Hide();
                form8.Show();
            }
            if(comboBox2.SelectedIndex == 5)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            if (comboBox2.SelectedIndex == 6)
            {
                Form7 form7 = new Form7();
                form7.Kullanici_adi_form7 = kullanici_adi_form14;
                this.Hide();
                form7.Show();
            }
        }
    }
}