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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form15;
        public string oynanan_oyun;
        private void Form15_Load(object sender, EventArgs e)
        {
            if (kullanici_adi_form15 != "misafir")
            {
                KullanıcıPP();
                KullanıcıAdı();
                KullanıcıSkor();
                KullanıcıOyun();
            }
            if (kullanici_adi_form15 == "misafir")
            {
                kadilabel.Text = "Misafir";
                OyunYaz();
            }
        }
        private void geridon_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.kullanici_adi_form14 = kullanici_adi_form15;
            this.Hide();
            form14.Show();
        }
        void KullanıcıPP()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT kullanici_pp FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);

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
            kadilabel.Text = kullanici_adi_form15;
        }
        void OyunYaz()
        {
            if (oynanan_oyun == "yılan")
            {
                oynananoyunlabel.Text = "YILAN";
            }
            if (oynanan_oyun == "uçankuş")
            {
                oynananoyunlabel.Text = "UÇAN KUŞ";
            }
            if (oynanan_oyun == "mayıntarlası")
            {
                oynananoyunlabel.Text = "MAYIN TARLASI";
            }
            if (oynanan_oyun == "trex")
            {
                oynananoyunlabel.Text = "TREX";
            }
            if (oynanan_oyun == "adamasmaca")
            {
                oynananoyunlabel.Text = "ADAM ASMACA";
            }
            if (oynanan_oyun == "xox")
            {
                oynananoyunlabel.Text = "XOX";
            }
            if (oynanan_oyun == "tkm")
            {
                oynananoyunlabel.Text = "TAŞ KAĞIT MAKAS";
            }
            if (oynanan_oyun == "eşbulma")
            {
                oynananoyunlabel.Text = "EŞ BULMA";
            }
        }
        void KullanıcıSkor()
        {
            label1.Text = "Yüksek Skor:";
            using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
            {
                connection.Open();
                if (oynanan_oyun == "yılan")
                {
                    using (SqlCommand command = new SqlCommand("SELECT yilan_oyunu_skor FROM kullanicidatabase where kullanici_adi = @KullaniciAdi", connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                skorlabel.Text = reader["yilan_oyunu_skor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "uçankuş")
                {
                    label1.Text = "Yüksek Skor:";
                    using (SqlCommand command = new SqlCommand("SELECT ucankus_oyunu_skor FROM kullanicidatabase where kullanici_adi = @KullaniciAdi", connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                skorlabel.Text = reader["ucankus_oyunu_skor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "mayıntarlası")
                {
                    label1.Text = "Yüksek Skor:";
                    using (SqlCommand command = new SqlCommand("SELECT mayin_oyunu_skor FROM kullanicidatabase where kullanici_adi = @KullaniciAdi", connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                skorlabel.Text = reader["mayin_oyunu_skor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "trex")
                {
                    label1.Text = "Yüksek Skor:";
                    using (SqlCommand command = new SqlCommand("SELECT trex_oyunu_skor FROM kullanicidatabase where kullanici_adi = @KullaniciAdi", connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                skorlabel.Text = reader["trex_oyunu_skor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "adamasmaca")
                {
                    label1.Text = "Yüksek Skor:";
                    using (SqlCommand command = new SqlCommand("SELECT adamasmaca_oyunu_skor FROM kullanicidatabase where kullanici_adi = @KullaniciAdi", connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                skorlabel.Text = reader["adamasmaca_oyunu_skor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "xox")
                {
                    label1.Text = "Toplam skor:";
                    using (SqlCommand command = new SqlCommand("SELECT xox_oyunu_skor FROM kullanicidatabase where kullanici_adi = @KullaniciAdi", connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                skorlabel.Text = reader["xox_oyunu_skor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "tkm")
                {
                    label1.Text = "Toplam skor:";
                    using (SqlCommand command = new SqlCommand("SELECT tkm_oyunu_skor FROM kullanicidatabase where kullanici_adi = @KullaniciAdi", connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                skorlabel.Text = reader["tkm_oyunu_skor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "eşbulma")
                {
                    label1.Text = "Yüksek Skor:";
                    using (SqlCommand command = new SqlCommand("SELECT esbulma_oyunu_skor FROM kullanicidatabase where kullanici_adi = @KullaniciAdi", connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form15);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                skorlabel.Text = reader["esbulma_oyunu_skor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
            }
        }
        void KullanıcıOyun()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
            {
                connection.Open();
                if (oynanan_oyun == "yılan")
                {
                    using (SqlCommand command = new SqlCommand("SELECT oyun_yilan_pp FROM magazadatabase", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["oyun_yilan_pp"] != DBNull.Value)
                                {
                                    byte[] fotoBinary = (byte[])reader["oyun_yilan_pp"];
                                    MemoryStream ms = new MemoryStream(fotoBinary);
                                    oyunfoto.Image = Image.FromStream(ms);
                                    oynananoyunlabel.Text = "YILAN";
                                    ikikisilikoyna.Enabled = false;
                                    ikikisilikoyna.Visible = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "trex")
                {
                    using (SqlCommand command = new SqlCommand("SELECT oyun_trex_pp FROM magazadatabase", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["oyun_trex_pp"] != DBNull.Value)
                                {
                                    byte[] fotoBinary = (byte[])reader["oyun_trex_pp"];
                                    MemoryStream ms = new MemoryStream(fotoBinary);
                                    oyunfoto.Image = Image.FromStream(ms);
                                    oynananoyunlabel.Text = "TREX";
                                    ikikisilikoyna.Enabled = false;
                                    ikikisilikoyna.Visible = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "mayıntarlası")
                {
                    using (SqlCommand command = new SqlCommand("SELECT oyun_mayin_tarlasi_pp FROM magazadatabase", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["oyun_mayin_tarlasi_pp"] != DBNull.Value)
                                {
                                    byte[] fotoBinary = (byte[])reader["oyun_mayin_tarlasi_pp"];
                                    MemoryStream ms = new MemoryStream(fotoBinary);
                                    oyunfoto.Image = Image.FromStream(ms);
                                    oynananoyunlabel.Text = "MAYIN TARLASI";
                                    ikikisilikoyna.Enabled = false;
                                    ikikisilikoyna.Visible = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "uçankuş")
                {
                    using (SqlCommand command = new SqlCommand("SELECT oyun_ucan_kus_pp FROM magazadatabase", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["oyun_ucan_kus_pp"] != DBNull.Value)
                                {
                                    byte[] fotoBinary = (byte[])reader["oyun_ucan_kus_pp"];
                                    MemoryStream ms = new MemoryStream(fotoBinary);
                                    oyunfoto.Image = Image.FromStream(ms);
                                    oynananoyunlabel.Text = "UÇAN KUŞ";
                                    ikikisilikoyna.Enabled = false;
                                    ikikisilikoyna.Visible = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "adamasmaca")
                {
                    using (SqlCommand command = new SqlCommand("SELECT oyun_adam_asmaca_pp FROM magazadatabase", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["oyun_adam_asmaca_pp"] != DBNull.Value)
                                {
                                    byte[] fotoBinary = (byte[])reader["oyun_adam_asmaca_pp"];
                                    MemoryStream ms = new MemoryStream(fotoBinary);
                                    oyunfoto.Image = Image.FromStream(ms);
                                    oynananoyunlabel.Text = "ADAM ASMACA";
                                    ikikisilikoyna.Enabled = false;
                                    ikikisilikoyna.Visible = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }

                }
                if (oynanan_oyun == "xox")
                {
                    using (SqlCommand command = new SqlCommand("SELECT oyun_xox_pp FROM magazadatabase", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["oyun_xox_pp"] != DBNull.Value)
                                {
                                    byte[] fotoBinary = (byte[])reader["oyun_xox_pp"];
                                    MemoryStream ms = new MemoryStream(fotoBinary);
                                    oyunfoto.Image = Image.FromStream(ms);
                                    oynananoyunlabel.Text = "XOX";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "tkm")
                {
                    using (SqlCommand command = new SqlCommand("SELECT oyun_tkm_pp FROM magazadatabase", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["oyun_tkm_pp"] != DBNull.Value)
                                {
                                    byte[] fotoBinary = (byte[])reader["oyun_tkm_pp"];
                                    MemoryStream ms = new MemoryStream(fotoBinary);
                                    oyunfoto.Image = Image.FromStream(ms);
                                    oynananoyunlabel.Text = "TAŞ- KAĞIT- MAKAS";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                if (oynanan_oyun == "eşbulma")
                {
                    using (SqlCommand command = new SqlCommand("SELECT oyun_esbulma_pp FROM magazadatabase", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["oyun_esbulma_pp"] != DBNull.Value)
                                {
                                    byte[] fotoBinary = (byte[])reader["oyun_esbulma_pp"];
                                    MemoryStream ms = new MemoryStream(fotoBinary);
                                    oyunfoto.Image = Image.FromStream(ms);
                                    oynananoyunlabel.Text = "EŞ BULMA";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                    }
                }
                connection.Close();
            }
        }
        private void Form15_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void oynabuton_Click(object sender, EventArgs e)
        {
            if (oynanan_oyun == "uçankuş")
            {
                Form16 form16 = new Form16();
                form16.kullanici_adi_form16 = kullanici_adi_form15;
                this.Hide();
                form16.Show();
            }
            if (oynanan_oyun == "xox")
            {
                Form18 form18 = new Form18();
                form18.kullanici_adi_form18 = kullanici_adi_form15;
                this.Hide();
                form18.Show();
            }
            if(oynanan_oyun == "trex")
            {
                Form19 form19 = new Form19();
                form19.kullanici_adi_form19 = kullanici_adi_form15;
                this.Hide();
                form19.Show();
            }
            if(oynanan_oyun == "tkm")
            {
                Form21 form21 = new Form21();   
                form21.kullanici_adi_form21 = kullanici_adi_form15;
                this.Hide();
                form21.Show();
            }
            if(oynanan_oyun == "adamasmaca")
            {
                Form22 form22 = new Form22();
                form22.kullanici_adi_form22 = kullanici_adi_form15;
                this.Hide();
                form22.Show();
            }
            if(oynanan_oyun == "yılan")
            {
                Form4 form4 = new Form4();
                form4.kullanici_adi_form4= kullanici_adi_form15;
                this.Hide();
                form4.Show();
            }
            if(oynanan_oyun == "mayıntarlası")
            {
                Form23 form23 = new Form23();
                form23.kullanici_adi_form23 = kullanici_adi_form15;
                this.Hide();
                form23.Show();
            }
            if(oynanan_oyun == "eşbulma")
            {
                Form24 form24 = new Form24();
                form24.kullanici_adi_form24 = kullanici_adi_form15;
                this.Hide();
                form24.Show();
            }
        }
        private void ikikisilikoyna_Click(object sender, EventArgs e)
        {
            if(oynanan_oyun == "xox")
            {
                Form17 form17 = new Form17();
                form17.kullanici_adi_form17 = kullanici_adi_form15;
                this.Hide(); 
                form17.Show();
            }
            if(oynanan_oyun == "tkm")
            {
                Form20 form20 = new Form20();
                form20.kullanici_adi_form20 = kullanici_adi_form15;
                this.Hide();
                form20.Show();
            }
            if (oynanan_oyun == "eşbulma")
            {
                Form25 form25 = new Form25();
                form25.kullanici_adi_form25 = kullanici_adi_form15;
                this.Hide();
                form25.Show();
            }
        }
    }
}
