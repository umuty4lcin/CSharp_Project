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
    public partial class Frm_HastaKayit : Form
    {
        public Frm_HastaKayit()
        {
            InitializeComponent();
        }
        sqlBaglantisi s_bgl = new sqlBaglantisi();
        void temizle()
        {
            txtBox_kayit_Ad.Text = "";
            txtBox_kayitSoyad.Text = "";
            mskBox_girisTC.Text = "";
            mskBox_kayitTelNo.Text = "";
            txtBox_kayitSifre.Text = "";
            comboBox_kayitCinsiyet.Text ="";
        }
        private void btn_kayitOl_Click(object sender, EventArgs e)
        {      
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)",s_bgl.connection());
            komut.Parameters.AddWithValue("@p1", txtBox_kayit_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_kayitSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskBox_girisTC.Text);
            komut.Parameters.AddWithValue("@p4", mskBox_kayitTelNo.Text);
            komut.Parameters.AddWithValue("@p5", txtBox_kayitSifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBox_kayitCinsiyet.Text);
            komut.ExecuteNonQuery();
            s_bgl.connection().Close();
            temizle();
            MessageBox.Show("Kaydınız gerçekleşmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Frm_HastaKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
