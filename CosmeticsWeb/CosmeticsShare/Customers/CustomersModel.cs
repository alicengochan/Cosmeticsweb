using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmeticsShare;
namespace CosmeticsShare.Customers
{
    public class CustomersModel : BaseModels
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string Identity { get; set; }
        public bool Gender { get; set; }
        public string Active { get; set; }
        public bool MarialStatus { get; set; }
        public bool FrequentMember { get; set; } 
        public DateTime DateFrequentMember { get; set; }

    }
}
