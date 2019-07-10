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
    public partial class Departman_Kayıt : Form
    {
        public Departman_Kayıt()
        {
            InitializeComponent();
        }
        ContextSınıfı db = new ContextSınıfı();
        Departman departman = new Departman();

        int GenelID;

        void ListviewDoldurma()
        {
            lstwDepartmanlar.Items.Clear();


            try
            {

                var departmanlar = db.Departmans.Select(s => new { s.DepartmanID, s.DepartmanAdi, s.Aciklama});

                int i = 0;
                foreach (var departman in departmanlar)
                {
                    lstwDepartmanlar.Items.Add(departman.DepartmanID.ToString());
                    lstwDepartmanlar.Items[i].SubItems.Add(departman.DepartmanAdi);
                    lstwDepartmanlar.Items[i].SubItems.Add(departman.Aciklama);
                    

                    i++;

                }
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = " ";
                    }                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Eksik giriş yaptınız.Eksik yerleri doldurunuz!");
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                    departman.DepartmanAdi = txtDepartmanAdi.Text;
                    departman.Aciklama = txtAciklama.Text;

                    db.Departmans.Add(departman);//yeni personeli tablomuza kaydettik
                    db.SaveChanges();//değişiklikleri kaydettik               

                    MessageBox.Show($"{departman.DepartmanAdi} departmanı, departman bilgi sistemine kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListviewDoldurma();
                
              
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Oluşmadı!!!");
            }
            

        }

      
        
        private void txtDepartmanAdi_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtDepartmanAdi.Text)
            {
                if (char.IsDigit(c))
                {
                    txtDepartmanAdi.Text = txtDepartmanAdi.Text.Remove(txtDepartmanAdi.Text.Length - 1);
                    txtDepartmanAdi.Select(txtDepartmanAdi.Text.Length, 0);
                }
            }
        }

        private void btnTumDepartmanlar_Click(object sender, EventArgs e)
        {
            ListviewDoldurma();
        }

        private void lstwDepartmanlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GenelID = Convert.ToInt32(lstwDepartmanlar.SelectedItems[0].SubItems[0].Text);

            txtDepartmanAdi.Text = lstwDepartmanlar.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lstwDepartmanlar.SelectedItems[0].SubItems[2].Text;
          
            txtDepartmanAdi.Focus();

            

        }

        private void lstwDepartmanlar_MouseClick(object sender, MouseEventArgs e)
        {
            GenelID = Convert.ToInt32(lstwDepartmanlar.SelectedItems[0].SubItems[0].Text);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var guncelle_departman = db.Departmans.Where(p => p.DepartmanID == GenelID).FirstOrDefault();
                guncelle_departman.DepartmanAdi = txtDepartmanAdi.Text;
                guncelle_departman.Aciklama = txtAciklama.Text;
                db.SaveChanges();

                ListviewDoldurma();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Yapılmadı!!!");
            }

            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var sil_departman = db.Departmans.Where(p => p.DepartmanID == GenelID).FirstOrDefault();
                db.Departmans.Remove(sil_departman);
                db.SaveChanges();

                ListviewDoldurma();
            }
            catch (Exception)
            {

                MessageBox.Show("Silme işlemi Yapılmadı!!!");
            }
          
        }
    }
}
