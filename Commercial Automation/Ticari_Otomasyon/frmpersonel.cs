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
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_PERSONELLER", bgl.baglanti());
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
        void temizle()
        {
            txtid.Text = " ";
            txtad.Text = " ";
            msktc.Text = " ";
            txtsoyad.Text = " ";
            msktel1.Text = " ";
            
            txtmaıl.Text = " ";
            
            cmbil.Text = " ";
            cmbilçe.Text = " ";
            txtgörev.Text = " ";
            rchadres.Text = " ";
            
            txtad.Focus();
        }
        private void frmpersonel_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            temizle();
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
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER (ad,soyad,telefon,tc,MAIL,IL,ILCE,ADRES,GOREV) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", msktel1.Text);
           
            komut.Parameters.AddWithValue("@P4", msktc.Text);
            komut.Parameters.AddWithValue("@P5", txtmaıl.Text);
            komut.Parameters.AddWithValue("@P6", cmbil.Text);
            komut.Parameters.AddWithValue("@P7", cmbilçe.Text);
            komut.Parameters.AddWithValue("@P8", rchadres.Text);
            komut.Parameters.AddWithValue("@P9", txtgörev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Personel Başarıyla Kaydedilmiştir", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
               
                msktc.Text = dr["TC"].ToString();
                txtmaıl.Text = dr["MAIL"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilçe.Text = dr["ILCE"].ToString();
                rchadres.Text = dr["ADRES"].ToString();
                txtgörev.Text = dr["GOREV"].ToString();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show(txtad.Text + " " + txtsoyad.Text + " " + "personelinizi" + "  " + "silmeyi onaylıyor musunuz_?", "EMİN MİSİNİZ ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {


                SqlCommand komut = new SqlCommand("delete from TBL_PERSONELLER where ID=@p1", bgl.baglanti());
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
            SqlCommand komut = new SqlCommand("update TBL_PERSONELLER set ad=@p1,soyad=@p2,telefon=@p3,tc=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GOREV=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", msktel1.Text);
          
            komut.Parameters.AddWithValue("@P4", msktc.Text);
            komut.Parameters.AddWithValue("@P5", txtmaıl.Text);
            komut.Parameters.AddWithValue("@P6", cmbil.Text);
            komut.Parameters.AddWithValue("@P7", cmbilçe.Text);
            komut.Parameters.AddWithValue("@P8", rchadres.Text);
            komut.Parameters.AddWithValue("@P9", txtgörev.Text);
            komut.Parameters.AddWithValue("@P10", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Personel Bilgileri Başarıyla Güncellendi", "GÜNCELLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
