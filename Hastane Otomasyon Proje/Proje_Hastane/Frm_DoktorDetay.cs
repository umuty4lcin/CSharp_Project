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
    public partial class Frm_DoktorDetay : Form
    {
        public Frm_DoktorDetay()
        {
            InitializeComponent();
        }
        public string tc_no;
        sqlBaglantisi s_blg = new sqlBaglantisi();
        private void Frm_DoktorDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_DoktorDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad çekme
            SqlCommand komut_adSoyad = new SqlCommand("SELECT (DoktorAd +' '+DoktorSoyad) AS DoktorAdSoyad FROM Tbl_Doktorlar WHERE DoktorTC = @p1", s_blg.connection());
            komut_adSoyad.Parameters.AddWithValue("@p1", tc_no);
            SqlDataReader dr = komut_adSoyad.ExecuteReader();
            while(dr.Read())
            {
                lbl_adSoyad.Text = dr[0].ToString();
            }
            s_blg.connection().Close();
            lbl_TC.Text = tc_no;

            //Randevuları DataGridView'e çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDoktor = '"+lbl_adSoyad.Text+"'", s_blg.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            s_blg.connection().Close();

        }

        private void btn_BilgiDuzenle_Click(object sender, EventArgs e)
        {
            Frm_DoktorBilgiDuzenle fr_bilgi = new Frm_DoktorBilgiDuzenle();
            fr_bilgi.tcNo = tc_no;
            fr_bilgi.ShowDialog();
        }

        private void btn_Duyurular_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fr = new Frm_Duyurular();
            fr.Show();            
        }
        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTxtBox_RandevuNot.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
