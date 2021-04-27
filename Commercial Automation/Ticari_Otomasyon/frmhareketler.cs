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
    public partial class frmhareketler : Form
    {
        public frmhareketler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void firmahareketlerilistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec FIRMAPROCEDURE", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        void müsteriareketlerilistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec MUSTERIPROCEDURE", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void frmhareketler_Load(object sender, EventArgs e)
        {
            firmahareketlerilistele();
            müsteriareketlerilistele();
        }
    }
}
