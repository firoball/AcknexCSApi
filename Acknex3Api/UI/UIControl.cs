using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public abstract class UIControl
    {
        protected Var m_x;
        protected Var m_y;
        protected Func<Skill> m_MonitorSkill;
        protected Func<Var> m_MonitorVar;
        protected Skill m_skill;

        public UIControl(Var x, Var y, Func<Skill> skill) : this(x, y)
        {
            m_MonitorSkill = skill;
        }

        public UIControl(Var x, Var y, Func<Var> var) : this(x, y)
        {
            m_MonitorVar = var;
            m_skill = new Skill();
        }

        public UIControl(Var x, Var y)
        {
            m_x = x;
            m_y = y;
        }

        public virtual void Update()
        {
            if (m_MonitorSkill != null)
                m_skill = m_MonitorSkill();
            if (m_MonitorVar != null)
                m_skill.Value = m_MonitorVar();
        }
    }
}
