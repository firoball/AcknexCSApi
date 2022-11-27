using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Palette : A3Object
    {
        private string m_palfile;
        private string m_anifile;
        private int[,] m_range;
        private int[,,,] m_anicolor;
        private Var m_cycle;

        public Palette() : base() { }

        public string Palfile { get => m_palfile; set => m_palfile = value; }
        public string Anifile { get => m_anifile; set => m_anifile = value; }
        public int[,] Range { get => m_range; set => m_range = value; }
        public int[,,,] Anicolor { get => m_anicolor; set => m_anicolor = value; }
        public Var Cycle { get => m_cycle; set => m_cycle = value; }
        public int Hard { get => IsSet(A3Flags.Hard); set => m_flags = (value != 0) ? Set(A3Flags.Hard) : Reset(A3Flags.Hard); }
        public int Autorange { get => IsSet(A3Flags.Autorange); set => m_flags = (value != 0) ? Set(A3Flags.Autorange) : Reset(A3Flags.Autorange); }
        public int Blur { get => IsSet(A3Flags.Blur); set => m_flags = (value != 0) ? Set(A3Flags.Blur) : Reset(A3Flags.Blur); }
    }
}
