using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Personel_Bilgi_Sistemi
{
   public class Personel
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30)]
        [Required]
        public string Adi { get; set; }

        [MaxLength(50)]
        [Required]
        public string Soyadi { get; set; }
        
        [MaxLength(11)]      
        [MinLength(11)]
        [Required]
        public string TcKimlikNo { get; set; }


        public DateTime? DogumTarihi { get; set; }

        [Required]
        public decimal Maas { get; set; }

        [Required]
        public int DepartmanID { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        public Departman Departman { get; set; }


    }
}
