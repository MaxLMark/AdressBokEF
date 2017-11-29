using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressbokV2.DataContext
{
    public abstract class EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }

    public class Contact : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
       
        public virtual List<Adress> Adresses { get; set; }
        public virtual List<ContactType> ContactTypes { get; set; }
    }

    public class Adress : EntityBase
    {
        public string StreetName { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        public virtual List<Contact> Contacts { get; set; }
    }

    public class ContactType : EntityBase
    {
        public string Name { get; set; }

        public virtual List<Contact> Contacts { get; set; } 
    }
}
