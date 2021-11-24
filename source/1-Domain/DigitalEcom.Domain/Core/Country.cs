﻿using DigitalEcom.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEcom.Domain.Core
{
    public class Country : EntityBase
    {
        public Country(long id)
        {
            Id = id;
        }

        
        public string Name { get; private set; }

        public string Code3 { get; private set; }

        public bool IsBillingEnabled { get; private set; }

        public bool IsShippingEnabled { get; private set; }

        public bool IsCityEnabled { get; private set; } = true;

        public bool IsZipCodeEnabled { get; private set; } = true;

        public bool IsDistrictEnabled { get; private set; } = true;

        public IList<StateOrProvince> StatesOrProvinces { get; private set; } = new List<StateOrProvince>();
    }
}
