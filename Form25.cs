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
    public partial class Form25 : Form
    {
        public Form25()
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
        int skor1;
        int skor2;
        int denemehakki = 10;
        public string kullanici_adi_form25;
        string kazananoyuncu;
        private void HucrelereResimAta()
        {
            foreach (Control etk in tableLayoutPanel2.Controls)
            {
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
        private void oyunkurbuton_Click(object sender, EventArgs e)
        {
            skor1 = 0;
            skor2 = 0;
            oyuncusirasi.Text = "1. oyuncu";
            oyunkurbuton.Enabled = false;
            HucrelereResimAta();
            tableLayoutPanel2.Enabled = true;
        }
        private void Form25_Load(object sender, EventArgs e)
        {
            KullanıcıAdı();
            tableLayoutPanel2.Enabled = false;
        }
        void KullanıcıAdı()
        {
            kadilabel.Text = kullanici_adi_form25;
        }
        private void Form25_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void oyunBittimi()
        {
            foreach (Control etk in tableLayoutPanel2.Controls)
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
            kazananoyuncu = oyuncusirasi.Text;
            DialogResult dialog = MessageBox.Show($"{kazananoyuncu} oyunu kazandı! \nPuan durumu: 1. oyuncu {skor1} puana ve 2. oyuncu {skor2} puana sahip\nYeniden oynamak ister misiniz?", "Yeniden Oynama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                foreach (Control etk in tableLayoutPanel2.Controls)
                {
                    icons.Add(etk.Text);
                    etk.ForeColor = tableLayoutPanel2.BackColor;
                    etk.Text = null;
                }
                tableLayoutPanel2.Enabled = false;
                oyunkurbuton.Enabled = true;
            }
            else
            {
                Form14 form14 = new Form14();
                form14.kullanici_adi_form14 = kullanici_adi_form25;
                this.Hide();
                form14.Show();
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            etk_1.ForeColor = etk_1.BackColor;
            etk_2.ForeColor = etk_2.BackColor;
            etk_1 = null;
            etk_2 = null;
        }
        private void label_(object sender, EventArgs e)
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
                    if (oyuncusirasi.Text == "1. oyuncu")
                    {
                        skor1 += 5;
                    }
                    else if (oyuncusirasi.Text == "2. oyuncu")
                    {
                        skor2 += 5;
                    }
                    oyuncu1skor.Text = skor1.ToString();
                    oyuncu2skor.Text = skor2.ToString();
                    etk_1 = null;
                    etk_2 = null;
                    return;
                }
                if (oyuncusirasi.Text == "1. oyuncu")
                {
                    skor1 -= 1;
                    oyuncusirasi.Text = "2. oyuncu";
                }
                else
                {
                    skor2 -= 1;
                    oyuncusirasi.Text = "1. oyuncu";
                }
                timer1.Start();
                oyuncu1skor.Text = skor1.ToString();
                oyuncu2skor.Text = skor2.ToString();
            }
        }
    }
}
