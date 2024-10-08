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

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=UMUT\\TEW_SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        bool durum;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox_Ad.Focus();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personeller' table. You can move, or remove it, as needed.
            this.tbl_PersonellerTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personeller);
            dataGridView1.Enabled = true;
        }
        void temizle()
        {
            txtBox_ID.Text = "";
            txtBox_Ad.Text = "";
            txtBox_Soyad.Text = "";
            comboBox_Sehir.Text = "";
            radioBtn_Bekar.Checked = false;
            radioBtn_Evli.Checked = false;
            maskedTxtBox_Maas.Text = "";
            txtBox_Meslek.Text = "";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personeller (PerAd,PerSoyad,PerSehir,PerMaas,PerMedeniDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            komut.Parameters.AddWithValue("@p1", txtBox_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txtBox_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBox_Sehir.Text);
            komut.Parameters.AddWithValue("@p4", maskedTxtBox_Maas.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", txtBox_Meslek.Text);
            komut.ExecuteNonQuery();//Sorguyu çalıştırır ekle-sil-güncelleme işlemlerinde kullanılır
            connection.Close();
            MessageBox.Show("Personel Eklendi"," ",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioBtn_Evli_CheckedChanged(object sender, EventArgs e)
        {
            durum = true;
        }

        private void radioBtn_Bekar_CheckedChanged(object sender, EventArgs e)
        {
            durum = false;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool medeniHal;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtBox_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBox_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBox_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox_Sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTxtBox_Maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            medeniHal = Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value);
            txtBox_Meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if (medeniHal == true)
                radioBtn_Evli.Checked = true;
            else
                radioBtn_Bekar.Checked = true;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komutSil = new SqlCommand("Delete From Tbl_Personeller WHERE  PerID = @ıd1", connection);
            komutSil.Parameters.AddWithValue("@ıd1", txtBox_ID.Text);
            komutSil.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("İlgili kişi silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            bool durum = radioBtn_Evli.Checked;
            //ÖNEMLİ eğer update sorgularına where koşulu koyulmazsa tablodaki bütün verileri en son girilen bilgiler ile günceller. Where koşuluna dikkat ediniz.
            connection.Open();
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Personeller Set PerAd = @a1, PerSoyad = @a2, PerSehir = @a3, PerMaas = @a4, PerMedeniDurum = @a5, PerMeslek = @a6 WHERE PerID = @a7", connection);
            komutGuncelle.Parameters.AddWithValue("@a1", txtBox_Ad.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", txtBox_Soyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", comboBox_Sehir.Text);
            komutGuncelle.Parameters.AddWithValue("@a4", maskedTxtBox_Maas.Text);
            komutGuncelle.Parameters.AddWithValue("@a5",durum);
            komutGuncelle.Parameters.AddWithValue("@a6", txtBox_Meslek.Text);
            komutGuncelle.Parameters.AddWithValue("@a7", txtBox_ID.Text);
            komutGuncelle.ExecuteNonQuery();//ExecuteNonQuery komutu olmazsa yazılan kodlar çalışmaz
            connection.Close();
            MessageBox.Show("Kişi Güncellenmiştir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (durum == true)
                radioBtn_Evli.Checked = true;
            else
                radioBtn_Bekar.Checked = true;
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik(); //Istatistik formundan nesne türettik.
            fr.Show();
           
        }
    }
}
