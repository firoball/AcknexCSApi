using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Digits : UIControl
    {
        private Var m_len;
        private readonly Font m_font;
        private Var m_fac;
        
        public Digits(Var x, Var y, Var len, Font font, Var fac, Func<Var> var) : base(x, y, var)
        {
            m_len = len;
            m_font = font;
            m_fac = fac;
        }

    }
}
