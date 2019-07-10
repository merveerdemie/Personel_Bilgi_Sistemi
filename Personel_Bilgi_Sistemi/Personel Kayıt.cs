using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Bilgi_Sistemi
{
    public partial class Personel_Kayıt : Form
    {
        public Personel_Kayıt()
        {
            InitializeComponent();
        }

        ContextSınıfı db = new ContextSınıfı();
        Personel personel = new Personel();
        int GenelID;

        void ListviewDoldurma()
        {
            lstwPersonelGiris.Items.Clear();
            

            try
            {

                var personeller = db.Personels.Select(s => new { s.ID, s.Adi, s.Soyadi, s.TcKimlikNo,s.DogumTarihi,s.Maas,s.DepartmanID,s.Email });

                int i = 0;
                foreach (var personel in personeller)
                {
                    lstwPersonelGiris.Items.Add(personel.ID.ToString());
                    lstwPersonelGiris.Items[i].SubItems.Add(personel.Adi);
                    lstwPersonelGiris.Items[i].SubItems.Add(personel.Soyadi);
                    lstwPersonelGiris.Items[i].SubItems.Add(personel.TcKimlikNo);
                    lstwPersonelGiris.Items[i].SubItems.Add(personel.DogumTarihi.ToString());
                    lstwPersonelGiris.Items[i].SubItems.Add(personel.Maas.ToString());
                    lstwPersonelGiris.Items[i].SubItems.Add(personel.DepartmanID.ToString());
                    lstwPersonelGiris.Items[i].SubItems.Add(personel.Email.ToString());
                    
                    i++;

                }

                lstwPersonelGiris.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = " ";
                    }
                    else if (ctrl is DateTimePicker)
                    {
                        ctrl.Text = DateTime.Now.ToString();
                    }
                    
                }
                nudMaas.Value = 0;
            }

            catch (Exception)
            {

                MessageBox.Show("Eksik giriş yaptınız.Eksik yerleri doldurunuz!");
            }
        }

        private void Personel_Kayıt_Load(object sender, EventArgs e)
        {
            cmbDepartman.DisplayMember = "DepartmanID";
            cmbDepartman.DataSource = db.Departmans.ToList();

            
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                personel.Adi = txtPersonelAdi.Text;
                personel.Soyadi = txtPersonelSoyadı.Text;
                personel.TcKimlikNo = txtPersonelTcKimlik.Text;
                personel.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
                personel.Maas = Convert.ToDecimal(nudMaas.Text);
                personel.DepartmanID = int.Parse(cmbDepartman.Text);
                personel.Email = txtMail.Text;

                db.Personels.Add(personel);//yeni personeli tablomuza kaydettik
                db.SaveChanges();//değişiklikleri kaydettik

                MessageBox.Show($"{personel.Adi} {personel.Soyadi} kişisi Personel Bilgi Sistemine Kaydedilmiştir.");

                ListviewDoldurma();
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Oluşmadı!!!");
            }
            
        }
        

        private void txtPersonelAdi_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtPersonelAdi.Text)
            {
                if (char.IsDigit(c))
                {

                    txtPersonelAdi.Text = txtPersonelAdi.Text.Remove(txtPersonelAdi.Text.Length - 1);
                    txtPersonelAdi.Select(txtPersonelAdi.Text.Length, 0);//imleci sonda tutuyor

                }
            }

        }

        private void txtPersonelSoyadı_TextChanged(object sender, EventArgs e)
        {

            foreach (char c in txtPersonelSoyadı.Text)
            {
                if (char.IsDigit(c))
                {

                    txtPersonelSoyadı.Text = txtPersonelSoyadı.Text.Remove(txtPersonelSoyadı.Text.Length - 1);
                    txtPersonelSoyadı.Select(txtPersonelSoyadı.Text.Length, 0);

                }
            }
        }

        private void txtPersonelTcKimlik_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtPersonelTcKimlik.Text)
            {
                if (!char.IsDigit(c))
                {

                    txtPersonelTcKimlik.Text = txtPersonelTcKimlik.Text.Remove(txtPersonelTcKimlik.Text.Length - 1);
                    txtPersonelTcKimlik.Select(txtPersonelTcKimlik.Text.Length, 0);

                }
                if (txtPersonelTcKimlik.TextLength != 11)
                {
                    errorProvider1.SetError(txtPersonelTcKimlik, "Bu alan 11 haneli olmalı");

                    if (txtPersonelTcKimlik.Text.Length > 11)
                    {
                        txtPersonelTcKimlik.Text = txtPersonelTcKimlik.Text.Remove(txtPersonelTcKimlik.Text.Length - 1);
                        txtPersonelTcKimlik.Select(txtPersonelTcKimlik.Text.Length, 0);
                    }
                }

                else errorProvider1.Clear();
            }


        }
        
        
        private void btnTümPersoneller_Click(object sender, EventArgs e)
        {

            ListviewDoldurma();

            
        }

        private void lstwPersonelGiris_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GenelID = Convert.ToInt32(lstwPersonelGiris.SelectedItems[0].SubItems[0].Text);

            txtPersonelAdi.Text = lstwPersonelGiris.SelectedItems[0].SubItems[1].Text;
            txtPersonelSoyadı.Text = lstwPersonelGiris.SelectedItems[0].SubItems[2].Text;
            txtPersonelTcKimlik.Text = lstwPersonelGiris.SelectedItems[0].SubItems[3].Text;
            dtpDogumTarihi.Text = lstwPersonelGiris.SelectedItems[0].SubItems[4].Text;
            nudMaas.Value = decimal.Parse(lstwPersonelGiris.SelectedItems[0].SubItems[5].Text);
            cmbDepartman.Text = lstwPersonelGiris.SelectedItems[0].SubItems[6].Text;
            txtMail.Text = lstwPersonelGiris.SelectedItems[0].SubItems[7].Text;
            txtPersonelAdi.Focus();


        }

        private void lstwPersonelGiris_MouseClick(object sender, MouseEventArgs e)
        {
            GenelID = Convert.ToInt32(lstwPersonelGiris.SelectedItems[0].SubItems[0].Text);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var guncelle_personel = db.Personels.Where(p => p.ID == GenelID).FirstOrDefault();

                guncelle_personel.Adi = txtPersonelAdi.Text;
                guncelle_personel.Soyadi = txtPersonelSoyadı.Text;
                guncelle_personel.TcKimlikNo = txtPersonelTcKimlik.Text;
                guncelle_personel.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
                guncelle_personel.Maas = Convert.ToDecimal(nudMaas.Text);
                guncelle_personel.DepartmanID = int.Parse(cmbDepartman.Text);
                guncelle_personel.Email = txtMail.Text;
                db.SaveChanges();

                ListviewDoldurma();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Gerçekleşmedi!!");
            }
            
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var sil_personel = db.Personels.Where(p => p.ID == GenelID).FirstOrDefault();

                db.Personels.Remove(sil_personel);
                db.SaveChanges();

                ListviewDoldurma();
            }
            catch (Exception)
            {

                MessageBox.Show("Silme işlemi Gerçekleşmedi!!");
            }            
        }
       
        private void nudMaas_ValueChanged(object sender, EventArgs e)
        {
            foreach (char c in nudMaas.Text)
            {
                if (!char.IsDigit(c))
                {
                    nudMaas.Text = nudMaas.Text.Remove(nudMaas.Text.Length - 1);
                    nudMaas.Select(nudMaas.Text.Length, 0);

                }
            }
        }

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int Id = int.Parse(cmbDepartman.Text);
            var sorgu = db.Departmans.SingleOrDefault(r => r.DepartmanID == Id);

            if (sorgu != null)
            {
                lblDAdi.Text = sorgu.DepartmanAdi;
                
            }

        }

            
    }
}
