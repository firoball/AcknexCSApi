using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Model : Asset
    {
        public Model(string name) : base(name, string.Empty) { }
        public Model(string name, string file) : base(name, file) { }
    }
}
