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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER Order By ID Asc", bgl.baglanti());
            da.Fill(dt);//dataadapter daki degeri dt ile doldur
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            Txtid.Text = "";
            CmbAy.Text = "";
            CmbYil.Text = "";
            TxtElektrik.Text = "";
            TxtSu.Text = "";
            TxtDogalgaz.Text = "";
            TxtInternet.Text = "";
            TxtMaas.Text = "";
            TxtEkstra.Text = "";
            RchNot.Text = "";
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderlistesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY, YIL, ELEKTRIK, SU, DOGALGAZ, INTERNET, MAASLAR, EKSTRA, NOTLAR) values (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", CmbAy.Text);
            komut.Parameters.AddWithValue("@P2", CmbYil.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtInternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(TxtMaas.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@P9", RchNot.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider tabloya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                CmbAy.Text = dr["AY"].ToString();
                CmbYil.Text = dr["YIL"].ToString();
                TxtElektrik.Text = dr["ELEKTRIK"].ToString();
                TxtSu.Text = dr["SU"].ToString();
                TxtDogalgaz.Text = dr["DOGALGAZ"].ToString();
                TxtInternet.Text = dr["INTERNET"].ToString();
                TxtMaas.Text = dr["MAASLAR"].ToString();
                TxtEkstra.Text = dr["EKSTRA"].ToString();
                RchNot.Text = dr["NOTLAR"].ToString();
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
                SqlCommand komutsil = new SqlCommand("Delete from TBL_GIDERLER where ID=@P1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@P1", Txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                giderlistesi();
                MessageBox.Show("Gider Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("Update TBL_GIDERLER set AY=@P1, YIL=@P2, ELEKTRIK=@P3, SU=@P4, DOGALGAZ=@P5, INTERNET=@P6, MAASLAR=@P7, EKSTRA=@P8, NOTLAR=@P9 where ID = @P10",bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@P1", CmbAy.Text);
            komutGuncelle.Parameters.AddWithValue("@P2", CmbYil.Text);
            komutGuncelle.Parameters.AddWithValue("@P3", decimal.Parse(TxtElektrik.Text));
            komutGuncelle.Parameters.AddWithValue("@P4", decimal.Parse(TxtSu.Text));
            komutGuncelle.Parameters.AddWithValue("@P5", decimal.Parse(TxtDogalgaz.Text));
            komutGuncelle.Parameters.AddWithValue("@P6", decimal.Parse(TxtInternet.Text));
            komutGuncelle.Parameters.AddWithValue("@P7", decimal.Parse(TxtMaas.Text));
            komutGuncelle.Parameters.AddWithValue("@P8", decimal.Parse(TxtEkstra.Text));
            komutGuncelle.Parameters.AddWithValue("@P9", RchNot.Text);
            komutGuncelle.Parameters.AddWithValue("@P10", Txtid.Text);
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
            temizle();
        }
    }
}
