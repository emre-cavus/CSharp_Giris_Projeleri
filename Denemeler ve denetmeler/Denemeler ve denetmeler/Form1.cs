using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denemeler_ve_denetmeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte ortalama;
            ortalama = Convert.ToByte(textBox1.Text);
            if (ortalama >= 50)
            {
                if (ortalama >= 85)
                {
                    label2.Text = "Taktir belgesi almaya hak kazandınız.";
                }
                else if (ortalama >= 70)
                {
                    label2.Text = "Teşekkür belgesi almaya hak kazandınız.";
                }
                else if (ortalama < 70)
                {
                    label2.Text = "Belge almaya hak kazanamadınız .";
                }
            }
            else
            {
                label2.Text = "Sınıfı geçmek için yeterli notu alamadınız.";
            }
        }
    }
}
