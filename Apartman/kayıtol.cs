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
    public partial class kayıtol : Form
    {
        public static DataTable tablo = new DataTable();
        public kayıtol()
        {
            InitializeComponent();

        }

        string Sifre = " ";
        string Harfler = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuiopğüasdfghjklşizxcvbnmöç";
        string Rakamlar = "1234567890";
        string OzelKarakterler = "é<!>'£^#+$% % &/{([)]=}* ?_-^@;,.:";


        bool HarfVar = false;
        bool RakamVar = false;
        bool OzelKarakterVar = false;


        public void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {  
            tablo.Rows.Add(adkaytext.Text, soyadkaytext.Text, epostakaytext.Text, telefonkaytext.Text, katkaytext.Text, nokaytext.Text, blokcombobox.SelectedItem);
           

            string ad, soyad, posta, tcno, no, sifre, kat, numara, blok;
            ad = adkaytext.Text;
            soyad = soyadkaytext.Text;
            posta = epostakaytext.Text;
            tcno = kimlikkaytext.Text;
            no = telefonkaytext.Text;
            sifre = sifrekaytext.Text;
            sifre = sifretkaytext.Text;
            kat = katkaytext.Text;
            numara = nokaytext.Text;
            blok = blokcombobox.Text;


            if (adkaytext.Text == "" || soyadkaytext.Text == "" || kimlikkaytext.Text == "" || epostakaytext.Text == "" || katkaytext.Text == ""
               || nokaytext.Text == "" || sifrekaytext.Text == "" || sifretkaytext.Text == "" || telefonkaytext.Text == "" || adkaytext.Text == string.Empty || blokcombobox.Text == ""
               || soyadkaytext.Text == string.Empty || epostakaytext.Text == string.Empty || katkaytext.Text == string.Empty
                || nokaytext.Text == string.Empty || blokcombobox.Text == string.Empty || sifretkaytext.Text == string.Empty || telefonkaytext.Text == string.Empty || kimlikkaytext.Text == string.Empty)
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ.");


            }
            else if (sifrekaytext.Text != sifretkaytext.Text)
            {

                MessageBox.Show("LÜTFEN İKİ ŞİFRENİN AYNI OLUP OLMADIĞINI KONTROL EDİNİZ.");
                sifrekaytext.Clear();
                sifretkaytext.Clear();
            }
            else if (checkBox1.Checked == false)
            {

                MessageBox.Show("LÜTFEN BİLGİLERİNİZİN DOĞRULUĞUNU ONAYLAYIN.");
                sifrekaytext.Clear();
                sifretkaytext.Clear();
            }
            else
            {
                MessageBox.Show("KAYIT BAŞARILI. BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDERİZ.");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
        public void SifreKontrol()
        {

            Sifre = sifrekaytext.Text;
            if (Sifre.Length < 6)
            {
                label1.Text = "Zayıf Şifre";
            }

            else
            {
                foreach (char item in Sifre)
                {
                    if (Harfler.IndexOf(item) != -1)
                    {
                        HarfVar = true;
                    }
                    if (Rakamlar.IndexOf(item) != -1)
                    {
                        RakamVar = true;
                    }
                    if (OzelKarakterler.IndexOf(item) != -1)
                    {
                        OzelKarakterVar = true;
                    }
                }

                if (HarfVar == true && RakamVar == true && OzelKarakterVar == true)
                {
                    label1.Text = "Kuvvetli Şifre";
                }
                else if (HarfVar == true && RakamVar == true || HarfVar == true && OzelKarakterVar == true ||
                RakamVar == true && OzelKarakterVar == true)
                {
                    label1.Text = "Orta Seviye Şifre";
                }
                else
                {
                    label1.Text = "Zayıf Şifre";
                }
            }
        }

        public void button3_Click_1(object sender, EventArgs e)
        { 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;  

        }

        public void adkaytext_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        public void kimlikkaytext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void telefonkaytext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void katkaytext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void nokaytext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void sifrekaytext_TextChanged_1(object sender, EventArgs e)
        {
            SifreKontrol();
        }

        public void sifretkaytext_TextChanged(object sender, EventArgs e)
        {
            if (sifrekaytext.Text != sifretkaytext.Text)
            {
                label2.Text = "ŞİFRELER FARKLI.";
            }
            else
            {
                label2.Text = "ŞİFRELER AYNI.";
            }
        }






        public void panel2_Paint(object sender, PaintEventArgs e)
        {

        }    

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void telefonkaytext_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void adkaytext_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        public void soyadkaytext_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        public void kimlikkaytext_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        public void epostakaytext_Leave(object sender, EventArgs e)
        {
            
        }

        public void telefonkaytext_Click(object sender, EventArgs e)
        {
            label7.Visible= false;
        }

        public void epostakaytext_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        public void sifrekaytext_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        public void sifretkaytext_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        public void blokcombobox_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        public void katkaytext_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        public void nokaytext_Click(object sender, EventArgs e)
        {
            label12.Visible = false;
        }

        public void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void kayıtol_Load(object sender, EventArgs e)
        {
            try
            {
                tablo.Columns.Add("AD", typeof(string));
                tablo.Columns.Add("SOYAD", typeof(string));
                tablo.Columns.Add("EPOSTA", typeof(string));
                tablo.Columns.Add("TELEFON NO", typeof(string));
                tablo.Columns.Add("KAT", typeof(string));
                tablo.Columns.Add("DAİRE NO", typeof(string));
                tablo.Columns.Add("BLOK ADI", typeof(string));
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu !, Lüften Tekrar Deneyin !");
            }
        }
    }
}