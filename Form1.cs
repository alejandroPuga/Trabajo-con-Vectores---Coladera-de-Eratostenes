using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combos_listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        vector a = new vector();

        private void button1_Click(object sender, EventArgs e)
        {
            a.llenar();
            a.reacomodo();
            textBox1.Text = a.mostrar().ToString();
        }
    }
}
