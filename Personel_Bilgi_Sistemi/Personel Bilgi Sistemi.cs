using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Bilgi_Sistemi
{
    public partial class Personel_Bilgi_Sistemi : Form
    {
        public Personel_Bilgi_Sistemi()
        {
            InitializeComponent();
        }

        void FormKontrol(Form form)
        {
            this.Width = form.Width + 22;
            this.Height = form.Height + 68;
            bool gelenFormAcikMi = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == form.Text)
                {
                    form.Activate();
                    gelenFormAcikMi = true;

                }
                else item.Close();
            }

            if (gelenFormAcikMi == false)
            {
                form.MdiParent = this; 
                form.Show();
            }

        }

        ContextSınıfı db = new ContextSınıfı();

        private void Personel_Bilgi_Sistemi_Load(object sender, EventArgs e)
        {
            var objects = db.Departmans.ToList();
        }
        
        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new Personel_Kayıt());
        }

        private void departmanKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new Departman_Kayıt());
        }

        private void personelAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new Personel_Arama());
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "UYARI : Çıkış yapmak üzeresiniz..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
