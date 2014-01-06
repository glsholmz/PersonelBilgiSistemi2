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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 myservice = new localhost.Service1();
            myservice.KisiSil(textBox1.Text);
            MessageBox.Show("Personel Silindi.");
            
        }

        
        
    }
}
