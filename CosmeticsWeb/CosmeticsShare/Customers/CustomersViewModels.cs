using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShare.Customers
{
   public class CustomersViewModels
    {
        public List<CustomersModel> Listcustomers { get; set; }
        public CustomersViewModels()
        {
            Listcustomers = new List<CustomersModel>();
        }
    }
}
