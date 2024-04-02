using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Ovly : Bitmap
    {
        public Ovly(string name) : base(name, string.Empty) { }
        public Ovly(string name, string file) : base(name, file) { }
        public Ovly(string name, string file, Var x, Var y, Var dx, Var dy) : base(name, file, x, y, dx, dy) { }
    }
}
