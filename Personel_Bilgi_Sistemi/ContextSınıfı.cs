using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Bilgi_Sistemi
{
    public class ContextSınıfı:DbContext
    {
        public ContextSınıfı(): base("PersonelBilgiSistemiCon")
        {
            Database.SetInitializer<ContextSınıfı>(new DropCreateDatabaseIfModelChanges<ContextSınıfı>());
        }

        public DbSet<Departman> Departmans { get; set; }

        public DbSet<Personel> Personels { get; set; }

    }
}
