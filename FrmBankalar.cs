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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgi", bgl.baglanti());
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

        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBL_FIRMALAR",bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;

        }

        void temizle()
        {
            TxtBankaAd.Text = "";
            TxtHesapNo.Text = "";
            TxtHesapTuru.Text = "";
            TxtIBAN.Text = "";
            Txtid.Text = "";
            TxtSube.Text = "";
            TxtYetkili.Text = "";
            MskTarih.Text = "";
            MskTel.Text = "";
            lookUpEdit1.Text = "";
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
            firmaListesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR (BANKAADI, IL, ILCE, SUBE, TELEFON, IBAN, HESAPNO, YETKILI, TARIH, HESAPTURU, FIRMAID) " +
                "values (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtBankaAd.Text);
            komut.Parameters.AddWithValue("@P2", Cmbil.Text);
            komut.Parameters.AddWithValue("@P3", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P4", TxtSube.Text);
            komut.Parameters.AddWithValue("@P5", MskTel.Text);
            komut.Parameters.AddWithValue("@P6", TxtIBAN.Text);
            komut.Parameters.AddWithValue("@P7", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@P8", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@P9", MskTarih.Text);
            komut.Parameters.AddWithValue("@P10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11", lookUpEdit1.EditValue);// düzenlenecek deger, ID alanı
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Sisteme Kaydedildi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtBankaAd.Text = dr["BANKAADI"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtSube.Text = dr["SUBE"].ToString();
                TxtIBAN.Text = dr["IBAN"].ToString();
                TxtHesapNo.Text = dr["HESAPNO"].ToString();
                TxtYetkili.Text = dr["YETKILI"].ToString();
                MskTel.Text = dr["TELEFON"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                TxtHesapTuru.Text = dr["HESAPTURU"].ToString();
                lookUpEdit1.Text = dr["FIRMAID"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_BANKALAR where ID=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                temizle();
                MessageBox.Show("Banka Bilgisi Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_BANKALAR set BANKAADI=@P1, IL=@P2, ILCE=@P3, SUBE=@P4, TELEFON=@P5, IBAN=@P6, HESAPNO=@P7, YETKILI=@P8, TARIH=@P9, HESAPTURU=@P10, FIRMAID=@P11 where ID=@P12",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtBankaAd.Text);
            komut.Parameters.AddWithValue("@P2", Cmbil.Text);
            komut.Parameters.AddWithValue("@P3", CmbIlce.Text);
            komut.Parameters.AddWithValue("@P4", TxtSube.Text);
            komut.Parameters.AddWithValue("@P5", MskTel.Text);
            komut.Parameters.AddWithValue("@P6", TxtIBAN.Text);
            komut.Parameters.AddWithValue("@P7", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@P8", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@P9", MskTarih.Text);
            komut.Parameters.AddWithValue("@P10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11", lookUpEdit1.EditValue);// düzenlenecek deger, ID alanı
            komut.Parameters.AddWithValue("@P12", Txtid.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
