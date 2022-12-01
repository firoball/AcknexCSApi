using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Picture : UIControl
    {
        private readonly Texture m_texture;
        
        public Picture(Var x, Var y, Texture texture, Func<Var> var) : base (x, y, var)
        {
            m_texture = texture;
        }
    }
}
