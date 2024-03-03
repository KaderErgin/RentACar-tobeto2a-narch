//using NArchitecture.Core.Persistence.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Domain.Entities;
//public class CorporateCustomer : Entity<Guid>
//{
//    public CorporateCustomer(string companyName, string taxNo, Guid customerId)//Guid customerId
//    {
//        CompanyName = companyName;
//        TaxNo = taxNo;
//        CustomerId = customerId;
//    }
//    public CorporateCustomer()
//    {

//    }
//    //eski hali//public int CustomerId { get; set; }
//    public Guid CustomerId { get; set; } //yeni eklenen
//    public string CompanyName { get; set; }
//    public string TaxNo { get; set; }
//    public Customer? Customer { get; set; } = null;
//}
using NArchitecture.Core.Persistence.Repositories;
using System;

namespace Domain.Entities
{
    public class CorporateCustomer : Entity<Guid>
    {
        public CorporateCustomer()
        {
        }

        public Guid CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public Customer? Customer { get; set; } = null;
    }
}


