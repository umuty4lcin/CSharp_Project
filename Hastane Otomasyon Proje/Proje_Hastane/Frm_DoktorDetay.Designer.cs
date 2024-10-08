namespace Proje_Hastane
{
    partial class Frm_DoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_adSoyad = new System.Windows.Forms.Label();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTxtBox_RandevuNot = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_Duyurular = new System.Windows.Forms.Button();
            this.btn_BilgiDuzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_adSoyad);
            this.groupBox1.Controls.Add(this.lbl_TC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Detay";
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.Location = new System.Drawing.Point(136, 111);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(105, 25);
            this.lbl_adSoyad.TabIndex = 3;
            this.lbl_adSoyad.Text = "Ad Soyad";
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Location = new System.Drawing.Point(136, 56);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(144, 25);
            this.lbl_TC.TabIndex = 2;
            this.lbl_TC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTxtBox_RandevuNot);
            this.groupBox2.Location = new System.Drawing.Point(5, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Not";
            // 
            // richTxtBox_RandevuNot
            // 
            this.richTxtBox_RandevuNot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBox_RandevuNot.Location = new System.Drawing.Point(3, 27);
            this.richTxtBox_RandevuNot.Name = "richTxtBox_RandevuNot";
            this.richTxtBox_RandevuNot.Size = new System.Drawing.Size(303, 155);
            this.richTxtBox_RandevuNot.TabIndex = 0;
            this.richTxtBox_RandevuNot.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(320, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(990, 547);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 517);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Cikis);
            this.groupBox4.Controls.Add(this.btn_Duyurular);
            this.groupBox4.Controls.Add(this.btn_BilgiDuzenle);
            this.groupBox4.Location = new System.Drawing.Point(8, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 179);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(74, 125);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(161, 41);
            this.btn_Cikis.TabIndex = 2;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_Duyurular
            // 
            this.btn_Duyurular.Location = new System.Drawing.Point(74, 78);
            this.btn_Duyurular.Name = "btn_Duyurular";
            this.btn_Duyurular.Size = new System.Drawing.Size(161, 41);
            this.btn_Duyurular.TabIndex = 1;
            this.btn_Duyurular.Text = "Duyurular";
            this.btn_Duyurular.UseVisualStyleBackColor = true;
            this.btn_Duyurular.Click += new System.EventHandler(this.btn_Duyurular_Click);
            // 
            // btn_BilgiDuzenle
            // 
            this.btn_BilgiDuzenle.Location = new System.Drawing.Point(74, 30);
            this.btn_BilgiDuzenle.Name = "btn_BilgiDuzenle";
            this.btn_BilgiDuzenle.Size = new System.Drawing.Size(161, 41);
            this.btn_BilgiDuzenle.TabIndex = 0;
            this.btn_BilgiDuzenle.Text = "Bilgi Düzenle";
            this.btn_BilgiDuzenle.UseVisualStyleBackColor = true;
            this.btn_BilgiDuzenle.Click += new System.EventHandler(this.btn_BilgiDuzenle_Click);
            // 
            // Frm_DoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1322, 582);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_DoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Detay Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DoktorDetay_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_adSoyad;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTxtBox_RandevuNot;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Button btn_Duyurular;
        private System.Windows.Forms.Button btn_BilgiDuzenle;
    }
}