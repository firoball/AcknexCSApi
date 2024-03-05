using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public abstract class Bitmap : Asset
    {
        protected Var m_x;
        protected Var m_y;
        protected Var m_dx;
        protected Var m_dy;

        public Bitmap(string name, string file) : base(name, file)
        {
            m_x = 0;
            m_y = 0;
            //TODO: DX = bitmap size, DY = bitmap height
        }
        public Bitmap(string name, string file, Var x, Var y, Var dx, Var dy) : base(name, file)
        {
            m_x = x;
            m_y = y;
            m_dx = dx;
            m_dy = dy;
        }
    }
}
