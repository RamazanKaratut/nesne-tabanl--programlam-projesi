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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }
        Random random = new Random();
        List<string> icons = new List<string>()
        {
           "t", "t","e","e","d","d","A","A","J","J","C","C","m","m","i","i","l","l","M","M","Q","Q","S","S","[","[","]","]",">",">",":",":","9","9","3","3"
        };
        Label etk_1 = null;
        Label etk_2 = null;
        int skor;
        int denemehakki = 10;
        private void HucrelereResimAta()
        {
            foreach (Control etk in tableLayoutPanel1.Controls)
            {
                skor = 0;
                Label resEtk = etk as Label;
                if (resEtk != null)
                {
                    int rs = random.Next(icons.Count);
                    resEtk.Text = icons[rs];
                    resEtk.ForeColor = resEtk.BackColor;
                    icons.RemoveAt(rs);
                }
            }
        }
        private void Form24_Load(object sender, EventArgs e)
        {
            KullanıcıAdı();
            tableLayoutPanel1.Enabled = false;
        }
        public string kullanici_adi_form24;
        void KullanıcıAdı()
        {
            kadilabel.Text = kullanici_adi_form24;
        }

        private void Form24_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void oyunkurbuton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = true;
            oyunkurbuton.Enabled = false;
            HucrelereResimAta();
        }
        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }
            Label secilenEtiket = sender as Label;
            if (secilenEtiket != null)
            {
                if (secilenEtiket.ForeColor == Color.Black)
                {
                    return;
                }
                if (etk_1 == null)
                {
                    etk_1 = secilenEtiket;
                    etk_1.ForeColor = Color.Black;
                    return;
                }
                etk_2 = secilenEtiket;
                etk_2.ForeColor = Color.Black;
                oyunBittimi();
                if (etk_1.Text == etk_2.Text)
                {
                    etk_1 = null;
                    etk_2 = null;
                    skor += 5;
                    skorlabel.Text = skor.ToString();
                    return;
                }
                skor -= 1;
                timer1.Start();
                skorlabel.Text = skor.ToString();
            }
        }
        private void oyunBittimi()
        {
            foreach (Control etk in tableLayoutPanel1.Controls)
            {
                Label resEtk = etk as Label;
                if (resEtk != null)
                {
                    if (resEtk.ForeColor == resEtk.BackColor)
                    {
                        return;
                    }
                }
            }
            int skor1 = Convert.ToInt32(skor);
            int eskiskor;
            if (kullanici_adi_form24 != "misafir")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT esbulma_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form24", connection))
                {
                    command.Parameters.AddWithValue("@kullanici_adi_form24", kullanici_adi_form24);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            eskiskor = Convert.ToInt32(reader["esbulma_oyunu_skor"].ToString());
                            reader.Close();
                            if (skor1 > eskiskor)
                            {
                                using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET esbulma_oyunu_skor = @skor1 WHERE kullanici_adi = @kullanici_adi_form24", connection))
                                {
                                    cmd.Parameters.AddWithValue("@kullanici_adi_form24", kullanici_adi_form24);
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
            DialogResult dialog = MessageBox.Show("Kazandınız! \nYeniden oynamak ister misiniz?", "Yeniden Oynama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                foreach (Control etk in tableLayoutPanel1.Controls)
                {
                    icons.Add(etk.Text);
                    etk.ForeColor = tableLayoutPanel1.BackColor;
                    etk.Text = null;
                }
                tableLayoutPanel1.Enabled = false;
                oyunkurbuton.Enabled = true;
            }
            else
            {
                Form14 form14 = new Form14();
                form14.kullanici_adi_form14 = kullanici_adi_form24;
                this.Hide();
                form14.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            etk_1.ForeColor = etk_1.BackColor;
            etk_2.ForeColor = etk_2.BackColor;
            etk_1 = null;
            etk_2 = null;
        }
    }
}
