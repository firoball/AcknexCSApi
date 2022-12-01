using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class UIObject : A3Object
    {
        protected int m_pos_x;
        protected int m_pos_y;
        protected int layer;

        public Var Pos_x { get => m_pos_x; set => m_pos_x = value; }
        public Var Pos_y { get => m_pos_y; set => m_pos_y = value; }
        public int Layer { get => layer; set => layer = value; }

        public int Visible { get => IsSet(A3Flags.Visible); set => m_flags = (value != 0) ? Set(A3Flags.Visible) : Reset(A3Flags.Visible); } //M
    }
}
