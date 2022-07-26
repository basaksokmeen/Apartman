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
    public partial class su : Form
    {
        public su()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GÜNCEL BORÇ = 48,65 TL'DİR. EN KISA ZAMANDA ÖDEMENİZİ RİCA EDERİZ.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void su_Load(object sender, EventArgs e)
        {

        }

        private void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
