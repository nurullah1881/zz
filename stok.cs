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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }

        public ArrayList listee = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listee;

        }
    }
}
