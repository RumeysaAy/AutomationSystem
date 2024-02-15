using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon_Sistemi
{
    public partial class FrRaporlar : Form
    {
        public FrRaporlar()
        {
            InitializeComponent();
        }

        private void FrRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'TelefonSatisOtomasyonuDataSet9.TBL_PERSONELLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_PERSONELLERTableAdapter.Fill(this.TelefonSatisOtomasyonuDataSet9.TBL_PERSONELLER);
            // TODO: Bu kod satırı 'TelefonSatisOtomasyonuDataSet8.TBL_GIDERLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_GIDERLERTableAdapter.Fill(this.TelefonSatisOtomasyonuDataSet8.TBL_GIDERLER);
            // TODO: Bu kod satırı 'TelefonSatisOtomasyonuDataSet7.TBL_MUSTERILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_MUSTERILERTableAdapter.Fill(this.TelefonSatisOtomasyonuDataSet7.TBL_MUSTERILER);
            // TODO: Bu kod satırı 'TelefonSatisOtomasyonuDataSet6.TBL_FIRMALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_FIRMALARTableAdapter.Fill(this.TelefonSatisOtomasyonuDataSet6.TBL_FIRMALAR);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
