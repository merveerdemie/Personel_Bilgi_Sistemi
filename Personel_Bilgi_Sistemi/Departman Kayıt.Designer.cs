namespace Personel_Bilgi_Sistemi
{
    partial class Departman_Kayıt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmanAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstwDepartmanlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTumDepartmanlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.LightPink;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "DEPARTMAN ADI :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.LightPink;
            this.label3.Location = new System.Drawing.Point(76, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "AÇIKLAMA :";
            // 
            // txtDepartmanAdi
            // 
            this.txtDepartmanAdi.Location = new System.Drawing.Point(200, 81);
            this.txtDepartmanAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepartmanAdi.Name = "txtDepartmanAdi";
            this.txtDepartmanAdi.Size = new System.Drawing.Size(195, 26);
            this.txtDepartmanAdi.TabIndex = 2;
            this.txtDepartmanAdi.TextChanged += new System.EventHandler(this.txtDepartmanAdi_TextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(200, 127);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(195, 239);
            this.txtAciklama.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightPink;
            this.label4.Location = new System.Drawing.Point(345, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "DEPARTMAN KAYIT";
            // 
            // lstwDepartmanlar
            // 
            this.lstwDepartmanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstwDepartmanlar.FullRowSelect = true;
            this.lstwDepartmanlar.GridLines = true;
            this.lstwDepartmanlar.Location = new System.Drawing.Point(402, 81);
            this.lstwDepartmanlar.Name = "lstwDepartmanlar";
            this.lstwDepartmanlar.Size = new System.Drawing.Size(621, 329);
            this.lstwDepartmanlar.TabIndex = 0;
            this.lstwDepartmanlar.UseCompatibleStateImageBehavior = false;
            this.lstwDepartmanlar.View = System.Windows.Forms.View.Details;
            this.lstwDepartmanlar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstwDepartmanlar_MouseClick);
            this.lstwDepartmanlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstwDepartmanlar_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DEPARTMAN ADI";
            this.columnHeader2.Width = 252;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "AÇIKLAMA";
            this.columnHeader3.Width = 313;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightPink;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Brown;
            this.btnKaydet.Image = global::Personel_Bilgi_Sistemi.Properties.Resources.kaydet_icon_png_5_FPz_icon;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(132, 437);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(136, 44);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.LightPink;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.Brown;
            this.btnGüncelle.Image = global::Personel_Bilgi_Sistemi.Properties.Resources._6_128_2Q1_icon;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.Location = new System.Drawing.Point(295, 437);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(168, 44);
            this.btnGüncelle.TabIndex = 5;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightPink;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Brown;
            this.btnSil.Image = global::Personel_Bilgi_Sistemi.Properties.Resources.indir_DBX_icon;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(819, 437);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(141, 44);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTumDepartmanlar
            // 
            this.btnTumDepartmanlar.BackColor = System.Drawing.Color.LightPink;
            this.btnTumDepartmanlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTumDepartmanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumDepartmanlar.ForeColor = System.Drawing.Color.Brown;
            this.btnTumDepartmanlar.Image = global::Personel_Bilgi_Sistemi.Properties.Resources.man_icon_mzo_icon;
            this.btnTumDepartmanlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTumDepartmanlar.Location = new System.Drawing.Point(504, 437);
            this.btnTumDepartmanlar.Name = "btnTumDepartmanlar";
            this.btnTumDepartmanlar.Size = new System.Drawing.Size(260, 44);
            this.btnTumDepartmanlar.TabIndex = 5;
            this.btnTumDepartmanlar.Text = "TÜM DEPARTMANLAR";
            this.btnTumDepartmanlar.UseVisualStyleBackColor = false;
            this.btnTumDepartmanlar.Click += new System.EventHandler(this.btnTumDepartmanlar_Click);
            // 
            // Departman_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 692);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTumDepartmanlar);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstwDepartmanlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtDepartmanAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Departman_Kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Departman_Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmanAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstwDepartmanlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTumDepartmanlar;
    }
}