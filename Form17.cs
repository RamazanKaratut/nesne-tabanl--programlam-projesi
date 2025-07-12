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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        public string kullanici_adi_form17;
        private void Form17_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void XOXtiklama(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (labelxo.Text == "X")
            {
                bt.Text = "X";
                bt.Enabled = false;
                labelxo.Text = "O";
            }
            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                labelxo.Text = "X";
            }
            // X 'LER
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                OyunBitiş();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                OyunBitiş();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                OyunBitiş();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                OyunBitiş();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                OyunBitiş();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                OyunBitiş();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                OyunBitiş();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Kazanan : X oldu");
                OyunBitiş();
            }

            // O 'LAR
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                OyunBitiş();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                OyunBitiş();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                OyunBitiş();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                OyunBitiş();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                OyunBitiş();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                OyunBitiş();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                OyunBitiş();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Kazanan : O oldu");
                OyunBitiş();
            }

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                button7.Text != "" && button8.Text != "" && button8.Text != "")
            {
                MessageBox.Show("Berabere");
                OyunBitiş();
            }
        }
        void OyunBitiş()
        {
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
                form14.kullanici_adi_form14 = kullanici_adi_form17;
                this.Hide();
                form14.Show();
            }
        }
    }
}
