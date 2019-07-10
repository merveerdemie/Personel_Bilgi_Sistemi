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
    public partial class Personel_Arama : Form
    {
        public Personel_Arama()
        {
            InitializeComponent();
        }

        ContextSınıfı db = new ContextSınıfı();  
        
        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtAdi.Text)
            {
                if (char.IsDigit(c))
                {
                    txtAdi.Text = txtAdi.Text.Remove(txtAdi.Text.Length - 1);
                    txtAdi.Select(txtAdi.Text.Length, 0);
                }
            }            
        }
        
        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtTcNo.Text)
            {
                if (!char.IsDigit(c))
                {
                    txtTcNo.Text = txtTcNo.Text.Remove(txtTcNo.Text.Length - 1);
                    txtTcNo.Select(txtTcNo.Text.Length, 0);
                }
            }

            if (txtTcNo.TextLength != 11)
            {
                

                if (txtTcNo.Text.Length > 11)
                {
                    txtTcNo.Text = txtTcNo.Text.Remove(txtTcNo.Text.Length - 1);
                    txtTcNo.Select(txtTcNo.Text.Length, 0);
                }
            }

            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lstwArananPersonel.Items.Clear();
            string Ad = txtAdi.Text;
           

            var sorguAd = db.Personels.SingleOrDefault(a => a.Adi == Ad);

            if (sorguAd != null)
            {
                lstwArananPersonel.Items.Add(sorguAd.ID.ToString());
                lstwArananPersonel.Items[0].SubItems.Add(sorguAd.Adi);
                lstwArananPersonel.Items[0].SubItems.Add(sorguAd.Soyadi);
                lstwArananPersonel.Items[0].SubItems.Add(sorguAd.TcKimlikNo);
                lstwArananPersonel.Items[0].SubItems.Add(sorguAd.DogumTarihi.ToString());
                lstwArananPersonel.Items[0].SubItems.Add(sorguAd.Maas.ToString());
                lstwArananPersonel.Items[0].SubItems.Add(sorguAd.DepartmanID.ToString());
                lstwArananPersonel.Items[0].SubItems.Add(sorguAd.Email);
                lstwArananPersonel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else MessageBox.Show(txtAdi.Text+  " adında bir personel yok..");

            


            txtAdi.Text = "";
        }

        private void btnTcAra_Click(object sender, EventArgs e)
        {
            lstwArananPersonel.Items.Clear();

            string TC = txtTcNo.Text;
            var sorguTc = db.Personels.SingleOrDefault(a => a.TcKimlikNo == TC);


            if (sorguTc != null)
            {
                lstwArananPersonel.Items.Add(sorguTc.ID.ToString());
                lstwArananPersonel.Items[0].SubItems.Add(sorguTc.Adi);
                lstwArananPersonel.Items[0].SubItems.Add(sorguTc.Soyadi);
                lstwArananPersonel.Items[0].SubItems.Add(sorguTc.TcKimlikNo);
                lstwArananPersonel.Items[0].SubItems.Add(sorguTc.DogumTarihi.ToString());
                lstwArananPersonel.Items[0].SubItems.Add(sorguTc.Maas.ToString());
                lstwArananPersonel.Items[0].SubItems.Add(sorguTc.DepartmanID.ToString());
                lstwArananPersonel.Items[0].SubItems.Add(sorguTc.Email);
                lstwArananPersonel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else MessageBox.Show(txtTcNo.Text + " Tc numaralı bir personel yok..");

            txtTcNo.Text = "";
        }
    }
    }

