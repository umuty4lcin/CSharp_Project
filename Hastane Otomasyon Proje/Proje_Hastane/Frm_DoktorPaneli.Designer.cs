﻿namespace Proje_Hastane
{
    partial class Frm_DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Ad = new System.Windows.Forms.TextBox();
            this.txtBox_Soyad = new System.Windows.Forms.TextBox();
            this.cmbBox_Brans = new System.Windows.Forms.ComboBox();
            this.mskTxtBox_TC = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_Sifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre :";
            // 
            // txtBox_Ad
            // 
            this.txtBox_Ad.Location = new System.Drawing.Point(124, 83);
            this.txtBox_Ad.Name = "txtBox_Ad";
            this.txtBox_Ad.Size = new System.Drawing.Size(173, 31);
            this.txtBox_Ad.TabIndex = 5;
            // 
            // txtBox_Soyad
            // 
            this.txtBox_Soyad.Location = new System.Drawing.Point(124, 129);
            this.txtBox_Soyad.Name = "txtBox_Soyad";
            this.txtBox_Soyad.Size = new System.Drawing.Size(173, 31);
            this.txtBox_Soyad.TabIndex = 6;
            // 
            // cmbBox_Brans
            // 
            this.cmbBox_Brans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Brans.FormattingEnabled = true;
            this.cmbBox_Brans.Location = new System.Drawing.Point(124, 173);
            this.cmbBox_Brans.Name = "cmbBox_Brans";
            this.cmbBox_Brans.Size = new System.Drawing.Size(173, 33);
            this.cmbBox_Brans.TabIndex = 7;
            // 
            // mskTxtBox_TC
            // 
            this.mskTxtBox_TC.Location = new System.Drawing.Point(124, 221);
            this.mskTxtBox_TC.Mask = "00000000000";
            this.mskTxtBox_TC.Name = "mskTxtBox_TC";
            this.mskTxtBox_TC.Size = new System.Drawing.Size(173, 31);
            this.mskTxtBox_TC.TabIndex = 8;
            this.mskTxtBox_TC.ValidatingType = typeof(int);
            // 
            // txtBox_Sifre
            // 
            this.txtBox_Sifre.Location = new System.Drawing.Point(124, 267);
            this.txtBox_Sifre.Name = "txtBox_Sifre";
            this.txtBox_Sifre.Size = new System.Drawing.Size(173, 31);
            this.txtBox_Sifre.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(924, 375);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ekle.Location = new System.Drawing.Point(124, 329);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(174, 39);
            this.btn_Ekle.TabIndex = 11;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Sil.Location = new System.Drawing.Point(124, 420);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(174, 39);
            this.btn_Sil.TabIndex = 12;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guncelle.Location = new System.Drawing.Point(124, 375);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(174, 39);
            this.btn_Guncelle.TabIndex = 13;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID :";
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Enabled = false;
            this.txtBox_ID.Location = new System.Drawing.Point(125, 39);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(173, 31);
            this.txtBox_ID.TabIndex = 15;
            // 
            // Frm_DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1264, 470);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBox_Sifre);
            this.Controls.Add(this.mskTxtBox_TC);
            this.Controls.Add(this.cmbBox_Brans);
            this.Controls.Add(this.txtBox_Soyad);
            this.Controls.Add(this.txtBox_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_DoktorPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.Frm_DoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Ad;
        private System.Windows.Forms.TextBox txtBox_Soyad;
        private System.Windows.Forms.ComboBox cmbBox_Brans;
        private System.Windows.Forms.MaskedTextBox mskTxtBox_TC;
        private System.Windows.Forms.TextBox txtBox_Sifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_ID;
    }
}