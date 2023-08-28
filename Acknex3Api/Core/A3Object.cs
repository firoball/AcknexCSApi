using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class A3Object
    {
        protected int m_flags = 0;

        public A3Flags Flags { get => (A3Flags)m_flags; set => m_flags = (int)value; }

        protected int IsSet(A3Flags flag)
        {
            return ((m_flags & (int)flag) != 0) ? 1 : 0;
        }

        protected int Set(A3Flags flag)
        {
            return m_flags | (int)flag;
        }

        protected int Reset(A3Flags flag)
        {
            return m_flags & ~(int)flag;
        }

        public static implicit operator bool(A3Object a) => a != null;

    }
}
