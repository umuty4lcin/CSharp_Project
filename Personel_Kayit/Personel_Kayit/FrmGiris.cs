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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=UMUT\\TEW_SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand kmt_giris = new SqlCommand("SELECT * FROM Tbl_Giris WHERE kullaniciAdi = @p1 AND sifre = @p2",connection);
            kmt_giris.Parameters.AddWithValue("@p1", txt_Kullaniciad.Text);
            kmt_giris.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr_giris = kmt_giris.ExecuteReader();
            if(dr_giris.Read())
            {
                Form1 frmAna = new Form1();
                frmAna.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre girdiniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();
        }
    }
}
