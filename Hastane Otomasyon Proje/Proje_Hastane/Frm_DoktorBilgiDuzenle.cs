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

namespace Proje_Hastane
{
    public partial class Frm_DoktorBilgiDuzenle : Form
    {
        public Frm_DoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlBaglantisi s_bgl = new sqlBaglantisi();
        public string tcNo;
        private void Frm_DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {

            //Branşları çekme
            SqlCommand komut_brans = new SqlCommand("SELECT BransAd FROM Tbl_Branslar", s_bgl.connection());
            SqlDataReader dr1 = komut_brans.ExecuteReader();
            while (dr1.Read())
            {
                cmbBox_Brans.Items.Add(dr1[0].ToString());
            }

            //İlgili alanlara doktor verilerini çekme
            mskBox_girisTC.Text = tcNo;
            SqlCommand komut_vericekme = new SqlCommand("SELECT * FROM Tbl_Doktorlar WHERE DoktorTC = @t1", s_bgl.connection());
            komut_vericekme.Parameters.AddWithValue("@t1", tcNo);
            SqlDataReader dr2 = komut_vericekme.ExecuteReader();
            while (dr2.Read())
            {
                txtBox_kayit_Ad.Text = dr2[1].ToString();
                txtBox_kayitSoyad.Text = dr2[2].ToString();
                cmbBox_Brans.Text = dr2[3].ToString();
                txtBox_kayitSifre.Text = dr2[5].ToString();
            }
            s_bgl.connection().Close();

        }
        private void btn_bilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd = @p1,DoktorSoyad = @p2,DoktorBrans = @p3,DoktorSifre = @p4 WHERE DoktorTC = @p5", s_bgl.connection());
            komut2.Parameters.AddWithValue("@p1", txtBox_kayit_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", txtBox_kayitSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", cmbBox_Brans.Text);
            komut2.Parameters.AddWithValue("@p4", txtBox_kayitSifre.Text);
            komut2.Parameters.AddWithValue("@p5", mskBox_girisTC.Text);
            komut2.ExecuteNonQuery();
            s_bgl.connection().Close();
            MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
