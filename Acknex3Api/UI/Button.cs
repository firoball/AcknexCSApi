using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Button : UIControl
    {
        private readonly Bmap m_bmap_on;
        private readonly Bmap m_bmap_off;
        private readonly Function m_action_on;
        private readonly Function m_action_off;

        public Button(Var x, Var y, Bmap bmap_on, Bmap bmap_off, Function action_on, Function action_off) : base(x, y)
        {
            m_bmap_on = bmap_on;
            m_bmap_off = bmap_off;
            m_action_on = action_on;
            m_action_off = action_off;
        }
    }
}
