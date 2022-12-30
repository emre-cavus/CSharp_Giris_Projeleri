using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Çalışmaları_vol._3
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
                    label2.Text = "Takdir Belgesi Almaya Hak Kazandınız.";
                }
                else if (ortalama >= 70)
                {
                    label2.Text = "Teşekkür Belgesi Almaya Hak Kazandınız.";
                }
                else
                { label2.Text = "Belge Almadan Sınıf Geçtiniz."; }
            }
            else
            { label2.Text = "Sınıf Geçmek İçin Yeterli Not Alamadınız."; }
        }
    }
}
