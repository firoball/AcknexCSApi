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
        Stick,
        Follow,
        Repel,
        Vertex,
        Node1,
        Node2,
        Way,
        Hold,
        LevelObject
    }

}
