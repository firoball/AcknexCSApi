using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Window : UIControl
    {
        private Var m_dx;
        private Var m_dy;
        private readonly Bmap m_bmap;
        private readonly Func<Var> m_monitor_x;
        private readonly Func<Var> m_monitor_y;
        private Var m_var_x;
        private Var m_var_y;

        public Window(Var x, Var y, Var dx, Var dy, Bmap bmap, Func<Var> var_x, Func<Var> var_y) : base(x, y)
        {
            m_dx = dx;
            m_dy = dy;
            m_bmap = bmap;
            m_monitor_x = var_x;
            m_monitor_y = var_y;
        }

        public override void Update()
        {
            base.Update();
            m_var_x = m_monitor_x();
            m_var_y = m_monitor_y();
        }
    }
}
