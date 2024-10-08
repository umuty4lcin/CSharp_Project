using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class Frm_Girisler : Form
    {
        public Frm_Girisler()
        {
            InitializeComponent();
        }


        private void btn_HastaGiris_Click(object sender, EventArgs e)
        {
            Frm_HastaGiris hasta_Giris = new Frm_HastaGiris();
            hasta_Giris.Show();
            this.Hide();
            
        }

        private void btn_DoktorGiris_Click(object sender, EventArgs e)
        {
            Frm_DoktorGiris doktor_Giris = new Frm_DoktorGiris();
            doktor_Giris.Show();
            this.Hide();
        }

        private void btn_SekreterGiris_Click(object sender, EventArgs e)
        {
            Frm_SekreterGiris sekreter_Giris = new Frm_SekreterGiris();
            sekreter_Giris.Show();
            this.Hide();
        }

        private void Frm_Girisler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
