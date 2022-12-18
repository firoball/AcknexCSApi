using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Actor : BaseObject<Actor>
    {
        private ActorTarget m_target;
        private Way m_targetWay;
        private ILevelObject m_targetObject;
        private Var m_waypoint; //M
        private Var m_target_x; //M
        private Var m_target_y; //M
        private Var m_rel_angle; //M
        private Var m_rel_dist; //M
        private Var m_speed; //M
        private Var m_vspeed; //M
        private Var m_aspeed;
        private Function m_if_arrived; //M

        public Actor() : base()
        {
            Set(A3Flags.Actor);
        }

        public ActorTarget Target { get => m_target; set => m_target = value; }
        public Way TargetWay { get => m_targetWay; set => m_targetWay = value; }
        public ILevelObject TargetObject { get => m_targetObject; set => m_targetObject = value; }
        public Var Waypoint { get => m_waypoint; set => m_waypoint = value; }
        public Var Target_x { get => m_target_x; set => m_target_x = value; }
        public Var Target_y { get => m_target_y; set => m_target_y = value; }
        public Var Rel_angle { get => m_rel_angle; set => m_rel_angle = value; }
        public Var Rel_dist { get => m_rel_dist; set => m_rel_dist = value; }
        public Var Speed { get => m_speed; set => m_speed = value; }
        public Var Vspeed { get => m_vspeed; set => m_vspeed = value; }
        public Var Aspeed { get => m_aspeed; set => m_aspeed = value; }
        public Function If_arrived { get => m_if_arrived; set => m_if_arrived = value; }

        public int Moved { get => IsSet(A3Flags.Moved); set => m_flags = (value != 0) ? Set(A3Flags.Moved) : Reset(A3Flags.Moved); } //M
        public int Sensitive { get => IsSet(A3Flags.Sensitive); set => m_flags = (value != 0) ? Set(A3Flags.Sensitive) : Reset(A3Flags.Sensitive); } //M
        public int Carefully { get => IsSet(A3Flags.Carefully); set => m_flags = (value != 0) ? Set(A3Flags.Carefully) : Reset(A3Flags.Carefully); } //M
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
