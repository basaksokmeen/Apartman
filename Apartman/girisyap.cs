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
    public partial class girisyap : Form
    {
        public girisyap()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namemasked.Text == "" || siftextBox.Text == "" || namemasked.Text == string.Empty || siftextBox.Text == string.Empty)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            else if (namemasked.Text == "11111111111" && siftextBox.Text == "06ANKARA")
            {

                anasayfa anasay = new anasayfa();
                anasay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen tekrar deneyin.");
                namemasked.Clear();
                siftextBox.Clear();
            }
        }

        private void circularbut1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KİMLİK NO: 11111111111, \nŞİFRE: 06ANKARA");
        }

        private void namemasked_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void circularbut2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
