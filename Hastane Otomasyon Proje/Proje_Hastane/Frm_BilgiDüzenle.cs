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
    public partial class Frm_BilgiDüzenle : Form
    {
        public Frm_BilgiDüzenle()
        {
            InitializeComponent();
        }
        public string tc_no;
        sqlBaglantisi s_bgl = new sqlBaglantisi();
        private void Frm_BilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskBox_girisTC.Text = tc_no;
            mskBox_girisTC.Enabled = false;

            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Hastalar WHERE HastaTC = @p1",s_bgl.connection());
            komut.Parameters.AddWithValue("@p1",tc_no);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtBox_kayit_Ad.Text = dr[1].ToString();
                txtBox_kayitSoyad.Text = dr[2].ToString();
                mskBox_kayitTelNo.Text = dr[4].ToString();
                txtBox_kayitSifre.Text = dr[5].ToString();
                comboBox_kayitCinsiyet.Text = dr[6].ToString();
            }
            s_bgl.connection().Close();

        }

        private void btn_bilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("UPDATE Tbl_Hastalar SET HastaAd = @p1, HastaSoyad = @p2, HastaTelefon = @p3, HastaSifre = @p4, HastaCinsiyet = @p5 WHERE HastaTC = @p6", s_bgl.connection());
            komut2.Parameters.AddWithValue("@p1", txtBox_kayit_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", txtBox_kayitSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskBox_kayitTelNo.Text);
            komut2.Parameters.AddWithValue("@p4", txtBox_kayitSifre.Text);
            komut2.Parameters.AddWithValue("@p5", comboBox_kayitCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskBox_girisTC.Text);
            komut2.ExecuteNonQuery();
            s_bgl.connection().Close();
            MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
