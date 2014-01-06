using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Personel_Bilgi_Sistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(textBoxkime.Text);
                mesaj.From = new MailAddress(textBoxmailadresi.Text);
                mesaj.Subject = textBoxkonu.Text;
                mesaj.Body = textBoxmesaj.Text;
                NetworkCredential guvenlik = new NetworkCredential(textBoxmailadresi.Text, textBoxsifre.Text);
                client.Credentials = guvenlik;
                client.EnableSsl = true;
                client.Send(mesaj);
                MessageBox.Show("Mail Başarıyla GÖnderildi.", "Mail Gönderme");
            }
            catch
            {
                MessageBox.Show("Mail Gönderme Başarısız.","Mail Gönderme");
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            textBoxsifre.PasswordChar = (char)42;
        }

        
    }
}