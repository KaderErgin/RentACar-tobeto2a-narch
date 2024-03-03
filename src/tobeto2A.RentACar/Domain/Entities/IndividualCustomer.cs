//using NArchitecture.Core.Persistence.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


using NArchitecture.Core.Persistence.Repositories;
using System;

namespace Domain.Entities
{
    public class IndividualCustomer : Entity<Guid>
    {
        public IndividualCustomer()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; } = null;
    }
}
