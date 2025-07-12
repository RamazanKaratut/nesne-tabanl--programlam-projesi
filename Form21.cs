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
using static System.Formats.Asn1.AsnWriter;

namespace PROJEM
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form21;
        string oyuncu1_secim;
        string bilgisayar_secim;
        int o_puan;
        int b_puan;
        int rastgele;
        Random random = new Random();
        private void Form21_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void tasbutton_Click(object sender, EventArgs e)
        {
            oyuncu1_secim = "Taş";
        }

        private void kagitbuton_Click(object sender, EventArgs e)
        {
            oyuncu1_secim = "Kağıt";
        }
        private void makasbuton_Click(object sender, EventArgs e)
        {
            oyuncu1_secim = "Makas";
        }
        private void Bilgisayar_Hamle()
        {
            rastgele = random.Next(1, 4);
            if (rastgele == 1)
            {
                pcsecimpp.Image = Properties.Resources.tas;
                bilgisayar_secim = "Taş";
            }
            if (rastgele == 2)
            {
                pcsecimpp.Image = Properties.Resources.kagit;
                bilgisayar_secim = "Kağıt";
            }
            if (rastgele == 3)
            {
                pcsecimpp.Image = Properties.Resources.makas;
                bilgisayar_secim = "Makas";
            }
        }
        private void oynabuton_Click(object sender, EventArgs e)
        {
            if (oyuncu1_secim == null)
            {
                MessageBox.Show("Hamle seçimini yapınız", "Seçim Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Bilgisayar_Hamle();
            }
            Puan();
        }
        private void Puan()
        {
            if (oyuncu1_secim == "Taş" && bilgisayar_secim == "Kağıt")
            {
                b_puan++;
                bilgisayarpuan.Text = b_puan.ToString();
                oyuncupuan.Text = o_puan.ToString();
                kazananlabel.Text = "Bilgisayar kazandı";
            }
            else if (oyuncu1_secim == "Taş" && bilgisayar_secim == "Makas")
            {
                o_puan++;
                oyuncupuan.Text = o_puan.ToString();
                bilgisayarpuan.Text = b_puan.ToString();
                kazananlabel.Text = "Siz kazandınız";
            }
            else if (oyuncu1_secim == "Taş" && bilgisayar_secim == "Taş")
            {
                kazananlabel.Text = "Beraberlik";
                oyuncupuan.Text = o_puan.ToString();
                bilgisayarpuan.Text = b_puan.ToString();
            }
            else if (oyuncu1_secim == "Kağıt" && bilgisayar_secim == "Kağıt")
            {
                kazananlabel.Text = "Beraberlik";
                oyuncupuan.Text = o_puan.ToString();
                bilgisayarpuan.Text = b_puan.ToString();
            }
            else if (oyuncu1_secim == "Kağıt" && bilgisayar_secim == "Makas")
            {
                kazananlabel.Text = "Bilgisayar kazandı";
                b_puan++;
                oyuncupuan.Text = o_puan.ToString();
                bilgisayarpuan.Text = b_puan.ToString();
            }
            else if (oyuncu1_secim == "Kağıt" && bilgisayar_secim == "Taş")
            {
                kazananlabel.Text = "Siz kazandınız";
                o_puan++;
                oyuncupuan.Text = o_puan.ToString();
                bilgisayarpuan.Text = b_puan.ToString();
            }
            else if (oyuncu1_secim == "Makas" && bilgisayar_secim == "Kağıt")
            {
                kazananlabel.Text = "Siz kazandınız";
                o_puan++;
                oyuncupuan.Text = o_puan.ToString();
                bilgisayarpuan.Text = b_puan.ToString();
            }
            else if (oyuncu1_secim == "Makas" && bilgisayar_secim == "Makas")
            {
                kazananlabel.Text = "Beraberlik";
                oyuncupuan.Text = o_puan.ToString();
                bilgisayarpuan.Text = b_puan.ToString();
            }
            else if (oyuncu1_secim == "Makas" && bilgisayar_secim == "Taş")
            {
                kazananlabel.Text = "Bilgisayar kazandı";
                b_puan++;
                oyuncupuan.Text = o_puan.ToString();
                bilgisayarpuan.Text = b_puan.ToString();
            }
            if (o_puan == 3)
            {
                int eklenecekskor = 1;
                int eskiskor;
                if (kullanici_adi_form21 != "misafir")
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT tkm_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form21", connection))
                    {
                        command.Parameters.AddWithValue("@kullanici_adi_form21", kullanici_adi_form21);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                eskiskor = Convert.ToInt32(reader["tkm_oyunu_skor"].ToString());
                                int yeniskor = eskiskor + Convert.ToInt32(eklenecekskor);
                                reader.Close();
                                using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET tkm_oyunu_skor = @yeniskor WHERE kullanici_adi = @kullanici_adi_form21", connection))
                                {
                                    cmd.Parameters.AddWithValue("@kullanici_adi_form21", kullanici_adi_form21);
                                    cmd.Parameters.AddWithValue("@yeniskor", yeniskor);
                                    cmd.ExecuteNonQuery();
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
                else
                {
                    MessageBox.Show("Misafir modunda skor kaydı tutulmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult result = MessageBox.Show("Kazandınız, yeniden oynamak ister misiniz", "Yeniden Oynama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    oyuncu1_secim = null;
                    bilgisayar_secim = null;
                    o_puan = 0;
                    b_puan = 0;
                    oyuncupuan.Text = o_puan.ToString();
                    bilgisayarpuan.Text = b_puan.ToString();
                }
                else
                {
                    Form14 form14 = new Form14();
                    form14.kullanici_adi_form14 = kullanici_adi_form21;
                    this.Hide();
                    form14.Show();
                }
            }
            if (b_puan == 3)
            {
                int eklenecekskor = -1;
                int eskiskor;
                if (kullanici_adi_form21 != "misafir")
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT tkm_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form21", connection))
                    {
                        command.Parameters.AddWithValue("@kullanici_adi_form21", kullanici_adi_form21);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                eskiskor = Convert.ToInt32(reader["tkm_oyunu_skor"].ToString());
                                int yeniskor = eskiskor + Convert.ToInt32(eklenecekskor);
                                reader.Close();
                                using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET tkm_oyunu_skor = @yeniskor WHERE kullanici_adi = @kullanici_adi_form21", connection))
                                {
                                    cmd.Parameters.AddWithValue("@kullanici_adi_form21", kullanici_adi_form21);
                                    cmd.Parameters.AddWithValue("@yeniskor", yeniskor);
                                    cmd.ExecuteNonQuery();
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
                else
                {
                    MessageBox.Show("Misafir modunda skor kaydı tutulmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult result = MessageBox.Show("Kaybettiniz, yeniden oynamak ister misiniz", "Yeniden Oynama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    oyuncu1_secim = null;
                    bilgisayar_secim = null;
                    o_puan = 0;
                    b_puan = 0;
                    oyuncupuan.Text = o_puan.ToString();
                    bilgisayarpuan.Text = b_puan.ToString();
                }
                else
                {
                    Form14 form14 = new Form14();
                    form14.kullanici_adi_form14 = kullanici_adi_form21;
                    this.Hide();
                    form14.Show();
                }
            }
        }
    }
}
