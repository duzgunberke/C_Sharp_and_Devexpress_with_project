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
    public partial class frmrehber : Form
    {
        public frmrehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void musterilistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD,SOYAD,TELEFON,TELEFON2,MAIL from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void firmalistele()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from TBL_FIRMALAR", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }
        private void frmrehber_Load(object sender, EventArgs e)
        {
            musterilistele();
            firmalistele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmmail fr = new frmmail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.mail = dr["MAIL"].ToString();

            }
            fr.Show();
        }
     

        private void gridView2_DoubleClick_1(object sender, EventArgs e)
        {
            frmmail fr = new frmmail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                fr.mail = dr["MAIL"].ToString();

            }
            fr.Show();
        }
    }
}
