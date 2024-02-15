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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
            temizleme();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR = @P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (AD, SOYAD, TELEFON, TELEFON2, TC, MAIL, IL, ILCE, ADRES, VERGIDAIRE) values (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10)",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTel1.Text);
            komut.Parameters.AddWithValue("@P4", MskTel2.Text);
            komut.Parameters.AddWithValue("@P5", MskTC.Text);
            komut.Parameters.AddWithValue("@P6", TxtMail.Text);
            komut.Parameters.AddWithValue("@P7", Cmbil.Text);
            komut.Parameters.AddWithValue("@P8", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P9", RchAdres.Text);
            komut.Parameters.AddWithValue("@P10", TxtVergiD.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizleme();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTel1.Text = dr["TELEFON"].ToString();
                MskTel2.Text = dr["TELEFON2"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                TxtVergiD.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_MUSTERILER where ID = @p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();//insert, update, delete tablo üzerinde değişikliklik oldugunda calısır
                                        //executereader select sorgusunda calısır
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set AD=@P1, SOYAD=@P2, TELEFON=@P3, TELEFON2=@P4, TC=@P5, MAIL=@P6, IL=@P7, ILCE=@P8, VERGIDAIRE=@P9, ADRES=@P10 where ID=@P11", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTel1.Text);
            komut.Parameters.AddWithValue("@P4", MskTel2.Text);
            komut.Parameters.AddWithValue("@P5", MskTC.Text);
            komut.Parameters.AddWithValue("@P6", TxtMail.Text);
            komut.Parameters.AddWithValue("@P7", Cmbil.Text);
            komut.Parameters.AddWithValue("@P8", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P10", RchAdres.Text);
            komut.Parameters.AddWithValue("@P9", TxtVergiD.Text);
            komut.Parameters.AddWithValue("@P11", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
        void temizleme()
        {
            TxtAd.Text = "";
            Txtid.Text = "";
            TxtMail.Text = "";
            TxtSoyad.Text = "";
            TxtVergiD.Text = "";
            MskTC.Text = "";
            MskTel1.Text = "";
            MskTel2.Text = "";
            Cmbil.Text = "";
            CmbIlce.Text = "";
            RchAdres.Text = "";
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizleme();
        }
    }
}
