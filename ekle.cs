using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_1001
{
    public partial class ekle : Form
    {

        public ekle()
        {
            InitializeComponent();
        }

        class urunler
        {
            public int urunNo { get; set; }
            public string urunAdi { get; set; }
            public int urunFiyat { get; set; }
            public int urunAdet { get; set; }
        }

        private void ekle_Load(object sender, EventArgs e)
        {
            /* 
             maskedTextBox1.Mask = "0000";
             maskedTextBox2.Mask = "0000";
             maskedTextBox3.Mask = "0000"; 
            */
        }

        panel bilgi = new panel();
        private void button1_Click(object sender, EventArgs e)
        {
            urunler ekle = new urunler();

            ekle.urunNo = int.Parse(maskedTextBox1.Text);
            ekle.urunAdi = textBox2.Text;
            ekle.urunFiyat = int.Parse(maskedTextBox2.Text);
            ekle.urunAdet = int.Parse(maskedTextBox3.Text);
            bilgi.liste1.Add(ekle);

            // MessageBox.Show("Ürün eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

}
