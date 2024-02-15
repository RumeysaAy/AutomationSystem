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
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

        }

        public string urunid; //urunid=Txtid
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            TxtUrunID.Text = urunid;
            SqlCommand komut = new SqlCommand("Select * From TBL_FATURADETAY where FATURAURUNID =@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtFiyat.Text = dr[3].ToString();//TBL_FATURADETAY daki 3. indeksdeki sutün FIYAT
                TxtMiktar.Text = dr[2].ToString();
                TxtTutar.Text = dr[4].ToString();
                TxtUrunAdi.Text = dr[1].ToString();
                bgl.baglanti().Close();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY set URUNAD=@P1, MIKTAR=@P2, FIYAT=@P3, TUTAR=@P4 where FATURAURUNID = @P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunAdi.Text);
            komut.Parameters.AddWithValue("@P2", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtFiyat.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@P5", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_FATURADETAY where FATURAURUNID = @P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtUrunID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
