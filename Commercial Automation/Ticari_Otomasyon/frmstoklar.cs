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
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmstoklar_Load(object sender, EventArgs e)
        {
                   

            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,SUM(ADET) as 'MIKTAR' FROM TBL_URUNLER GROUP BY URUNAD", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //charta veri listeleme

            SqlCommand komut = new SqlCommand("select URUNAD,SUM(ADET) as 'Miktar' FROM TBL_URUNLER GROUP BY URUNAD", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();

            //charta fırma verısı lısteleme

            /*SqlCommand komut2 = new SqlCommand("select IL,COUNT(*) FROM TBL_FIRMALAR GROUP BY IL ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();*/

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmstokdetay fr = new frmstokdetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.ad = dr["URUNAD"].ToString();
                fr.Show();
            }
        }
    }
}
