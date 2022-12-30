using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g_rakam;
            double c_sonuc;
            g_rakam = Convert.ToInt32(textBox1.Text);
            c_sonuc = g_rakam * 0.18;
            MessageBox.Show(c_sonuc.ToString());
        }
    }
}
