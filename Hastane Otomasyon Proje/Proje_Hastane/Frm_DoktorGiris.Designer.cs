namespace Proje_Hastane
{
    partial class Frm_DoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoktorGiris));
            this.btn_HastaGiris = new System.Windows.Forms.Button();
            this.mskTxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_Sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_HastaGiris
            // 
            this.btn_HastaGiris.Location = new System.Drawing.Point(248, 224);
            this.btn_HastaGiris.Name = "btn_HastaGiris";
            this.btn_HastaGiris.Size = new System.Drawing.Size(115, 39);
            this.btn_HastaGiris.TabIndex = 2;
            this.btn_HastaGiris.Text = "Giriş Yap";
            this.btn_HastaGiris.UseVisualStyleBackColor = true;
            this.btn_HastaGiris.Click += new System.EventHandler(this.btn_HastaGiris_Click);
            // 
            // mskTxt_TC
            // 
            this.mskTxt_TC.Location = new System.Drawing.Point(204, 111);
            this.mskTxt_TC.Mask = "00000000000";
            this.mskTxt_TC.Name = "mskTxt_TC";
            this.mskTxt_TC.Size = new System.Drawing.Size(159, 31);
            this.mskTxt_TC.TabIndex = 0;
            this.mskTxt_TC.ValidatingType = typeof(int);
            // 
            // txtBox_Sifre
            // 
            this.txtBox_Sifre.Location = new System.Drawing.Point(204, 157);
            this.txtBox_Sifre.Name = "txtBox_Sifre";
            this.txtBox_Sifre.Size = new System.Drawing.Size(159, 31);
            this.txtBox_Sifre.TabIndex = 1;
            this.txtBox_Sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Location = new System.Drawing.Point(12, 251);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(122, 46);
            this.btn_GeriDon.TabIndex = 3;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(204, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Frm_DoktorGiris
            // 
            this.AcceptButton = this.btn_HastaGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(443, 309);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_GeriDon);
            this.Controls.Add(this.btn_HastaGiris);
            this.Controls.Add(this.mskTxt_TC);
            this.Controls.Add(this.txtBox_Sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_DoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DoktorGiris_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HastaGiris;
        private System.Windows.Forms.MaskedTextBox mskTxt_TC;
        private System.Windows.Forms.TextBox txtBox_Sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}