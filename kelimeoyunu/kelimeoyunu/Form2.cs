using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace kelimeoyunu
{
    public partial class Form2 : Form
    {
        public static string ad;
        
        public Form2()
        {
            InitializeComponent();
        }
        public void cek()
        {
            string dosya_yolu = @"./deneme.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            int s = 0;
            while (yazi != null)
            {
                
                string[] words = yazi.Split('-');
            
                dataGridView1.Rows.Add(words[0], words[1], words[2], words[3]);


                yazi = sw.ReadLine();
                s=s+1;



            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cek();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            ad = textBox1.Text;
            
            frm.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soruekle soru = new soruekle();
            soru.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string ad=dataGridView1.Rows[i].Cells[0].Value.ToString();
               
                    string puan = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string sure = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string zaman = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList liste = new ArrayList();
                bool deger = false;
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    
                    string value = dataGridView1.Rows[rows].Cells[0].Value.ToString();
                    string text = textBox2.Text.ToLower();
                    if (value.ToLower() == text)
                    {
                        deger = true;
                        string cumle = dataGridView1.Rows[rows].Cells[0].Value.ToString() + "-" + dataGridView1.Rows[rows].Cells[1].Value.ToString() + "-" + dataGridView1.Rows[rows].Cells[2].Value.ToString() + "-" + dataGridView1.Rows[rows].Cells[3].Value.ToString();
                        liste.Add(cumle);



                    }
                    
                }
                if (deger)
                {
                    dataGridView1.Rows.Clear();

                    foreach (var item in liste)
                    {
                        string[] words = item.ToString().Split('-');

                        dataGridView1.Rows.Add(words[0], words[1], words[2], words[3]);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bulunumadı");
            }
        }
    }
}
