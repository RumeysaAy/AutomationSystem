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
using DevExpress.Charts;

namespace Otomasyon_Sistemi
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void musteriHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void firmaHareket()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute FirmaHareketler", bgl.baglanti());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
        
        void giderlistesi()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from TBL_GIDERLER Order By ID Asc", bgl.baglanti());
            da3.Fill(dt3);//dataadapter daki degeri dt ile doldur
            gridControl2.DataSource = dt3;
        }

        public string ad;
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            LblAktifKullanici.Text = ad;

            giderlistesi();
            musteriHareket();
            firmaHareket();

            //Toplam Tutarı Hesaplama
            SqlCommand komut1 = new SqlCommand("Select Sum(TUTAR) from TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKasaToplam.Text = dr1[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //son ayın faturaları
            SqlCommand komut2 = new SqlCommand("Select (ELEKTRIK + SU + DOGALGAZ + INTERNET + EKSTRA) from TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblOdemeler.Text = dr2[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //son ayın personel maasları toplamı
            SqlCommand komut3 = new SqlCommand("Select MAASLAR from TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblPersonelMaasi.Text = dr3[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //Toplam musteri sayısı
            //musteriler tablosundaki bütün degerleri say
            SqlCommand komut4 = new SqlCommand("Select Count(*) From TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblMusteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            //toplam firma sayısı
            SqlCommand komut5 = new SqlCommand("Select Count(*) From TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblFirmaSayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            //firma toplam sehir sayısı
            //sehirleri tekrarsız olarak say-> distinct
            SqlCommand komut6 = new SqlCommand("Select Count(Distinct(IL)) From TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblFSehirSayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            //musteri toplam sehir sayısı(4 farklı sehirden musteriler var)
            SqlCommand komut7 = new SqlCommand("Select Count(Distinct(IL)) From TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblMSehirSayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            //toplam personel sayısı
            SqlCommand komut8 = new SqlCommand("Select Count(*) From TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                LblPersonelSayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

            //stok sayısı(toplam urun sayısı)
            SqlCommand komut9 = new SqlCommand("Select Sum(ADET) from TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                LblStokSayisi.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
            //Elektrik
            if(sayac>0 && sayac <= 5)
            {
                groupControl1.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("Select top 4 AY, ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }

            //Su
            if(sayac>5 && sayac <= 10)
            {
                groupControl1.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("Select top 4 AY, SU from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //Dogalgaz
            if (sayac > 10 && sayac <= 15)
            {
                groupControl1.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("Select top 4 AY, DOGALGAZ from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }

            //internet
            if (sayac > 15 && sayac <= 20)
            {
                groupControl1.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("Select top 4 AY, INTERNET from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }

            //ekstra
            if (sayac > 20 && sayac <= 25)
            {
                groupControl1.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("Select top 4 AY, EKSTRA from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }

            if(sayac == 26)
            {
                sayac = 0;
            }
        }

        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;

            //Elektrik
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl2.Text = "Elektrik";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("Select top 4 AY, ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }

            //Su
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl2.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("Select top 4 AY, SU from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //Dogalgaz
            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl2.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("Select top 4 AY, DOGALGAZ from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }

            //internet
            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl2.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("Select top 4 AY, INTERNET from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }

            //ekstra
            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl2.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("Select top 4 AY, EKSTRA from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }

            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
}
