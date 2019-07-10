namespace Personel_Bilgi_Sistemi
{
    partial class Personel_Arama
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
            this.label13 = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lstwArananPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTcAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label13.Location = new System.Drawing.Point(323, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 46);
            this.label13.TabIndex = 8;
            this.label13.Text = "PERSONEL ARAMA";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.BackColor = System.Drawing.Color.Transparent;
            this.lblAD.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAD.Location = new System.Drawing.Point(131, 69);
            this.lblAD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(56, 25);
            this.lblAD.TabIndex = 9;
            this.lblAD.Text = "ADI :";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTC.Location = new System.Drawing.Point(35, 273);
            this.lblTC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(152, 25);
            this.lblTC.TabIndex = 9;
            this.lblTC.Text = "TC KİMLİK NO:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(222, 64);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(176, 30);
            this.txtAdi.TabIndex = 10;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(222, 268);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(176, 30);
            this.txtTcNo.TabIndex = 10;
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnAra.Image = global::Personel_Bilgi_Sistemi.Properties.Resources.Zerode_Plump_Search;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(222, 123);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(176, 48);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Personel Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lstwArananPersonel
            // 
            this.lstwArananPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstwArananPersonel.GridLines = true;
            this.lstwArananPersonel.Location = new System.Drawing.Point(428, 64);
            this.lstwArananPersonel.Name = "lstwArananPersonel";
            this.lstwArananPersonel.Size = new System.Drawing.Size(725, 381);
            this.lstwArananPersonel.TabIndex = 13;
            this.lstwArananPersonel.UseCompatibleStateImageBehavior = false;
            this.lstwArananPersonel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TcKimlikNo";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doğum Tarihi";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Maaş";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "DepartmanAdı";
            this.columnHeader7.Width = 177;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.Width = 184;
            // 
            // btnTcAra
            // 
            this.btnTcAra.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTcAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTcAra.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnTcAra.Image = global::Personel_Bilgi_Sistemi.Properties.Resources.Zerode_Plump_Search;
            this.btnTcAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTcAra.Location = new System.Drawing.Point(222, 331);
            this.btnTcAra.Name = "btnTcAra";
            this.btnTcAra.Size = new System.Drawing.Size(176, 48);
            this.btnTcAra.TabIndex = 12;
            this.btnTcAra.Text = "Personel Ara";
            this.btnTcAra.UseVisualStyleBackColor = false;
            this.btnTcAra.Click += new System.EventHandler(this.btnTcAra_Click);
            // 
            // Personel_Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 488);
            this.Controls.Add(this.lstwArananPersonel);
            this.Controls.Add(this.btnTcAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Personel_Arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personel Arama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListView lstwArananPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnTcAra;
    }
}