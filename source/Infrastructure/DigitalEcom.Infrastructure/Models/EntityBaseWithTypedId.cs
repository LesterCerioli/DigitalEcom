using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Infrastructure.Models
{
    public abstract class EntityBaseWithTypedId<TId> : ValidatableObject, IEntityWithTypedId<TId>
    {
        public virtual TId Id { get; protected set; }
    }
}
