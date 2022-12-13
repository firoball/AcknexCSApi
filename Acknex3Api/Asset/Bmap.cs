using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Bmap : Bitmap
    {
        public Bmap(string file) : base(file) { }
        public Bmap(string file, Var x, Var y, Var dx, Var dy) : base(file, x, y, dx, dy) { }
    }
}
