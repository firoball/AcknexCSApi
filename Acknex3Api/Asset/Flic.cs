using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Flic : Asset
    {
        public Flic(string name) : base(name, string.Empty) { }
        public Flic(string name, string file) : base(name, file) { }
    }
}
