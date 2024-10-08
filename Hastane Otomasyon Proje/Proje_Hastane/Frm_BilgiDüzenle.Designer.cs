namespace Proje_Hastane
{
    partial class Frm_BilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BilgiDüzenle));
            this.comboBox_kayitCinsiyet = new System.Windows.Forms.ComboBox();
            this.btn_bilgiGuncelle = new System.Windows.Forms.Button();
            this.mskBox_kayitTelNo = new System.Windows.Forms.MaskedTextBox();
            this.mskBox_girisTC = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_kayitSifre = new System.Windows.Forms.TextBox();
            this.txtBox_kayitSoyad = new System.Windows.Forms.TextBox();
            this.txtBox_kayit_Ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_kayitCinsiyet
            // 
            this.comboBox_kayitCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kayitCinsiyet.FormattingEnabled = true;
            this.comboBox_kayitCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox_kayitCinsiyet.Location = new System.Drawing.Point(195, 344);
            this.comboBox_kayitCinsiyet.Name = "comboBox_kayitCinsiyet";
            this.comboBox_kayitCinsiyet.Size = new System.Drawing.Size(174, 33);
            this.comboBox_kayitCinsiyet.TabIndex = 6;
            // 
            // btn_bilgiGuncelle
            // 
            this.btn_bilgiGuncelle.Location = new System.Drawing.Point(195, 403);
            this.btn_bilgiGuncelle.Name = "btn_bilgiGuncelle";
            this.btn_bilgiGuncelle.Size = new System.Drawing.Size(174, 41);
            this.btn_bilgiGuncelle.TabIndex = 28;
            this.btn_bilgiGuncelle.Text = "Güncelle";
            this.btn_bilgiGuncelle.UseVisualStyleBackColor = true;
            this.btn_bilgiGuncelle.Click += new System.EventHandler(this.btn_bilgiGuncelle_Click);
            // 
            // mskBox_kayitTelNo
            // 
            this.mskBox_kayitTelNo.Location = new System.Drawing.Point(195, 248);
            this.mskBox_kayitTelNo.Mask = "(999) 000-0000";
            this.mskBox_kayitTelNo.Name = "mskBox_kayitTelNo";
            this.mskBox_kayitTelNo.Size = new System.Drawing.Size(174, 31);
            this.mskBox_kayitTelNo.TabIndex = 4;
            // 
            // mskBox_girisTC
            // 
            this.mskBox_girisTC.Location = new System.Drawing.Point(195, 202);
            this.mskBox_girisTC.Mask = "00000000000";
            this.mskBox_girisTC.Name = "mskBox_girisTC";
            this.mskBox_girisTC.Size = new System.Drawing.Size(174, 31);
            this.mskBox_girisTC.TabIndex = 3;
            this.mskBox_girisTC.ValidatingType = typeof(int);
            // 
            // txtBox_kayitSifre
            // 
            this.txtBox_kayitSifre.Location = new System.Drawing.Point(195, 297);
            this.txtBox_kayitSifre.Name = "txtBox_kayitSifre";
            this.txtBox_kayitSifre.Size = new System.Drawing.Size(174, 31);
            this.txtBox_kayitSifre.TabIndex = 5;
            // 
            // txtBox_kayitSoyad
            // 
            this.txtBox_kayitSoyad.Location = new System.Drawing.Point(195, 150);
            this.txtBox_kayitSoyad.Name = "txtBox_kayitSoyad";
            this.txtBox_kayitSoyad.Size = new System.Drawing.Size(174, 31);
            this.txtBox_kayitSoyad.TabIndex = 1;
            // 
            // txtBox_kayit_Ad
            // 
            this.txtBox_kayit_Ad.Location = new System.Drawing.Point(195, 101);
            this.txtBox_kayit_Ad.Name = "txtBox_kayit_Ad";
            this.txtBox_kayit_Ad.Size = new System.Drawing.Size(174, 31);
            this.txtBox_kayit_Ad.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefon No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(87, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "Bilgi Düzenleme Paneli";
            // 
            // Frm_BilgiDüzenle
            // 
            this.AcceptButton = this.btn_bilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(478, 475);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_kayitCinsiyet);
            this.Controls.Add(this.btn_bilgiGuncelle);
            this.Controls.Add(this.mskBox_kayitTelNo);
            this.Controls.Add(this.mskBox_girisTC);
            this.Controls.Add(this.txtBox_kayitSifre);
            this.Controls.Add(this.txtBox_kayitSoyad);
            this.Controls.Add(this.txtBox_kayit_Ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_BilgiDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Düzenleme Paneli";
            this.Load += new System.EventHandler(this.Frm_BilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_bilgiGuncelle;
        private System.Windows.Forms.MaskedTextBox mskBox_kayitTelNo;
        private System.Windows.Forms.MaskedTextBox mskBox_girisTC;
        private System.Windows.Forms.TextBox txtBox_kayitSifre;
        private System.Windows.Forms.TextBox txtBox_kayitSoyad;
        private System.Windows.Forms.TextBox txtBox_kayit_Ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_kayitCinsiyet;
    }
}