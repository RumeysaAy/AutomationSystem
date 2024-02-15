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

namespace Otomasyon_Sistemi
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBL_ADMIN where KullaniciAd='" + TxtKullaniciAd.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read() == true)
            {
                if (TxtMail.Text == dr["Mail"].ToString())
                {
                    bgl.baglanti().Close();
                    komut = new SqlCommand("update TBL_ADMIN set Sifre ='" + TxtYeniSifre.Text + "' where KullaniciAd='" + TxtKullaniciAd.Text + "'", bgl.baglanti());
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Şifreniz Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAnaModul fr = new FrmAnaModul();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
