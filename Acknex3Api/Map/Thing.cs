using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Thing : BaseObject
    {
        public Thing(string name) : base(name)
        {
            Set(A3Flags.Thing);
        }
    }

}
