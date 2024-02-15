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

namespace Otomasyon_Sistemi
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            TxtMail.Text = mail;

        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("Mail","Sifre"); //gonderen kişinin mail adresi
            istemci.Port = 587;//turkiyenin port numarası
            istemci.Host = "smtp.live.com";//windows live kullanıldı. gmail içinde sunucu var
            istemci.EnableSsl = true;//yol boyunca şifrelesin
            mesaj.To.Add(TxtMail.Text);//kime gonderdiğimiz
            mesaj.From = new MailAddress("Mail","Sifre");//gonderen kişinin mail adresi
            mesaj.Subject = TxtKonu.Text;
            mesaj.Body = RchMesaj.Text;
            istemci.Send(mesaj);
        }
    }
}
