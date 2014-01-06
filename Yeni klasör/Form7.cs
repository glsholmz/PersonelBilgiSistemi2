using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Bilgi_Sistemi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public Form1 frm1; 
        private void Form7_Load(object sender, EventArgs e)
        {
            panelGenelBilgiler.Location = new Point(12, 28);
            panelGenelBilgiler.Height = 872;
            panelGenelBilgiler.Width = 850;
            panelOgrenimBilgileri.Visible = false;
            panelGenelBilgiler.Visible = true;
            panelDigerBilgiler.Visible = false;

            


        }


        private void toolStripLabelGenelBilgiler_Click(object sender, EventArgs e)
        {
            panelGenelBilgiler.Location = new Point(12, 28);
            panelGenelBilgiler.Height = 872;
            panelGenelBilgiler.Width = 850;
            panelOgrenimBilgileri.Visible = false;
            panelGenelBilgiler.Visible = true;
            panelDigerBilgiler.Visible = false;
        }


        private void toolStripLabelOgrenimBilgileri_Click(object sender, EventArgs e)
        {
            panelOgrenimBilgileri.Location = new Point(12, 28);
            panelOgrenimBilgileri.Height = 872;
            panelOgrenimBilgileri.Width = 850;
            panelOgrenimBilgileri.Visible = true;
            panelGenelBilgiler.Visible = false;
            panelDigerBilgiler.Visible = false;


        }

        private void toolStripLabelDigerBilgiler_Click(object sender, EventArgs e)
        {
            panelDigerBilgiler.Location = new Point(12, 28);
            panelDigerBilgiler.Height = 872;
            panelDigerBilgiler.Width = 850;
            panelOgrenimBilgileri.Visible = false;
            panelGenelBilgiler.Visible = false;
            panelDigerBilgiler.Visible = true;

        }

        private void toolStripLabelKaydet_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            service.KisiGuncelle(textBoxtc.Text, textBoxad.Text, textBoxsoyad.Text, textBoxdogumyeri.Text, dateTimePickerdogumtarihi.Text, comboBoxcinsiyet.Text, textBoxuyruk.Text, textBoxunvan.Text, textBoxpersonelno.Text, textBoxevtelefonu.Text,
                textBoxceptelefonu.Text, textBoxeposta.Text, textBoxil.Text, textBoxilce.Text, textBoxadres.Text, dateTimePickerisegiristarihi.Text, textBoxfirma.Text, textBoxsube.Text, textBoxbirim.Text, textBoxsicilno.Text, textBoxvergino.Text, textBoxvergidaire.Text, textBoxbanka.Text, textBoxbankasubesi.Text, textBoxbankahesapno.Text,
                textBoxilkokuladi.Text, dateTimePickerilkokulbas.Text, dateTimePickerilkokulmezun.Text, textBoxliseokuladi.Text, dateTimePickerlisebas.Text, dateTimePickerlisemezun.Text, textBoxuniversiteokuladi.Text, textBoxuniversitebolum.Text, dateTimePickeruniversitebas.Text, dateTimePickeruniversitemezun.Text, textBoxegitimadi.Text, textBoxegitimbilgi.Text, dateTimePickeregitimbas.Text, dateTimePickeregitimbitis.Text,
                textBoxayrilmanedeni.Text, dateTimePickerayrilmatarihi.Text, comboBoxaskerlikdurumu.Text, textBoxtecilnedeni.Text, textBoxsakatlik.Text, comboBoxmedenidurum.Text, textBoxcocuksayisi.Text, textBoxkangrubu.Text, comboBoxehliyet.Text, textBoxkizliksoyadi.Text, textBoxraporsayisi.Text, textBoxizinsayisi.Text, comboBoxservis.Text);



            if (textBoxtc.Text == " " || textBoxad.Text == " " || textBoxsoyad.Text == "" || textBoxdogumyeri.Text == "" ||
            comboBoxcinsiyet.Text == "" ||
            textBoxuyruk.Text == "" ||
            textBoxunvan.Text == "" ||
            textBoxpersonelno.Text == "") { MessageBox.Show("Personel Genel Bilgilerini Eksiksiz Doldurunuz."); }

            else
            {
                MessageBox.Show("Personel Bilgileri Güncellendi");
                textSil();
            }
        }





        private void textSil()
        {
            textBoxtc.Text = "";
            textBoxad.Text = "";
            textBoxsoyad.Text = "";
            textBoxdogumyeri.Text = "";
            resetDateTimePicker();
            comboBoxcinsiyet.Text = "";
            textBoxuyruk.Text = "";
            textBoxunvan.Text = "";
            textBoxpersonelno.Text = "";
        }


        private void resetDateTimePicker()
        {

            dateTimePickerdogumtarihi.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=personelbilgileri; Integrated Security=True";
                con.Open();

            }
            catch (Exception hataDB)
            {
                MessageBox.Show("Hata DB bağlantı kurulamadı !" + hataDB.ToString());
            }

            string SQL = String.Format("select * from dbo.personel_genel_bilgileri,dbo.personel_iletisim_bilgileri,dbo.personel_mali_bilgileri,dbo.personel_istihdam_bilgileri,dbo.personel_ogrenim_bilgileri,dbo.personel_diger_bilgileri where personel_no='{0}' ", textBoxpersonelno.Text);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                textBoxad.Text = dr["ad"].ToString();
                textBoxtc.Text = dr["tc_kimlik_no"].ToString();
                textBoxsoyad.Text = dr["soyad"].ToString();
                textBoxdogumyeri.Text = dr["dogum_yeri"].ToString();
                comboBoxcinsiyet.Text = dr["cinsiyet"].ToString();
                textBoxuyruk.Text = dr["uyruk"].ToString();
                textBoxunvan.Text = dr["unvan"].ToString();
                textBoxpersonelno.Text = dr["personel_no"].ToString();
                textBoxevtelefonu.Text = dr["ev_telefonu"].ToString();
                textBoxceptelefonu.Text = dr["cep_telefonu"].ToString();
                textBoxil.Text = dr["il"].ToString();
                textBoxilce.Text = dr["ilce"].ToString();
                textBoxadres.Text = dr["adres"].ToString();
                textBoxeposta.Text = dr["e_posta"].ToString();
                textBoxfirma.Text = dr["firma"].ToString();
                textBoxsube.Text = dr["sube"].ToString();
                textBoxbirim.Text = dr["calistigi_birim"].ToString();
                textBoxsicilno.Text = dr["sigorta_sicil_no"].ToString();
                textBoxvergino.Text = dr["vergi_numarasi"].ToString();
                textBoxvergidaire.Text = dr["vergi_dairesi"].ToString();
                textBoxbanka.Text = dr["banka"].ToString();
                textBoxbankasubesi.Text = dr["banka_subesi"].ToString();
                textBoxbankahesapno.Text = dr["banka_hesap_no"].ToString();
                textBoxilkokuladi.Text = dr["ilkokul_adi"].ToString();
                textBoxliseokuladi.Text = dr["lise_adi"].ToString();
                textBoxuniversiteokuladi.Text = dr["universite_adi"].ToString();
                textBoxuniversitebolum.Text = dr["bolumu"].ToString();
                textBoxegitimadi.Text = dr["egitim_adi"].ToString();
                textBoxegitimbilgi.Text = dr["egitim_bilgi"].ToString();
                textBoxayrilmanedeni.Text = dr["isten_ayrilma_nedeni"].ToString();
                comboBoxaskerlikdurumu.Text = dr["askerlik_durumu"].ToString();
                textBoxtecilnedeni.Text = dr["tecil_nedeni"].ToString();
                textBoxsakatlik.Text = dr["sakatlik_durumu"].ToString();
                comboBoxmedenidurum.Text = dr["medeni_durum"].ToString();
                textBoxcocuksayisi.Text = dr["cocuk_sayisi"].ToString();
                textBoxkangrubu.Text = dr["kan_grubu"].ToString();
                comboBoxehliyet.Text = dr["ehliyet"].ToString();
                textBoxkizliksoyadi.Text = dr["kizlik_soyadi"].ToString();
                textBoxraporsayisi.Text = dr["rapor_aldigi_gun_sayisi"].ToString();
                textBoxizinsayisi.Text = dr["izinli_gun_sayisi"].ToString();
                comboBoxservis.Text = dr["servis_kullanimi"].ToString();

            }
        }






    }





}

