using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.EF;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1 ();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            kvartirsBindingSource.DataSource = db.Kvartirs.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
