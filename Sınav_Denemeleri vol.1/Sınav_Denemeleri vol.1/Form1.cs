using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Denemeleri_vol._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mat_dogru, turkce_dogru;
            double mat_yanlis, turkce_yanlis;
            double mate_Net, turkce_Net;
            int toplam_net;
            turkce_dogru = Convert.ToDouble(textBox1.Text);
            turkce_yanlis = Convert.ToDouble(textBox3.Text);
            turkce_Net = (turkce_dogru - (turkce_yanlis / 4));
            textBox6.Text = turkce_Net.ToString();
            mat_dogru = Convert.ToDouble(textBox2.Text);
            mat_yanlis = Convert.ToDouble(textBox4.Text);
            mate_Net = (mat_dogru - (mat_yanlis / 4));
            textBox5.Text = mate_Net.ToString();
            toplam_net = Convert.ToInt32(turkce_Net + mate_Net);
            textBox7.Text = toplam_net.ToString();


        }
    }
}
