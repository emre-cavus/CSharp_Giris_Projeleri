using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            string soyadi = textBox2.Text;

            textBox3.Text = adi + " " + soyadi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mat_not1 = textBox4.Text;
            string mat_not2 = textBox5.Text;
            string mat_not3 = textBox6.Text;
            string mat_not4 = textBox7.Text;

            int Mat_Not1 = Convert.ToInt32(mat_not1);
            int Mat_Not2 = Convert.ToInt32(mat_not2);
            int Mat_Not3 = Convert.ToInt32(mat_not3);
            int Mat_Not4 = Convert.ToInt32(mat_not4);

            double ortalama = (Mat_Not1 + Mat_Not2 + Mat_Not3 + Mat_Not4) / 4;
            textBox8.Text = "" + ortalama;

            //Edebiyat 

            string edb_not1 = textBox13.Text;
            string edb_not2 = textBox12.Text;
            string edb_not3 = textBox11.Text;
            string edb_not4 = textBox10.Text;

            int Edb_Not1 = Convert.ToInt32(edb_not1);
            int Edb_Not2 = Convert.ToInt32(edb_not2);
            int Edb_Not3 = Convert.ToInt32(edb_not3);
            int Edb_Not4 = Convert.ToInt32(edb_not4);

            double ortalama2 = (Edb_Not1 + Edb_Not2 + Edb_Not3 + Edb_Not4) / 4;
            textBox9.Text = "" + ortalama2;

            //Yabanci dil

            string y_dil_not1 = textBox18.Text;
            string y_dil_not2 = textBox17.Text;
            string y_dil_not3 = textBox16.Text;
            string y_dil_not4 = textBox15.Text;

            int Y_dil_Not1 = Convert.ToInt32(y_dil_not1);
            int Y_dil_Not2 = Convert.ToInt32(y_dil_not2);
            int Y_dil_Not3 = Convert.ToInt32(y_dil_not3);
            int Y_dil_Not4 = Convert.ToInt32(y_dil_not4);

            double ortalama3 = (Y_dil_Not1 + Y_dil_Not2 + Y_dil_Not3 + Y_dil_Not4 ) / 4;
            textBox14.Text = "" + ortalama3;

            //Fizik

            string fzk_not1 = textBox23.Text;
            string fzk_not2 = textBox22.Text;
            string fzk_not3 = textBox21.Text;
            string fzk_not4 = textBox20.Text;

            int Fzk_Not1 = Convert.ToInt32(fzk_not1);
            int Fzk_Not2 = Convert.ToInt32(fzk_not2);
            int Fzk_Not3 = Convert.ToInt32(fzk_not3);
            int Fzk_Not4 = Convert.ToInt32(fzk_not4);

            double ortalama4 = (Fzk_Not1 + Fzk_Not2 + Fzk_Not3 + Fzk_Not4) / 4;
            textBox19.Text = "" + ortalama4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string notlar = textBox3.Text + "'un ders notu ortalamaları = " + " Matematik = " + textBox8.Text + " Edebiyat = " + textBox9.Text + " Yabanci dil = " + textBox14.Text + " Fizik = " + textBox19.Text;

            listBox1.Items.Add(notlar);
        }
    }
}
