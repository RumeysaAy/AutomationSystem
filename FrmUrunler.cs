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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()//FrmUrunler
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);//dataadpter in içini datatable ile doldur
            gridControl1.DataSource = dt;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listele();//form yüklendikten sonra listele metodu cagrildi
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Verileri Kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD, MARKA, KAPASITE, YIL, ADET, ALISFIYAT, SATISFIYAT, DETAY) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtKapasite.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery();//sorguyu calıstırır
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);//hata
                listele();
            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //imleç satırı değiştiği zaman ne olsun
            //datarow veri satırıdır. veri satırı sınıfından dr isimli bir nesne üretip bu dr komutuna gorev atanacak.
            //bu gorev gridview icerisinde getdatarow dedigimiz satırın verisini al dmektir
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//satır, gridviewdeki imlecle secilen satır
            Txtid.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            TxtKapasite.Text = dr["KAPASITE"].ToString();
            MskYil.Text = dr["YIL"].ToString();
            NudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            TxtAlis.Text = dr["ALISFIYAT"].ToString();
            TxtSatis.Text = dr["SATISFIYAT"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD = @P1, MARKA = @P2, KAPASITE = @P3, YIL = @P4, ADET = @P5, ALISFIYAT = @P6, SATISFIYAT = @P7, DETAY = @P8 where ID = @P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P3", TxtKapasite.Text);
            komut.Parameters.AddWithValue("@P4", MskYil.Text);
            komut.Parameters.AddWithValue("@P5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@P8", RchDetay.Text);
            komut.Parameters.AddWithValue("@P9", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);//uyarı: warning
            listele();
        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtAlis.Text = "";
            Txtid.Text = "";
            TxtMarka.Text = "";
            TxtKapasite.Text = "";
            TxtSatis.Text = "";
            MskYil.Text = "";
            RchDetay.Text = "";
            NudAdet.Value = 0;
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
