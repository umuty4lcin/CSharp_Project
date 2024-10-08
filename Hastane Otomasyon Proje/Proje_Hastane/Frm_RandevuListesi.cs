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
    public partial class Frm_RandevuListesi : Form
    {
        public Frm_RandevuListesi()
        {
            InitializeComponent();
        }
        Frm_SekreterDetay fr = new Frm_SekreterDetay();
        sqlBaglantisi s_bgl = new sqlBaglantisi();
        private void Frm_RandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular", s_bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}
