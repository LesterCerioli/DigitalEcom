using DigitalEcom.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class CustomerGroup : EntityBase
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public bool IsActive { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }

        public IList<CustomerGroupUser> Users { get; private set; } = new List<CustomerGroupUser>();
    }
}
