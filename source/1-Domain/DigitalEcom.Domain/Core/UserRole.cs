using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class UserRole
    {
        public override long UserId { get; private set; }

        public User User { get; private set; }

        public override long RoleId { get; private set; }

        public Role Role { get; private set; }
    }
}
