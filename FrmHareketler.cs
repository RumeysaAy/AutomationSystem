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
    public partial class FrmHareketler : Form
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void FirmaHareketleri()
        {
            DataTable dt = new DataTable();
            //baglanti adresinin icerisinde bulunan firmahareketleri cagırsın
            SqlDataAdapter da = new SqlDataAdapter("Execute FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }

        void MusteriHareketler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            FirmaHareketleri();
            MusteriHareketler();
        }
    }
}
