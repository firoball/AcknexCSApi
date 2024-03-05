using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Font : Bitmap
    {
        private Var m_width;
        private Var m_height;

        public Font(string name, string file, Var width, Var height) : base(name, file)
        {
            m_width = width;
            m_height = height;
        }
        public Font(string name, string file, Var width, Var height, Var x, Var y, Var dx, Var dy) : base(name, file, x, y, dx, dy)
        {
            m_width = width;
            m_height = height;
        }
    }
}
