using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class UIObject : A3Object
    {
        protected int m_layer;

        public int Visible { get => IsSet(A3Flags.Visible); set => m_flags = (value != 0) ? Set(A3Flags.Visible) : Reset(A3Flags.Visible); } //M

    }
}
