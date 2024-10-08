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
using System.Data.Sql;

namespace Personel_Kayit
{   //Data Source=UMUT\TEW_SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True -> baglanti adresi
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=UMUT\\TEW_SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        bool durum;

        bool durum_kontrol()
        {
            if (radioBtn_Evli.Checked == true)
                durum = true;
            else if (radioBtn_Bekar.Checked == true)
                durum = false;
            else
                durum = false;
            return durum;
        }
        void durum_okuma()
        {
            if (durum == true)
                radioBtn_Evli.Checked = true;
            else if (durum == false)
                radioBtn_Bekar.Checked = true;
            else
                radioBtn_Bekar.Checked = true;
        }
        void temizle()
        {
            txtBox_ID.Text = "";
            txtBox_Ad.Text = "";
            txtBox_Soyad.Text = "";
            comboBox_Sehir.Text = "";
            maskedTxtBox_Maas.Text = "";
            radioBtn_Evli.Checked = false;
            radioBtn_Bekar.Checked = false;
            txtBox_Meslek.Text = "";
            txtBox_Ad.Focus();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet1.Tbl_Personeller' table. You can move, or remove it, as needed.
            this.tbl_PersonellerTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personeller);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand kmt_ekle = new SqlCommand("INSERT INTO Tbl_Personeller (PerAd,PerSoyad,PerSehir,PerMaas,PerMedeniDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            kmt_ekle.Parameters.AddWithValue("@p1", txtBox_Ad.Text);
            kmt_ekle.Parameters.AddWithValue("@p2", txtBox_Soyad.Text);
            kmt_ekle.Parameters.AddWithValue("@p3", comboBox_Sehir.Text);
            kmt_ekle.Parameters.AddWithValue("@p4", maskedTxtBox_Maas.Text);
            kmt_ekle.Parameters.AddWithValue("@p5", durum_kontrol());
            kmt_ekle.Parameters.AddWithValue("@p6", txtBox_Meslek.Text);
            kmt_ekle.ExecuteNonQuery(); //insert update ve delete işlemlerinde kullanılır.Bu komut olmazsa sorgu çalışmaz
            connection.Close();
            temizle();
            MessageBox.Show("Personel başarılı bir şekilde eklendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand kmt_guncelle = new SqlCommand("UPDATE Tbl_Personeller SET PerAd = @a1,PerSoyad = @a2,PerSehir = @a3,PerMaas = @a4,PerMedeniDurum = @a5,PerMeslek = @a6 WHERE PerID = @a7", connection);
            kmt_guncelle.Parameters.AddWithValue("@a1", txtBox_Ad.Text);
            kmt_guncelle.Parameters.AddWithValue("@a2", txtBox_Soyad.Text);
            kmt_guncelle.Parameters.AddWithValue("@a3", comboBox_Sehir.Text);
            kmt_guncelle.Parameters.AddWithValue("@a4", maskedTxtBox_Maas.Text);
            durum_kontrol();
            kmt_guncelle.Parameters.AddWithValue("@a5", durum);
            kmt_guncelle.Parameters.AddWithValue("@a6", txtBox_Meslek.Text);
            kmt_guncelle.Parameters.AddWithValue("@a7", txtBox_ID.Text);
            kmt_guncelle.ExecuteNonQuery();
            connection.Close();
            temizle();
            
            MessageBox.Show("Personel Güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //DataGridView'ın seçilen hücreleri içerisinde 0.hücrenin satır indeksi

            //Seçilen satırdaki verileri komutlara yazdırma
            txtBox_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBox_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBox_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox_Sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTxtBox_Maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            durum = Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value);
            durum_okuma();
            txtBox_Meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand kmt_sil = new SqlCommand("DELETE FROM Tbl_Personeller WHERE PerID = @id1", connection);
            kmt_sil.Parameters.AddWithValue("@id1", txtBox_ID.Text);
            kmt_sil.ExecuteNonQuery();
            connection.Close();
            temizle();
            MessageBox.Show("Personel Silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }

        private void btn_grafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGraf = new FrmGrafikler();
            frmGraf.Show();
        }
    }
}
