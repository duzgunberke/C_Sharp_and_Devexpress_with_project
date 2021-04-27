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
    public partial class frmfirmalar : Form
    {
        public frmfirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void firmalistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FIRMALAR ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void labelControl12_Click(object sender, EventArgs e)
        {

        }
        void carikodlarınaçıklaması()
        {
            SqlCommand komut = new SqlCommand("select FIRMAKOD1 from TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rchkod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void frmfirmalar_Load(object sender, EventArgs e)
        {
            firmalistele();
            temizle();
            sehirlistesi();
            carikodlarınaçıklaması();
        }
       

        void temizle()
        {
            txtid.Text = " ";
            txtad.Text = " ";
            msktc.Text = " ";
            txtsektor.Text = " ";
            txtygörev.Text = " ";
            txtyetkili.Text = " ";
            msktel.Text = " ";
            msktel2.Text = " ";
            msktel3.Text =" ";
            txtmaıl.Text =" ";
            mskfaks.Text = " ";
            cmbil.Text = " ";
            cmbilce.Text = " ";
            txtvergidairesi.Text = " ";
            rchadres.Text = " ";
            txtkod1.Text = "";
            txtkod2.Text = "";
            txtkod3.Text = "";
            txtad.Focus();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                msktc.Text = dr["YETKILITC"].ToString();
                txtsektor.Text = dr["SEKTOR"].ToString();
                txtygörev.Text = dr["YETKILISTATU"].ToString();
                txtyetkili.Text = dr["YETKILIADSOYAD"].ToString();
                msktel.Text = dr["TELEFON1"].ToString();
                msktel2.Text = dr["TELEFON2"].ToString();
                msktel3.Text = dr["TELEFON3"].ToString();
                txtmaıl.Text = dr["MAIL"].ToString();
                mskfaks.Text = dr["FAX"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                txtvergidairesi.Text = dr["VERGIDAIRE"].ToString();
                rchadres.Text = dr["ADRES"].ToString();
                txtkod1.Text = dr["OZELKOD1"].ToString();
                txtkod2.Text = dr["OZELKOD2"].ToString();
                txtkod3.Text = dr["OZELKOD3"].ToString();



            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR (AD,YETKILITC,SEKTOR,YETKILISTATU,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", msktc.Text);
            komut.Parameters.AddWithValue("@p3", txtsektor.Text);
            komut.Parameters.AddWithValue("@p4", txtygörev.Text);
            komut.Parameters.AddWithValue("@p5", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p6", msktel.Text);
            komut.Parameters.AddWithValue("@p7", msktel2.Text);
            komut.Parameters.AddWithValue("@p8", msktel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p10", mskfaks.Text);
            komut.Parameters.AddWithValue("@p11", cmbil.Text);
            komut.Parameters.AddWithValue("@p12", cmbilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergidairesi.Text);
            komut.Parameters.AddWithValue("@p14", rchadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmalistele();
            MessageBox.Show("Firma Kayıt İşlemi Başarıyla Gerçekleşmiştir", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbil_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show(txtad.Text + "  " + "adlı firmayı" + " " + "silmeyi onaylıyor musunuz ?", "EMİN MİSİNİZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_FIRMALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                firmalistele();
                MessageBox.Show("Firma Silme İşlemi Başarıyla Gerçekleşmiştir", "SİLME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (secim == DialogResult.No)
            {
                MessageBox.Show(" " + "Silme işlemi İptal Edilmiştir....","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            firmalistele();
            bgl.baglanti().Close();
            
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FIRMALAR set AD=@p1,YETKILITC=@p2,SEKTOR=@p3,YETKILISTATU=@p4,YETKILIADSOYAD=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13,ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 where ID=@p18", bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", msktc.Text);
            komut.Parameters.AddWithValue("@p3", txtsektor.Text);
            komut.Parameters.AddWithValue("@p4", txtygörev.Text);
            komut.Parameters.AddWithValue("@p5", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p6", msktel.Text);
            komut.Parameters.AddWithValue("@p7", msktel2.Text);
            komut.Parameters.AddWithValue("@p8", msktel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p10", mskfaks.Text);
            komut.Parameters.AddWithValue("@p11", cmbil.Text);
            komut.Parameters.AddWithValue("@p12", cmbilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergidairesi.Text);
            komut.Parameters.AddWithValue("@p14", rchadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut.Parameters.AddWithValue("@p18", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmalistele();
            MessageBox.Show("Firma Güncelleme İşlemi Başarıyla Gerçekleşmiştir", "GÜNCELLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
    }
