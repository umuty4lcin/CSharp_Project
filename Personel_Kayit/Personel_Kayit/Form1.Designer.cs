namespace Personel_Kayit
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_Evli = new System.Windows.Forms.RadioButton();
            this.radioBtn_Bekar = new System.Windows.Forms.RadioButton();
            this.maskedTxtBox_Maas = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_Sehir = new System.Windows.Forms.ComboBox();
            this.txtBox_Meslek = new System.Windows.Forms.TextBox();
            this.txtBox_Soyad = new System.Windows.Forms.TextBox();
            this.txtBox_Ad = new System.Windows.Forms.TextBox();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_grafikler = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_istatistik = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelVeriTabaniDataSet1 = new Personel_Kayit.PersonelVeriTabaniDataSet1();
            this.tblPersonellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonellerTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonellerTableAdapter();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMedeniDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_Evli);
            this.groupBox1.Controls.Add(this.radioBtn_Bekar);
            this.groupBox1.Controls.Add(this.maskedTxtBox_Maas);
            this.groupBox1.Controls.Add(this.comboBox_Sehir);
            this.groupBox1.Controls.Add(this.txtBox_Meslek);
            this.groupBox1.Controls.Add(this.txtBox_Soyad);
            this.groupBox1.Controls.Add(this.txtBox_Ad);
            this.groupBox1.Controls.Add(this.txtBox_ID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 456);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PersonelKayit";
            // 
            // radioBtn_Evli
            // 
            this.radioBtn_Evli.AutoSize = true;
            this.radioBtn_Evli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn_Evli.Location = new System.Drawing.Point(302, 306);
            this.radioBtn_Evli.Name = "radioBtn_Evli";
            this.radioBtn_Evli.Size = new System.Drawing.Size(73, 33);
            this.radioBtn_Evli.TabIndex = 7;
            this.radioBtn_Evli.TabStop = true;
            this.radioBtn_Evli.Text = "Evli";
            this.radioBtn_Evli.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Bekar
            // 
            this.radioBtn_Bekar.AutoSize = true;
            this.radioBtn_Bekar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn_Bekar.Location = new System.Drawing.Point(199, 306);
            this.radioBtn_Bekar.Name = "radioBtn_Bekar";
            this.radioBtn_Bekar.Size = new System.Drawing.Size(97, 33);
            this.radioBtn_Bekar.TabIndex = 6;
            this.radioBtn_Bekar.TabStop = true;
            this.radioBtn_Bekar.Text = "Bekar";
            this.radioBtn_Bekar.UseVisualStyleBackColor = true;
            // 
            // maskedTxtBox_Maas
            // 
            this.maskedTxtBox_Maas.Location = new System.Drawing.Point(199, 251);
            this.maskedTxtBox_Maas.Mask = "00000";
            this.maskedTxtBox_Maas.Name = "maskedTxtBox_Maas";
            this.maskedTxtBox_Maas.Size = new System.Drawing.Size(129, 38);
            this.maskedTxtBox_Maas.TabIndex = 5;
            this.maskedTxtBox_Maas.ValidatingType = typeof(int);
            // 
            // comboBox_Sehir
            // 
            this.comboBox_Sehir.FormattingEnabled = true;
            this.comboBox_Sehir.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.comboBox_Sehir.Location = new System.Drawing.Point(199, 196);
            this.comboBox_Sehir.Name = "comboBox_Sehir";
            this.comboBox_Sehir.Size = new System.Drawing.Size(129, 39);
            this.comboBox_Sehir.TabIndex = 4;
            // 
            // txtBox_Meslek
            // 
            this.txtBox_Meslek.Location = new System.Drawing.Point(199, 363);
            this.txtBox_Meslek.Name = "txtBox_Meslek";
            this.txtBox_Meslek.Size = new System.Drawing.Size(129, 38);
            this.txtBox_Meslek.TabIndex = 8;
            // 
            // txtBox_Soyad
            // 
            this.txtBox_Soyad.Location = new System.Drawing.Point(199, 144);
            this.txtBox_Soyad.Name = "txtBox_Soyad";
            this.txtBox_Soyad.Size = new System.Drawing.Size(129, 38);
            this.txtBox_Soyad.TabIndex = 3;
            // 
            // txtBox_Ad
            // 
            this.txtBox_Ad.Location = new System.Drawing.Point(199, 97);
            this.txtBox_Ad.Name = "txtBox_Ad";
            this.txtBox_Ad.Size = new System.Drawing.Size(129, 38);
            this.txtBox_Ad.TabIndex = 2;
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Location = new System.Drawing.Point(199, 48);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(129, 38);
            this.txtBox_ID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 32);
            this.label7.TabIndex = 26;
            this.label7.Text = "Meslek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Personel ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Medeni Hal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Maas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sehir";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_grafikler);
            this.groupBox2.Controls.Add(this.btn_temizle);
            this.groupBox2.Controls.Add(this.btn_istatistik);
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.btn_listele);
            this.groupBox2.Location = new System.Drawing.Point(506, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 440);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btn_grafikler
            // 
            this.btn_grafikler.Location = new System.Drawing.Point(106, 384);
            this.btn_grafikler.Name = "btn_grafikler";
            this.btn_grafikler.Size = new System.Drawing.Size(138, 45);
            this.btn_grafikler.TabIndex = 15;
            this.btn_grafikler.Text = "Grafikler";
            this.btn_grafikler.UseVisualStyleBackColor = true;
            this.btn_grafikler.Click += new System.EventHandler(this.btn_grafikler_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(106, 262);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(138, 45);
            this.btn_temizle.TabIndex = 13;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.Location = new System.Drawing.Point(106, 329);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(138, 45);
            this.btn_istatistik.TabIndex = 14;
            this.btn_istatistik.Text = "İstatistik";
            this.btn_istatistik.UseVisualStyleBackColor = true;
            this.btn_istatistik.Click += new System.EventHandler(this.btn_istatistik_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(106, 207);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(138, 45);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(106, 152);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(138, 45);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(106, 100);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(138, 45);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(106, 37);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(138, 45);
            this.btn_listele.TabIndex = 9;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1070, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perMedeniDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonellerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 216);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelVeriTabaniDataSet1
            // 
            this.personelVeriTabaniDataSet1.DataSetName = "PersonelVeriTabaniDataSet1";
            this.personelVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonellerBindingSource
            // 
            this.tblPersonellerBindingSource.DataMember = "Tbl_Personeller";
            this.tblPersonellerBindingSource.DataSource = this.personelVeriTabaniDataSet1;
            // 
            // tbl_PersonellerTableAdapter
            // 
            this.tbl_PersonellerTableAdapter.ClearBeforeFill = true;
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMedeniDurumDataGridViewCheckBoxColumn
            // 
            this.perMedeniDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerMedeniDurum";
            this.perMedeniDurumDataGridViewCheckBoxColumn.HeaderText = "PerMedeniDurum";
            this.perMedeniDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perMedeniDurumDataGridViewCheckBoxColumn.Name = "perMedeniDurumDataGridViewCheckBoxColumn";
            this.perMedeniDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1316, 702);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonellerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Sehir;
        private System.Windows.Forms.TextBox txtBox_Meslek;
        private System.Windows.Forms.TextBox txtBox_Soyad;
        private System.Windows.Forms.TextBox txtBox_Ad;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.RadioButton radioBtn_Bekar;
        private System.Windows.Forms.RadioButton radioBtn_Evli;
        private System.Windows.Forms.MaskedTextBox maskedTxtBox_Maas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_istatistik;
        private System.Windows.Forms.Button btn_grafikler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet1 personelVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblPersonellerBindingSource;
        private PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonellerTableAdapter tbl_PersonellerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perMedeniDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
    }
}

