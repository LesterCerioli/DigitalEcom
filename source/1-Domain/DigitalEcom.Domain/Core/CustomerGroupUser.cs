using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class CustomerGroupUser
    {
        public CustomerGroupUser(long userId, User user, long customerGroupId, CustomerGroup customerGroup)
        {
            UserId = userId;
            User = user;
            CustomerGroupId = customerGroupId;
            CustomerGroup = customerGroup;
        }

        public long UserId { get; private set; }

        public User User { get; private set; }

        public long CustomerGroupId { get; private set; }

        public CustomerGroup CustomerGroup { get; private set; }
    }
}
