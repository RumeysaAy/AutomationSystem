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
using System.Xml;

namespace Otomasyon_Sistemi
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void Stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUNAD, Sum(ADET) as 'ADET' from TBL_URUNLER group by URUNAD Having Sum(ADET) <= 20 order by Sum(ADET)", bgl.baglanti());
            da.Fill(dt);
            GCstoklar.DataSource = dt;
        }

        void Ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 10 TARIH, SAAT, BASLIK from TBL_NOTLAR order by ID desc", bgl.baglanti());
            da.Fill(dt);
            GCajanda.DataSource = dt;
        }

        void FirmaHareketleri()
        {
            DataTable dt = new DataTable();
            //baglanti adresinin icerisinde bulunan firmahareketleri cagırsın
            SqlDataAdapter da = new SqlDataAdapter("Execute FirmaHareket2", bgl.baglanti());
            da.Fill(dt);
            GChareket.DataSource = dt;
        }

        void FirmaRehber()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD, TELEFON1 from TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            GCfirma.DataSource = dt;
        }

        void Haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/teknoloji");
            while (xmloku.Read())
            {
                if(xmloku.Name == "title")
                {
                    listBoxControl1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Stoklar();
            Ajanda();
            FirmaRehber();
            FirmaHareketleri();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            Haberler();
        }
    }
}
