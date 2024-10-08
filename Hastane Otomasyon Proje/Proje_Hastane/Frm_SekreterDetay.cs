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
    public partial class Frm_SekreterDetay : Form
    {
        public Frm_SekreterDetay()
        {
            InitializeComponent();
        }
        public string tc_no;
        bool durum = true;
        sqlBaglantisi s_blg = new sqlBaglantisi();
        private void Frm_SekreterDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void temizle()
        {
            mskTxtBox_Tarih.Text = "";
            mskTxtBox_Saat.Text = "";
            comboBox_Brans.Text = "";
            comboBox_Doktor.Text = "";
            checkBox_Musait.Checked = false;
            checkBox_MusaitDegil.Checked = false;
        }
        private void Frm_SekreterDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad Çekme
            lbl_TC.Text = tc_no;
            SqlCommand komut = new SqlCommand("SELECT SekreterAdSoyad FROM Tbl_Sekreter WHERE SekreterTc = @p1", s_blg.connection());
            komut.Parameters.AddWithValue("@p1", tc_no);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbl_adSoyad.Text = dr[0].ToString();
            }

            //Branşları DataGriedView'e çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branslar", s_blg.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            s_blg.connection().Close();

            //Doktorlara DataGriedView'e çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT DoktorID,(DoktorAd +' '+DoktorSoyad) AS Doktorlar,DoktorBrans FROM Tbl_Doktorlar", s_blg.connection());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            s_blg.connection().Close();

            //Branşları Çekme
            SqlCommand kmt_brans = new SqlCommand("SELECT BransAd FROM Tbl_Branslar",s_blg.connection());
            SqlDataReader dr1 = kmt_brans.ExecuteReader();
            while (dr1.Read())
            {
                comboBox_Brans.Items.Add(dr1[0].ToString());
            }
            s_blg.connection().Close();
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand r_komut = new SqlCommand("INSERT INTO Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum) VALUES (@r1,@r2,@r3,@r4,@r5)", s_blg.connection());
            r_komut.Parameters.AddWithValue("@r1", mskTxtBox_Tarih.Text);
            r_komut.Parameters.AddWithValue("@r2", mskTxtBox_Saat.Text);
            r_komut.Parameters.AddWithValue("@r3", comboBox_Brans.Text);
            r_komut.Parameters.AddWithValue("@r4", comboBox_Doktor.Text);
            if (checkBox_Musait.Checked == true)
                durum = true;
                
            else if (checkBox_MusaitDegil.Checked == true)
                durum = false;
            else
                durum = true;
            r_komut.Parameters.AddWithValue("@r5", durum);

            r_komut.ExecuteNonQuery();
            s_blg.connection().Close();
            MessageBox.Show("Randevu oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            temizle();
                    
        }
        //Branşa göre doktor getirme
        private void comboBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Doktor.Items.Clear();
            SqlCommand kmt_doktor = new SqlCommand("SELECT (DoktorAd+' '+DoktorSoyad) FROM Tbl_Doktorlar WHERE DoktorBrans = @p1", s_blg.connection());
            kmt_doktor.Parameters.AddWithValue("@p1", comboBox_Brans.Text);
            SqlDataReader dr = kmt_doktor.ExecuteReader();
            while(dr.Read())
            {
                comboBox_Doktor.Items.Add(dr[0].ToString());
            }
            s_blg.connection().Close();
        }

        private void btn_DuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Duyurular (Duyuru) VALUES (@d1)", s_blg.connection());
            komut.Parameters.AddWithValue("@d1", richTxtBox_Duyuru.Text);
            if (richTxtBox_Duyuru.Text.Length >= 250)
                MessageBox.Show("Lütfen 250 karakteri aşmayınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                komut.ExecuteNonQuery();
                s_blg.connection().Close();
                MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_DoktorPanel_Click(object sender, EventArgs e)
        {
            Frm_DoktorPaneli fr = new Frm_DoktorPaneli();
            fr.Show();

        }

        private void btn_BransPanel_Click(object sender, EventArgs e)
        {
            Frm_BransPaneli fr = new Frm_BransPaneli();
            fr.Show();
        }

        private void btn_RandevuListesi_Click(object sender, EventArgs e)
        {
            Frm_RandevuListesi fr = new Frm_RandevuListesi();
            fr.Show();
        }

    }
}
