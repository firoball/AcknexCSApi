using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Vslider : Slider
    {
        public Vslider(Var x, Var y, Var len, Bmap bmap, Func<Var> v) : base(x, y, len, bmap, v) { }
    }
}
