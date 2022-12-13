using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public abstract class Bar : UIControl
    {
        private Var m_len;
        private readonly Bmap m_bmap;
        private Var m_fac;

        public Bar(Var x, Var y, Var len, Bmap bmap, Var fac, Func<Var> var) : base(x, y, var)
        {
            m_len = len;
            m_bmap = bmap;
            m_fac = fac;
        }
    }
}
