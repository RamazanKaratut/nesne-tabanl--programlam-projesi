using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace PROJEM
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form22;
        private void Form22_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        int hatasayac;
        int puan;
        string[] kelimeler = { "İsimler", "Meyveler", "Filmler", "Futbolcular", "Yönetmenler" };

        string[] isimler = { "Ramazan", "EyüpCan", "Ahmet", "Mustafa", "Bünyamin", "Bekir Burak", "Yılmaz", "Furkan", "Hasan", "Toprak", "Ali", "Ayşe", "Mehmet", "Elif", "Cem", "Zeynep", "Kemal", "Deniz", "Selin", "Orhan", "Ece", 
            "Oğuz", "Rabia", "Hüseyin", "Nur", "Tolga", "Esra", "Umut", "Sude", "Caner", "Gizem", "Burak", "Melis", "Emre", "Aslı", "Kaan", "Buse", "Cihan", "Berrak", "Onur", "Şeyma", "Uğur", "Sema", "Serkan", "Şule", "Erdem", "Sibel" };

        string[]  meyveler = { "Elma", "Armut", "Kiraz", "Ananas", "Şeftali", "Kayısı", "Portakal", "Mandalina", "Ejderha Meyvesi", "Karpuz", "Çilek", "Muz", "Üzüm", "Nar", "Vişne", "Hurma", "Ayva", "Dut", "İncir", "Kavun", "Limon", 
            "Çarkıfelek", "Böğürtlen", "Kızılcık", "Göçmen Erik", "Yeşil Erik", "Ceviz", "Fındık", "Antep Fıstığı", "Badem", "Vişneli Yoğurt", "Mango", "Bamya", "Karnabahar", "Ispanak", "Biber", "Domates", "Salatalık", "Brokoli", 
            "Lahana", "Havuç", "Patlıcan", "Soğan", "Sarımsak", "Kırmızı Lahana", "Pırasa", "Taze Fasulye" };

        string[] filmer = { "Oppenheimer", "Deadpool", "Joker", "İllegal Hayatlar", "Batı Cephesinde Yeni Bir Şey Yok", "Jungle Cruise", "Red Notice", "Thor Ragnarok", "Scarface", "Interstellar", "Pulp Fiction", "The Dark Knight", 
            "Inception", "Django Unchained", "Fight Club", "Seven", "The Godfather", "Forrest Gump", "The Shawshank Redemption", "Schindlers List", "The Matrix", "The Lord of the Rings", "Avatar", "Titanic", "The Silence of the Lambs", 
            "The Shining", "The Green Mile", "Braveheart", "Gladiator", "The Departed", "The Social Network", "The Grand Budapest Hotel", "La La Land", "Blade Runner", "The Revenant", "Gravity", "The Shape of Water", "Birdman", "Whiplash", 
            "Black Swan", "The Wolf of Wall Street", "No Country for Old Men", "American Psycho", "The Pianist", "The Great Gatsby", "Casablanca", "Gone with the Wind", "Citizen Kane", "Eternal Sunshine of the Spotless Mind" };

        string[] futbolcular = { "Lionel Messi", "Cristiano Ronaldo", "Ronaldinho", "Zlatan Ibrahimovic", "Diego Maradona", "Roberto Carlos", "Eric Cantona", "George Best", "Jurgen Klinsmann", "Lothar Matthaus", "Neymar", "Kylian Mbappe", 
            "Luka Modric", "Mohamed Salah", "Sadio Mane", "Virgil van Dijk", "Robert Lewandowski", "Harry Kane", "Kevin De Bruyne", "Luis Suarez", "Andres Iniesta", "Xavi Hernandez", "Zinedine Zidane", "Ronaldo Nazario", "Raul Gonzalez", 
            "Paolo Maldini", "Franz Beckenbauer", "Lev Yashin", "Gianluigi Buffon", "David Beckham", "Ruud Gullit", "Thierry Henry", "Cafu", "Kaka", "Alessandro Del Piero", "Fabio Cannavaro", "Marco van Basten", "Michel Platini", 
            "Paolo Rossi", "Gerd Muller", "Bobby Charlton", "George Best", "Eusebio", "Ferenc Puskas", "Alfredo Di Stefano", "Garrincha", "Bobby Moore", "Lev Yashin" };

        string[] yönetmenler = { "Christopher Nolan", "Quentin Tarantino", "David Lynch", "David Fincher", "Todd Phillips", "Alfred Hitchcock", "Peter Jackson", "Stanley Kubrick", "Martin Scorsese", "Steven Spielberg", 
            "James Cameron", "Tim Burton", "Coen Brothers", "Francis Ford Coppola", "Ridley Scott", "Guillermo del Toro", "Paul Thomas Anderson", "Spike Lee", "Wes Anderson", "Denis Villeneuve", "Greta Gerwig", "Bong Joonho", 
            "Ava DuVernay", "Hayao Miyazaki", "Akira Kurosawa", "Ingmar Bergman", "Federico Fellini", "Charlie Chaplin", "Woody Allen", "George Lucas", "George Miller", "Quentin Tarantino", "Orson Welles", "Fritz Lang", "Ingmar Bergman", 
            "Billy Wilder", "Roman Polanski", "John Ford", "Federico Fellini", "JeanLuc Godard", "Francis Ford Coppola", "Steven Soderbergh", "Pedro Almodovar", "Stanley Kubrick", "David Lean", "FW Murnau", "Frank Capra" };
        Random random = new Random();
        string rastgelekelime;
        string rastgelekategori;
        string bosluksuzkelime;
        private void OyunOluştur()
        {
            foreach (Control buttons in this.Controls)
            {
                if (buttons is Button)
                {
                    ((Button)buttons).Enabled = true;
                }
            }
            hatasayac = 0;
            kalanhak.Text = hatasayac.ToString();
            puanlabel.Text = puan.ToString();

            rastgelekategori = kelimeler[random.Next(kelimeler.Length)];
            kategorilabel.Text = rastgelekategori;
            if (rastgelekategori == "İsimler")
            {
                rastgelekelime = isimler[random.Next(isimler.Length)].ToUpper();
            }
            if (rastgelekategori == "Meyveler")
            {
                rastgelekelime = meyveler[random.Next(meyveler.Length)].ToUpper();
            }
            if (rastgelekategori == "Filmler")
            {
                rastgelekelime = filmer[random.Next(filmer.Length)].ToUpper();
            }
            if (rastgelekategori == "Futbolcular")
            {
                rastgelekelime = futbolcular[random.Next(futbolcular.Length)].ToUpper();
            }
            if (rastgelekategori == "Yönetmenler")
            {
                rastgelekelime = yönetmenler[random.Next(yönetmenler.Length)].ToUpper();
            }
            hatasayac = 0;
            pictureBox1.Image = Properties.Resources._5;
            cevaplabel.Text = "";
            // Kelimenin her harfi için "_" karakterini ekle
            if (rastgelekelime.Contains(" "))
            {
                bosluksuzkelime = rastgelekelime.Replace(" ", "");
                for (int i = 0; i < bosluksuzkelime.Length; i++)
                {
                    cevaplabel.Text += "_" + " ";
                }
            }
            else
            {
                bosluksuzkelime = rastgelekelime;
                for (int i = 0; i < bosluksuzkelime.Length; i++)
                {
                    cevaplabel.Text += "_" + " ";
                }
            }

        }
        private void Oyun(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (bosluksuzkelime.Contains(button.Text) == false)
            {
                button.Enabled = false;
                hatasayac++;
                kalanhak.Text = hatasayac.ToString();
                if (hatasayac == 1)
                    pictureBox1.Image = Properties.Resources._6;
                if (hatasayac == 2)
                    pictureBox1.Image = Properties.Resources._7;
                if (hatasayac == 3)
                    pictureBox1.Image = Properties.Resources._8;
                if (hatasayac == 4)
                    pictureBox1.Image = Properties.Resources._9;
                if (hatasayac == 5)
                    pictureBox1.Image = Properties.Resources._10;
                if (hatasayac == 6)
                {
                    pictureBox1.Image = Properties.Resources._11;
                    puan -= cevaplabel.Text.Length * 1;
                    puanlabel.Text = puan.ToString();
                    DialogResult result = MessageBox.Show("Oyun bitti, yenildiniz. Doğru kelime " + rastgelekelime + "\nYeniden oynamak ister misiniz?", "Yeniden Oynama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        OyunOluştur();
                    }
                    else
                    {
                        int eskiskor;
                        int skor1 = Convert.ToInt32(puan);
                        if (kullanici_adi_form22 != "misafir")
                        {
                            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("SELECT adamasmaca_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form22", connection))
                            {
                                command.Parameters.AddWithValue("@kullanici_adi_form22", kullanici_adi_form22);
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        eskiskor = Convert.ToInt32(reader["adamasmaca_oyunu_skor"].ToString());
                                        reader.Close();
                                        if (skor1 > eskiskor)
                                        {
                                            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET adamasmaca_oyunu_skor = @skor1 WHERE kullanici_adi = @kullanici_adi_form22", connection))
                                            {
                                                cmd.Parameters.AddWithValue("@kullanici_adi_form22", kullanici_adi_form22);
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
                        Form14 form14 = new Form14();
                        form14.kullanici_adi_form14 = kullanici_adi_form22;
                        this.Hide();
                        form14.Show();
                    }
                }
            }
            else
            {
                button.Enabled = false;
                string text = cevaplabel.Text.Replace(" ", "");
                for (int i = 0; i < bosluksuzkelime.Length; i++)
                {
                    if (bosluksuzkelime[i].ToString() == button.Text)
                    {
                        text = ReplaceAt(text, i, 1, button.Text);
                        puan++;
                    }
                }
                string sonuç = "";
                for (int i = 0; i < text.Length; i++)
                {
                    sonuç += text[i].ToString() + " ";
                }
                cevaplabel.Text = sonuç;
                puanlabel.Text = puan.ToString();

                if (cevaplabel.Text.Replace(" ", "") == bosluksuzkelime)
                {
                    puan += cevaplabel.Text.Length * 1;
                    puanlabel.Text = puan.ToString();
                    DialogResult dialogResult = MessageBox.Show("Kazandınız. Tebrikler!\nTekrar Oynamak İstiyor Musunuz ?", "Yeniden Oynama Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        OyunOluştur();
                    }
                    else
                    {
                        int eskiskor;
                        int skor1 = Convert.ToInt32(puan);
                        if (kullanici_adi_form22 != "misafir")
                        {
                            SqlConnection connection = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=oyundatabase;Integrated Security=True");
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("SELECT adamasmaca_oyunu_skor FROM kullanicidatabase where kullanici_adi = @kullanici_adi_form22", connection))
                            {
                                command.Parameters.AddWithValue("@kullanici_adi_form22", kullanici_adi_form22);
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        eskiskor = Convert.ToInt32(reader["adamasmaca_oyunu_skor"].ToString());
                                        reader.Close();
                                        if (skor1 > eskiskor)
                                        {
                                            using (SqlCommand cmd = new SqlCommand("UPDATE kullanicidatabase SET adamasmaca_oyunu_skor = @skor1 WHERE kullanici_adi = @kullanici_adi_form22", connection))
                                            {
                                                cmd.Parameters.AddWithValue("@kullanici_adi_form22", kullanici_adi_form22);
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
                        Form14 form14 = new Form14();
                        form14.kullanici_adi_form14 = kullanici_adi_form22;
                        this.Hide();
                        form14.Show();
                    }
                }
            }
        }
        public string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index))
                    .Insert(index, replace);
        }
        private void Form22_Load(object sender, EventArgs e)
        {  
            OyunOluştur();
        }
    }
}
