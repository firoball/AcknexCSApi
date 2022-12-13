using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{

    public abstract class MapObject<T> : A3Object, IEnumerable<T> where T : MapObject<T>
    {
        private List<T> m_instances;
        private T m_parent;
        private T m_original;

        protected Skill[] m_skill = new Skill[8];

        public MapObject() : base()
        {
            m_skill = new Skill[8];
            for (int i = 0; i < m_skill.Length; i++)
                m_skill[i] = new Skill();
            //make initial instance the first one
            m_instances = new List<T>
            {
                (T)this
            };
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

        public T this[int i]
        {
            get
            {
                //always access parent instance
                if (m_parent != null)
                {
                    return m_parent[i];
                }
                else
                {
                    if (i < m_instances.Count)
                        return m_instances[i];
                    else
                        return null;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (m_parent != null)
                return m_parent.GetEnumerator();
            else
                return m_instances.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (m_parent != null)
                return m_parent.GetEnumerator();
            else
                return ((IEnumerable<T>)m_instances).GetEnumerator();
        }

        public void Instantiate()
        {
            //do not add instances on instances themselves
            if (m_parent != null)
            {
                m_parent.Instantiate();
            }
            else
            {
                //keep an unmodified copy for further instances
                if (m_original == null)
                    m_original = Clone((T)this);

                //always clone form unmodified original
                T clone = Clone(m_original);
                m_instances.Add(clone);
            }
        }

        private T Clone(T template)
        {
            T clone = (T)template.MemberwiseClone();
            clone.m_parent = (T)this;

            //skills require deep copy
            clone.m_skill = new Skill[8];
            for (int i = 0; i < template.m_skill.Length; i++)
                clone.m_skill[i] = new Skill(template.m_skill[i]);

            //Remove instance list
            clone.m_instances = null;

            return clone;
        }

//        public static implicit operator T(MapObject<T> a) => (T)a;
    }

}
