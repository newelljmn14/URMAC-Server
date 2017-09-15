using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DataAccess.DataModels
{
    public class Receipt
    {
        public User User;
        public Image Image;
        public DateTime TimeCreated;
        public PurchaseInformation PurchaseInformation;
    }
}
