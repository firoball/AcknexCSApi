using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Ovly : Bitmap
    {
        public Ovly(string file) : base(file) { }
        public Ovly(string file, Var x, Var y, Var dx, Var dy) : base(file, x, y, dx, dy) { }
    }
}
