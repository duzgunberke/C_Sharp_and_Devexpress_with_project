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
    public partial class frmfaturaüründüzenleme : Form
    {
        public frmfaturaüründüzenleme()
        {
            InitializeComponent();
        }
        public string ürünid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            txtürünidd.Text = ürünid;
            SqlCommand komut = new SqlCommand("select * from TBL_FATURADETAY where FATURAURUNID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", ürünid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtfiyat.Text = dr[3].ToString();
                txtmiktar.Text = dr[2].ToString();
                txttutar.Text = dr[4].ToString();
                txtürünadı.Text = dr[1].ToString();

                bgl.baglanti().Close();
            }

        }
        private void frmfaturaüründüzenleme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4 WHERE FATURAURUNID=@P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtürünadı.Text);
            komut.Parameters.AddWithValue("@P2", txtmiktar.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtfiyat.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@P5", txtürünidd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişikler Fatura Alanında İşlenmiştir", "GÜNCELLEME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show(txtürünadı.Text  + " " + "Fatura Detaylarını" + "  " + "silmeyi onaylıyor musunuz_?", "EMİN MİSİNİZ ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {


                SqlCommand komut = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtürünidd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşmiştir", "SİLME BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Secim == DialogResult.No)
            {
                MessageBox.Show(" " + "Silme işlemi İptal Edilmiştir....", txtürünadı.Text  + " " + " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();

            listele();
        }
    }
}
