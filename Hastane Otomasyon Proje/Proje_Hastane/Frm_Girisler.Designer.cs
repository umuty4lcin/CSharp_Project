namespace Proje_Hastane
{
    partial class Frm_Girisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Girisler));
            this.btn_HastaGiris = new System.Windows.Forms.Button();
            this.btn_DoktorGiris = new System.Windows.Forms.Button();
            this.btn_SekreterGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_HastaGiris
            // 
            this.btn_HastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HastaGiris.BackgroundImage")));
            this.btn_HastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HastaGiris.Location = new System.Drawing.Point(12, 94);
            this.btn_HastaGiris.Name = "btn_HastaGiris";
            this.btn_HastaGiris.Size = new System.Drawing.Size(155, 122);
            this.btn_HastaGiris.TabIndex = 0;
            this.btn_HastaGiris.UseVisualStyleBackColor = true;
            this.btn_HastaGiris.Click += new System.EventHandler(this.btn_HastaGiris_Click);
            // 
            // btn_DoktorGiris
            // 
            this.btn_DoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DoktorGiris.BackgroundImage")));
            this.btn_DoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DoktorGiris.Location = new System.Drawing.Point(208, 94);
            this.btn_DoktorGiris.Name = "btn_DoktorGiris";
            this.btn_DoktorGiris.Size = new System.Drawing.Size(155, 122);
            this.btn_DoktorGiris.TabIndex = 1;
            this.btn_DoktorGiris.UseVisualStyleBackColor = true;
            this.btn_DoktorGiris.Click += new System.EventHandler(this.btn_DoktorGiris_Click);
            // 
            // btn_SekreterGiris
            // 
            this.btn_SekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SekreterGiris.BackgroundImage")));
            this.btn_SekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SekreterGiris.Location = new System.Drawing.Point(410, 94);
            this.btn_SekreterGiris.Name = "btn_SekreterGiris";
            this.btn_SekreterGiris.Size = new System.Drawing.Size(155, 122);
            this.btn_SekreterGiris.TabIndex = 2;
            this.btn_SekreterGiris.UseVisualStyleBackColor = true;
            this.btn_SekreterGiris.Click += new System.EventHandler(this.btn_SekreterGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(129, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hastane Giriş Paneline";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SekreterGiris);
            this.Controls.Add(this.btn_DoktorGiris);
            this.Controls.Add(this.btn_HastaGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_Girisler";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Girisler_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HastaGiris;
        private System.Windows.Forms.Button btn_DoktorGiris;
        private System.Windows.Forms.Button btn_SekreterGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

