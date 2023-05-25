using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configuration
{
   public class BrowserConfiguration : IConfiguration

    {
        public string Name => "Browser";

        public bool Headless { get; set; }

        public string TypeBrowser { get; set; }
    }
}
