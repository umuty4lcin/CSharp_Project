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
    public partial class Frm_BransPaneli : Form
    {
        public Frm_BransPaneli()
        {
            InitializeComponent();
        }
        sqlBaglantisi s_bgl = new sqlBaglantisi();
        
        void branscekme()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branslar", s_bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            txtBox_ID.Text = "";
            txtBox_Ad.Text = "";
            txtBox_Ad.Focus();
        }

        private void Frm_BransPaneli_Load(object sender, EventArgs e)
        {
            branscekme();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut_ekle = new SqlCommand("INSERT INTO Tbl_Branslar (BransAd) VALUES (@b1) ", s_bgl.connection());
            komut_ekle.Parameters.AddWithValue("@b1", txtBox_Ad.Text);
            komut_ekle.ExecuteNonQuery();
            s_bgl.connection().Close();
            MessageBox.Show("Branş başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            branscekme();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut_guncelle = new SqlCommand("UPDATE Tbl_Branslar SET BransAd= @b2 WHERE BransID =@b1", s_bgl.connection());
            komut_guncelle.Parameters.AddWithValue("@b1", txtBox_ID.Text);
            komut_guncelle.Parameters.AddWithValue("@b2", txtBox_Ad.Text);
            komut_guncelle.ExecuteNonQuery();
            s_bgl.connection().Close();
            MessageBox.Show("Branş başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            branscekme();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBox_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBox_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut_sil = new SqlCommand("DELETE FROM Tbl_Branslar WHERE BransID = @p1", s_bgl.connection());
            komut_sil.Parameters.AddWithValue("@p1", txtBox_ID.Text);
            komut_sil.ExecuteNonQuery();
            s_bgl.connection().Close();
            MessageBox.Show("Branş başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            branscekme();
        }
    }
}
