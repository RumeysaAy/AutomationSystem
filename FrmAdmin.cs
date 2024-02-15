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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ADMIN where KullaniciAd = @P1 and Sifre = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtKullanici.Text);
            komut.Parameters.AddWithValue("@P2", TxtParola.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul fr = new FrmAnaModul();
                //giris yapan kullanıcı(aktif kullanıcı)
                fr.kullanici = TxtKullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiUnuttum fr2 = new FrmSifremiUnuttum();
            fr2.Show();
            this.Hide();
        }
    }
}
