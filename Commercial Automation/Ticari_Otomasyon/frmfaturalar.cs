using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class frmfaturalar : Form
    {
        public frmfaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void faturalistele()
        {
            SqlDataAdapter DA = new SqlDataAdapter("select * from TBL_FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            DA.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtid.Text ="";
            txtseri.Text = "";
            txtsırano.Text = "";
            msktarih.Text = "";
            msksaat.Text = "";
            txtvergidairesi.Text = "";
            txtyalıcı.Text = "";
            txtteslimeden.Text = "";
            txtteslimalan.Text = "";
        }
        private void frmfaturalar_Load(object sender, EventArgs e)
        {
            faturalistele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
            //firma kaydı
            if (txtfaturaıd.Text == "" )
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtseri.Text);
                komut.Parameters.AddWithValue("@p2", txtsırano.Text);
                komut.Parameters.AddWithValue("@p3", msktarih.Text);
                komut.Parameters.AddWithValue("@p4", msksaat.Text);
                komut.Parameters.AddWithValue("@p5", txtvergidairesi.Text);
                komut.Parameters.AddWithValue("@p6", txtyalıcı.Text);
                komut.Parameters.AddWithValue("@p7", txtteslimeden.Text);
                komut.Parameters.AddWithValue("@p8", txtteslimalan.Text);
                komut.ExecuteNonQuery();
                faturalistele();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Kaydı Sisteme Başarıyla Yapıldı", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtfaturaıd.Text != "" && comboBox1.Text=="Firma")
            {
                double miktar, tutar,fiyat;
                fiyat = Convert.ToDouble(txtfiyat.Text);
                miktar = Convert.ToDouble(txtmiktar.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();
                
                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,FIYAT,MIKTAR,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtürünadı.Text);
                komut2.Parameters.AddWithValue("@p2", decimal.Parse(txtfiyat.Text));
                komut2.Parameters.AddWithValue("@p3", txtmiktar.Text);
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtfaturaıd.Text);
                komut2.ExecuteNonQuery();
                faturalistele();
                bgl.baglanti().Close();
                
                //hAREKRET TABLOSUNA VERI GIRISI
                SqlCommand komut7 = new SqlCommand("insert into TBL_FIRMAHAREKETLER (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) VALUES (@H1,@H2,@H3,@H4,@H5,@H6,@H7,@H8)", bgl.baglanti());
                komut7.Parameters.AddWithValue("@H1", txtürünid.Text);
                komut7.Parameters.AddWithValue("@H2", txtmiktar.Text);
                komut7.Parameters.AddWithValue("@H3", txtpersonel.Text);
                komut7.Parameters.AddWithValue("@H4", txtfirma.Text);
               
                komut7.Parameters.AddWithValue("@H5", decimal.Parse(txtfiyat.Text));
                komut7.Parameters.AddWithValue("@H6", decimal.Parse(txttutar.Text));
                komut7.Parameters.AddWithValue("@H7", txtfaturaıd.Text);
                komut7.Parameters.AddWithValue("@H8", msktarih.Text);
                komut7.ExecuteNonQuery();
                bgl.baglanti().Close();

                //stok sayısını azaltma
                SqlCommand komut9 = new SqlCommand("update TBL_URUNLER SET ADET=ADET-@S1 WHERE ID=@S2 ", bgl.baglanti());
                komut9.Parameters.AddWithValue("@S1", txtmiktar.Text);
                komut9.Parameters.AddWithValue("@S2", txtürünid.Text);
                komut9.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Fatura Kaydı Sisteme Başarıyla Yapıldı", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            //müşteri hareket
            if (txtfaturaıd.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtseri.Text);
                komut.Parameters.AddWithValue("@p2", txtsırano.Text);
                komut.Parameters.AddWithValue("@p3", msktarih.Text);
                komut.Parameters.AddWithValue("@p4", msksaat.Text);
                komut.Parameters.AddWithValue("@p5", txtvergidairesi.Text);
                komut.Parameters.AddWithValue("@p6", txtyalıcı.Text);
                komut.Parameters.AddWithValue("@p7", txtteslimeden.Text);
                komut.Parameters.AddWithValue("@p8", txtteslimalan.Text);
                komut.ExecuteNonQuery();
                faturalistele();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Kaydı Sisteme Başarıyla Yapıldı", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtfaturaıd.Text != "" && comboBox1.Text=="Müşteri")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtfiyat.Text);
                miktar = Convert.ToDouble(txtmiktar.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,FIYAT,MIKTAR,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtürünadı.Text);
                komut2.Parameters.AddWithValue("@p2", decimal.Parse(txtfiyat.Text));
                komut2.Parameters.AddWithValue("@p3", txtmiktar.Text);
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtfaturaıd.Text);
                komut2.ExecuteNonQuery();
                faturalistele();
                bgl.baglanti().Close();

                //hAREKRET TABLOSUNA VERI GIRISI
                SqlCommand komut7 = new SqlCommand("insert into TBL_MUSTERIHAREKETLER (URUNID,ADET,PERSONEL,MUSTERİ,FIYAT,TOPLAM,FATURAID,TARIH) VALUES (@H1,@H2,@H3,@H4,@H5,@H6,@H7,@H8)", bgl.baglanti());
                komut7.Parameters.AddWithValue("@H1", txtürünid.Text);
                komut7.Parameters.AddWithValue("@H2", txtmiktar.Text);
                komut7.Parameters.AddWithValue("@H3", txtpersonel.Text);
                komut7.Parameters.AddWithValue("@H4", txtfirma.Text);

                komut7.Parameters.AddWithValue("@H5", decimal.Parse(txtfiyat.Text));
                komut7.Parameters.AddWithValue("@H6", decimal.Parse(txttutar.Text));
                komut7.Parameters.AddWithValue("@H7", txtfaturaıd.Text);
                komut7.Parameters.AddWithValue("@H8", msktarih.Text);
                komut7.ExecuteNonQuery();
                bgl.baglanti().Close();

                //stok sayısını azaltma
                SqlCommand komut9 = new SqlCommand("update TBL_URUNLER SET ADET=ADET-@S1 WHERE ID=@S2 ", bgl.baglanti());
                komut9.Parameters.AddWithValue("@S1", txtmiktar.Text);
                komut9.Parameters.AddWithValue("@S2", txtürünid.Text);
                komut9.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Fatura Kaydı Sisteme Başarıyla Yapıldı", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }



            private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FATURA ID ALANI BOŞKEN KAYIT YAPILMAK İSTENİRSE SADECE FATURA BİLGİLERİ KISMINDAKİ ALANLAR ETKİLENİR", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtseri.Text = dr["SERI"].ToString();
                txtsırano.Text = dr["SIRANO"].ToString();
                msktarih.Text = dr["TARIH"].ToString();
                msksaat.Text = dr["SAAT"].ToString();
                txtvergidairesi.Text = dr["VERGIDAIRE"].ToString();
                txtyalıcı.Text = dr["ALICI"].ToString();
                txtteslimeden.Text = dr["TESLIMEDEN"].ToString();
                txtteslimalan.Text = dr["TESLIMALAN"].ToString();
            }
        }

       
       

       

        private void btngüncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRE=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8 where ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtseri.Text);
            komut.Parameters.AddWithValue("@p2", txtsırano.Text);
            komut.Parameters.AddWithValue("@p3", msktarih.Text);
            komut.Parameters.AddWithValue("@p4", msksaat.Text);
            komut.Parameters.AddWithValue("@p5", txtvergidairesi.Text);
            komut.Parameters.AddWithValue("@p6", txtyalıcı.Text);
            komut.Parameters.AddWithValue("@p7", txtteslimeden.Text);
            komut.Parameters.AddWithValue("@p8", txtteslimalan.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);
            komut.ExecuteNonQuery();
            faturalistele();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Güncellme İşlemi Başarıyla Yapıldı", "GÜNCELLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show(txtid.Text + "  " + "ID'li Faturayı" + " " + "silmeyi onaylıyor musunuz ?", "EMİN MİSİNİZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_FATURABILGI ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                faturalistele();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Silme İşlemi Başarıyla Gerçekleşmiştir", "SİLME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (secim == DialogResult.No)
            {
                MessageBox.Show(" " + "Silme işlemi İptal Edilmiştir....", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            faturalistele();
            bgl.baglanti().Close();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmfaturaürünler fr = new frmfaturaürünler();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["ID"].ToString();
                fr.Show();
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            SqlCommand komut99 = new SqlCommand("select URUNAD,SATISFIYAT FROM TBL_URUNLER WHERE ID=@P1", bgl.baglanti());
            komut99.Parameters.AddWithValue("@P1", txtürünid.Text);
            SqlDataReader dr = komut99.ExecuteReader();
            while (dr.Read())
            {
                txtürünadı.Text = dr[0].ToString();
                txtfiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
    }

        private void frmfaturalar_Load_1(object sender, EventArgs e)
        {

        }
    }
