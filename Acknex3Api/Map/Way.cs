using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Way : MapObject<Way> //TODO: instancing really needed?
    {
        public Way(string name) : base(name) { }
    }
}
