using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon
{
    public partial class frmmail : Form
    {
        public frmmail()
        {
            InitializeComponent();
        }
        public string mail;

        private void frmmail_Load(object sender, EventArgs e)
        {
            txtmaıladresi.Text = mail;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("","");//credential kimlik anlamına geliyor. bu bölüm maıl gonderenın kendıne gore doldurması gerekn maıl adresı ve sıfresı
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(txtmaıladresi.Text);
            mesaj.From = new MailAddress("Mail");
            mesaj.Subject = txtkonu.Text;
            mesaj.Body = rchmsj.Text;
            istemci.Send(mesaj);
        }
    }
}
