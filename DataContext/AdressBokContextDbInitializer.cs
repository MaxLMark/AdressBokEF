using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdressbokV2.Models;

namespace AdressbokV2.DataContext
{
    public class AdressBokContextDbInitializer : DropCreateDatabaseIfModelChanges<AdressBokContext>
    {
        protected override void Seed(AdressBokContext context)
        {
            base.Seed(context);
          
            context.SaveChanges();
        }
    }
}
