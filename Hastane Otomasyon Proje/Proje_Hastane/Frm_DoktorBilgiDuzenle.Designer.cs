namespace Proje_Hastane
{
    partial class Frm_DoktorBilgiDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoktorBilgiDuzenle));
            this.mskBox_girisTC = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_kayitSoyad = new System.Windows.Forms.TextBox();
            this.txtBox_kayit_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_bilgiGuncelle = new System.Windows.Forms.Button();
            this.txtBox_kayitSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBox_Brans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskBox_girisTC
            // 
            this.mskBox_girisTC.Enabled = false;
            this.mskBox_girisTC.Location = new System.Drawing.Point(184, 206);
            this.mskBox_girisTC.Mask = "00000000000";
            this.mskBox_girisTC.Name = "mskBox_girisTC";
            this.mskBox_girisTC.Size = new System.Drawing.Size(194, 31);
            this.mskBox_girisTC.TabIndex = 32;
            this.mskBox_girisTC.ValidatingType = typeof(int);
            // 
            // txtBox_kayitSoyad
            // 
            this.txtBox_kayitSoyad.Location = new System.Drawing.Point(184, 156);
            this.txtBox_kayitSoyad.Name = "txtBox_kayitSoyad";
            this.txtBox_kayitSoyad.Size = new System.Drawing.Size(194, 31);
            this.txtBox_kayitSoyad.TabIndex = 31;
            // 
            // txtBox_kayit_Ad
            // 
            this.txtBox_kayit_Ad.Location = new System.Drawing.Point(184, 106);
            this.txtBox_kayit_Ad.Name = "txtBox_kayit_Ad";
            this.txtBox_kayit_Ad.Size = new System.Drawing.Size(194, 31);
            this.txtBox_kayit_Ad.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(126, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 31);
            this.label7.TabIndex = 33;
            this.label7.Text = "Bilgi Düzenleme Paneli";
            // 
            // btn_bilgiGuncelle
            // 
            this.btn_bilgiGuncelle.Location = new System.Drawing.Point(184, 360);
            this.btn_bilgiGuncelle.Name = "btn_bilgiGuncelle";
            this.btn_bilgiGuncelle.Size = new System.Drawing.Size(194, 41);
            this.btn_bilgiGuncelle.TabIndex = 35;
            this.btn_bilgiGuncelle.Text = "Güncelle";
            this.btn_bilgiGuncelle.UseVisualStyleBackColor = true;
            this.btn_bilgiGuncelle.Click += new System.EventHandler(this.btn_bilgiGuncelle_Click);
            // 
            // txtBox_kayitSifre
            // 
            this.txtBox_kayitSifre.Location = new System.Drawing.Point(184, 310);
            this.txtBox_kayitSifre.Name = "txtBox_kayitSifre";
            this.txtBox_kayitSifre.Size = new System.Drawing.Size(194, 31);
            this.txtBox_kayitSifre.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Şifre :";
            // 
            // cmbBox_Brans
            // 
            this.cmbBox_Brans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Brans.FormattingEnabled = true;
            this.cmbBox_Brans.Location = new System.Drawing.Point(184, 257);
            this.cmbBox_Brans.Name = "cmbBox_Brans";
            this.cmbBox_Brans.Size = new System.Drawing.Size(194, 33);
            this.cmbBox_Brans.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Branş :";
            // 
            // Frm_DoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(515, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBox_Brans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_bilgiGuncelle);
            this.Controls.Add(this.txtBox_kayitSifre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskBox_girisTC);
            this.Controls.Add(this.txtBox_kayitSoyad);
            this.Controls.Add(this.txtBox_kayit_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_DoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Düzenleme Paneli";
            this.Load += new System.EventHandler(this.Frm_DoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskBox_girisTC;
        private System.Windows.Forms.TextBox txtBox_kayitSoyad;
        private System.Windows.Forms.TextBox txtBox_kayit_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_bilgiGuncelle;
        private System.Windows.Forms.TextBox txtBox_kayitSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBox_Brans;
        private System.Windows.Forms.Label label4;
    }
}