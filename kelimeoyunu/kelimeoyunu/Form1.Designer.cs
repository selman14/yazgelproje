
namespace kelimeoyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.soru_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dakika = new System.Windows.Forms.Label();
            this.saniye = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.sayac2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tahmin_txt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tpuan_lbl = new System.Windows.Forms.Label();
            this.hpuan_lbl = new System.Windows.Forms.Label();
            this.kelime_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soru_lbl
            // 
            this.soru_lbl.BackColor = System.Drawing.Color.Transparent;
            this.soru_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soru_lbl.Location = new System.Drawing.Point(285, 155);
            this.soru_lbl.Name = "soru_lbl";
            this.soru_lbl.Size = new System.Drawing.Size(357, 60);
            this.soru_lbl.TabIndex = 3;
            this.soru_lbl.Text = "label4label4label4label4label4label4label\r\n4label4label4label4label4label4label4l" +
    "abel\r\n4label4label4label4label4";
            this.soru_lbl.Click += new System.EventHandler(this.soru_lbl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(75, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Harf Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tahmin Yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(61)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(423, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "SÜRE:";
            // 
            // dakika
            // 
            this.dakika.AutoSize = true;
            this.dakika.BackColor = System.Drawing.Color.Transparent;
            this.dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakika.ForeColor = System.Drawing.Color.White;
            this.dakika.Location = new System.Drawing.Point(423, 21);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(36, 25);
            this.dakika.TabIndex = 7;
            this.dakika.Text = "04";
            // 
            // saniye
            // 
            this.saniye.AutoSize = true;
            this.saniye.BackColor = System.Drawing.Color.Transparent;
            this.saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniye.ForeColor = System.Drawing.Color.White;
            this.saniye.Location = new System.Drawing.Point(488, 21);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(36, 25);
            this.saniye.TabIndex = 8;
            this.saniye.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(463, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // sayac2
            // 
            this.sayac2.AutoSize = true;
            this.sayac2.BackColor = System.Drawing.Color.Transparent;
            this.sayac2.Enabled = false;
            this.sayac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayac2.Location = new System.Drawing.Point(446, 285);
            this.sayac2.Name = "sayac2";
            this.sayac2.Size = new System.Drawing.Size(36, 25);
            this.sayac2.TabIndex = 11;
            this.sayac2.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(142, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // tahmin_txt
            // 
            this.tahmin_txt.Location = new System.Drawing.Point(396, 366);
            this.tahmin_txt.Name = "tahmin_txt";
            this.tahmin_txt.Size = new System.Drawing.Size(128, 22);
            this.tahmin_txt.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Tamam";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tpuan_lbl
            // 
            this.tpuan_lbl.AutoSize = true;
            this.tpuan_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tpuan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpuan_lbl.ForeColor = System.Drawing.Color.White;
            this.tpuan_lbl.Location = new System.Drawing.Point(282, 109);
            this.tpuan_lbl.Name = "tpuan_lbl";
            this.tpuan_lbl.Size = new System.Drawing.Size(24, 25);
            this.tpuan_lbl.TabIndex = 16;
            this.tpuan_lbl.Text = "0";
            // 
            // hpuan_lbl
            // 
            this.hpuan_lbl.AutoSize = true;
            this.hpuan_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(61)))));
            this.hpuan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hpuan_lbl.ForeColor = System.Drawing.Color.White;
            this.hpuan_lbl.Location = new System.Drawing.Point(435, 223);
            this.hpuan_lbl.Name = "hpuan_lbl";
            this.hpuan_lbl.Size = new System.Drawing.Size(24, 25);
            this.hpuan_lbl.TabIndex = 18;
            this.hpuan_lbl.Text = "0";
            // 
            // kelime_lbl
            // 
            this.kelime_lbl.AutoSize = true;
            this.kelime_lbl.BackColor = System.Drawing.Color.Transparent;
            this.kelime_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelime_lbl.Location = new System.Drawing.Point(423, 190);
            this.kelime_lbl.Name = "kelime_lbl";
            this.kelime_lbl.Size = new System.Drawing.Size(0, 25);
            this.kelime_lbl.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(320, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(45, 20, 45, 20);
            this.label1.Size = new System.Drawing.Size(90, 60);
            this.label1.TabIndex = 20;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(499, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.label3.Size = new System.Drawing.Size(80, 60);
            this.label3.TabIndex = 21;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(334, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "HARF AL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(492, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "TAHMİN YAP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 438);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kelime_lbl);
            this.Controls.Add(this.hpuan_lbl);
            this.Controls.Add(this.tpuan_lbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tahmin_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sayac2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saniye);
            this.Controls.Add(this.dakika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soru_lbl);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label soru_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dakika;
        private System.Windows.Forms.Label saniye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label sayac2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tahmin_txt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label tpuan_lbl;
        private System.Windows.Forms.Label hpuan_lbl;
        private System.Windows.Forms.Label kelime_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

