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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elektrik elektrik = new elektrik();
            elektrik.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            su su = new su();
            su.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dogalgaz dogalgaz  = new dogalgaz();
            dogalgaz.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            yonetici yonetici = new yonetici();
            yonetici.Show();
            this.Hide();
        }

        private void duybut_Click(object sender, EventArgs e)
        {
            duyurular duyurular = new duyurular();
            duyurular.ShowDialog();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] renk = { "Red", "White" };
            Random rnd = new Random();
            int sayi = rnd.Next(renk.Length);

            duybut.BackColor = Color.FromName(renk[sayi]);
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void spotsbut_Click(object sender, EventArgs e)
        {
           sporsalonu sporsalonu   = new sporsalonu();
            sporsalonu.Show();
            this.Hide();
        }

        private void aidatbut_Click(object sender, EventArgs e)
        {
            odemeekrani odemeekrani = new odemeekrani();
            odemeekrani.Show();
            this.Hide();

        }

        private void kirabut_Click(object sender, EventArgs e)
        {
            odemeekrani odemeekrani = new odemeekrani();
            odemeekrani.Show();
            this.Hide();
        }

        private void sporbut_Click(object sender, EventArgs e)
        {
            odemeekrani odemeekrani = new odemeekrani();
            odemeekrani.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kisiselbilgi kisiselbilgi = new kisiselbilgi();
            kisiselbilgi.Show();
            this.Hide();
        }

        private void galereibut_Click(object sender, EventArgs e)
        {
            galeri galeri = new galeri();
            galeri.Show();
            this.Hide();
        }

        private void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
