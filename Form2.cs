using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PROJEM
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MSI\\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GirişYap();
        }
        void GirişYap()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
            string KullaniciAdi = kaditext.Text.Trim();
            string KullaniciSifresi = ksifretext.Text.Trim();

            if (string.IsNullOrEmpty(KullaniciAdi) || string.IsNullOrEmpty(KullaniciSifresi))
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
            }
            else
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("Select * from kullanicidatabase where kullanici_adi= @KullaniciAdi and kullanici_sifresi= @KullaniciSifresi", connection))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                    command.Parameters.AddWithValue("@KullaniciSifresi", KullaniciSifresi);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Giriş Başarılı!");
                            Form13 form13 = new Form13();
                            form13.kullanici_adi_form13 = KullaniciAdi;
                            this.Hide();
                            form13.Show();
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler uyuşmuyor.");
                        }
                    }
                }

                connection.Close();
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }
        private void ksifretext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                GirişYap();
            }
        }
        private void kaditext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("\t");
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
        private void ilk80_Tick(object sender, EventArgs e)
        {
            ilerlemebari.Value += 20;
            if (ilerlemebari.Value == 80)
            {
                ilk80.Stop();
                son20.Start();
            }
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.Hide();
            label1.Visible = false;
            label2.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            kaditext.Visible = false;
            ksifretext.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            linkLabel3.Visible = false;
            ilk80.Start();
        }
        private void son20_Tick(object sender, EventArgs e)
        {
            if (ilerlemebari.Value == 100)
            {
                this.Show();
                ilerlemebari.Visible = false;
                son20.Stop();
                label1.Visible = true;
                label2.Visible = true;
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
                kaditext.Visible = true;
                ksifretext.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                linkLabel3.Visible = true;
                return;
            }
            ilerlemebari.Value += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ksifretext.PasswordChar == '*')
                ksifretext.PasswordChar = '\0';
            else
                ksifretext.PasswordChar = '*';
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form13 form13 = new Form13();
            form13.kullanici_adi_form13 = "misafir";
            this.Hide();
            form13.Show();
        }
    }
}