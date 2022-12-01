using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Overlay : UIObject
    {
        private Var m_cycles;
        private Var m_sides;
        private Ovly[] m_ovlys;
        private int[] m_delay;
        private Var m_side; //M
        private int[] m_offset_x;
        private int[] m_offset_y;
        private Var m_size_x; //R
        private Var m_size_y; //R

        public Overlay() : base() { }

        public Var Cycles { get => m_cycles; set => m_cycles = value; }
        public Var Sides { get => m_sides; set => m_sides = value; }
        public Ovly[] Ovlys { get => m_ovlys; set => m_ovlys = value; }
        public int[] Delay { get => m_delay; set => m_delay = value; }
        public Var Side { get => m_side; set => m_side = value; }
        public int[] Offset_x { get => m_offset_x; set => m_offset_x = value; }
        public int[] Offset_y { get => m_offset_y; set => m_offset_y = value; }
        public Var Size_x { get => m_size_x; set => m_size_x = value; }
        public Var Size_y { get => m_size_y; set => m_size_y = value; }

        public int Abspos { get => IsSet(A3Flags.Abspos); set => m_flags = (value != 0) ? Set(A3Flags.Abspos) : Reset(A3Flags.Abspos); }
    }
}
