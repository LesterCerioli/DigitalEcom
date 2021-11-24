using DigitalEcom.Domain.ValueObjects;
using DigitalEcom.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class Vendor : EntityBase
    {
        
        public Vendor()
        {
            CreatedOn = DateTimeOffset.Now;
        }
        
        public Name Name { get; private set; }

        public string Slug { get; private set; }

        public string Description { get; set; }

        public Email Email { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }

        public bool IsActive { get; private set; }

        public bool IsDeleted { get; private set; }

        public IList<User> Users { get; private set; }
    }
}
