using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataModels
{
    public class PurchaseInformation
    {
        public int Id { get; set; }
        public string Vendor { get; set; }
        public DateTime TimeOfPurchase { get; set; }
        public string Location { get; set; }
    }
}
