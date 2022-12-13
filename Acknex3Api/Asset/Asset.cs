using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public abstract class Asset
    {
        protected string m_file;

        public Asset(string file)
        {
            m_file = file;
        }
    }
}
