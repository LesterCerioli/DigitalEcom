using DigitalEcom.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class AppSetting : EntityBaseWithTypedId<string>
    {
        public AppSetting(string value, string module, bool isVisibleInCommonSettingPage)
        {
            Value = value;
            Module = module;
            IsVisibleInCommonSettingPage = isVisibleInCommonSettingPage;
        }

        public string Value { get; private set; }

        public string Module { get; private set; }

        public bool IsVisibleInCommonSettingPage { get; private set; }
    }
}
