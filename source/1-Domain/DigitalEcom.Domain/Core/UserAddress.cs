using DigitalEcom.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class UserAddress : EntityBase
    {
        public long UserId { get; private set; }

        public User User { get; private set; }

        public long AddressId { get; private set; }

        public Address Address { get; private set; }

        public AddressType AddressType { get; set; }

        public DateTimeOffset? LastUsedOn { get; set; }
    }
}
