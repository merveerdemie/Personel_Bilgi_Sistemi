using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Bilgi_Sistemi
{
    
   public class OrtakMetotlar
    {
        public void Cikis()
        {

            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "UYARI : Çıkış yapmak üzeresiniz..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        

        
    }

    


}
