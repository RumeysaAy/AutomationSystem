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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            TxtAlici.Text = "";
            TxtTeslimAlan.Text = "";
            TxtTeslimEden.Text = "";
            TxtVergiD.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";
            TxtSiraNo.Text = "";
            TxtSeri.Text = "";
            Txtid.Text = "";
        }

        void personelListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, AD, SOYAD from TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            LuePersonel.Properties.ValueMember = "ID";
            LuePersonel.Properties.DisplayMember = "AD";
            LuePersonel.Properties.DataSource = dt;
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            personelListesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(TxtFaturaID.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI(SERI, SIRANO, TARIH, SAAT, VERGIDAIRE, ALICI, TESLIMEDEN, TESLIMALAN) values (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtSeri.Text);
                komut.Parameters.AddWithValue("@P2", TxtSiraNo.Text);
                komut.Parameters.AddWithValue("@P3", MskTarih.Text);
                komut.Parameters.AddWithValue("@P4", MskSaat.Text);
                komut.Parameters.AddWithValue("@P5", TxtVergiD.Text);
                komut.Parameters.AddWithValue("@P6", TxtAlici.Text);
                komut.Parameters.AddWithValue("@P7", TxtTeslimEden.Text);
                komut.Parameters.AddWithValue("@P8", TxtTeslimAlan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            
            //Firma Cari ise
            if(TxtFaturaID.Text != "" && comboBox1.Text == "Firma")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD, MIKTAR, FIYAT, TUTAR, FATURAID) values (@P1, @P2, @P3, @P4, @P5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@P1",TxtUrunAdi.Text);
                komut2.Parameters.AddWithValue("@P2", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@P3", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@P4", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@P5", TxtFaturaID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Hareket Tablosuna Veri Girişi
                SqlCommand komut3 = new SqlCommand("insert into TBL_FIRMAHAREKETLER (URUNID, ADET, PERSONEL, FIRMA, FIYAT, TOPLAM, FATURAID, TARIH) values (@F1, @F2, @F3, @F4, @F5, @F6, @F7, @F8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@F1", TxtUrunID.Text);
                komut3.Parameters.AddWithValue("@F2", TxtMiktar.Text);
                komut3.Parameters.AddWithValue("@F3", LuePersonel.EditValue);
                komut3.Parameters.AddWithValue("@F4", Txt.Text);
                komut3.Parameters.AddWithValue("@F5", decimal.Parse(TxtFiyat.Text));
                komut3.Parameters.AddWithValue("@F6", decimal.Parse(TxtTutar.Text));
                komut3.Parameters.AddWithValue("@F7", TxtFaturaID.Text);
                komut3.Parameters.AddWithValue("@F8", MskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //stok sayısını azaltma
                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER set ADET=ADET-@H1 where ID=@H2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@H1", TxtMiktar.Text);
                komut4.Parameters.AddWithValue("@H2", TxtUrunID.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Faturaya Ait Ürün Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Cari Müşteri ise
            if (TxtFaturaID.Text != "" && comboBox1.Text == "Müşteri")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD, MIKTAR, FIYAT, TUTAR, FATURAID) values (@P1, @P2, @P3, @P4, @P5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@P1", TxtUrunAdi.Text);
                komut2.Parameters.AddWithValue("@P2", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@P3", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@P4", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@P5", TxtFaturaID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Hareket Tablosuna Veri Girişi
                SqlCommand komut3 = new SqlCommand("insert into TBL_MUSTERIHAREKETLER (URUNID, ADET, PERSONEL, MUSTERI, FIYAT, TOPLAM, FATURAID, TARIH) values (@F1, @F2, @F3, @F4, @F5, @F6, @F7, @F8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@F1", TxtUrunID.Text);
                komut3.Parameters.AddWithValue("@F2", TxtMiktar.Text);
                komut3.Parameters.AddWithValue("@F3", LuePersonel.EditValue);
                komut3.Parameters.AddWithValue("@F4", Txt.Text);
                komut3.Parameters.AddWithValue("@F5", decimal.Parse(TxtFiyat.Text));
                komut3.Parameters.AddWithValue("@F6", decimal.Parse(TxtTutar.Text));
                komut3.Parameters.AddWithValue("@F7", TxtFaturaID.Text);
                komut3.Parameters.AddWithValue("@F8", MskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //stok sayısını azaltma
                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER set ADET=ADET-@H1 where ID=@H2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@H1", TxtMiktar.Text);
                komut4.Parameters.AddWithValue("@H2", TxtUrunID.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Faturaya Ait Ürün Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Fare imleci degistiginde ne olsun
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                Txtid.Text = dr["FATURABILGIID"].ToString();
                TxtSeri.Text = dr["SERI"].ToString();
                TxtSiraNo.Text = dr["SIRANO"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtVergiD.Text = dr["VERGIDAIRE"].ToString();
                TxtAlici.Text = dr["ALICI"].ToString();
                TxtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
                TxtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
            }
        }

        

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_FATURABILGI where FATURABILGIID = @P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Silindi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURABILGI set SERI=@P1, SIRANO=@P2, TARIH=@P3, SAAT=@P4, VERGIDAIRE=@P5, ALICI=@P6, TESLIMEDEN=@P7, TESLIMALAN=@P8 where FATURABILGIID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtSeri.Text);
            komut.Parameters.AddWithValue("@P2", TxtSiraNo.Text);
            komut.Parameters.AddWithValue("@P3", MskTarih.Text);
            komut.Parameters.AddWithValue("@P4", MskSaat.Text);
            komut.Parameters.AddWithValue("@P5", TxtVergiD.Text);
            komut.Parameters.AddWithValue("@P6", TxtAlici.Text);
            komut.Parameters.AddWithValue("@P7", TxtTeslimEden.Text);
            komut.Parameters.AddWithValue("@P8", TxtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@P9", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay fr = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//gridView1 de seçmiş oldugum satırın verisini al
            if( dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select URUNAD, SATISFIYAT from TBL_URUNLER where ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunID.Text);//p1 e deger atandı
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunAdi.Text = dr[0].ToString();
                TxtFiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
