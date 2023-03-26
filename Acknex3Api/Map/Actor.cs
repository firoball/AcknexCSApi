using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Actor : BaseObject
    {
        public Actor() : base()
        {
            Set(A3Flags.Actor);
        }

    }

    public enum ActorTarget
    {
        Null = 0,
        Move,
        Bullet,
        Drop, //undocumented, same as "drop" command?
        Stick,
        Straight, //undocumented, same as target "move"?
        Follow,
        Repel,
        Vertex,
        Node0,
        Node1,
        Way,
        Hold,
        Object
    }

}
