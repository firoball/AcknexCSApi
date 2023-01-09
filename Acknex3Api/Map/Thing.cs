using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Thing : BaseObject
    {
        public Thing() : base()
        {
            Set(A3Flags.Thing);
        }
    }

}
