using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
//TODO: remove class and just use C# references....
    public class Synonym<T> : A3Object where T : A3Object
    {
        private T m_reference;

        public T Default { set => m_reference = value; }

        public Synonym() : base() { }
        public Synonym(T value) : this()
        {
            m_reference = value;
        }

        public static implicit operator Synonym<T>(T a) => new Synonym<T>(a);
        public static implicit operator T(Synonym<T> a) => a.m_reference;
    }
}
