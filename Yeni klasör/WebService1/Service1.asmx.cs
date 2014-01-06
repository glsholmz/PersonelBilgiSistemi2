using System;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;


namespace WebService1
{



    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    public class Service1 : System.Web.Services.WebService

    {

      

        [WebMethod]
        public DataSet PersonelBilgilerini_Al()
        {
            SqlConnection Baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=personelbilgileri; Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            komut.Connection = Baglanti;
            Baglanti.Open();

            string SQL = String.Format("SELECT personel_no, tc_kimlik_no,  ad,  soyad,  dogum_yeri,  dogum_tarihi,  cinsiyet,  uyruk,unvan,"  
            +" ev_telefonu,  cep_telefonu,  e_posta,  il,  ilce,  adres,"
            + "ise_giris_tarihi,  firma,  sube,calistigi_birim,sigorta_sicil_no,"
            + "vergi_numarasi,  vergi_dairesi,  banka,  banka_subesi,  banka_hesap_no,"
            + "ilkokul_adi,  ilkokul_baslama_tarihi,  ilkokul_mezun_olma_tarihi,  lise_adi,"
            +" lise_baslama_tarihi,  lise_mezun_olma_tarihi,  universite_adi,  bolumu,  uni_baslama_tarihi,  uni_mezun_olma_tarihi,"
            + "egitim_adi,  egitim_bilgi,  egitim_baslama_tarihi,  egitim_bitirme_tarihi,  isten_ayrilma_nedeni,  isten_ayrilma_tarihi,"
            +"askerlik_durumu,  tecil_nedeni,  sakatlik_durumu,  medeni_durum,  cocuk_sayisi,  kan_grubu,  ehliyet,  kizlik_soyadi,"
            +"rapor_aldigi_gun_sayisi,  izinli_gun_sayisi,  servis_kullanimi FROM personel_genel_bilgileri , personel_iletisim_bilgileri  ,"
              +"  personel_mali_bilgileri  ,"
              +" personel_istihdam_bilgileri  ,"
              +"  personel_ogrenim_bilgileri  ,"
              + " personel_diger_bilgileri  WHERE  personel_no=personel_no2 and personel_no=personel_no4 and personel_no=personel_no3 and personel_no=personel_no5 and personel_no=personel_no6 ");
                

     
            SqlDataAdapter Adap = new SqlDataAdapter(SQL, Baglanti);
            DataSet MyDataSet = new DataSet();
            Adap.Fill(MyDataSet);
            MyDataSet.AcceptChanges();

            Baglanti.Close();
            return MyDataSet;
        }

        [WebMethod]
        public DataSet personel_kayit(string tc_kimlik_no, string ad, string soyad, string dogum_yeri, string dogum_tarihi, string cinsiyet, string uyruk,
            string unvan, string personel_no,string personel_no2,
            string ev_telefonu, string cep_telefonu, string e_posta, string il, string ilce, string adres,
            string personel_no3,string ise_giris_tarihi, string firma, string sube, string calistigi_birim, string sigorta_sicil_no,
            string personel_no4,string vergi_numarasi, string vergi_dairesi, string banka, string banka_subesi, string banka_hesap_no,
            string personel_no5,string ilkokul_adi, string ilkokul_baslama_tarihi, string ilkokul_mezun_olma_tarihi, string lise_adi,
            string lise_baslama_tarihi, string lise_mezun_olma_tarihi, string universite_adi, string bolumu, string uni_baslama_tarihi, string uni_mezun_olma_tarihi,
            string egitim_adi, string egitim_bilgi, string egitim_baslama_tarihi, string egitim_bitirme_tarihi,string personel_no6, string isten_ayrilma_nedeni, string isten_ayrilma_tarihi,
            string askerlik_durumu, string tecil_nedeni, string sakatlik_durumu, string medeni_durum, string cocuk_sayisi, string kan_grubu, string ehliyet, string kizlik_soyadi,
            string rapor_aldigi_gun_sayisi, string izinli_gun_sayisi, string servis_kullanimi)
        {
            SqlConnection Baglanti = new SqlConnection((@"Data Source=.\SQLEXPRESS; Initial Catalog=personelbilgileri; Integrated Security=True"));
            Baglanti.Open();
            string dataAdd = "INSERT INTO personel_genel_bilgileri ( tc_kimlik_no, ad, soyad, dogum_yeri, dogum_tarihi, cinsiyet, uyruk, unvan, personel_no) VALUES(@tc_kimlik_no,@ad,@soyad,@dogum_yeri,@dogum_tarihi,@cinsiyet,@uyruk,@unvan,@personel_no)";
            SqlCommand komut = new SqlCommand(dataAdd, Baglanti);
            komut.Parameters.AddWithValue("@tc_kimlik_no", tc_kimlik_no);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@dogum_yeri", dogum_yeri);
            komut.Parameters.AddWithValue("@dogum_tarihi", dogum_tarihi);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@uyruk", uyruk);
            komut.Parameters.AddWithValue("@unvan", unvan);
            komut.Parameters.AddWithValue("@personel_no", personel_no);

            string dataAdd2 = "INSERT INTO personel_iletisim_bilgileri (personel_no2, ev_telefonu, cep_telefonu, e_posta, il,ilce,adres) VALUES(@personel_no2,@ev_telefonu,@cep_telefonu,@e_posta,@il,@ilce,@adres) ";
            SqlCommand komut2 = new SqlCommand(dataAdd2, Baglanti);
            komut2.Parameters.AddWithValue("@personel_no2", personel_no2);
            komut2.Parameters.AddWithValue("@ev_telefonu", ev_telefonu);
            komut2.Parameters.AddWithValue("@cep_telefonu", cep_telefonu);
            komut2.Parameters.AddWithValue("@e_posta", e_posta);
            komut2.Parameters.AddWithValue("@il", il);
            komut2.Parameters.AddWithValue("@ilce", ilce);
            komut2.Parameters.AddWithValue("@adres", adres);



            string dataAdd3 = "INSERT INTO personel_istihdam_bilgileri (personel_no3, ise_giris_tarihi, firma, sube, calistigi_birim,sigorta_sicil_no) VALUES(@personel_no3,@ise_giris_tarihi,@firma,@sube,@calistigi_birim,@sigorta_sicil_no)";
           
            SqlCommand komut3 = new SqlCommand(dataAdd3, Baglanti);
            komut3.Parameters.AddWithValue("@personel_no3", personel_no3);
            komut3.Parameters.AddWithValue("@ise_giris_tarihi", ise_giris_tarihi);
            komut3.Parameters.AddWithValue("@firma", firma);
            komut3.Parameters.AddWithValue("@sube", sube);
            komut3.Parameters.AddWithValue("@calistigi_birim", calistigi_birim);
            komut3.Parameters.AddWithValue("@sigorta_sicil_no", sigorta_sicil_no);


            string dataAdd4 = "INSERT INTO personel_mali_bilgileri (personel_no4, vergi_numarasi, vergi_dairesi, banka, banka_subesi,banka_hesap_no) VALUES(@personel_no4,@vergi_numarasi,@vergi_dairesi,@banka,@banka_subesi,@banka_hesap_no)";
           
            SqlCommand komut4 = new SqlCommand(dataAdd4, Baglanti);
            komut4.Parameters.AddWithValue("@personel_no4", personel_no4);
            komut4.Parameters.AddWithValue("@vergi_numarasi", vergi_numarasi);
            komut4.Parameters.AddWithValue("@vergi_dairesi", vergi_dairesi);
            komut4.Parameters.AddWithValue("@banka", banka);
            komut4.Parameters.AddWithValue("@banka_subesi", banka_subesi);
            komut4.Parameters.AddWithValue("@banka_hesap_no", banka_hesap_no);
            

          

            string dataAdd5 = "INSERT INTO personel_ogrenim_bilgileri (personel_no5,ilkokul_adi, ilkokul_baslama_tarihi, ilkokul_mezun_olma_tarihi, lise_adi, lise_baslama_tarihi, lise_mezun_olma_tarihi,universite_adi,bolumu,uni_baslama_tarihi,uni_mezun_olma_tarihi,egitim_adi,egitim_bilgi,egitim_baslama_tarihi,egitim_bitirme_tarihi)VALUES(@personel_no5,@ilkokul_adi,@ilkokul_baslama_tarihi,@ilkokul_mezun_olma_tarihi,@lise_adi,@lise_baslama_tarihi,@lise_mezun_olma_tarihi,@universite_adi,@bolumu,@uni_baslama_tarihi,@uni_mezun_olma_tarihi,@egitim_adi,@egitim_bilgi,@egitim_baslama_tarihi,@egitim_bitirme_tarihi)";
            SqlCommand komut5 = new SqlCommand(dataAdd5, Baglanti);
            komut5.Parameters.AddWithValue("@personel_no5", personel_no5);
            komut5.Parameters.AddWithValue("@ilkokul_adi", ilkokul_adi);
            komut5.Parameters.AddWithValue("@ilkokul_baslama_tarihi", ilkokul_baslama_tarihi);
            komut5.Parameters.AddWithValue("@ilkokul_mezun_olma_tarihi", ilkokul_mezun_olma_tarihi);
            komut5.Parameters.AddWithValue("@lise_adi", lise_adi);
            komut5.Parameters.AddWithValue("@lise_baslama_tarihi", lise_baslama_tarihi);
            komut5.Parameters.AddWithValue("@lise_mezun_olma_tarihi", lise_mezun_olma_tarihi);
            komut5.Parameters.AddWithValue("@universite_adi", universite_adi);
            komut5.Parameters.AddWithValue("@bolumu", bolumu);
            komut5.Parameters.AddWithValue("@uni_baslama_tarihi", uni_baslama_tarihi);
            komut5.Parameters.AddWithValue("@uni_mezun_olma_tarihi", uni_mezun_olma_tarihi);
            komut5.Parameters.AddWithValue("@egitim_adi", egitim_adi);
            komut5.Parameters.AddWithValue("@egitim_bilgi", egitim_bilgi);
            komut5.Parameters.AddWithValue("@egitim_baslama_tarihi", egitim_baslama_tarihi);
            komut5.Parameters.AddWithValue("@egitim_bitirme_tarihi", egitim_bitirme_tarihi);

            string dataAdd6 = "INSERT INTO personel_diger_bilgileri (personel_no6,isten_ayrilma_nedeni, isten_ayrilma_tarihi, askerlik_durumu, tecil_nedeni, sakatlik_durumu, medeni_durum,cocuk_sayisi,kan_grubu,ehliyet,kizlik_soyadi,rapor_aldigi_gun_sayisi,izinli_gun_sayisi,servis_kullanimi)VALUES(@personel_no6,@isten_ayrilma_nedeni,@isten_ayrilma_tarihi,@askerlik_durumu,@tecil_nedeni,@sakatlik_durumu,@medeni_durum,@cocuk_sayisi,@kan_grubu,@ehliyet,@kizlik_soyadi,@rapor_aldigi_gun_sayisi,@izinli_gun_sayisi,@servis_kullanimi)";
            SqlCommand komut6 = new SqlCommand(dataAdd6, Baglanti);
            komut6.Parameters.AddWithValue("@personel_no6", personel_no6);
            komut6.Parameters.AddWithValue("@isten_ayrilma_nedeni", isten_ayrilma_nedeni);
            komut6.Parameters.AddWithValue("@isten_ayrilma_tarihi", isten_ayrilma_tarihi);
            komut6.Parameters.AddWithValue("@askerlik_durumu", askerlik_durumu);
            komut6.Parameters.AddWithValue("@tecil_nedeni", tecil_nedeni);
            komut6.Parameters.AddWithValue("@sakatlik_durumu", sakatlik_durumu);
            komut6.Parameters.AddWithValue("@medeni_durum", medeni_durum);
            komut6.Parameters.AddWithValue("@cocuk_sayisi", cocuk_sayisi);
            komut6.Parameters.AddWithValue("@kan_grubu", kan_grubu);
            komut6.Parameters.AddWithValue("@ehliyet", ehliyet);
            komut6.Parameters.AddWithValue("@kizlik_soyadi", kizlik_soyadi);
            komut6.Parameters.AddWithValue("@rapor_aldigi_gun_sayisi", rapor_aldigi_gun_sayisi);
            komut6.Parameters.AddWithValue("@izinli_gun_sayisi", izinli_gun_sayisi);
            komut6.Parameters.AddWithValue("@servis_kullanimi", servis_kullanimi);
            
            
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            komut3.ExecuteNonQuery();
            komut4.ExecuteNonQuery();
            komut5.ExecuteNonQuery();
            komut6.ExecuteNonQuery();
            
            Baglanti.Close();
            return PersonelBilgilerini_Al();


        }




        [WebMethod]
        public DataSet KisiDondurad(string ad)
        {
            string SQL = String.Format("SELECT * FROM personel_genel_bilgileri,personel_iletisim_bilgileri,personel_mali_bilgileri,personel_istihdam_bilgileri,personel_ogrenim_bilgileri,personel_diger_bilgileri WHERE ad = '{0}'and personel_no=personel_no2 and personel_no=personel_no3 and personel_no=personel_no4 and personel_no=personel_no5 and personel_no=personel_no6", ad);
            SqlConnection Baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=personelbilgileri; Integrated Security=True");
            Baglanti.Open();



            SqlDataAdapter da = new SqlDataAdapter(SQL, Baglanti);
            da.SelectCommand.ExecuteNonQuery();
            DataSet dt = new DataSet();
            da.Fill(dt);

            Baglanti.Close();
            return dt;
        }

        [WebMethod]
        public DataSet KisiDondurtc(string tc_kimlik_no)
        {
            string SQL = String.Format("SELECT * FROM personel_genel_bilgileri,personel_iletisim_bilgileri,personel_mali_bilgileri,personel_istihdam_bilgileri,personel_ogrenim_bilgileri,personel_diger_bilgileri WHERE tc_kimlik_no = '{0}' and personel_no=personel_no2 and personel_no=personel_no3 and personel_no=personel_no4 and personel_no=personel_no5 and personel_no=personel_no6", tc_kimlik_no);
            SqlConnection Baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=personelbilgileri; Integrated Security=True");
            Baglanti.Open();



            SqlDataAdapter da = new SqlDataAdapter(SQL, Baglanti);
            da.SelectCommand.ExecuteNonQuery();
            DataSet dt = new DataSet();
            da.Fill(dt);

            Baglanti.Close();
            return dt;
        }
        [WebMethod]
        public DataSet KisiDondurpers(string personel_no)
        {
            string SQL = String.Format("SELECT * FROM personel_genel_bilgileri,personel_iletisim_bilgileri,personel_mali_bilgileri,personel_istihdam_bilgileri,personel_ogrenim_bilgileri,personel_diger_bilgileri WHERE personel_no = '{0}' and personel_no=personel_no2 and personel_no=personel_no3 and personel_no=personel_no4 and personel_no=personel_no5 and personel_no=personel_no6 ", personel_no);
            SqlConnection Baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=personelbilgileri; Integrated Security=True");
            Baglanti.Open();



            SqlDataAdapter da = new SqlDataAdapter(SQL, Baglanti);
            da.SelectCommand.ExecuteNonQuery();
            DataSet dt = new DataSet();
            da.Fill(dt);

            Baglanti.Close();
            return dt;
        }

      
        [WebMethod]
        public void KisiSil(string personel_no)
        {


            SqlConnection Baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=personelbilgileri; Integrated Security=True");
            Baglanti.Open();
           /* SqlCommand km = new SqlCommand("DELETE  FROM personel_diger_bilgileri where @personel_no='sil'",Baglanti);
            km.Parameters.AddWithValue("@personel_no", personel_no);
            km.ExecuteNonQuery();*/
            SqlCommand komut = new SqlCommand("DELETE FROM personel_genel_bilgileri WHERE  @personel_no=personel_no ", Baglanti); 
            komut.Parameters.AddWithValue("@personel_no", personel_no);
            
            SqlCommand komut2 = new SqlCommand("DELETE FROM personel_iletisim_bilgileri  WHERE  @personel_no=personel_no2 ", Baglanti);
            komut2.Parameters.AddWithValue("@personel_no", personel_no);
            SqlCommand komut3 = new SqlCommand("DELETE FROM personel_istihdam_bilgileri WHERE  @personel_no=personel_no3 ", Baglanti);
            komut3.Parameters.AddWithValue("@personel_no", personel_no);
            SqlCommand komut4 = new SqlCommand("DELETE FROM personel_mali_bilgileri WHERE  @personel_no=personel_no4 ", Baglanti);
            komut4.Parameters.AddWithValue("@personel_no", personel_no);
            SqlCommand komut5= new SqlCommand("DELETE FROM personel_ogrenim_bilgileri WHERE  @personel_no=personel_no5 ", Baglanti);
            komut5.Parameters.AddWithValue("@personel_no", personel_no);
            SqlCommand komut6= new SqlCommand("DELETE FROM personel_diger_bilgileri WHERE  @personel_no=personel_no6 ", Baglanti);
            komut6.Parameters.AddWithValue("@personel_no", personel_no);
            
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            komut3.ExecuteNonQuery();
            komut4.ExecuteNonQuery();
            komut5.ExecuteNonQuery();
            komut6.ExecuteNonQuery();
            Baglanti.Close();
            personel_no = null;
        }
        

        [WebMethod]
        public bool KisiGuncelle(string tc_kimlik_no, string ad, string soyad, string dogum_yeri, string dogum_tarihi, string cinsiyet, string uyruk,
            string unvan, string personel_no,
            string ev_telefonu, string cep_telefonu, string e_posta, string il, string ilce, string adres,
            string ise_giris_tarihi, string firma, string sube, string calistigi_birim, string sigorta_sicil_no,
            string vergi_numarasi, string vergi_dairesi, string banka, string banka_subesi, string banka_hesap_no,
            string ilkokul_adi, string ilkokul_baslama_tarihi, string ilkokul_mezun_olma_tarihi, string lise_adi,
            string lise_baslama_tarihi, string lise_mezun_olma_tarihi, string universite_adi, string bolumu, string uni_baslama_tarihi, string uni_mezun_olma_tarihi,
            string egitim_adi, string egitim_bilgi, string egitim_baslama_tarihi, string egitim_bitirme_tarihi, string isten_ayrilma_nedeni, string isten_ayrilma_tarihi,
            string askerlik_durumu, string tecil_nedeni, string sakatlik_durumu, string medeni_durum, string cocuk_sayisi, string kan_grubu, string ehliyet, string kizlik_soyadi,
            string rapor_aldigi_gun_sayisi, string izinli_gun_sayisi, string servis_kullanimi)
        {
            if (personel_no == null) throw new Exception("Record does not exist in Customers table.");
            SqlConnection Baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=personelbilgileri; Integrated Security=True");
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE personel_genel_bilgileri SET "
              + "tc_kimlik_no = @tc_kimlik_no, ad = @ad, "
              + "soyad = @soyad, dogum_yeri = @dogum_yeri, dogum_tarihi = @dogum_tarihi, "
              + "cinsiyet = @cinsiyet, uyruk = @uyruk, unvan = @unvan "
              + "WHERE personel_no = @personel_no", Baglanti);
            komut.Parameters.AddWithValue("@tc_kimlik_no", tc_kimlik_no);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@dogum_yeri", dogum_yeri);
            komut.Parameters.AddWithValue("@dogum_tarihi", dogum_tarihi);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@uyruk", uyruk);
            komut.Parameters.AddWithValue("@unvan", unvan);
            komut.Parameters.AddWithValue("@personel_no", personel_no);

            SqlCommand komut2 = new SqlCommand("UPDATE personel_iletisim_bilgileri SET "
              + "ev_telefonu = @ev_telefonu, cep_telefonu = @cep_telefonu, "
              + "e_posta = @e_posta, il = @il, ilce = @ilce, "
              + "adres = @adres"+ "WHERE personel_no = @personel_no", Baglanti);
            komut2.Parameters.AddWithValue("@ev_telefonu", ev_telefonu);
            komut2.Parameters.AddWithValue("@cep_telefonu", cep_telefonu);
            komut2.Parameters.AddWithValue("@e_posta", e_posta);
            komut2.Parameters.AddWithValue("@il", il);
            komut2.Parameters.AddWithValue("@ilce", ilce);
            komut2.Parameters.AddWithValue("@adres", adres);


            SqlCommand komut3 = new SqlCommand("UPDATE personel_istihdam_bilgileri SET "
              + "ise_giris_tarihi = @ise_giris_tarihi, firma = @firma, "
              + "sube = @sube, calistigi_birim = @calistigi_birim, sigorta_sicil_no = @sigorta_sicil_no"
              + "WHERE personel_no = @personel_no", Baglanti);
            komut3.Parameters.AddWithValue("@ise_giris_tarihi", ise_giris_tarihi);
            komut3.Parameters.AddWithValue("@firma", firma);
            komut3.Parameters.AddWithValue("@sube", sube);
            komut3.Parameters.AddWithValue("@calistigi_birim", calistigi_birim);
            komut3.Parameters.AddWithValue("@sigorta_sicil_no", sigorta_sicil_no);


            SqlCommand komut4 = new SqlCommand("UPDATE personel_mali_bilgileri SET "
              + "vergi_numarasi = @vergi_numarasi, vergi_dairesi = @vergi_dairesi, "
              + "banka = @banka, banka_subesi = @banka_subesi, banka_hesap_no = @banka_hesap_no"
              + "WHERE personel_no = @personel_no", Baglanti);
            komut4.Parameters.AddWithValue("@vergi_numarasi", vergi_numarasi);
            komut4.Parameters.AddWithValue("@vergi_dairesi", vergi_dairesi);
            komut4.Parameters.AddWithValue("@banka", banka);
            komut4.Parameters.AddWithValue("@banka_subesi", banka_subesi);
            komut4.Parameters.AddWithValue("@banka_hesap_no", banka_hesap_no);

            
            SqlCommand komut5 = new SqlCommand("UPDATE personel_ogrenim_bilgileri SET "
              + "ilkokul_adi = @ilkokul_adi, ilkokul_baslama_tarihi = @ilkokul_baslama_tarihi, "
              + "ilkokul_mezun_olma_tarihi = @ilkokul_mezun_olma_tarihi, lise_adi = @lise_adi, lise_baslama_tarihi = @lise_baslama_tarihi,"
              + "lise_mezun_olma_tarihi=@lise_mezun_olma_tarihi,universite_adi=@universite_adi,"
              + "bolumu=@bolumu,uni_baslama_tarihi=@uni_baslama_tarihi,uni_mezun_olma_tarihi=@uni_mezun_olma_tarihi"
              + "egitim_adi=@egitim_adi,egitim_bilgi=@egitim_bilgi,egitim_baslama_tarihi=@egitim_baslama_tarihi"
              +"egitim_bitirme_tarihi=@egitim_bitirme_tarihi"
              + "WHERE personel_no = @personel_no", Baglanti);
            komut5.Parameters.AddWithValue("@ilkokul_adi", ilkokul_adi);
            komut5.Parameters.AddWithValue("@ilkokul_baslama_tarihi", ilkokul_baslama_tarihi);
            komut5.Parameters.AddWithValue("@ilkokul_mezun_olma_tarihi", ilkokul_mezun_olma_tarihi);
            komut5.Parameters.AddWithValue("@lise_adi", lise_adi);
            komut5.Parameters.AddWithValue("@lise_baslama_tarihi", lise_baslama_tarihi);
            komut5.Parameters.AddWithValue("@lise_mezun_olma_tarihi", lise_mezun_olma_tarihi);
            komut5.Parameters.AddWithValue("@universite_adi", universite_adi);
            komut5.Parameters.AddWithValue("@bolumu", bolumu);
            komut5.Parameters.AddWithValue("@uni_baslama_tarihi", uni_baslama_tarihi);
            komut5.Parameters.AddWithValue("@uni_mezun_olma_tarihi", uni_mezun_olma_tarihi);
            komut5.Parameters.AddWithValue("@egitim_adi", egitim_adi);
            komut5.Parameters.AddWithValue("@egitim_bilgi", egitim_bilgi);
            komut5.Parameters.AddWithValue("@egitim_baslama_tarihi", egitim_baslama_tarihi);
            komut5.Parameters.AddWithValue("@egitim_bitirme_tarihi", egitim_bitirme_tarihi);


            SqlCommand komut6 = new SqlCommand("UPDATE personel_diger_bilgileri SET "
              + "isten_ayrilma_nedeni = @isten_ayrilma_nedeni, isten_ayrilma_tarihi = @isten_ayrilma_tarihi, "
              + "askerlik_durumu = @askerlik_durumu, tecil_nedeni = @tecil_nedeni, sakatlik_durumu = @sakatlik_durumu,"
              + "medeni_durum=@medeni_durum,cocuk_sayisi=@cocuk_sayisi,"
              + "kan_grubu=@kan_grubu,ehliyet=@ehliyet,kizlik_soyadi=@kizlik_soyadi"
              + "rapor_aldigi_gun_sayisi=@rapor_aldigi_gun_sayisi,izinli_gun_sayisi=@izinli_gun_sayisi,"
              + "servis_kullanimi=@servis_kullanimi"
              + "WHERE personel_no = @personel_no", Baglanti);
            komut6.Parameters.AddWithValue("@isten_ayrilma_nedeni", isten_ayrilma_nedeni);
            komut6.Parameters.AddWithValue("@isten_ayrilma_tarihi", isten_ayrilma_tarihi);
            komut6.Parameters.AddWithValue("@askerlik_durumu", askerlik_durumu);
            komut6.Parameters.AddWithValue("@tecil_nedeni", tecil_nedeni);
            komut6.Parameters.AddWithValue("@sakatlik_durumu", sakatlik_durumu);
            komut6.Parameters.AddWithValue("@medeni_durum", medeni_durum);
            komut6.Parameters.AddWithValue("@cocuk_sayisi", cocuk_sayisi);
            komut6.Parameters.AddWithValue("@kan_grubu", kan_grubu);
            komut6.Parameters.AddWithValue("@ehliyet", ehliyet);
            komut6.Parameters.AddWithValue("@kizlik_soyadi", kizlik_soyadi);
            komut6.Parameters.AddWithValue("@rapor_aldigi_gun_sayisi", rapor_aldigi_gun_sayisi);
            komut6.Parameters.AddWithValue("@izinli_gun_sayisi", izinli_gun_sayisi);
            komut6.Parameters.AddWithValue("@servis_kullanimi", servis_kullanimi);


            bool result = false;
            if (komut.ExecuteNonQuery() > 0) result = true;
            Baglanti.Close();
            return result;
        }

        

    }
}

