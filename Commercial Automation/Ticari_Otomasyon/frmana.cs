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
    public partial class frmana : Form
    {
        public frmana()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void azalanstok()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT URUNAD,SUM(ADET) AS 'ADET' FROM TBL_URUNLER GROUP BY URUNAD having Sum(adet)<=20 order by sum(adet)", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void ajanda()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT TOP 10 TARIH,SAAT,BASLIK FROM TBL_NOTLAR ORDER BY ID DESC", bgl.baglanti());
            da2.Fill(dt2);
            gridControl4.DataSource = dt2;

        }
        void firmahareketlerilistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec firmahareket2", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        void fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ad,telefon1 from TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void frmana_Load(object sender, EventArgs e)
        {
            azalanstok();
            ajanda();
            firmahareketlerilistele();
            fihrist();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
            webBrowser2.Navigate("https://www.instagram.com/");
            webBrowser3.Navigate("https://www.youtube.com/");
        }
    }
}
