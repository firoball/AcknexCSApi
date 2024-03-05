using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Bmap : Bitmap
    {
        public Bmap(string name, string file) : base(name, file) { }
        public Bmap(string name, string file, Var x, Var y, Var dx, Var dy) : base(name, file, x, y, dx, dy) { }
    }
}
