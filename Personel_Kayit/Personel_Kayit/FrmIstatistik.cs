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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=UMUT\\TEW_SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand kmt_ToplamPer = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personeller", connection);
            SqlDataReader dr_toplamPer = kmt_ToplamPer.ExecuteReader(); //sql'den gelen bilgileri okumak icin sql datareader nesnesi oluşturduk. daha sonrasinda ilgili komut çalistiginde executereader ile okuduk.
            while(dr_toplamPer.Read())
            {
                lbl_PerSayisi.Text = dr_toplamPer[0].ToString();
                //istenilen komut okunduğu süre boyunca (dr_toplamPer.Read() komutu) çıktı olarak dönen sütunun 0.indeksindeki değeri yazdırır. Yani toplam personel sayisini
            }
            
            connection.Close();

            //Evli personel sayisi
            connection.Open();
            SqlCommand kmt_EvliPerSayi = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personeller WHERE PerMedeniDurum = 'True'", connection);
            SqlDataReader dr_EvliPerSayi = kmt_EvliPerSayi.ExecuteReader();
            while (dr_EvliPerSayi.Read())
            {
                lbl_EvliPerSayisi.Text = dr_EvliPerSayi[0].ToString();
            }
            connection.Close();

            //Bekar Personel Sayisi
            connection.Open();
            SqlCommand kmt_BekarPerSayi = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personeller WHERE PerMedeniDurum = 'False'", connection);
            SqlDataReader dr_BekarPerSayi = kmt_BekarPerSayi.ExecuteReader();
            while (dr_BekarPerSayi.Read())
            {
                lbl_BekarPerSayisi.Text = dr_BekarPerSayi[0].ToString();
            }
            connection.Close();

            //Sehir Sayisi

            connection.Open();
            SqlCommand kmt_sehirSayisi = new SqlCommand("SELECT COUNT(DISTINCT(PerSehir)) FROM Tbl_Personeller ", connection);
            SqlDataReader dr_sehirSayisi = kmt_sehirSayisi.ExecuteReader();
            while(dr_sehirSayisi.Read())
            {
                lbl_SehirSayisi.Text = dr_sehirSayisi[0].ToString();
            }
            connection.Close();

            //Toplam Maas

            connection.Open();
            SqlCommand kmt_toplamMaas = new SqlCommand("SELECT SUM(PerMaas) FROM Tbl_Personeller", connection);
            SqlDataReader dr_ToplamMaas = kmt_toplamMaas.ExecuteReader();
            while (dr_ToplamMaas.Read())
            {
                lbl_ToplamMaas.Text = dr_ToplamMaas[0].ToString();
            }
            connection.Close();

            //Ort Maas

            connection.Open();
            SqlCommand kmt_ortMaas = new SqlCommand("SELECT AVG(PerMaas) FROM Tbl_Personeller", connection);
            SqlDataReader dr_ortMaas = kmt_ortMaas.ExecuteReader();
            while (dr_ortMaas.Read())
            {
                lbl_OrtalamaMaas.Text = dr_ortMaas[0].ToString();
            }
            connection.Close();
        }
    }
}
