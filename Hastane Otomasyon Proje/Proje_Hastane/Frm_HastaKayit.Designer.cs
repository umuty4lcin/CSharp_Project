namespace Proje_Hastane
{
    partial class Frm_HastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HastaKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_kayit_Ad = new System.Windows.Forms.TextBox();
            this.txtBox_kayitSoyad = new System.Windows.Forms.TextBox();
            this.txtBox_kayitSifre = new System.Windows.Forms.TextBox();
            this.mskBox_girisTC = new System.Windows.Forms.MaskedTextBox();
            this.mskBox_kayitTelNo = new System.Windows.Forms.MaskedTextBox();
            this.btn_kayitOl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_kayitCinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefon No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cinsiyet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şifre :";
            // 
            // txtBox_kayit_Ad
            // 
            this.txtBox_kayit_Ad.Location = new System.Drawing.Point(215, 95);
            this.txtBox_kayit_Ad.Name = "txtBox_kayit_Ad";
            this.txtBox_kayit_Ad.Size = new System.Drawing.Size(148, 31);
            this.txtBox_kayit_Ad.TabIndex = 0;
            // 
            // txtBox_kayitSoyad
            // 
            this.txtBox_kayitSoyad.Location = new System.Drawing.Point(215, 144);
            this.txtBox_kayitSoyad.Name = "txtBox_kayitSoyad";
            this.txtBox_kayitSoyad.Size = new System.Drawing.Size(148, 31);
            this.txtBox_kayitSoyad.TabIndex = 1;
            // 
            // txtBox_kayitSifre
            // 
            this.txtBox_kayitSifre.Location = new System.Drawing.Point(215, 291);
            this.txtBox_kayitSifre.Name = "txtBox_kayitSifre";
            this.txtBox_kayitSifre.Size = new System.Drawing.Size(148, 31);
            this.txtBox_kayitSifre.TabIndex = 4;
            // 
            // mskBox_girisTC
            // 
            this.mskBox_girisTC.Location = new System.Drawing.Point(215, 196);
            this.mskBox_girisTC.Mask = "00000000000";
            this.mskBox_girisTC.Name = "mskBox_girisTC";
            this.mskBox_girisTC.Size = new System.Drawing.Size(148, 31);
            this.mskBox_girisTC.TabIndex = 2;
            this.mskBox_girisTC.ValidatingType = typeof(int);
            // 
            // mskBox_kayitTelNo
            // 
            this.mskBox_kayitTelNo.Location = new System.Drawing.Point(215, 242);
            this.mskBox_kayitTelNo.Mask = "(999) 000-0000";
            this.mskBox_kayitTelNo.Name = "mskBox_kayitTelNo";
            this.mskBox_kayitTelNo.Size = new System.Drawing.Size(148, 31);
            this.mskBox_kayitTelNo.TabIndex = 3;
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.Location = new System.Drawing.Point(215, 397);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.Size = new System.Drawing.Size(148, 41);
            this.btn_kayitOl.TabIndex = 6;
            this.btn_kayitOl.Text = "Kayıt Ol";
            this.btn_kayitOl.UseVisualStyleBackColor = true;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(158, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hasta Kayıt Paneli";
            // 
            // comboBox_kayitCinsiyet
            // 
            this.comboBox_kayitCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kayitCinsiyet.FormattingEnabled = true;
            this.comboBox_kayitCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox_kayitCinsiyet.Location = new System.Drawing.Point(215, 338);
            this.comboBox_kayitCinsiyet.Name = "comboBox_kayitCinsiyet";
            this.comboBox_kayitCinsiyet.Size = new System.Drawing.Size(148, 33);
            this.comboBox_kayitCinsiyet.TabIndex = 5;
            // 
            // Frm_HastaKayit
            // 
            this.AcceptButton = this.btn_kayitOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(533, 464);
            this.Controls.Add(this.comboBox_kayitCinsiyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_kayitOl);
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
            this.Name = "Frm_HastaKayit";
            this.Text = "Hasta Kayıt Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_HastaKayit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_kayit_Ad;
        private System.Windows.Forms.TextBox txtBox_kayitSoyad;
        private System.Windows.Forms.TextBox txtBox_kayitSifre;
        private System.Windows.Forms.MaskedTextBox mskBox_girisTC;
        private System.Windows.Forms.MaskedTextBox mskBox_kayitTelNo;
        private System.Windows.Forms.Button btn_kayitOl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_kayitCinsiyet;
    }
}