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
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBL_ADMIN where KULLANICIAD=@P1 AND SIFRE=@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtkullanıcıad.Text);
            komut.Parameters.AddWithValue("@P2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmmain fr = new frmmain();
                fr.kullanıcı = txtkullanıcıad.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI YA DA ŞİFRE !!!", "BAŞARAMADIK ABİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
