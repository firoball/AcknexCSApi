using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Overlay : UIObject
    {
        private Var pos_x; //M
        private Var pos_y; //M
        private Var cycles;
        private Var sides;
        private Ovly[] ovlys;
        private Var[] delay;
        private Var side; //M
        private Var[] offset_x;
        private Var[] offset_y;
        private Var size_x; //R
        private Var size_y; //R

        public Var Pos_x { get => pos_x; set => pos_x = value; }
        public Var Pos_y { get => pos_y; set => pos_y = value; }
        public Var Cycles { get => cycles; set => cycles = value; }
        public Var Sides { get => sides; set => sides = value; }
        public Ovly[] Ovlys { get => ovlys; set => ovlys = value; }
        public Var[] Delay { get => delay; set => delay = value; }
        public Var Side { get => side; set => side = value; }
        public Var[] Offset_x { get => offset_x; set => offset_x = value; }
        public Var[] Offset_y { get => offset_y; set => offset_y = value; }
        public Var Size_x { get => size_x; set => size_x = value; }
        public Var Size_y { get => size_y; set => size_y = value; }

        public int Abspos { get => IsSet(A3Flags.Abspos); set => m_flags = (value != 0) ? Set(A3Flags.Abspos) : Reset(A3Flags.Abspos); }
    }
}
