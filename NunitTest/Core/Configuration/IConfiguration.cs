﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configuration
{
    internal interface IConfiguration
    {
        public string SectionName=>throw new NotImplementedException();
    }
}
