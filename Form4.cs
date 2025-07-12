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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form4_KeyDown);
        }
        public string kullanici_adi_form4;
        private void Form4_Load(object sender, EventArgs e)
        {
            KullanıcıAdı();
            kazankaybetlabel.Visible = false;
        }
        void KullanıcıAdı()
        {
            kadilabel.Text = kullanici_adi_form4;
        }
        Panel parca;
        Panel elma = new Panel();
        List<Panel> yilan = new List<Panel>();
        string yön = "sağ";
        private void baslabuton_Click(object sender, EventArgs e)
        {
            baslabuton.Visible = false;
            label2.Visible = false;
            OyunKur();
        }
        void OyunKur()
        {
            PaneliTemizle();
            skorlabel.Text = 0.ToString();
            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Green;
            yilan.Add(parca);
            panel1.Controls.Add(yilan[0]);
            timer1.Start();
            ElmaOluştur();
        }
        void çarpışmaKontrol()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    baslabuton.Visible = true;
                    label2.Visible = true;
                    kazankaybetlabel.Visible = true;
                    kazankaybetlabel.Text = "KAYBETTİNİZ";
                    int puan = int.Parse(skorlabel.Text);
                    if(kullanici_adi_form4!= "misafir")
                        skorKaydet(puan);
                    timer1.Stop();
                }
            }
        }
        void PaneliTemizle()
        {
            panel1.Controls.Clear();
            yilan.Clear();
            kazankaybetlabel.Visible = false;
        }
        void puanKontrol()
        {
            int puan = int.Parse(skorlabel.Text);
            if (puan > 30000)
            {
                kazankaybetlabel.Text = "KAZANDINIZ";
                if (kullanici_adi_form4 != "misafir")
                    skorKaydet(puan);
                timer1.Stop();
                kazankaybetlabel.Visible = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int locx = yilan[0].Location.X;
            int locy = yilan[0].Location.Y;
            ElmaYendimi();
            hareket();
            çarpışmaKontrol();
            puanKontrol();

            if (yön == "sağ")
            {
                if (locx < 580)
                    locx += 20;
                else
                    locx = 0;
            }
            if (yön == "sol")
            {
                if (locx > 0)
                    locx -= 20;
                else
                    locx = 580;
            }
            if (yön == "aşağı")
            {
                if (locy < 580)
                    locy += 20;
                else
                    locy = 0;
            }
            if (yön == "yukarı")
            {
                if (locy > 0)
                    locy -= 20;
                else
                    locy = 580;
            }
            yilan[0].Location = new Point(locx, locy);
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && yön != "sol")
                yön = "sağ";

            if (e.KeyCode == Keys.Left && yön != "sağ")
                yön = "sol";

            if (e.KeyCode == Keys.Up && yön != "aşağı")
                yön = "yukarı";

            if (e.KeyCode == Keys.Down && yön != "yukarı")
                yön = "aşağı";
        }
        void ElmaOluştur()
        {
            Random random = new Random();
            int elmax, elmay;
            elmax = random.Next(0, 580);
            elmay = random.Next(0, 580);

            elmax -= elmax % 20;
            elmay -= elmay % 20;

            elma.Size = new Size(20, 20);
            elma.BackColor = Color.Red;
            elma.Location = new Point(elmax, elmay);
            panel1.Controls.Add(elma);
        }
        void ElmaYendimi()
        {
            int skor = int.Parse(skorlabel.Text);
            if (yilan[0].Location == elma.Location)
            {
                panel1.Controls.Remove(elma);
                skor += 50;
                skorlabel.Text = skor.ToString();
                ElmaOluştur();
                parcaEkle();
            }
        }
        void parcaEkle()
        {
            Panel ekParca = new Panel();
            ekParca.Size = new Size(20, 20);
            ekParca.BackColor = Color.Green;
            yilan.Add(ekParca);
            panel1.Controls.Add(ekParca);
        }
        void hareket()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.kullanici_adi_form14 = kullanici_adi_form4;
            this.Hide();
            form14.Show();
        }
        void skorKaydet(int puan)
        {
            int eskiskor;
            if (kullanici_adi_form4 != "misafir")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT yilan_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form4", connection))
                {
                    command.Parameters.AddWithValue("@kullanici_adi_form4", kullanici_adi_form4);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            eskiskor = Convert.ToInt32(reader["yilan_oyunu_skor"].ToString());
                            reader.Close();
                            if (puan > eskiskor)
                            {
                                using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET yilan_oyunu_skor = @puan WHERE kullanici_adi = @kullanici_adi_form4", connection))
                                {
                                    cmd.Parameters.AddWithValue("@kullanici_adi_form4", kullanici_adi_form4);
                                    cmd.Parameters.AddWithValue("@puan", puan);
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
                return;
            }
        }
    }
}
