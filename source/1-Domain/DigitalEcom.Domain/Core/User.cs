using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class User
    {
        public User()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }

        public const string SettingsDataKey = "Settings";

        public Guid UserGuid { get; private set; }

        public string FullName { get; private set; }

        public long? VendorId { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }

        public IList<UserAddress> UserAddresses { get; private set; } = new List<UserAddress>();

        public UserAddress DefaultShippingAddress { get; private set; }

        public long? DefaultShippingAddressId { get; private set; }

        public UserAddress DefaultBillingAddress { get; private set; }

        public long? DefaultBillingAddressId { get; private set; }

        public string RefreshTokenHash { get; private set; }

        public IList<UserRole> Roles { get; private set; } = new List<UserRole>();

        public IList<CustomerGroupUser> CustomerGroups { get; private set; } = new List<CustomerGroupUser>();

        public string Culture { get; private set; }

        /// <inheritdoc />
        public string ExtensionData { get; private set; }
    }
}
