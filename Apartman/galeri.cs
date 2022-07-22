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
    public partial class galeri : Form
    {
        public galeri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void circularbut1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
           else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void circularbut1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
