using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEM
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form13;
        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            if(kullanici_adi_form13 != "misafir") 
            {
                KullanıcıPP();
                KullanıcıAdı();
                KullanıcıParası();
                OyunlarText();
                Gerekliler();
            }
            if(kullanici_adi_form13 == "misafir")
            {
                kadilabel.Text = "Misafir";
                paralabel.Text = "0 TL";
            }
        }
        void Gerekliler()
        {
            comboBox1.Text = "MAĞAZA";
        }
        void KullanıcıPP()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT kullanici_pp FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);

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
            kadilabel.Text = kullanici_adi_form13;
        }
        void KullanıcıParası()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
            connection.Open();
            using (SqlCommand command = new SqlCommand("Select * from kullanicidatabase where kullanici_adi= @KullaniciAdi", connection))
            {
                command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kullaniciparasilabel.Text = reader["kullanici_parasi"].ToString().TrimEnd();
                        paralabel.Text = reader["kullanici_parasi"].ToString().TrimEnd() + " TL";
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
                command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["yilan_oyunu_skor"] == DBNull.Value)
                        {
                            yilanoyunbuton.Text = "999 TL";
                        }
                        else
                        {
                            yilanoyunbuton.Text = " Kütüphanede Mevcut";
                            yilanoyunbuton.Enabled = false;
                        }
                        if (reader["trex_oyunu_skor"] == DBNull.Value)
                        {
                            trexbuton.Text = "999 TL";
                        }
                        else
                        {
                            trexbuton.Text = " Kütüphanede Mevcut";
                            trexbuton.Enabled = false;
                        }
                        if (reader["mayin_oyunu_skor"] == DBNull.Value)
                        {
                            mayıntarlasibuton.Text = "999 TL";
                        }
                        else
                        {
                            mayıntarlasibuton.Text = " Kütüphanede Mevcut";
                            mayıntarlasibuton.Enabled = false;
                        }
                        if (reader["ucankus_oyunu_skor"] == DBNull.Value)
                        {
                            flappybuton.Text = "999 TL";
                        }
                        else
                        {
                            flappybuton.Text = " Kütüphanede Mevcut";
                            flappybuton.Enabled = false;
                        }
                        if (reader["adamasmaca_oyunu_skor"] == DBNull.Value)
                        {
                            adamasmacabutonu.Text = "999 TL";
                        }
                        else
                        {
                            adamasmacabutonu.Text = " Kütüphanede Mevcut";
                            adamasmacabutonu.Enabled = false;
                        }
                        if (reader["xox_oyunu_skor"] == DBNull.Value)
                        {
                            xoxbuton.Text = "999 TL";
                        }
                        else
                        {
                            xoxbuton.Text = " Kütüphanede Mevcut";
                            xoxbuton.Enabled = false;
                        }
                        if (reader["tkm_oyunu_skor"] == DBNull.Value)
                        {
                            tkmbuton.Text = "999 TL";
                        }
                        else
                        {
                            tkmbuton.Text = "Kütüphanede Mevcut";
                            tkmbuton.Enabled = false;
                        }
                        if (reader["esbulma_oyunu_skor"] == DBNull.Value)
                        {
                            esbulmabuton.Text = "999 TL";
                        }
                        else
                        {
                            esbulmabuton.Text = "Kütüphanede Mevcut";
                            esbulmabuton.Enabled = false;
                        }
                    }
                }
            }
        }
        void YılanOyunuSkor(int yeniPara, SqlConnection connection)
        {
            int skor_yilan_oyun = 0;
            int YilanSkor = 0;
            using (SqlCommand updateCommand = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @YeniPara WHERE kullanici_adi = @KullaniciAdi", connection))
            {
                updateCommand.Parameters.AddWithValue("@YeniPara", yeniPara);
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }
            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET yilan_oyunu_skor = @YilanSkor WHERE kullanici_adi = @kullanici_adi_form13", connection))
            {
                cmd.Parameters.AddWithValue("@kullanici_adi_form13", kullanici_adi_form13);
                cmd.Parameters.AddWithValue("@YilanSkor", YilanSkor);
                cmd.ExecuteNonQuery();
            }
        }
        void UçanKuşSkor(int yeniPara, SqlConnection connection)
        {
            int UcanKusSkor = 0;
            using (SqlCommand updateCommand = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @YeniPara WHERE kullanici_adi = @KullaniciAdi", connection))
            {
                updateCommand.Parameters.AddWithValue("@YeniPara", yeniPara);
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET ucankus_oyunu_skor = @UcanKusSkor WHERE kullanici_adi = @kullanici_adi_form13", connection))
            {
                cmd.Parameters.AddWithValue("@kullanici_adi_form13", kullanici_adi_form13);
                cmd.Parameters.AddWithValue("@UcanKusSkor", UcanKusSkor);
                cmd.ExecuteNonQuery();
            }
        }
        void MayınTarlasıOyunSkor(int yeniPara, SqlConnection connection)
        {
            int MayinTarlasiSkor = 0;
            using (SqlCommand updateCommand = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @YeniPara WHERE kullanici_adi = @KullaniciAdi", connection))
            {
                updateCommand.Parameters.AddWithValue("@YeniPara", yeniPara);
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET mayin_oyunu_skor = @MayinTarlasiSkor WHERE kullanici_adi = @kullanici_adi_form13", connection))
            {
                cmd.Parameters.AddWithValue("@kullanici_adi_form13", kullanici_adi_form13);
                cmd.Parameters.AddWithValue("@MayinTarlasiSkor", MayinTarlasiSkor);
                cmd.ExecuteNonQuery();
            }
        }
        void TREXOyunSkor(int yeniPara, SqlConnection connection)
        {
            int TREXSkor = 0;
            using (SqlCommand updateCommand = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @YeniPara WHERE kullanici_adi = @KullaniciAdi", connection))
            {
                updateCommand.Parameters.AddWithValue("@YeniPara", yeniPara);
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET trex_oyunu_skor = @TREXSkor WHERE kullanici_adi = @kullanici_adi_form13", connection))
            {
                cmd.Parameters.AddWithValue("@kullanici_adi_form13", kullanici_adi_form13);
                cmd.Parameters.AddWithValue("@TREXSkor", TREXSkor);
                cmd.ExecuteNonQuery();
            }
        }
        void AdamAsmacaSkor(int yeniPara, SqlConnection connection)
        {
            int AdamAsmacaSkor = 0;
            using (SqlCommand updateCommand = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @YeniPara WHERE kullanici_adi = @KullaniciAdi", connection))
            {
                updateCommand.Parameters.AddWithValue("@YeniPara", yeniPara);
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET adamasmaca_oyunu_skor = @AdamAsmacaSkor WHERE kullanici_adi = @kullanici_adi_form13", connection))
            {
                cmd.Parameters.AddWithValue("@kullanici_adi_form13", kullanici_adi_form13);
                cmd.Parameters.AddWithValue("@AdamAsmacaSkor", AdamAsmacaSkor);
                cmd.ExecuteNonQuery();
            }
        }
        void XOXOyunSkor(int yeniPara, SqlConnection connection)
        {
            int xoxoyunskor = 0;
            using (SqlCommand updateCommand = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @YeniPara WHERE kullanici_adi = @KullaniciAdi", connection))
            {
                updateCommand.Parameters.AddWithValue("@YeniPara", yeniPara);
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET xox_oyunu_skor = @xoxoyunskor WHERE kullanici_adi = @kullanici_adi_form13", connection))
            {
                cmd.Parameters.AddWithValue("@kullanici_adi_form13", kullanici_adi_form13);
                cmd.Parameters.AddWithValue("@xoxoyunskor", xoxoyunskor);
                cmd.ExecuteNonQuery();
            }
        }
        void TaşKağıtMakasSkor(int yeniPara, SqlConnection connection)
        {
            int tkm_oyunu_skor = 0;
            using (SqlCommand updateCommand = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @YeniPara WHERE kullanici_adi = @KullaniciAdi", connection))
            {
                updateCommand.Parameters.AddWithValue("@YeniPara", yeniPara);
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET tkm_oyunu_skor = @tkm_oyunu_skor WHERE kullanici_adi = @kullanici_adi_form13", connection))
            {
                cmd.Parameters.AddWithValue("@kullanici_adi_form13", kullanici_adi_form13);
                cmd.Parameters.AddWithValue("@tkm_oyunu_skor", tkm_oyunu_skor);
                cmd.ExecuteNonQuery();
            }
        }
        void EşBulmaSkor(int yeniPara, SqlConnection connection)
        {
            int esbulma_oyunu_skor = 0;
            using (SqlCommand updateCommand = new SqlCommand("UPDATE kullanicidatabase SET kullanici_parasi = @YeniPara WHERE kullanici_adi = @KullaniciAdi", connection))
            {
                updateCommand.Parameters.AddWithValue("@YeniPara", yeniPara);
                updateCommand.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET esbulma_oyunu_skor = @esbulma_oyunu_skor WHERE kullanici_adi = @kullanici_adi_form13", connection))
            {
                cmd.Parameters.AddWithValue("@kullanici_adi_form13", kullanici_adi_form13);
                cmd.Parameters.AddWithValue("@esbulma_oyunu_skor", esbulma_oyunu_skor);
                cmd.ExecuteNonQuery();
            }
        }
        private void SatınAlımButonlar(object sender, EventArgs e)
        {
            if (kullanici_adi_form13 != "misafir")
            {
                Form14 form14 = new Form14();
                form14.kullanici_adi_form14 = kullanici_adi_form13;
                if (sender is Button tiklananbuton)
                {
                    DialogResult result1 = MessageBox.Show("Bu oyunu satın almak istiyor musunuz?", "Satın Alma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True"))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("SELECT * FROM kullanicidatabase WHERE kullanici_adi = @KullaniciAdi", connection))
                            {
                                command.Parameters.AddWithValue("@KullaniciAdi", kullanici_adi_form13);
                                int eskiPara = Convert.ToInt32(kullaniciparasilabel.Text.ToString().TrimEnd());
                                List<string> results = new List<string>();

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        results.Add(reader[0].ToString());
                                    }
                                }

                                if (eskiPara >= 999)
                                {
                                    foreach (var result in results)
                                    {
                                        int yeniPara = eskiPara - 999;
                                        if (tiklananbuton == yilanoyunbuton)
                                        {
                                            YılanOyunuSkor(yeniPara, connection);
                                        }
                                        if (tiklananbuton == flappybuton)
                                        {
                                            UçanKuşSkor(yeniPara, connection);
                                        }
                                        if (tiklananbuton == mayıntarlasibuton)
                                        {
                                            MayınTarlasıOyunSkor(yeniPara, connection);
                                        }
                                        if (tiklananbuton == trexbuton)
                                        {
                                            TREXOyunSkor(yeniPara, connection);
                                        }
                                        if (tiklananbuton == adamasmacabutonu)
                                        {
                                            AdamAsmacaSkor(yeniPara, connection);
                                        }
                                        if (tiklananbuton == xoxbuton)
                                        {
                                            XOXOyunSkor(yeniPara, connection);
                                        }
                                        if (tiklananbuton == tkmbuton)
                                        {
                                            TaşKağıtMakasSkor(yeniPara, connection);
                                        }
                                        if (tiklananbuton == esbulmabuton)
                                        {
                                            EşBulmaSkor(yeniPara, connection);
                                        }
                                    }
                                    this.Hide();
                                    form14.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Hesabınızda yeterli miktarda para bulunmuyor!");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (sender is Button tiklanan)
                {
                    MessageBox.Show("Ödeme tamamlandı.");
                    tiklanan.Text = "Kütüphanede Mevcut";
                    tiklanan.Enabled = false;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                return;
            }
            if(comboBox1.SelectedIndex == 1)
            {
                Form14 form14 = new Form14();
                form14.kullanici_adi_form14 = kullanici_adi_form13;
                this.Hide();
                form14.Show();
            }
        }
    }
}