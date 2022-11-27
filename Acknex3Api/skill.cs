using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Skill
    {
        private Var m_value;
        private Var m_max;
        private Var m_min;
        private Skilltype m_type;

        public Var Value { get => m_value; set => m_value = _LIMIT(value, Min, Max); }
        public Var Max { get => m_max; set { m_max = value; m_value = _LIMIT(m_value, Min, Max); } }
        public Var Min { get => m_min; set { m_min = value; m_value = _LIMIT(m_value, Min, Max); } }
        public Skilltype Type { get => m_type; set => m_type = value; }

        public Skill() : this(0) {}

        public Skill(Var value) : this(value, -2097151, 2097151, Skilltype.Player) {}

        public Skill(Var value, Var min, Var max, Skilltype type)
        {
            m_min = min;
            m_max = max;
            m_value = _LIMIT(value, m_min, m_max);
            m_type = type;
        }

        public static Skill operator +(Skill a, Var b) { a.Value += b; return a; } //=> new Skill(a.Value + b, a.Min, a.Max, a.Type);
        public static Skill operator -(Skill a, Var b) { a.Value -= b; return a; } //=> new Skill(a.Value - b, a.Min, a.Max, a.Type);
        public static Skill operator *(Skill a, Var b) { a.Value *= b; return a; }// => new Skill(a.Value * b, a.Min, a.Max, a.Type);
        public static Skill operator /(Skill a, Var b) { a.Value /= b; return a; } //=> new Skill(a.Value / b, a.Min, a.Max, a.Type);
        public static bool operator >(Skill a, Var b) => a.Value > b;
        public static bool operator <(Skill a, Var b) => a.Value < b;
        public static bool operator >=(Skill a, Var b) => a.Value >= b;
        public static bool operator <=(Skill a, Var b) => a.Value <= b;
        public static bool operator ==(Skill a, Var b) => a.Value == b;
        public static bool operator !=(Skill a, Var b) => a.Value != b;
        public static Skill operator ++(Skill a) => a += 1;
        public static Skill operator --(Skill a) => a -= 1;
        public static Skill operator -(Skill a) { a.Value *= -1; return a; }

        public static implicit operator Var(Skill a) => a.Value;

        private static Var _LIMIT(Var value, Var min, Var max)
        {
            Var v = value; 
            if (max != 0)
                v = (v < max) ? v : max;
            if (min != 0)
                v = (v > min) ? v : min;
            return v;
        }

        public override bool Equals(object obj)
        {
            Skill skill = obj as Skill;
            return skill != null &&
                   m_value == skill.m_value &&
                   m_max == skill.m_max &&
                   m_min == skill.m_min &&
                   m_type == skill.m_type;
        }

        public override int GetHashCode()
        {
            int hashCode = 1819146591;
            hashCode = hashCode * -1521134295 + m_value.GetHashCode();
            hashCode = hashCode * -1521134295 + m_max.GetHashCode();
            hashCode = hashCode * -1521134295 + m_min.GetHashCode();
            hashCode = hashCode * -1521134295 + m_type.GetHashCode();
            return hashCode;
        }
    }

    public enum Skilltype
    {
        Player = 0,
        Local = 1,
        Global = 2
    }

}
