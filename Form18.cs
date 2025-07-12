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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form18;
        private void XOXTiklama(object sender, EventArgs e)
        {
            int skor = 0;
            Button bt = sender as Button;
            if (labelxo.Text == "X")
            {
                bt.Text = "X";
                bt.Enabled = false;
                labelxo.Text = "O";
            }
            List<Button> bosButonlar = Controls.OfType<Button>().Where(b => b.Enabled).ToList();
            if (labelxo.Text == "O" && bosButonlar.Count > 0)
            {
                Random rnd = new Random();
                Button randomButon = bosButonlar[rnd.Next(bosButonlar.Count)];

                randomButon.Text = "O";
                randomButon.Enabled = false;
                labelxo.Text = "X";
            }
            // X 'LER
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                skor++;
                OyunBitiş(skor);
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                skor++;
                OyunBitiş(skor);
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                skor++;
                OyunBitiş(skor);
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                skor++;
                OyunBitiş(skor);
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                skor++;
                OyunBitiş(skor);
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                skor++;
                OyunBitiş(skor);
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                skor++;
                OyunBitiş(skor);
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                skor++;
                OyunBitiş(skor);
            }

            // O 'LAR
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                skor--;
                OyunBitiş(skor);
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                skor--;
                OyunBitiş(skor);
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                skor--;
                OyunBitiş(skor);
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                skor--;
                OyunBitiş(skor);
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                skor--;
                OyunBitiş(skor);
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                skor--;
                OyunBitiş(skor);
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                skor--;
                OyunBitiş(skor);
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                skor--;
                OyunBitiş(skor);
            }

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                button7.Text != "" && button8.Text != "" && button8.Text != "")
            {
                MessageBox.Show("Berabere");
                OyunBitiş(skor);
            }
        }
        void OyunBitiş(int skor)
        {
            int skor1 = Convert.ToInt32(skor);
            int eskiskor;
            if (kullanici_adi_form18 != "misafir")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT xox_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form18", connection))
                {
                    command.Parameters.AddWithValue("@kullanici_adi_form18", kullanici_adi_form18);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            eskiskor = Convert.ToInt32(reader["xox_oyunu_skor"].ToString());
                            reader.Close();
                            int yeniskor = eskiskor + skor1;
                            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET  xox_oyunu_skor= @yeniskor WHERE kullanici_adi = @kullanici_adi_form18", connection))
                            {
                                cmd.Parameters.AddWithValue("@kullanici_adi_form18", kullanici_adi_form18);
                                cmd.Parameters.AddWithValue("@yeniskor", yeniskor);
                                cmd.ExecuteNonQuery();
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
                MessageBox.Show("Misafir modunda skor kaydı tutulmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult result = MessageBox.Show("Yeniden oynamak istiyor musunuz?", "Oynama Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                labelxo.Text = "X";
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
                button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
                button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;

                button1.Text = ""; button2.Text = ""; button3.Text = "";
                button4.Text = ""; button5.Text = ""; button6.Text = "";
                button7.Text = ""; button8.Text = ""; button9.Text = "";
            }
            else
            {
                Form14 form14 = new Form14();
                form14.kullanici_adi_form14 = kullanici_adi_form18;
                this.Hide();
                form14.Show();
            }
        }

        private void Form18_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
