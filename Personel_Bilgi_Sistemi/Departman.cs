using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Bilgi_Sistemi
{
    public class Departman
    {
        [Key]

        public int DepartmanID { get; set; }
        [MaxLength(50)]
        [Required]
        public string DepartmanAdi { get; set; }
       
        public string Aciklama { get; set; }


        public List<Personel> Personels { get; set; }

    }
}
