using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personel_Bilgi_Sistemi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeniform= new Form2();
            yeniform.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 yeniform = new Form3();
            yeniform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 yeniform = new Form4();
            yeniform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 yeniform = new Form7();
            yeniform.Show();
        }
    }
}
