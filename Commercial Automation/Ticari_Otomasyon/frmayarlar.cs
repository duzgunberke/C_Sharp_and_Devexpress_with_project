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
    public partial class frmayarlar : Form
    {
        public frmayarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void kullanıcılistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_ADMIN", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmayarlar_Load(object sender, EventArgs e)
        {
            kullanıcılistele();
            txtkullanıcıad.Text = "";
            txtşifre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text == "GÜNCELLE")
            {
                SqlCommand komut2 = new SqlCommand("update TBL_ADMIN set SIFRE=@P2 WHERE KULLANICIAD=@P1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@P1", txtkullanıcıad.Text);
                komut2.Parameters.AddWithValue("@P2",txtşifre.Text );
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show( txtkullanıcıad.Text.ToUpper() + "--- AİT ŞİFRE GÜNCELLENDİ");
                kullanıcılistele();

            }
            else if (txtkullanıcıad.Text != "" || txtşifre.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_ADMIN values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkullanıcıad.Text);
                komut.Parameters.AddWithValue("@p2", txtşifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("YENİ ADMİN KAYDI BAŞARIYLA YAPILMIŞTIR", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullanıcılistele();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI YA DA ŞİFRE KISMINIZ BOŞ. LÜTFEN DOLDURUN");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtkullanıcıad.Text = dr["KULLANICIAD"].ToString();
                txtşifre.Text = dr["SIFRE"].ToString();
            }
        }

        private void txtkullanıcıad_TextChanged(object sender, EventArgs e)
        {
            if (txtkullanıcıad.Text != "")
            {
                button1.Text = "GÜNCELLE";
                button1.BackColor = Color.LightGreen;
            }
            else{
                button1.Text = "KAYDET";
                button1.BackColor = Color.LightGoldenrodYellow;
            }
        }
    }
}
