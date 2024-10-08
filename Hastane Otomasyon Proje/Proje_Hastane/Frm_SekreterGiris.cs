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
    public partial class Frm_SekreterGiris : Form
    {
        public Frm_SekreterGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi s_bgl = new sqlBaglantisi();
        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            Frm_Girisler fr = new Frm_Girisler();
            fr.Show();
            this.Close();
        }

        private void Frm_SekreterGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_HastaGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Sekreter WHERE SekreterTC = @p1 AND SekreterSifre = @p2", s_bgl.connection());
            komut.Parameters.AddWithValue("@p1", mskTxt_TC.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Frm_SekreterDetay fr = new Frm_SekreterDetay();
                fr.tc_no = mskTxt_TC.Text;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı TC No veya Şifre girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            s_bgl.connection().Close();
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
