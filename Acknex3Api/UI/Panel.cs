using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Panel : UIObject
    {
        private Bmap m_pan_map;
        private Bmap m_target_map;
        private UIControl[] m_controls;
        private Overlay m_mask;
        private Overlay m_msprite;
        private Function m_if_klick; //M

        public Panel() : base() { }

        public Bmap Pan_map { get => m_pan_map; set => m_pan_map = value; }
        public Bmap Target_map { get => m_target_map; set => m_target_map = value; }
        public UIControl[] Controls { get => m_controls; set => m_controls = value; }
        public Overlay Mask { get => m_mask; set => m_mask = value; }
        public Overlay Msprite { get => m_msprite; set => m_msprite = value; }
        public Function If_klick { get => m_if_klick; set => m_if_klick = value; }

        public int Transparent { get => IsSet(A3Flags.Transparent); set => m_flags = (value != 0) ? Set(A3Flags.Transparent) : Reset(A3Flags.Transparent); }
        public int Refresh { get => IsSet(A3Flags.Refresh); set => m_flags = (value != 0) ? Set(A3Flags.Refresh) : Reset(A3Flags.Refresh); }
        public int Relpos { get => IsSet(A3Flags.Relpos); set => m_flags = (value != 0) ? Set(A3Flags.Relpos) : Reset(A3Flags.Relpos); }

    }
}
