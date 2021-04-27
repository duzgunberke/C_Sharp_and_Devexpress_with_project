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
    public partial class frmnotlar : Form
    {
        public frmnotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void frmnotlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", msktarih.Text);
            komut.Parameters.AddWithValue("@P2", msksaat.Text);
            komut.Parameters.AddWithValue("@P3", txtbaşlık.Text);
            komut.Parameters.AddWithValue("@P4", rchdetay.Text);
            komut.Parameters.AddWithValue("@P5", txtoluşturan.Text);
            komut.Parameters.AddWithValue("@P6", txthitap.Text);
            komut.ExecuteNonQuery();
            
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Oluşturma İşlemi Başarıyla Gerçekleşmiştir", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,OLUSTURAN=@P5,HITAP=@P6 where ID=@P7", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", msktarih.Text);
            komut.Parameters.AddWithValue("@P2", msksaat.Text);
            komut.Parameters.AddWithValue("@P3", txtbaşlık.Text);
            komut.Parameters.AddWithValue("@P4", rchdetay.Text);
            komut.Parameters.AddWithValue("@P5", txtoluşturan.Text);
            komut.Parameters.AddWithValue("@P6", txthitap.Text);
            komut.Parameters.AddWithValue("@P7", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Güncelleme İşlemi Başarıyla Gerçekleşmiştir", "GÜNCELLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                msktarih.Text = dr["TARIH"].ToString();
                msksaat.Text = dr["SAAT"].ToString();
                txtbaşlık.Text = dr["BASLIK"].ToString();
                rchdetay.Text = dr["DETAY"].ToString();
                txtoluşturan.Text = dr["OLUSTURAN"].ToString();
                txthitap.Text = dr["HITAP"].ToString();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            msktarih.Text = "";
            msksaat.Text = "";
            txtbaşlık.Text = "";
            rchdetay.Text = "";
            txtoluşturan.Text = "";
            txthitap.Text = "";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show(txtbaşlık.Text + "  " + "Başlıklı Notu" + " " + "silmeyi onaylıyor musunuz ?", "EMİN MİSİNİZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_NOTLAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Not Silme İşlemi Başarıyla Gerçekleşmiştir", "SİLME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (secim == DialogResult.No)
            {
                MessageBox.Show(" " + "Silme işlemi İptal Edilmiştir....", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listele();
            bgl.baglanti().Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmnotdetay fr = new frmnotdetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.metin = dr["DETAY"].ToString();
                
            }
            fr.Show();
        }
    }
}
