using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace kelimeoyunu
{
    public partial class Form1 : Form
    {
        baglanti baglan = new baglanti();
        public int sira=0, harf_s=4;
        public string[,] dizi = new string[2, 2];
        public int sayi = 0;
        public string cevap,renkler= "e14040,e6563d";
        DateTime zaman =DateTime.Now;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        public void oku(string bilgi)
        {
            string dosya_yolu = @"./deneme.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine(bilgi);
            
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
        }
        public void kelimegetir(int h_sayi)
        {
            if (sira == 0)
            {
                dizi = baglan.kelimecagir(h_sayi);
                soru_lbl.Text = dizi[0, 1].ToString();
                label4.Text = dizi[0, 0].ToString();
                cevap= dizi[0, 0].ToString();
                tpuan_lbl.Text = (int.Parse(tpuan_lbl.Text) + int.Parse(hpuan_lbl.Text)).ToString();
                hpuan_lbl.Text = (dizi[0, 0].Length * 100).ToString();
                ciz(dizi[0, 0].Length);
                sira =1;
                sayi = 0;
            }
            else
            {
                sira = 0;
                soru_lbl.Text = dizi[1, 1].ToString();
                label4.Text = dizi[1, 0].ToString();
                cevap= dizi[1, 0].ToString();
                tpuan_lbl.Text = (int.Parse(tpuan_lbl.Text) + int.Parse(hpuan_lbl.Text)).ToString();
                hpuan_lbl.Text = (dizi[0, 0].Length * 100).ToString();
                
                ciz(dizi[1, 0].Length);
                harf_s = harf_s - 1;
                sayi = 0;
            }

            
        }
        public void ciz(int uzunluk)
        {
            kelime_lbl.Text = "";
            for (int i = 0; i < uzunluk; i++)
            {
                kelime_lbl.Text = kelime_lbl.Text + '_';
                kelime_lbl.Text = kelime_lbl.Text + ' ';

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            baglan.baglan();
            kelimegetir(harf_s);
            tahmin_txt.Visible = false;
            button3.Visible = false;
            sayac2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sn = int.Parse(saniye.Text);
            int dk = int.Parse(dakika.Text);

            

            if (sn==0)
            {
                dk = dk - 1;
                sn = 59;
            }
            else
            {
                sn = sn - 1;
            }

             saniye.Text = sn.ToString();
            dakika.Text= dk.ToString();
            if (sn == 0 && dk == 0)
            {
                Form2 frm2 = new Form2();
                
                timer1.Stop();
                MessageBox.Show("Oyun Bitti Puanınız" + tpuan_lbl.Text);
                oku(Form2.ad + "-" + tpuan_lbl.Text + "-" + dakika.Text + ":" + saniye.Text + "-" + zaman.ToString());

                frm2.Show();
                this.Hide();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac2.Visible = true;
            timer2.Enabled = true;
            tahmin_txt.Visible = true;
            button3.Visible = true;
            

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (tahmin_txt.Text.ToUpper() == cevap.ToUpper())
            {
                harf_s = harf_s + 1;
                kelimegetir(harf_s);
                timer2.Stop();
                sayac2.Text = "20";
                sayac2.Visible = false;
                tahmin_txt.Visible = false;
                button3.Visible = false;
                tahmin_txt.Text = "";
                timer1.Start();

            }
            if(harf_s==10 && sira == 0)
            {
                MessageBox.Show("Oyun Bitti Puanınız" + tpuan_lbl.Text);
                oku(Form2.ad + "-" + tpuan_lbl.Text + "-" +dakika.Text+":"+saniye.Text+"-" + zaman.ToString());
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            int uzunluk = kelime_lbl.Text.Length;


            string kelime, harfler;


            harfler = kelime_lbl.Text;
            if (sira == 1)
            {
                kelime = dizi[0, 0].ToString();
            }
            else
            {
                kelime = dizi[1, 0].ToString();
            }
            while (true)
            {
                int s = 0;
                int i = 0;
                bool kontrol = false;
                Random rastgele = new Random();
                int rand = rastgele.Next(kelime.Length);
                while (s != uzunluk)
                {


                    if (kelime_lbl.Text[s].ToString().Equals(" "))
                    {

                    }
                    else
                    {

                        if (kelime_lbl.Text[s].ToString().Equals("_"))
                        {
                            if (i == rand)
                            {
                                string deneme = kelime_lbl.Text;

                                StringBuilder mtn2 = new StringBuilder(deneme);
                                mtn2[s] = kelime[i];
                                kelime_lbl.Text = mtn2.ToString();
                                kontrol = true;
                                sayi = sayi + 1;

                            }
                        }


                        i = i + 1;
                    }
                    s = s + 1;

                }
                if (kontrol)
                {
                    hpuan_lbl.Text = (int.Parse(hpuan_lbl.Text) - 100).ToString();

                    break;
                }
                if (sayi == kelime.Length - 1)
                {
                    hpuan_lbl.Text = (int.Parse(hpuan_lbl.Text) - 100).ToString();
                    harf_s = harf_s + 1;
                    kelimegetir(harf_s);

                    break;
                }


            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac2.Visible = true;
            timer2.Enabled = true;
            tahmin_txt.Visible = true;
            button3.Visible = true;
        }

        private void soru_lbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk = kelime_lbl.Text.Length;
            
            
            string kelime,harfler;
            
            
            harfler= kelime_lbl.Text;
            if (sira == 1)
            {
                 kelime= dizi[0, 0].ToString();
            }
            else
            {
                kelime = dizi[1, 0].ToString();
            }
            while (true)
            {
                int s = 0;
                int i = 0;
                bool kontrol = false;
                Random rastgele = new Random();
                int rand = rastgele.Next(kelime.Length);
                while (s != uzunluk)
                {


                    if (kelime_lbl.Text[s].ToString().Equals(" "))
                    {

                    }
                    else
                    {
                        
                            if (kelime_lbl.Text[s].ToString().Equals("_"))
                            {
                            if (i == rand)
                            {
                                string deneme = kelime_lbl.Text;

                                StringBuilder mtn2 = new StringBuilder(deneme);
                                mtn2[s] = kelime[i];
                                kelime_lbl.Text = mtn2.ToString();
                                kontrol = true;
                                sayi = sayi + 1;

                            }
                        }
                           
                        
                        i = i + 1;
                    }
                    s = s + 1;
                    
                }
                if (kontrol)
                {
                    hpuan_lbl.Text = (int.Parse(hpuan_lbl.Text) - 100).ToString();

                    break;
                }
                if (sayi == kelime.Length-1)
                {
                    hpuan_lbl.Text = (int.Parse(hpuan_lbl.Text) - 100).ToString();
                    harf_s = harf_s + 1;
                    kelimegetir(harf_s);
                    
                    break;
                }
                
                
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sn = int.Parse(sayac2.Text);
            sn = sn - 1;
            sayac2.Text = sn.ToString();
            if (sn == 0)
            {
                hpuan_lbl.Text = (-100 * dizi[0, 0].Length).ToString();
                timer2.Stop();
                
                harf_s = harf_s + 1;
                kelimegetir(harf_s);
                sayac2.Enabled = false;
                sayac2.Text = "20";

            }

        }
    }
}
