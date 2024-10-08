using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class Frm_DoktorPaneli : Form
    {
        public Frm_DoktorPaneli()
        {
            InitializeComponent();
        }
        sqlBaglantisi s_blg = new sqlBaglantisi();
        void doktor_listeleme()
        {
            //Doktorları DataGriedView'e çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Tbl_Doktorlar", s_blg.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            s_blg.connection().Close();
        }
        void temizle()
        {
            txtBox_ID.Text = "";
            txtBox_Ad.Text = "";
            txtBox_Soyad.Text = "";
            cmbBox_Brans.Items.Clear();
            mskTxtBox_TC.Text = "";
            txtBox_Sifre.Text = "";
            txtBox_Ad.Focus();
        }

        void brans_listeleme()
        {
            //Bransları combobox'a çekme
            SqlCommand komut_doktor = new SqlCommand("SELECT BransAd FROM Tbl_Branslar", s_blg.connection());
            SqlDataReader dr = komut_doktor.ExecuteReader();
            while (dr.Read())
            {
                cmbBox_Brans.Items.Add(dr[0].ToString());
            }
            s_blg.connection().Close();
        }
        private void Frm_DoktorPaneli_Load(object sender, EventArgs e)
        {
            doktor_listeleme();

            brans_listeleme();
        }
        bool denetle(string tc_no)
        {
            SqlCommand komut_denetle = new SqlCommand("SELECT DoktorTC From Tbl_Doktorlar", s_blg.connection());
            SqlDataReader dr = komut_denetle.ExecuteReader();
            while(dr.Read())
            {
                if (dr[0].ToString() == tc_no)
                {
                    s_blg.connection().Close();
                    return true;               
                }
            }
            s_blg.connection().Close();
            return false;
            
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            denetle(mskTxtBox_TC.Text);
            bool durum = denetle(mskTxtBox_TC.Text);
            if (durum==true)
            {
                MessageBox.Show("İlgili TC Numarasına sahip doktor sistemde zaten kayıtlı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            { 
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) VALUES(@p1,@p2,@p3,@p4,@p5)", s_blg.connection());
                komut.Parameters.AddWithValue("@p1", txtBox_Ad.Text);
                komut.Parameters.AddWithValue("@p2", txtBox_Soyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbBox_Brans.Text);
                komut.Parameters.AddWithValue("@p4", mskTxtBox_TC.Text);
                komut.Parameters.AddWithValue("@p5", txtBox_Sifre.Text);
                komut.ExecuteNonQuery();
                s_blg.connection().Close();
                MessageBox.Show("Doktor ekleme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doktor_listeleme();
                temizle();
                brans_listeleme();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBox_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBox_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBox_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBox_Brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTxtBox_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtBox_Sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut_guncelle = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd = @p1,DoktorSoyad = @p2,DoktorBrans=@p3,DoktorSifre = @p5 WHERE DoktorTC = @p4", s_blg.connection());
            komut_guncelle.Parameters.AddWithValue("@p1", txtBox_Ad.Text);
            komut_guncelle.Parameters.AddWithValue("@p2", txtBox_Soyad.Text);
            komut_guncelle.Parameters.AddWithValue("@p3", cmbBox_Brans.Text);
            komut_guncelle.Parameters.AddWithValue("@p4", mskTxtBox_TC.Text);
            komut_guncelle.Parameters.AddWithValue("@p5", txtBox_Sifre.Text);
            komut_guncelle.ExecuteNonQuery();
            s_blg.connection().Close();
            MessageBox.Show("Doktor bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doktor_listeleme();
            temizle();
            brans_listeleme();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut_sil = new SqlCommand("DELETE FROM Tbl_Doktorlar WHERE DoktorTC = @p1", s_blg.connection());
            komut_sil.Parameters.AddWithValue("@p1", mskTxtBox_TC.Text);
            komut_sil.ExecuteNonQuery();
            s_blg.connection().Close();
            MessageBox.Show("Doktor silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doktor_listeleme();
            temizle();
            brans_listeleme();
        }
    }
}
