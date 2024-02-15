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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void firmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtAd.Text = "";
            Txtid.Text = "";
            TxtMail.Text = "";
            TxtSektor.Text = "";
            TxtVergiD.Text = "";
            TxtYetkili.Text = "";
            TxtYGorev.Text = "";
            MskFax.Text = "";
            MskTel1.Text = "";
            MskTel2.Text = "";
            MskTel3.Text = "";
            MskYTC.Text = "";
            RchAdres.Text = "";
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

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmaListesi();
            temizle();
            sehirListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtYGorev.Text = dr["YETKILISTATU"].ToString();
                TxtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                MskYTC.Text = dr["YETKILITC"].ToString();
                TxtSektor.Text = dr["SEKTOR"].ToString();
                MskTel1.Text = dr["TELEFON1"].ToString();
                MskTel2.Text = dr["TELEFON2"].ToString();
                MskTel3.Text = dr["TELEFON3"].ToString();
                MskFax.Text = dr["FAX"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtVergiD.Text = dr["VERGIDAIRE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
            }

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR(AD, YETKILISTATU, YETKILIADSOYAD, YETKILITC, SEKTOR, TELEFON1, TELEFON2, TELEFON3, MAIL, FAX, IL, ILCE, VERGIDAIRE, ADRES) values (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12, @P13, @P14)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtYGorev.Text);
            komut.Parameters.AddWithValue("@P3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@P4", MskYTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@P6", MskTel1.Text);
            komut.Parameters.AddWithValue("@P7", MskTel2.Text);
            komut.Parameters.AddWithValue("@P8", MskTel3.Text);
            komut.Parameters.AddWithValue("@P9", TxtMail.Text);
            komut.Parameters.AddWithValue("@P10", MskFax.Text);
            komut.Parameters.AddWithValue("@P11", Cmbil.Text);
            komut.Parameters.AddWithValue("@P12", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", TxtVergiD.Text);
            komut.Parameters.AddWithValue("@P14", RchAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_FIRMALAR where ID=@P1",bgl.baglanti());
                komut.Parameters.AddWithValue("@P1",Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                firmaListesi();
                MessageBox.Show("Firma listeden silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                temizle();
            }
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

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FIRMALAR set AD=@P1, YETKILISTATU=@P2, YETKILIADSOYAD=@P3, YETKILITC=@P4, SEKTOR=@P5, TELEFON1=@P6, TELEFON2=@P7, TELEFON3=@P8, MAIL=@P9, FAX=@P10, IL=@P11, ILCE=@P12, VERGIDAIRE=@P13, ADRES=@P14 where ID=@P18", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtYGorev.Text);
            komut.Parameters.AddWithValue("@P3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@P4", MskYTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@P6", MskTel1.Text);
            komut.Parameters.AddWithValue("@P7", MskTel2.Text);
            komut.Parameters.AddWithValue("@P8", MskTel3.Text);
            komut.Parameters.AddWithValue("@P9", TxtMail.Text);
            komut.Parameters.AddWithValue("@P10", MskFax.Text);
            komut.Parameters.AddWithValue("@P11", Cmbil.Text);
            komut.Parameters.AddWithValue("@P12", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", TxtVergiD.Text);
            komut.Parameters.AddWithValue("@P14", RchAdres.Text);
            komut.Parameters.AddWithValue("@P18", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
