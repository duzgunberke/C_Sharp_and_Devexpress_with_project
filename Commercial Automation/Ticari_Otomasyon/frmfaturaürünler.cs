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
    public partial class frmfaturaürünler : Form
    {
        public frmfaturaürünler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * FROM TBL_FATURADETAY where FATURAID='"+id+"'",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public string id;
        private void frmfaturaürünler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            frmfaturaüründüzenleme fr = new frmfaturaüründüzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.ürünid = dr["FATURAURUNID"].ToString();
            }
            fr.Show();
        }
    }
}
