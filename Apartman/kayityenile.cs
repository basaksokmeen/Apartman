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
    public partial class kayityenile : Form
    {
        public kayityenile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisiselbilgi kisi = new kisiselbilgi();
            kisi.telkis.Text = telguncul.Text;
            kisi.nokis.Text = kapınoguncul.Text;
            kisi.epostakis.Text = epostaguncul.Text;
            kisi.blokkis.Text = blokguncul.Text;
            kisi.katkis.Text = katguncul.Text;
            kisi.Show();
            this.Close();
        }

        private void telguncul_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void katguncul_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kapınoguncul_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void blokguncul_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }






        private void katguncul_TextChanged(object sender, EventArgs e)
        {

        }

        private void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
