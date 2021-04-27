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
    public partial class frmgiderler : Form
    {
        public frmgiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmgiderler_Load(object sender, EventArgs e)
        {
            giderlistesi();
            boşkalmasın();
        }
        void boşkalmasın()
        {
            txtelektrik.Text = "0";
            txtdoğalgaz.Text = "0";
            txtsu.Text = "0";
            txtextrlar.Text = "0";
            txtmaaşlar.Text = "0";
            txtinternet.Text = "0";
        }

        void temizle()
        {
            txtdoğalgaz.Text = "";
            txtelektrik.Text = "";
            txtextrlar.Text = "";
            txtid.Text = "";
            txtinternet.Text = "";
            txtmaaşlar.Text = "";
            txtsu.Text = "";
            cmbay.Text = "";
            cmbyıl.Text = "";
            rchnotlar.Text = "";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", cmbay.Text);
            komut.Parameters.AddWithValue("@P2", cmbyıl.Text);
            komut.Parameters.AddWithValue("@P3",decimal.Parse( txtelektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtsu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(txtdoğalgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(txtinternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(txtmaaşlar.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(txtextrlar.Text));
            komut.Parameters.AddWithValue("@P9", rchnotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderlistesi();
            MessageBox.Show("Gider Kaydı Başarıyla Alınmıştır", "KAYIT EDİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtelektrik.Text = dr["ELEKTRIK"].ToString();
                txtsu.Text = dr["SU"].ToString();
                txtmaaşlar.Text = dr["MAASLAR"].ToString();
                txtinternet.Text = dr["INTERNET"].ToString();
                txtextrlar.Text = dr["EKSTRA"].ToString();
                txtdoğalgaz.Text = dr["DOGALGAZ"].ToString();
                cmbay.Text = dr["AY"].ToString();
                cmbyıl.Text = dr["YIL"].ToString();
                rchnotlar.Text = dr["NOTLAR"].ToString();




            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show(cmbay.Text + " " + cmbyıl.Text + " " + "Tarihli Gideri" + "  " + "silmeyi onaylıyor musunuz_?", "EMİN MİSİNİZ ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {


                SqlCommand komut = new SqlCommand("delete from TBL_GIDERLER where ID=@p10", bgl.baglanti());
                komut.Parameters.AddWithValue("@p10", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                giderlistesi();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşmiştir", "SİLME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Secim == DialogResult.No)
            {
                MessageBox.Show(" " + "Silme işlemi İptal Edilmiştir....",   " " , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();

            giderlistesi(); 
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_GIDERLER set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", cmbay.Text);
            komut.Parameters.AddWithValue("@P2", cmbyıl.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtelektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtsu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(txtdoğalgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(txtinternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(txtmaaşlar.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(txtextrlar.Text));
            komut.Parameters.AddWithValue("@P9", rchnotlar.Text);
            komut.Parameters.AddWithValue("@P10", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderlistesi();
            MessageBox.Show("Gider Bilgileri Başarıyla Güncellendi", "GÜNCELLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
