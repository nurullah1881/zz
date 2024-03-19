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
    public partial class panel : Form
    {

        public ArrayList liste1 { get; set; }

        public panel()
        {
            InitializeComponent();
            liste1 = new ArrayList();
        }

        private void panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle ekleGec = new ekle();
            ekleGec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stok stokGec = new stok();
            stokGec.Show();            
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = liste1;
        }

        private void panel_Load(object sender, EventArgs e)
        {

        }
    }
}
