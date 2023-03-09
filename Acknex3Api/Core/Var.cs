using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    //may need to be changed to class for flawless referencing from Panel Digits
    public struct Var
    {
        private long m_value;

        //public long Value { get => value; }

        public Var(int a) { m_value = _VAR2(a); }
        public Var(float a) { m_value = _VAR2(a); }
        public Var(double a) { m_value = _VAR2(a); }
        public Var(long a) { m_value = a; }

        //public long getvalue() { return value; }

        /*
        inline var operator=(var r1) { value = r1.getvalue(); return *this; }
        inline var operator=(long r1) { value = r1; return *this; }
        inline var operator=(int r1) { value = _VAR2(r1); return *this; }
        inline var operator=(float r1) { value = _VAR2((double)r1); return *this; }
        inline var operator=(double r1) { value = _VAR2(r1); return *this; }
        inline var operator=(void* r1) { value = (long)r1; return *this; }
        */

        public static Var operator +(Var a, Var b) => new Var(a.m_value + b.m_value);
        public static Var operator +(Var a, long b) => new Var(a.m_value + b);
        public static Var operator +(Var a, int b) => new Var(a.m_value + _VAR2(b));
        public static Var operator +(Var a, float b) => new Var(a.m_value + _VAR2(b));
        public static Var operator +(Var a, double b) => new Var(a.m_value + _VAR2(b));

        /*
        inline var operator +(var r1) { var i1 = value + r1.getvalue(); return (i1); }
        inline var operator +(long r1) { var i1 = value + r1; return (i1); }
        inline var operator +(int r1) { var i1 = value + _VAR2(r1); return (i1); }
        inline var operator +(float r1) { var i1 = value + _VAR2(r1); return (i1); }
        inline var operator +(double r1) { var i1 = value + _VAR2(r1); return (i1); }
        */

        public static Var operator -(Var a, Var b) => new Var(a.m_value - b.m_value);
        public static Var operator -(Var a, long b) => new Var(a.m_value - b);
        public static Var operator -(Var a, int b) => new Var(a.m_value - _VAR2(b));
        public static Var operator -(Var a, float b) => new Var(a.m_value - _VAR2(b));
        public static Var operator -(Var a, double b) => new Var(a.m_value - _VAR2(b));

        /*
        inline var operator -(var r1) { var i1 = value - r1.getvalue(); return (i1); }
        inline var operator -(long r1) { var i1 = value - r1; return (i1); }
        inline var operator -(int r1) { var i1 = value - _VAR2(r1); return (i1); }
        inline var operator -(float r1) { var i1 = value - _VAR2(r1); return (i1); }
        inline var operator -(double r1) { var i1 = value - _VAR2(r1); return (i1); }
        */

        public static Var operator *(Var a, Var b) => new Var(_FIXMUL(a.m_value, b.m_value));
        public static Var operator *(Var a, long b) => new Var(_FIXMUL(a.m_value, b));
        public static Var operator *(Var a, int b) => new Var(_FIXMUL(a.m_value, _VAR2(b)));
        public static Var operator *(Var a, float b) => new Var(_FIXMUL(a.m_value, _VAR2(b)));
        public static Var operator *(Var a, double b) => new Var(_FIXMUL(a.m_value, _VAR2(b)));

        /*
        inline var operator *(var val1) { long r1 = val1.getvalue(); long r2 = value; return fixmul(r1, r2); }
        inline var operator *(long val1) { long r1 = val1; long r2 = value; return fixmul(r1, r2); }
        inline var operator *(int val1) { long r1 = _VAR2(val1); long r2 = value; return fixmul(r1, r2); }
        inline var operator *(float val1) { long r1 = _VAR2(val1); long r2 = value; return fixmul(r1, r2); }
        inline var operator *(double val1) { long r1 = _VAR2(val1); long r2 = value; return fixmul(r1, r2); }
        */

        public static Var operator /(Var a, Var b) => new Var(_FIXDIV(a.m_value, b.m_value));
        public static Var operator /(Var a, long b) => new Var(_FIXDIV(a.m_value, b));
        public static Var operator /(Var a, int b) => new Var(_FIXDIV(a.m_value, _VAR2(b)));
        public static Var operator /(Var a, float b) => new Var(_FIXDIV(a.m_value, _VAR2(b)));
        public static Var operator /(Var a, double b) => new Var(_FIXDIV(a.m_value, _VAR2(b)));

        /*
        inline var operator /(var val1) { long r1 = value; long r2 = val1.getvalue(); return fixdiv(r1, r2); }
        inline var operator /(long val1) { long r1 = value; long r2 = val1; return fixdiv(r1, r2); }
        inline var operator /(int val1) { long r1 = value; long r2 = _VAR2(val1); return fixdiv(r1, r2); }
        inline var operator /(float val1) { long r1 = value; long r2 = _VAR2(val1); return fixdiv(r1, r2); }
        inline var operator /(double val1) { long r1 = value; long r2 = _VAR2(val1); return fixdiv(r1, r2); }
        */

        public static bool operator ==(Var a, Var b) => a.m_value == b.m_value;
        public static bool operator ==(Var a, long b) => a.m_value == b;
        public static bool operator ==(Var a, int b) => a.m_value == _VAR2(b);
        public static bool operator ==(Var a, float b) => a.m_value == _VAR2(b);
        public static bool operator ==(Var a, double b) => a.m_value == _VAR2(b);

        /*
        inline int operator ==(var r1) { var i1 = (value == r1.getvalue()); return (i1); }
        inline int operator ==(long r1) { var i1 = (value == r1); return (i1); }
        inline int operator ==(int r1) { var i1 = (value == _VAR2(r1)); return (i1); }
        inline int operator ==(float r1) { var i1 = (value == _VAR2(r1)); return (i1); }
        inline int operator ==(double r1) { var i1 = (value == _VAR2(r1)); return (i1); }
        */

        public static bool operator <=(Var a, Var b) => a.m_value <= b.m_value;
        public static bool operator <=(Var a, long b) => a.m_value <= b;
        public static bool operator <=(Var a, int b) => a.m_value <= _VAR2(b);
        public static bool operator <=(Var a, float b) => a.m_value <= _VAR2(b);
        public static bool operator <=(Var a, double b) => a.m_value <= _VAR2(b);

        /*
        inline int operator <=(var r1) { var i1 = (value <= r1.getvalue()); return (i1); }
        inline int operator <=(long r1) { var i1 = (value <= r1); return (i1); }
        inline int operator <=(int r1) { var i1 = (value <= _VAR2(r1)); return (i1); }
        inline int operator <=(float r1) { var i1 = (value <= _VAR2(r1)); return (i1); }
        inline int operator <=(double r1) { var i1 = (value <= _VAR2(r1)); return (i1); }
        */

        public static bool operator >=(Var a, Var b) => a.m_value >= b.m_value;
        public static bool operator >=(Var a, long b) => a.m_value >= b;
        public static bool operator >=(Var a, int b) => a.m_value >= _VAR2(b);
        public static bool operator >=(Var a, float b) => a.m_value >= _VAR2(b);
        public static bool operator >=(Var a, double b) => a.m_value >= _VAR2(b);

        /*
        inline int operator >=(var r1) { var i1 = (value >= r1.getvalue()); return (i1); }
        inline int operator >=(long r1) { var i1 = (value >= r1); return (i1); }
        inline int operator >=(int r1) { var i1 = (value >= _VAR2(r1)); return (i1); }
        inline int operator >=(float r1) { var i1 = (value >= _VAR2(r1)); return (i1); }
        inline int operator >=(double r1) { var i1 = (value >= _VAR2(r1)); return (i1); }
        */

        public static bool operator <(Var a, Var b) => a.m_value < b.m_value;
        public static bool operator <(Var a, long b) => a.m_value < b;
        public static bool operator <(Var a, int b) => a.m_value < _VAR2(b);
        public static bool operator <(Var a, float b) => a.m_value < _VAR2(b);
        public static bool operator <(Var a, double b) => a.m_value < _VAR2(b);

        /*
        inline int operator <(var r1) { var i1 = (value < r1.getvalue()); return (i1); }
        inline int operator <(long r1) { var i1 = (value < r1); return (i1); }
        inline int operator <(int r1) { var i1 = (value < _VAR2(r1)); return (i1); }
        inline int operator <(float r1) { var i1 = (value < _VAR2(r1)); return (i1); }
        inline int operator <(double r1) { var i1 = (value < _VAR2(r1)); return (i1); }
        */

        public static bool operator >(Var a, Var b) => a.m_value > b.m_value;
        public static bool operator >(Var a, long b) => a.m_value > b;
        public static bool operator >(Var a, int b) => a.m_value > _VAR2(b);
        public static bool operator >(Var a, float b) => a.m_value > _VAR2(b);
        public static bool operator >(Var a, double b) => a.m_value > _VAR2(b);

        /*
        inline int operator >(var r1) { var i1 = (value > r1.getvalue()); return (i1); }
        inline int operator >(long r1) { var i1 = (value > r1); return (i1); }
        inline int operator >(int r1) { var i1 = (value > _VAR2(r1)); return (i1); }
        inline int operator >(float r1) { var i1 = (value > _VAR2(r1)); return (i1); }
        inline int operator >(double r1) { var i1 = (value > _VAR2(r1)); return (i1); }
        */

        public static bool operator !=(Var a, Var b) => a.m_value != b.m_value;
        public static bool operator !=(Var a, long b) => a.m_value != b;
        public static bool operator !=(Var a, int b) => a.m_value != _VAR2(b);
        public static bool operator !=(Var a, float b) => a.m_value != _VAR2(b);
        public static bool operator !=(Var a, double b) => a.m_value != _VAR2(b);

        /*
        inline int operator !=(var r1) { var i1 = (value != r1.getvalue()); return (i1); }
        inline int operator !=(long r1) { var i1 = (value != r1); return (i1); }
        inline int operator !=(int r1) { var i1 = (value != _VAR2(r1)); return (i1); }
        inline int operator !=(float r1) { var i1 = (value != _VAR2(r1)); return (i1); }
        inline int operator !=(double r1) { var i1 = (value != _VAR2(r1)); return (i1); }
        */

        public static Var operator ++(Var a) => a.m_value += _VAR2(1);
        public static Var operator --(Var a) => a.m_value -= _VAR2(1);

        /*
        inline var operator ++() { var i1 = *this; value += _VAR2(1); return (i1); }
        inline var operator --() { var i1 = *this; value -= _VAR2(1); return (i1); }
        */

        public static implicit operator bool(Var a) => a.m_value != 0;
        public static implicit operator long(Var a) => a.m_value;
        public static implicit operator int(Var a) => _INT2(a.m_value);
        public static implicit operator float(Var a) => _FLOAT2(a.m_value);
        public static implicit operator double(Var a) => _DOUBLE2(a.m_value);

        /*
        inline operator bool() { if (value != 0) return true; else return false; }
        inline operator short() { return (short)_INT2(value); }
        inline operator long() { return value; }
        inline operator int() { return _INT2(value); }
        inline operator float() { return _FLOAT2(value); }
        inline operator double() { return _FLOAT2(value); }
        */

        public static implicit operator Var(bool a) => new Var(a ? 1 : 0);
        public static implicit operator Var(long a) => new Var(a);
        public static implicit operator Var(int a) => new Var(a);
        public static implicit operator Var(float a) => new Var(a);
        public static implicit operator Var(double a) => new Var(a);
        public static implicit operator Var(A3Object a) => new Var(0); //hack: enable Var to accept "null" as value and treat it as 0

        public static Var operator -(Var a) => new Var(-a.m_value);

        public override string ToString() => $"{_DOUBLE2(m_value)}";

        public override bool Equals(object obj)
        {
            if (!(obj is Var))
            {
                return false;
            }

            var var = (Var)obj;
            return m_value == var.m_value;
        }

        public override int GetHashCode()
        {
            return -1584136870 + m_value.GetHashCode();
        }

        private static int _INT2(long x)
        {
            return (int)(x >> 10);
        }

        private static float _FLOAT2(long x)
        {
            return ((float)x) / (1 << 10);
        }

        private static double _DOUBLE2(long x)
        {
            return ((double)x) / (1 << 10);
        }

        private static long _VAR2(int i)
        {
            return (long)i << 10;
        }

        private static long _VAR2(double f)
        {
            return (long)(f * (1 << 10));
        }

        private static long _FIXMUL(long r1, long r2)
        {
            // don't care about overflow - range of Var is limited in original WDL
            long result;
            result = r1 * r2;
            return result >> 10;
        }

        private static long _FIXDIV(long r1, long r2)
        {
            long result;
            result = r1 << 10;
            result /= r2;
            return result;
        }

    }
}
