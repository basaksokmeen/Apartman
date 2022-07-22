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
    public partial class yoneticisayfasi : Form
    {
 

        public yoneticisayfasi()
        {
            InitializeComponent();
        }

        public void circularbut1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void yoneticisayfasi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kayıtol.tablo;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        public void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0] != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            }
            else
                MessageBox.Show("LÜTFEN BİR KAYIT SEÇİNİZ.");
        }
    }
}
