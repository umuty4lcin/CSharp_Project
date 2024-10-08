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
namespace Personel_Kayit
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=UMUT\\TEW_SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //Ort Maas
            connection.Open();
            SqlCommand kmt_ortmaas = new SqlCommand("SELECT PerMeslek,AVG(PerMaas) AS Yasayan_Kisi FROM Tbl_Personeller GROUP BY PerMeslek", connection);
            SqlDataReader dr_ortmaas = kmt_ortmaas.ExecuteReader();
            while(dr_ortmaas.Read())
            {
                chart_ortMaas.Series["OrtMaas"].Points.AddXY(dr_ortmaas[0], dr_ortmaas[1]);
            }
            connection.Close();

            //Meslekte kaç kişi var
            connection.Open();
            SqlCommand kmt_meslek_total = new SqlCommand("SELECT PerMeslek,Count(*) AS Total FROM Tbl_Personeller GROUP BY PerMeslek ", connection);
            SqlDataReader dr_meslek_total = kmt_meslek_total.ExecuteReader();
            while(dr_meslek_total.Read())
            {
                chart_MeslekSayisi.Series["Meslek"].Points.AddXY(dr_meslek_total[0], dr_meslek_total[1]);
            }
            connection.Close();
        }
    }
}
