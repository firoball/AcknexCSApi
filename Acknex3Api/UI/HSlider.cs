using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Hslider : Slider
    {
        public Hslider(Var x, Var y, Var len, Bmap bmap, Func<Skill> skill) : base(x, y, len, bmap, skill) { }
    }
}
