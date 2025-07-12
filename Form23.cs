using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace PROJEM
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form23;
        Random rnd = new Random();
        List<int> mayın = new List<int>();
        int puan, dtiklanan = 0, mayinsayisi = 0, kutu = 0;
        private void Form23_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                label1.Text = "Mayın Sayısı 10";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                label1.Text = "Mayın Sayısı 25";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                label1.Text = "Mayın Sayısı 40";
        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                Oyna("kolay");
            else if (radioButton2.Checked == true)
                Oyna("orta");
            else if (radioButton3.Checked == true)
                Oyna("zor");
            else
                MessageBox.Show("Zorluk Seçin");
        }
        public void Oyna(string mod)
        {
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.Controls.Clear();
            mayın.Clear();
            dtiklanan = 0;
            mayinsayisi = 0;
            kutu = 0;
            puan = 0;
            label2.Text = "PUAN: 0";

            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.RowCount = 10;

            if (mod == "kolay") mayinsayisi = 10;
            else if (mod == "orta") mayinsayisi = 25;
            else if (mod == "zor") mayinsayisi = 40;

            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                for (int x = 0; x < tableLayoutPanel1.RowCount; x++)
                {
                    if (i == 0)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    }
                    Button cmd = new Button();
                    cmd.BackColor = Color.Gray;
                    cmd.Dock = DockStyle.Fill;
                    cmd.Name = kutu.ToString();
                    tableLayoutPanel1.Controls.Add(cmd, i, x);
                    kutu++;
                }
            }
            int randomsayi;
            for (int i = 0; i < mayinsayisi; i++)
            {
                do
                {
                    randomsayi = rnd.Next(1, (tableLayoutPanel1.ColumnCount * tableLayoutPanel1.RowCount) - 1);

                } while (mayın.Contains(randomsayi));

                mayın.Add(randomsayi);
            }

            ButtonClickAyarla();
        }
        private void ButtonClickAyarla()
        {
            foreach (Control ctl in this.tableLayoutPanel1.Controls)
            {
                ctl.MouseClick += new MouseEventHandler(tableLayoutPanel1_Click);
            }
        }
        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Event(sender);
        }
        private void Event(object sender)
        {
            if (sender.GetType().Name == "Button")
            {
                Button tiklanan = (Button)sender;
                if (tiklanan.BackColor != Color.Green && tiklanan.BackColor != Color.Red)
                {
                    string isim = tiklanan.Name;
                    if (mayın.IndexOf(Convert.ToInt32(isim)) != -1) // Yandın
                    {
                        tiklanan.BackColor = Color.Red;
                        tiklanan.Image = Properties.Resources.Pictogrammers_Material_Mine_512;
                        HepsiniAc();
                        puan = puan - 20;
                        DialogResult result = MessageBox.Show("Kaybettiniz. Puanınınz 20 azaldı. Toplam Puan: " + puan + "\nYeniden oynamak ister misiniz?", "Yeniden Oynama Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        int eskiskor;
                        if (kullanici_adi_form23 != "misafir")
                        {
                            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                            connection.Open();
                            int skor1 = Convert.ToInt32(puan);
                            using (SqlCommand command = new SqlCommand("SELECT mayin_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form23", connection))
                            {
                                command.Parameters.AddWithValue("@kullanici_adi_form23", kullanici_adi_form23);
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        eskiskor = Convert.ToInt32(reader["mayin_oyunu_skor"].ToString());
                                        reader.Close();
                                        if (skor1 > eskiskor)
                                        {
                                            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET mayin_oyunu_skor = @skor1 WHERE kullanici_adi = @kullanici_adi_form23", connection))
                                            {
                                                cmd.Parameters.AddWithValue("@kullanici_adi_form23", kullanici_adi_form23);
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
                        else
                        {
                            MessageBox.Show("Misafir modunda skor kaydı tutulmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (result == DialogResult.No)
                        {
                            Form14 form14 = new Form14();
                            form14.kullanici_adi_form14 = kullanici_adi_form23;
                            this.Hide();
                            form14.Show();
                        }

                    }
                    else // Kazandın
                    {
                        tiklanan.BackColor = Color.Green;
                        Random rnd = new Random();
                        int tikpuan = rnd.Next(1, mayinsayisi);
                        puan += tikpuan;
                        tiklanan.Text = tikpuan.ToString();
                        label2.Text = "PUAN: " + puan.ToString();

                        if (dtiklanan == ((tableLayoutPanel1.ColumnCount * tableLayoutPanel1.RowCount) - 1) - mayinsayisi)
                        {
                            HepsiniAc();
                            puan = puan + 100;
                            int eskiskor;
                            if (kullanici_adi_form23 != "misafir")
                            {
                                SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                                connection.Open();
                                int skor1 = puan;
                                using (SqlCommand command = new SqlCommand("SELECT mayin_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form23", connection))
                                {
                                    command.Parameters.AddWithValue("@kullanici_adi_form23", kullanici_adi_form23);
                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            eskiskor = Convert.ToInt32(reader["mayin_oyunu_skor"].ToString());
                                            reader.Close();
                                            if (skor1 > eskiskor)
                                            {
                                                using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET mayin_oyunu_skor = @skor1 WHERE kullanici_adi = @kullanici_adi_form23", connection))
                                                {
                                                    cmd.Parameters.AddWithValue("@kullanici_adi_form23", kullanici_adi_form23);
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
                            else
                            {
                                MessageBox.Show("Misafir modunda skor kaydı tutulmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            DialogResult result = MessageBox.Show("Kazandınız. Puanınız 100 arttı. Toplam Puan: " + puan + "\nYeniden oynamak ister misiniz?", "Yeniden Oynama Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                            {
                                Form14 form14 = new Form14();
                                form14.kullanici_adi_form14 = kullanici_adi_form23;
                                this.Hide();
                                form14.Show();
                            }
                        }
                        else
                        {
                            dtiklanan++;
                        }
                    }
                }
            }
        }
        private void HepsiniAc()
        {
            for (int i = 0; i <= (tableLayoutPanel1.ColumnCount * tableLayoutPanel1.RowCount) - 1; i++)
            {
                Button btn = (Button)tableLayoutPanel1.Controls[i];
                if (mayın.IndexOf(Convert.ToInt32(btn.Name)) != -1)
                {
                    btn.BackColor = Color.Red;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage = Properties.Resources.Pictogrammers_Material_Mine_512;
                }
                else
                {
                    btn.BackColor = Color.Green;
                }
            }
        }
    }
}
