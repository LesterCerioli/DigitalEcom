using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Infrastructure.Models
{
    internal interface IEntityWithTypedId<TId>
    {
        TId Id { get; }
    }
}
