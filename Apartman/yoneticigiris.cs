using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman
{
    public partial class yoneticigiris : Form
    {
        public yoneticigiris()
        {
            InitializeComponent();
        }

        private void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (idmasked.Text == "" || siftextBox.Text == "" || idmasked.Text == string.Empty || siftextBox.Text == string.Empty)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }

            else if (idmasked.Text == "06" && siftextBox.Text == "yongiris06")
            {
                
                yoneticisayfasi yoneticisayfasi = new yoneticisayfasi();
                yoneticisayfasi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARISIZ.\nLÜTFEN TEKRAR DENEYİN. ");
                idmasked.Clear();
                siftextBox.Clear();
            }
        }

        private void yardyon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID = 06\nŞİFRE = yongiris06 ");
        }

        private void idmasked_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
