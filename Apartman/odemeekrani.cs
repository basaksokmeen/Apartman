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
    public partial class odemeekrani : Form
    {
        public odemeekrani()
        {
            InitializeComponent();
        }

        private void odemeyap_Click(object sender, EventArgs e)
        {
            string adsoy, kartnu, sonkull, cvcc;
            adsoy = kartis.Text;
            kartnu = kartnum.Text;
            sonkull = sonkul.Text;
            cvcc = cvc.Text;

            if (kartis.Text == "" || kartnum.Text == "" || sonkul.Text == "" || cvc.Text == "" ||
               kartis.Text == string.Empty || kartnum.Text == string.Empty || sonkul.Text == string.Empty || cvc.Text == string.Empty)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");

            }
            else
            {
                MessageBox.Show("ÖDEME TAMAMLANDI. ANA SAYFAYA YÖNLENDİRİLİYORSUNUZ.");
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
                this.Hide();
            }
        }
        private void kartis_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    
    private void button4_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa2 = new anasayfa();
            anasayfa2.Show();
            this.Hide();
        }

        private void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
