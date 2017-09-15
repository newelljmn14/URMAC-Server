using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataModels;

namespace DataAccess.Contexts
{
    public class UrmacContext : DbContext
    {
        public UrmacContext() : base("UrmacContext")
        {
            
        }

        public DbSet<PurchaseInformation> PurchaseInformation { get; set; }
    }
}
