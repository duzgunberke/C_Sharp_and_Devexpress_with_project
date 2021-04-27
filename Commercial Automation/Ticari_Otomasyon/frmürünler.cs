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
    public partial class frmürünler : Form
    {
        public frmürünler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            
        }
        private void frmürünler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //kayıt işlemi
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (urunad,marka,model,YIL,adet,ALISFIYAT,SATISFIYAT,detay) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", mskyıl.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nmradet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalış.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatış.Text));
            komut.Parameters.AddWithValue("@p8", rchdetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "EKLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = dr["ID"].ToString();
            txtad.Text = dr["URUNAD"].ToString();
            txtmarka.Text = dr["MARKA"].ToString();
            txtmodel.Text = dr["MODEL"].ToString();
            mskyıl.Text = dr["YIL"].ToString();
            nmradet.Value = int.Parse(dr["ADET"].ToString());
            txtalış.Text = dr["ALISFIYAT"].ToString();
            txtsatış.Text = dr["SATISFIYAT"].ToString();
            rchdetay.Text = dr["DETAY"].ToString();




        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update TBL_URUNLER set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 where ID=@P9", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", txtad.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", txtmarka.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", txtmodel.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", mskyıl.Text);
            komutgüncelle.Parameters.AddWithValue("@p5", int.Parse((nmradet.Value).ToString()));
            komutgüncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtalış.Text));
            komutgüncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtsatış.Text));
            komutgüncelle.Parameters.AddWithValue("@p8", rchdetay.Text);
            komutgüncelle.Parameters.AddWithValue("@p9", txtid.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
