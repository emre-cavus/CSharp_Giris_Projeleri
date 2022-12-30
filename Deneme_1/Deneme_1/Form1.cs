using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { this.BackColor = Color.LightCoral; }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            { this.BackColor = Color.RoyalBlue; }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            { this.BackColor = Color.MediumAquamarine; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            { this.BackColor = Color.MediumPurple; }

        }
    }
}
