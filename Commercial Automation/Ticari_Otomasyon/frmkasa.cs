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
using DevExpress.Charts;
namespace Ticari_Otomasyon
{
    public partial class frmkasa : Form
    {
        public frmkasa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();


        void müşterilistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MUSTERIPROCEDURE", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void firmailistele()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("execute FIRMAPROCEDURE", bgl.baglanti());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
       
        void faturalistele()
        {
            DataTable dt99 = new DataTable();
            SqlDataAdapter da99 = new SqlDataAdapter("SELECT * FROM TBL_GIDERLER", bgl.baglanti());
            
            
            da99.Fill(dt99);
            gridControl2.DataSource = dt99;
        }
        public string ad;
        private void frmkasa_Load(object sender, EventArgs e)
        {

            lblaktifkullanıcı.Text = ad;
            müşterilistele();
            firmailistele();
            faturalistele();

            // Toplam tutarı hesaplama
            SqlCommand komut1 = new SqlCommand("select sum(tutar) from TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader da1 = komut1.ExecuteReader();
            while (da1.Read())
            {
                lbltoplamtutar.Text = da1[0].ToString() + " TL";

            }
            bgl.baglanti().Close();

            //sson ayın faturaları
            SqlCommand komut2 = new SqlCommand("SELECT (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) FROM TBL_GIDERLER ORDER BY ID ASC ", bgl.baglanti());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                lblödemeler.Text = dr1[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //son ayın personel maaşları
            SqlCommand komut3 = new SqlCommand("SELECT MAASLAR FROM TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                lblpersonelmaaşları.Text = dr2[0].ToString() + " TL";

            }
            bgl.baglanti().Close();

            //toplam müşteri sayısı
            SqlCommand komut4 = new SqlCommand("SELECT COUNT(*) FROM TBL_MUSTERILER ", bgl.baglanti());
            SqlDataReader dr3 = komut4.ExecuteReader();
            while (dr3.Read())
            {
                lblmüşterisayısı.Text = dr3[0].ToString();

            }
            bgl.baglanti().Close();

            //firma sayısı
            SqlCommand komut5 = new SqlCommand("SELECT count(*) FROM TBL_FIRMALAR ", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblfirmasayısı.Text = dr5[0].ToString();

            }
            bgl.baglanti().Close();

            //toplam şehir sayısı
            SqlCommand komut6 = new SqlCommand("SELECT COUNT (distinct(IL)) FROM TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblşehirsayısı.Text = dr6[0].ToString();

            }
            bgl.baglanti().Close();

            //FİRMAŞEHİR SAYISI
            SqlCommand komut7 = new SqlCommand("SELECT COUNT (distinct(IL)) FROM TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                label3.Text = dr7[0].ToString();

            }
            bgl.baglanti().Close();

            //PERSONEL SAYISI
            SqlCommand komut8 = new SqlCommand("SELECT COUNT(*) from TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblpersonelsayısı.Text = dr8[0].ToString();

            }
            bgl.baglanti().Close();

            //TOPLAM ÜÜRN SAYISI

            SqlCommand komut9 = new SqlCommand("SELECT sum(ADET) FROM TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lblstoksayısı.Text = dr9[0].ToString();

            }
            bgl.baglanti().Close();

            //AKTİF KULLANICI SAYISI




        }
        int sayaç;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayaç++;
            //ELEKTRIK
            if (sayaç > 0 && sayaç <= 4)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl10.Text = "ELEKTRIK";
                SqlCommand komut10 = new SqlCommand("select top 12 ay,ELEKTRIK FROM TBL_GIDERLER ", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));

                }
                bgl.baglanti().Close();
            }
            //SU
            if (sayaç > 4 && sayaç <= 9)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl10.Text = "SU";
                SqlCommand komut11 = new SqlCommand("select top 12 ay,SU FROM TBL_GIDERLER ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                bgl.baglanti().Close();
            }
            //DOĞALGAZ
            if (sayaç > 9 && sayaç <= 14)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl10.Text = "DOĞALGAZ";
                SqlCommand komut11 = new SqlCommand("select top 12 ay,DOGALGAZ FROM TBL_GIDERLER ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                bgl.baglanti().Close();

            }
            //İNTERNET
            if (sayaç > 14 && sayaç <= 18)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl10.Text = "İNTERNET";
                SqlCommand komut11 = new SqlCommand("select top 12 ay,INTERNET FROM TBL_GIDERLER ", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));

                }
                bgl.baglanti().Close();

            }
            //RESTART
            if (sayaç == 19)
            {
                sayaç = 0;
            }
        }
        int sayaç2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayaç2++;

            //DOĞALGAZ
            if (sayaç2 > 0 && sayaç2 <= 2)
            {
                chartControl2.Series["Aylar"].Points.Clear();

                groupControl11.Text = "DOĞALGAZ";
                SqlCommand komut12 = new SqlCommand("select top 12 ay,DOGALGAZ FROM TBL_GIDERLER ", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));

                }
                bgl.baglanti().Close();

            }
            //SU
            if (sayaç2 > 2 && sayaç2 <= 4)
            {
                chartControl2.Series["Aylar"].Points.Clear();

                groupControl11.Text = "SU";
                SqlCommand komut12 = new SqlCommand("select top 12 ay,SU FROM TBL_GIDERLER ", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));

                }
                bgl.baglanti().Close();
            }
            //ELEKTRIK
            if (sayaç2 > 4 && sayaç2 <= 6)
            {
                chartControl2.Series["Aylar"].Points.Clear();

                groupControl11.Text = "ELEKTRIK";
                SqlCommand komut12 = new SqlCommand("select top 12 ay,ELEKTRIK FROM TBL_GIDERLER ", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));

                }
                bgl.baglanti().Close();
            }
           
           
            //İNTERNET
            if (sayaç2 > 6 && sayaç2 <= 8)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl11.Text = "İNTERNET";
                SqlCommand komut12 = new SqlCommand("select top 12 ay,INTERNET FROM TBL_GIDERLER ", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));

                }
                bgl.baglanti().Close();

            }
            
            //RESTART
            if (sayaç2 == 9)
            {
                sayaç2 = 0;
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
