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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void personelListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            Txtid.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTel.Text = "";
            MskTC.Text = "";
            TxtMail.Text = "";
            Cmbil.Text = "";
            CmbIlce.Text = "";
            RchAdres.Text = "";
            TxtGorev.Text = "";
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personelListe();
            sehirListesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER(AD, SOYAD, TELEFON, TC, MAIL, IL, ILCE, ADRES, GOREV) values (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTel.Text);
            komut.Parameters.AddWithValue("@P4", MskTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtMail.Text);
            komut.Parameters.AddWithValue("@P6", Cmbil.Text);
            komut.Parameters.AddWithValue("@P7", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P8", RchAdres.Text);
            komut.Parameters.AddWithValue("@P9", TxtGorev.Text);
            komut.ExecuteNonQuery();//komutu gerceklestirmesi icin
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListe();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR = @P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//DataRow dan dr isimli komut üretip gridView den secilen satırın verilerini alacagız
            if(dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTel.Text = dr["TELEFON"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                TxtGorev.Text = dr["GOREV"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_PERSONELLER where ID=@P1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@P1", Txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                personelListe();
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER set AD=@P1, SOYAD=@P2, TELEFON=@P3, TC=@P4, MAIL=@P5, IL=@P6, ILCE=@P7, ADRES=@P8, GOREV=@P9 where ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTel.Text);
            komut.Parameters.AddWithValue("@P4", MskTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtMail.Text);
            komut.Parameters.AddWithValue("@P6", Cmbil.Text);
            komut.Parameters.AddWithValue("@P7", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P8", RchAdres.Text);
            komut.Parameters.AddWithValue("@P9", TxtGorev.Text);
            komut.Parameters.AddWithValue("@P10", Txtid.Text);
            komut.ExecuteNonQuery();//komutu gerceklestirmesi icin
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListe();
        }
    }
}
