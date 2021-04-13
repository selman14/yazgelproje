using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelimeoyunu
{
    public partial class soruekle : Form
    {
        baglanti baglan = new baglanti();
        public soruekle()
        {
            InitializeComponent();
        }

        private void soruekle_Load(object sender, EventArgs e)
        {
            baglan.baglan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.ekle("INSERT INTO sorular(sorular,kelimeler) VALUES('"+richTextBox1.Text+"','"+textBox2.Text+"')");
            MessageBox.Show("İşlem başarılı teşekkürler...");
        }
    }
}
