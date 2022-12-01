using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class View : UIObject
    {
        private Var m_size_x;
        private Var m_size_y;
        private ILevelObject m_genius;

        public Var Size_x { get => m_size_x; set => m_size_x = value; }
        public Var Size_y { get => m_size_y; set => m_size_y = value; }
        public ILevelObject Genius { get => m_genius; set => m_genius = value; }
    }
}
