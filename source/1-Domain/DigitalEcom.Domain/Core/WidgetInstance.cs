using DigitalEcom.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class WidgetInstance : EntityBase
    {
        public string Name { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }

        public DateTimeOffset PublishStart { get; private set; }

        public DateTimeOffset PublishEnd { get; private set; }

        public string WidgetId { get; private set; }

        public Widget Widget { get; private set; }

        public int DisplayOrder { get; private set; }

        public string Data { get; private set; }

        public string HtmlData { get; private set; }

        


    }
}
