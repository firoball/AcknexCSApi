using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class A3Object
    {
        protected Skill[] m_skill = new Skill[8];
        protected int m_flags;

        public A3Object()
        {
            m_skill = new Skill[8];
            for (int i = 0; i < m_skill.Length; i++)
                m_skill[i] = new Skill();
        }

        public Skill Skill1 { get => m_skill[0]; set => m_skill[0] = value; } //M
        public Skill Skill2 { get => m_skill[1]; set => m_skill[1] = value; } //M
        public Skill Skill3 { get => m_skill[2]; set => m_skill[2] = value; } //M
        public Skill Skill4 { get => m_skill[3]; set => m_skill[3] = value; } //M
        public Skill Skill5 { get => m_skill[4]; set => m_skill[4] = value; } //M
        public Skill Skill6 { get => m_skill[5]; set => m_skill[5] = value; } //M
        public Skill Skill7 { get => m_skill[6]; set => m_skill[6] = value; } //M
        public Skill Skill8 { get => m_skill[7]; set => m_skill[7] = value; } //M

        public int Flag1 { get => IsSet(A3Flags.Flag1); set => m_flags = (value != 0) ? Set(A3Flags.Flag1) : Reset(A3Flags.Flag1); } //M
        public int Flag2 { get => IsSet(A3Flags.Flag2); set => m_flags = (value != 0) ? Set(A3Flags.Flag2) : Reset(A3Flags.Flag2); } //M
        public int Flag3 { get => IsSet(A3Flags.Flag3); set => m_flags = (value != 0) ? Set(A3Flags.Flag3) : Reset(A3Flags.Flag3); } //M
        public int Flag4 { get => IsSet(A3Flags.Flag4); set => m_flags = (value != 0) ? Set(A3Flags.Flag4) : Reset(A3Flags.Flag4); } //M
        public int Flag5 { get => IsSet(A3Flags.Flag5); set => m_flags = (value != 0) ? Set(A3Flags.Flag5) : Reset(A3Flags.Flag5); } //M
        public int Flag6 { get => IsSet(A3Flags.Flag6); set => m_flags = (value != 0) ? Set(A3Flags.Flag6) : Reset(A3Flags.Flag6); } //M
        public int Flag7 { get => IsSet(A3Flags.Flag7); set => m_flags = (value != 0) ? Set(A3Flags.Flag7) : Reset(A3Flags.Flag7); } //M
        public int Flag8 { get => IsSet(A3Flags.Flag8); set => m_flags = (value != 0) ? Set(A3Flags.Flag8) : Reset(A3Flags.Flag8); } //M
        public A3Flags Flags { set => m_flags = (int)value; }

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

    }
}
