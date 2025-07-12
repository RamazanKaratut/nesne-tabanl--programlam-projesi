using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEM
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        string O1_Secim;
        string O2_Secim;
        int rastgele;
        int o1_puan;
        int o2_puan;
        Random Random = new Random();
        public string kullanici_adi_form20;
        private void Form20_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tasbuton_Click(object sender, EventArgs e)
        {
            O1_Secim = "Taş";
        }
        private void kagitbuton_Click(object sender, EventArgs e)
        {
            O1_Secim = "Kağıt";
        }
        private void makasbuton_Click(object sender, EventArgs e)
        {
            O1_Secim = "Makas";
        }
        private void tas2buton_Click(object sender, EventArgs e)
        {
            O2_Secim = "Taş";
        }
        private void kagit2buton_Click(object sender, EventArgs e)
        {
            O2_Secim = "Kağıt";
        }
        private void makas2buton_Click(object sender, EventArgs e)
        {
            O2_Secim = "Makas";
        }
        private void oynabuton_Click(object sender, EventArgs e)
        {
            if (O1_Secim == null)
            {
                MessageBox.Show("Birinci oyuncu seçimini yapmadı!", "Seçim Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (O2_Secim == null)
            {
                MessageBox.Show("İkinci oyuncu seçimini yapmadı!", "Seçim Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Puan();
        }
        private void Puan()
        {
            if (O1_Secim == "Taş" && O2_Secim == "Kağıt")
            {
                o2_puan++;
                ikincioyuncuskor.Text = o2_puan.ToString();
                birincioyuncuskor.Text = o1_puan.ToString();
                kazananlabel.Text = "İkinci oyuncu kazandı";
            }
            else if (O1_Secim == "Taş" && O2_Secim == "Makas")
            {
                o1_puan++;
                birincioyuncuskor.Text = o1_puan.ToString();
                ikincioyuncuskor.Text = o2_puan.ToString();
                kazananlabel.Text = "Birinci oyuncu kazandı";
            }
            else if (O1_Secim == "Taş" && O2_Secim == "Taş")
            {
                kazananlabel.Text = "Beraberlik";
                birincioyuncuskor.Text = o1_puan.ToString();
                ikincioyuncuskor.Text = o2_puan.ToString();
            }
            else if (O1_Secim == "Kağıt" && O2_Secim == "Kağıt")
            {
                kazananlabel.Text = "Beraberlik";
                birincioyuncuskor.Text = o1_puan.ToString();
                ikincioyuncuskor.Text = o2_puan.ToString();
            }
            else if (O1_Secim == "Kağıt" && O2_Secim == "Makas")
            {
                kazananlabel.Text = "İkinci oyuncu kazandı";
                o2_puan++;
                birincioyuncuskor.Text = o1_puan.ToString();
                ikincioyuncuskor.Text = o2_puan.ToString();
            }
            else if (O1_Secim == "Kağıt" && O2_Secim == "Taş")
            {
                kazananlabel.Text = "Birinci oyuncu kazandı";
                o1_puan++;
                birincioyuncuskor.Text = o1_puan.ToString();
                ikincioyuncuskor.Text = o2_puan.ToString();
            }
            else if (O1_Secim == "Makas" && O2_Secim == "Kağıt")
            {
                kazananlabel.Text = "Birinci oyuncu kazandı";
                o1_puan++;
                birincioyuncuskor.Text = o1_puan.ToString();
                ikincioyuncuskor.Text = o2_puan.ToString();
            }
            else if (O1_Secim == "Makas" && O2_Secim == "Makas")
            {
                kazananlabel.Text = "Beraberlik";
                birincioyuncuskor.Text = o1_puan.ToString();
                ikincioyuncuskor.Text = o2_puan.ToString();
            }
            else if (O1_Secim == "Makas" && O2_Secim == "Taş")
            {
                kazananlabel.Text = "İkinci oyuncu kazandı";
                o2_puan++;
                birincioyuncuskor.Text = o1_puan.ToString();
                ikincioyuncuskor.Text = o2_puan.ToString();
            }
            if (o1_puan == 3)
            {
                DialogResult result = MessageBox.Show("Birinci oyuncu kazandı, yeniden oynamak ister misiniz", "Yeniden Oynama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    O1_Secim = null;
                    O2_Secim = null;
                    o1_puan = 0;
                    o2_puan = 0;
                    birincioyuncuskor.Text = o1_puan.ToString();
                    ikincioyuncuskor.Text = o2_puan.ToString();
                }
                else
                {
                    Form14 form14 = new Form14();
                    form14.kullanici_adi_form14 = kullanici_adi_form20;
                    this.Hide();
                    form14.Show();
                }
            }
            if (o2_puan == 3)
            {
                DialogResult result = MessageBox.Show("İkinci oyuncu kazandı, yeniden oynamak ister misiniz", "Yeniden Oynama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    O1_Secim = null;
                    O2_Secim = null;
                    o1_puan = 0;
                    o2_puan = 0;
                    birincioyuncuskor.Text = o1_puan.ToString();
                    ikincioyuncuskor.Text = o2_puan.ToString();
                }
                else
                {
                    Form14 form14 = new Form14();
                    form14.kullanici_adi_form14 = kullanici_adi_form20;
                    this.Hide();
                    form14.Show();
                }
            }
        }
    }
}
