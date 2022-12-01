using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class VBar : Bar
    {
        public VBar(Var x, Var y, Var len, Bmap bmap, Var fac, Func<Var> var) : base(x, y, len, bmap, fac, var) { }
    }
}
