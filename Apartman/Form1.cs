namespace Apartman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisbut_Click(object sender, EventArgs e)
        {
            girisyap girisyap = new girisyap();
            girisyap.Show();
            this.Hide();
        }

        private void kayitbut_Click(object sender, EventArgs e)
        {
            kayýtol kayýtol = new kayýtol();
            kayýtol.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox5.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {

            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink2()
        {

            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink3();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink3()
        {

            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://twitter.com/");
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void button1_Click(object sender, EventArgs e)
        {
            yoneticigiris yoneticigiris = new yoneticigiris();
            yoneticigiris.Show();
            this.Hide();
        }
        private void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }













        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}