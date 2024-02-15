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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_ADMIN", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            TxtKullaniciAdi.Text = "";
            TxtParola.Text = "";
            TxtMail.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
                SqlCommand komut = new SqlCommand("insert into TBL_ADMIN values (@P1, @P2, @P3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@P2", TxtParola.Text);
                komut.Parameters.AddWithValue("@P3", TxtMail.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele(); 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                TxtKullaniciAdi.Text = dr["KullaniciAd"].ToString();
                TxtParola.Text = dr["Sifre"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
            }
        }

        private void TxtKullaniciAdi_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text != "")
            {
                //BtnKaydet.Text = "Güncelle";
            }
            else
            {
                //BtnKaydet.Text = "Kaydet";
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update TBL_ADMIN set Sifre = @P2, Mail = @P3 where KullaniciAd = @P1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@P1", TxtKullaniciAdi.Text);
            komut2.Parameters.AddWithValue("@P2", TxtParola.Text);
            komut2.Parameters.AddWithValue("@P3", TxtMail.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Parola Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
