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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmStoklar_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select URUNAD, Sum(ADET) as 'MIKTAR' from TBL_URUNLER group by URUNAD", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            // Chart a stok miktarı listeleme
            SqlCommand komut = new SqlCommand("Select URUNAD, Sum(ADET) as 'MIKTAR' from TBL_URUNLER group by URUNAD", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())//dr komutu okuma işlemi yaptıgı sürece
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();

            //Chart da firma sehir sayısı gösterme
            SqlCommand komut2 = new SqlCommand("Select IL, Count(*) from TBL_FIRMALAR group by IL", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmStokDetay fr = new FrmStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//gridView1 de seçmiş oldugum satırın verisini al
            if (dr != null)
            {
                fr.ad = dr["URUNAD"].ToString();
            }
            fr.Show();
        }
    }
}
