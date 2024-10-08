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
    public partial class Frm_DoktorGiris : Form
    {
        public Frm_DoktorGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi s_blg = new sqlBaglantisi();
        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            Frm_Girisler fr = new Frm_Girisler();
            fr.Show();
            this.Close();
        }
        private void Frm_DoktorGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_HastaGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut_giris = new SqlCommand("SELECT * FROM Tbl_Doktorlar WHERE DoktorTC = @p1 AND DoktorSifre = @p2", s_blg.connection());
            komut_giris.Parameters.AddWithValue("@p1", mskTxt_TC.Text);
            komut_giris.Parameters.AddWithValue("@p2", txtBox_Sifre.Text);
            SqlDataReader dr = komut_giris.ExecuteReader();
            if(dr.Read())
            {
                Frm_DoktorDetay fr = new Frm_DoktorDetay();
                fr.tc_no = mskTxt_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC No veya şifre girdiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            s_blg.connection().Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtBox_Sifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtBox_Sifre.UseSystemPasswordChar = true;
            }
        }
    }
}
