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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (TARIH, SAAT, BASLIK, DETAY, OLUSTURAN, HITAP)  values (@P1, @P2, @P3, @P4, @P5, @P6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", MskTarih.Text);
            komut.Parameters.AddWithValue("@P2", MskSaat.Text);
            komut.Parameters.AddWithValue("@P3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4", RchDetay.Text);
            komut.Parameters.AddWithValue("@P5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@P6", TxtHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_NOTLAR where ID = @P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", Txtid.Text);//parametreye Txtid den gelen degeri atadık
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not Sistemden Silindi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if ( dr != null)//dr bos bir satır değilse
            {
                Txtid.Text = dr["ID"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtBaslik.Text = dr["BASLIK"].ToString();
                RchDetay.Text = dr["DETAY"].ToString();
                TxtOlusturan.Text = dr["OLUSTURAN"].ToString();
                TxtHitap.Text = dr["HITAP"].ToString();
            }
        }
        void temizle()
        {
            Txtid.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
            TxtBaslik.Text = "";
            RchDetay.Text = "";
            TxtOlusturan.Text = "";
            TxtHitap.Text = "";
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set TARIH=@P1, SAAT=@P2, BASLIK=@P3, DETAY=@P4, OLUSTURAN=@P5, HITAP=@P6 where ID=@P7",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", MskTarih.Text);
            komut.Parameters.AddWithValue("@P2", MskSaat.Text);
            komut.Parameters.AddWithValue("@P3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4", RchDetay.Text);
            komut.Parameters.AddWithValue("@P5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@P6", TxtHitap.Text);
            komut.Parameters.AddWithValue("@P7", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr != null)
            {
                fr.metin = dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
}
