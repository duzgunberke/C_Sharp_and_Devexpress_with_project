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
    public partial class frmbankalar : Form
    {
        public frmbankalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void bankalistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute bankainnerjoin", bgl.baglanti());
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
        void firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD from TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            cmbil.Text = "";
            cmbilçe.Text = "";
            txtşube.Text = "";
            mskıban.Text = "";
            mskhesapno.Text = "";
            txtyetkili.Text = "";
            msktel1.Text = "";
            msktarih.Text = "";
            txthesaptürü.Text = "";
           // lookUpEdit1.EditValue = "";
        }
        private void frmbankalar_Load(object sender, EventArgs e)
        {
            bankalistele();
            sehirlistesi();
            firmalistesi();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", cmbil.Text);
            komut.Parameters.AddWithValue("@p3", cmbilçe.Text);
            komut.Parameters.AddWithValue("@p4", txtşube.Text);
            komut.Parameters.AddWithValue("@p5", mskıban.Text);
            komut.Parameters.AddWithValue("@p6", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p8", msktel1.Text);
            komut.Parameters.AddWithValue("@p9", msktarih.Text);
            komut.Parameters.AddWithValue("@p10", txthesaptürü.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bankalistele();
            bgl.baglanti().Close();

            MessageBox.Show("Banka Kaydı Başarıyla Gerçekleşmiştir", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilçe.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilçe.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilçe.Text = dr["ILCE"].ToString();
                txtşube.Text = dr["SUBE"].ToString();
                mskıban.Text = dr["IBAN"].ToString();
                mskhesapno.Text = dr["HESAPNO"].ToString();
                txtyetkili.Text = dr["YETKILI"].ToString();
                msktel1.Text = dr["TELEFON"].ToString();
                msktarih.Text = dr["TARIH"].ToString();
                txthesaptürü.Text = dr["HESAPTURU"].ToString();
               //lookUpEdit1.EditValue = dr["FIRMAID"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
           
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show(txtad.Text + "  " + "adlı bankayı" + " " + "silmeyi onaylıyor musunuz ?", "EMİN MİSİNİZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_BANKALAR where ID=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                bankalistele();
                MessageBox.Show("Banka Silme İşlemi Başarıyla Gerçekleşmiştir", "SİLME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (secim == DialogResult.No)
            {
                MessageBox.Show(" " + "Silme işlemi İptal Edilmiştir....", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bankalistele();
            bgl.baglanti().Close();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_BANKALAR set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 where ID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", cmbil.Text);
            komut.Parameters.AddWithValue("@p3", cmbilçe.Text);
            komut.Parameters.AddWithValue("@p4", txtşube.Text);
            komut.Parameters.AddWithValue("@p5", mskıban.Text);
            komut.Parameters.AddWithValue("@p6", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p8", msktel1.Text);
            komut.Parameters.AddWithValue("@p9", msktarih.Text);
            komut.Parameters.AddWithValue("@p10", txthesaptürü.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12", txtid.Text);
            komut.ExecuteNonQuery();
            bankalistele();
            bgl.baglanti().Close();
            
            MessageBox.Show("Banka Bilgileri Başarıyla Güncellendi", "GÜNCELLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
