using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public abstract class Asset
    {
        protected string m_name = string.Empty;
        protected string m_file;

        public Asset(string name, string file)
        {
            if (!string.IsNullOrEmpty(name))
                m_name = name;
            if (!string.IsNullOrEmpty(name))
                m_file = file;
        }
    }
}
