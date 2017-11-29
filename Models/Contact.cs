using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressbokV2.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string ContactType { get; set; }

        public string ContactName { get; set; }

        public string StreetName { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

       
    }
}  
