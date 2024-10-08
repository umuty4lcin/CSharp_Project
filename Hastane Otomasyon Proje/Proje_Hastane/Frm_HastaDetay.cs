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
using System.Data.Common;

namespace Proje_Hastane
{
    public partial class Frm_HastaDetay : Form
    {
        public Frm_HastaDetay()
        {
            InitializeComponent();
        }
        public string tc_no;
        sqlBaglantisi s_bgl = new sqlBaglantisi();
        void gecmisRandevu()
        {
            //Randevu geçmişi
            DataTable dt = new DataTable();
            //DataTable veritabanı tablolarına benzer yapıdadır ve verileri saklamak işlemek için kullanılır

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE HastaTC=" + tc_no, s_bgl.connection());
            //SqlDataAdapter veritabanı sorgularını çalıştırmak ve verileri bir DataTable nesnesine aktarmak için kullanılır.

            /*SELECT * FROM Tbl_Randevular WHERE HastaTC= kısmı, tc_no değişkenindeki hasta TC kimlik numarasına sahip randevuları seçmek için bir SQL sorgusudur. 
             Bu sorgu, Tlb_Randevular adlı tablodan belirtilen TC kimlik numarasına sahip tüm randevuları alır.
            */
            da.Fill(dt);
            //SqlDataAdapter nesnesi, veritabanından verileri çeker ve bu verileri belirtilen DataTable (dt) nesnesine doldurur.
            //Yani, da.Fill(dt) satırı ile veriler veritabanından çekilip dt adlı DataTable nesnesine yerleştirilir.

            dataGridView1.DataSource = dt;//dataGridView'ın veri kaynağı olarak dataTableden gelen veriler 
            //dataGrid'de baglanti açıp kapatmay gerek kalmıyor

            //Bransları çekme
            SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM Tbl_Branslar ", s_bgl.connection());
            SqlDataReader dr1 = komut2.ExecuteReader();
            while (dr1.Read())
            {
                comboBox_Brans.Items.Add(dr1[0]);
            }
            s_bgl.connection().Close();
        }
        private void Frm_HastaDetay_Load(object sender, EventArgs e)
        {
            //Ad soyad ve Tc no çekme
            SqlCommand komut = new SqlCommand("SELECT HastaAd,HastaSoyad FROM Tbl_Hastalar WHERE HastaTC = @p1", s_bgl.connection());
            komut.Parameters.AddWithValue("@p1", tc_no);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbl_adSoyad.Text = dr[0] + " " + dr[1];
            }
            lbl_TC.Text = tc_no;
            s_bgl.connection().Close();

            gecmisRandevu();
            
        }
        //Kapat ikonuna tıklayınca uygulamayı da kapatıyoruz
        private void Frm_HastaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Branş seçince doktoru otomatik atıyor
        private void comboBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("SELECT DoktorAd,DoktorSoyad FROM Tbl_Doktorlar WHERE DoktorBrans = @p1", s_bgl.connection());
            komut3.Parameters.AddWithValue("@p1", comboBox_Brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox_Doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            s_bgl.connection().Close();
            comboBox_Doktor_SelectedIndexChanged(sender,e);
            
        }

        private void comboBox_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktora Göre randevuları görüntüleme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDoktor ='" + comboBox_Doktor.Text+"'AND RandevuDurum = 1", s_bgl.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_BilgiDüzenle frm = new Frm_BilgiDüzenle();
            frm.tc_no = lbl_TC.Text;
            frm.ShowDialog();
        }

        private void btn_RandevuAl_Click(object sender, EventArgs e)
        {
            if(richTxtBox_Not.TextLength >250)
            {
                MessageBox.Show("250 karakterden fazla giriş yaptınız. Lütfen daha kısa bir not yazınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut_randevuAl = new SqlCommand("UPDATE Tbl_Randevular SET RandevuDurum = @p1,HastaTC = @p2,HastaSikayet = @p3 WHERE RandevuID = @p4", s_bgl.connection());
                komut_randevuAl.Parameters.AddWithValue("@p1", false);
                komut_randevuAl.Parameters.AddWithValue("@p2", lbl_TC.Text);
                komut_randevuAl.Parameters.AddWithValue("@p3", richTxtBox_Not.Text);
                komut_randevuAl.Parameters.AddWithValue("@p4", txtBox_ID.Text);
                komut_randevuAl.ExecuteNonQuery();
                s_bgl.connection().Close();
                MessageBox.Show("Randevunuz başarılı bir şekilde oluşturulmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gecmisRandevu();
                txtBox_ID.Text = "";
                richTxtBox_Not.Text = "";
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtBox_ID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            comboBox_Brans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            comboBox_Doktor.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
