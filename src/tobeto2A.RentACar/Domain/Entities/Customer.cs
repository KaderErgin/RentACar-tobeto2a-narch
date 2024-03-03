
using NArchitecture.Core.Persistence.Repositories;
using System;

namespace Domain.Entities
{
    public class Customer : Entity<Guid>
    {
        public Customer()
        {
        }

        public User? User { get; set; } = null;
        public IndividualCustomer? IndividualCustomer { get; set; } = null;
        public CorporateCustomer? CorporateCustomer { get; set; } = null;
    }
}

