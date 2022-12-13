using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public abstract class Slider : UIControl
    {
        private Var m_len;
        private readonly Bmap m_bmap;

        public Slider(Var x, Var y, Var len, Bmap bmap, Func<Skill> skill) : base (x, y, skill)
        {
            m_len = len;
            m_bmap = bmap;
        }
    }
}
