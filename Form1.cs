using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random uret = new Random();
        public string kullanici = "Admin", sifre = "1234";
        bool kayit = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text = uret.Next(1000, 10000).ToString();
            textBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kayit == true)
            {
                if(textBox1.Text == kullanici && textBox2.Text == sifre)
                {
                    panel gec = new panel();
                    gec.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış.", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Giriş yapmadan önce aşağıdan kayıt olmanız gerekmektedir.", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != null)
            {
                kullanici = textBox3.Text;
                sifre = textBox4.Text;
                MessageBox.Show("Başarıyla kayıt oldunuz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kayit = true;
            }
            else
            {
                MessageBox.Show("Hata", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
