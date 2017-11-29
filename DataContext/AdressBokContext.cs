using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AdressbokV2.DataContext
{
    public class AdressBokContext : DbContext
    {

  
        public AdressBokContext()
            : base("name=AdressBokContext")
        {
            Database.SetInitializer<AdressBokContext>(new AdressBokContextDbInitializer());
        }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
    
    }
    
}
