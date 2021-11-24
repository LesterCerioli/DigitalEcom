using DigitalEcom.Infrastructure.Models;

namespace DigitalEcom.Domain.Core
{
    public class Entity : EntityBase
    {
        public string Slug { get; private set; }

        public string Name { get; private set; }

        public long EntityId { get; private set; }

        public string EntityTypeId { get; private set; }

        public EntityType EntityType { get; private set; }
    }
}