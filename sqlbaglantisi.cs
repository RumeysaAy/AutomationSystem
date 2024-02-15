using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Otomasyon_Sistemi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=TelefonSatisOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
