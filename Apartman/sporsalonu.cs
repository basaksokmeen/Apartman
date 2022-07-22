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
    public partial class sporsalonu : Form
    {
        public sporsalonu()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki = 0;
            boy = Convert.ToDouble(boysportext.Text);
            kilo = Convert.ToDouble(kilosportext.Text);
            vki =( kilo / (boy * boy));
            label2.Text = vki.ToString();
            if (vki < 18)
            {
                label1.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                label1.Text = "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                label1.Text = "Kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                label1.Text = "Obez";
            }
            else
            {
                label1.Text = "Ciddi Obez";


            }
        }
        private void kaydetspor_Click(object sender, EventArgs e)
        {
            string ad, soyad, dogum, no, boy, kilo;
            ad = adsportext.Text;
            soyad = soyadsportext.Text;
            dogum = dogumsportext.Text;
            no = telefonsportext.Text;
            boy = boysportext.Text;
            kilo = kilosportext.Text;
            radioButton1.Checked = true;
            radioButton2.Checked = true;



            if (adsportext.Text == "" || soyadsportext.Text == "" || dogumsportext.Text == ""
               || boysportext.Text == "" || kilosportext.Text == "" || telefonsportext.Text == ""
               || adsportext.Text == string.Empty || soyadsportext.Text == string.Empty
               || boysportext.Text == string.Empty || kilosportext.Text == string.Empty
               || telefonsportext.Text == string.Empty || dogumsportext.Text == string.Empty)
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ.");


            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {

                MessageBox.Show("LÜTFEN BİLGİLERİNİZİN EKSİKSİZ GİRİN.");

            }
            else if (checkBox1.Checked == false)
            {

                MessageBox.Show("LÜTFEN BİLGİLERİNİZİN DOĞRULUĞUNU ONAYLAYIN.");

            }
            else
            {
                MessageBox.Show("KAYIT BAŞARILI. BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ.");
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
                this.Hide();
            }
        }
        private void dogumsportext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void telefonsportext_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void boysportext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kilosportext_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void adsportext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void soyadsportext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }








        private void dogumsportext_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
