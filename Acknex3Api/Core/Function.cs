using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Function<T> : Function where T : Function, new()
    {
        public override Function Create(A3Object obj)
        {
            //function requires owner, create new instance
            if (Interruptable || HasOwner)
            {
                T f = new T();
                f.SetOwner(obj);
                return f;
            }
            //function does not require own instance
            else
            {
                return this;
            }
        }
    }

    public class Function
    {
        private bool m_interruptable = false;
        private bool m_hasOwner = false;
        private A3Object m_owner = null;
        private BaseObject m_my = null;
        private Region m_there = null;

        public bool Interruptable { get => m_interruptable; set => m_interruptable = value; }
        protected bool HasOwner { get => m_hasOwner; set => m_hasOwner = value; }
        protected BaseObject My { get => m_my; set => m_my = value; }
        protected Region There { get => m_there; set => m_there = value; }

        public void SetOwner(A3Object obj)
        {
            m_owner = obj;
            if (obj is BaseObject)
            {
                m_my = obj as BaseObject;
                m_there = m_my.Region;
            }
            else if (obj is Region)
            {
                m_my = null;
                m_there = obj as Region;
            }
            else
            {
                m_my = null;
                m_there = null;
            }
        }

        public virtual IEnumerator Logic()
        {
            yield break;
        }

        public virtual Function Create(A3Object obj)
        {
            return null;
        }

        protected IEnumerator Wait(Var value)
        {
            yield break;
        }

        protected IEnumerator Waitt(Var value)
        {
            yield break;
        }

    }
}
