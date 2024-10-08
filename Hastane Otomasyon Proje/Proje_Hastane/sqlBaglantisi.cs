using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlBaglantisi
    {
        string baglantiadresi = "Data Source=UMUT\\TEW_SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True";
        public SqlConnection connection()
        {
            SqlConnection baglan = new SqlConnection(baglantiadresi);
            baglan.Open();
            return baglan;
        } 
    }
}
