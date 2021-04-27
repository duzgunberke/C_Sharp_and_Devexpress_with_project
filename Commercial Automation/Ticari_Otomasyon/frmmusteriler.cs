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
    public partial class frmmusteriler : Form
    {
        public frmmusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_MUSTERILER", bgl.baglanti());
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
        private void frmmusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (ad,soyad,telefon,telefon2,tc,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", msktel1.Text);
            komut.Parameters.AddWithValue("@P4", msktel2.Text);
            komut.Parameters.AddWithValue("@P5", msktc.Text);
            komut.Parameters.AddWithValue("@P6", txtmaıl.Text);
            komut.Parameters.AddWithValue("@P7", cmbil.Text);
            komut.Parameters.AddWithValue("@P8", cmbilçe.Text);
            komut.Parameters.AddWithValue("@P9", rchadres.Text);
            komut.Parameters.AddWithValue("@P10", txtvergidaire.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Müşteri Başarıyla Kaydedilmiştir", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsoyad.Text = dr["SOYAD"].ToString();
                msktel1.Text = dr["TELEFON"].ToString();
                msktel2.Text = dr["TELEFON2"].ToString();
                msktc.Text = dr["TC"].ToString();
                txtmaıl.Text = dr["MAIL"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilçe.Text = dr["ILCE"].ToString();
                rchadres.Text = dr["ADRES"].ToString();
                txtvergidaire.Text = dr["VERGIDAIRE"].ToString();
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show(txtad.Text + " " + txtsoyad.Text + " " + "müşterinizi" + "  " + "silmeyi onaylıyor musunuz_?", "EMİN MİSİNİZ ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {


                SqlCommand komut = new SqlCommand("delete from TBL_MUSTERILER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşmiştir", "SİLME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Secim == DialogResult.No)
            {
                MessageBox.Show(" " + "Silme işlemi İptal Edilmiştir....", txtad.Text + " " + txtsoyad.Text + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();

            listele();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set ad=@p1,soyad=@p2,telefon=@p3,telefon2=@p4,tc=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRE=@p10 where ID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", msktel1.Text);
            komut.Parameters.AddWithValue("@P4", msktel2.Text);
            komut.Parameters.AddWithValue("@P5", msktc.Text);
            komut.Parameters.AddWithValue("@P6", txtmaıl.Text);
            komut.Parameters.AddWithValue("@P7", cmbil.Text);
            komut.Parameters.AddWithValue("@P8", cmbilçe.Text);
            komut.Parameters.AddWithValue("@P9", rchadres.Text);
            komut.Parameters.AddWithValue("@P10", txtvergidaire.Text);
            komut.Parameters.AddWithValue("@P11", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Müşteri Bilgileri Başarıyla Güncellendi", "GÜNCELLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
