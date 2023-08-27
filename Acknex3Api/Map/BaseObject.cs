using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class BaseObject : MapObject<BaseObject>
    {
        protected Texture m_texture;
        protected Texture m_attach;
        protected Var m_cycle;
        protected Overlay m_overlay;
        protected Var m_height; //M
        protected Var m_angle; //M
        protected Var m_map_color;
        protected Var m_dist; //M
        protected Var m_distance; //R
        protected Var m_size_x; //R
        protected Var m_size_y; //R
        protected Var m_floor_hgt; //R
        protected Var m_result; //R
        protected Var m_x1;
        protected Var m_y1;
        protected Var m_z1;
        protected Var m_x2;
        protected Var m_y2;
        protected Var m_z2;
        protected ActorTarget m_target;
        protected Way m_way;
        protected BaseObject m_targetObject;
        protected Var m_waypoint; //M
        protected Var m_target_x; //M
        protected Var m_target_y; //M
        protected Var m_rel_angle; //M
        protected Var m_rel_dist; //M
        protected Var m_speed; //M
        protected Var m_vspeed; //M
        protected Var m_aspeed;
        protected Var m_offset_x;
        protected Var m_offset_y;
        protected Var m_position;
        protected Var m_length;
        protected Var m_ambient; //undocumented
        protected Var m_node; //undocumented
        protected Region m_left; //M
        protected Region m_right;
        protected Function m_if_near; //M
        protected Function m_if_far; //M
        protected Function m_if_hit; //M
        protected Function m_each_cycle; //M
        protected Function m_each_tick; //M
        protected Function m_if_arrived; //M

        public BaseObject() : base() { }

        public Texture Texture { get => m_texture; set => m_texture = value; }
        public Texture Attach { get => m_attach; set => m_attach = value; }
        public Var Cycle { get => m_cycle; set => m_cycle = value; }
        public Overlay Overlay { get => m_overlay; set => m_overlay = value; }
        public Var Map_color { get => m_map_color; set => m_map_color = value; }
        public Var Dist { get => m_dist; set => m_dist = value; }
        public Var Distance { get => m_distance; set => m_distance = value; }
        public Var Size_x { get => m_size_x; set => m_size_x = value; }
        public Function If_near { get => m_if_near; set => m_if_near = value.Create(this); }
        public Function If_far { get => m_if_far; set => m_if_far = value.Create(this); }
        public Function If_hit { get => m_if_hit; set => m_if_hit = value.Create(this); }
        public Function Each_cycle { get => m_each_cycle; set => m_each_cycle = value.Create(this); }
        public Function Each_tick { get => m_each_tick; set => m_each_tick = value.Create(this); }

        //Wall
        public Var X1 { get => m_x1; set => m_x1 = value; }
        public Var Y1 { get => m_y1; set => m_y1 = value; }
        public Var Z1 { get => m_z1; set => m_z1 = value; }
        public Var X2 { get => m_x2; set => m_x2 = value; }
        public Var Y2 { get => m_y2; set => m_y2 = value; }
        public Var Z2 { get => m_z2; set => m_z2 = value; }
        public Var Offset_x { get => m_offset_x; set => m_offset_x = value; } //M
        public Var Offset_y { get => m_offset_y; set => m_offset_y = value; } //M
        public Var Position { get => m_position; set => m_position = value; } //M
        public Var Length { get => m_length; set => m_length = value; } //R
        public Region Left { get => m_left; set => m_left = value; } //R
        public Region Right { get => m_right; set => m_right = value; } //R

        //Thing, Actor
        public Var X { get => m_x1; set => m_x1 = value; }
        public Var Y { get => m_y1; set => m_y1 = value; }
        public Var Z { get => m_z1; set => m_z1 = value; }
        public Region Region { get => m_left; set => m_left = value; }
        public Var Height { get => m_height; set => m_height = value; }
        public Var Thing_hgt { get => m_height; set => m_height = value; } //undocumented
        public Var Angle { get => m_angle; set => m_angle = value; }
        public Var Size_y { get => m_size_y; set => m_size_y = value; }
        public Var Floor_hgt { get => m_floor_hgt; set => m_floor_hgt = value; }
        public Var Result { get => m_result; set => m_result = value; }
        public Var Ambient { get => m_ambient; set => m_ambient = value; }

        //Actor
        public object Target {
            set
            {
                if (value is Way)
                {
                    m_targetObject = null;
                    m_way = (Way)value;
                    m_target = ActorTarget.Way;
                }
                else if (value is BaseObject)
                {
                    m_targetObject = (BaseObject)value;
                    m_way = null;
                    m_target = ActorTarget.Object;
                }
                if (value is ActorTarget)
                {
                    m_targetObject = null;
                    m_way = null;
                    m_target = (ActorTarget)value;
                }
                else
                {
                    m_targetObject = null;
                    m_way = null;
                    m_target = ActorTarget.Null;
                }
            }
            get
            {
                if (m_way != null)
                {
                    return m_way;
                }
                else if (m_targetObject != null)
                {
                    return m_targetObject;
                }
                else
                {
                    return m_target;
                }
            }
        }
        //public ActorTarget Target { get => m_target; set => m_target = value; }
        public Way Way { get => m_way; set => m_way = value; } //undocumented
        //public BaseObject TargetObject { get => m_targetObject; set => m_targetObject = value; }
        public Var Waypoint { get => m_waypoint; set => m_waypoint = value; }
        public Var Target_x { get => m_target_x; set => m_target_x = value; }
        public Var Target_y { get => m_target_y; set => m_target_y = value; }
        public Var Rel_angle { get => m_rel_angle; set => m_rel_angle = value; }
        public Var Rel_dist { get => m_rel_dist; set => m_rel_dist = value; }
        public Var Speed { get => m_speed; set => m_speed = value; }
        public Var Vspeed { get => m_vspeed; set => m_vspeed = value; }
        public Var Aspeed { get => m_aspeed; set => m_aspeed = value; }
        public Var Node { get => m_node; set => m_node = value; } //TODO: map to target
        public Function If_arrived { get => m_if_arrived; set => m_if_arrived = value.Create(this); }

        /*
        public int? Invisible { get => IsSet(A3Flags.Invisible); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Invisible) : Reset(A3Flags.Invisible); } //M
        public int? Passable { get => IsSet(A3Flags.Passable); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Passable) : Reset(A3Flags.Passable); } //M
        public int? Impassable { get => IsSet(A3Flags.Impassable); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Impassable) : Reset(A3Flags.Impassable); } //M
        public int? Visible { get => IsSet(A3Flags.Visible); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Visible) : Reset(A3Flags.Visible); } //R
        public int? Berkeley { get => IsSet(A3Flags.Berkeley); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Berkeley) : Reset(A3Flags.Berkeley); } //M
        public int? Seen { get => IsSet(A3Flags.Seen); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Seen) : Reset(A3Flags.Seen); } //M
        public int? Play { get => IsSet(A3Flags.Play); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Play) : Reset(A3Flags.Play); } //M
        public int? Immaterial { get => IsSet(A3Flags.Immaterial); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Immaterial) : Reset(A3Flags.Immaterial); } //M
        public int? Fragile { get => IsSet(A3Flags.Fragile); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Fragile) : Reset(A3Flags.Fragile); } //M
        public int? Save { get => IsSet(A3Flags.Save); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Save) : Reset(A3Flags.Save); } //M
        public int? Sensitive { get => IsSet(A3Flags.Sensitive); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Sensitive) : Reset(A3Flags.Sensitive); } //M
        public int? Thing { get => IsSet(A3Flags.Thing); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Thing) : Reset(A3Flags.Thing); } //M
        public int? Actor { get => IsSet(A3Flags.Actor); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Actor) : Reset(A3Flags.Actor); } //M

        //Thing, Actor
        public int? Liber { get => IsSet(A3Flags.Liber); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Liber) : Reset(A3Flags.Liber); } //M
        public int? Ground { get => IsSet(A3Flags.Ground); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Ground) : Reset(A3Flags.Ground); } //M
        public int? Candelaber { get => IsSet(A3Flags.Candelaber); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Candelaber) : Reset(A3Flags.Candelaber); } //M
        public int? Flat { get => IsSet(A3Flags.Flat); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Flat) : Reset(A3Flags.Flat); } //M

        //Actor
        public int? Moved { get => IsSet(A3Flags.Moved); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Moved) : Reset(A3Flags.Moved); } //M
        public int? Carefully { get => IsSet(A3Flags.Carefully); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Carefully) : Reset(A3Flags.Carefully); } //M

        //Wall
        public int? Transparent { get => IsSet(A3Flags.Transparent); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Transparent) : Reset(A3Flags.Transparent); } //M
        public int? Curtain { get => IsSet(A3Flags.Curtain); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Curtain) : Reset(A3Flags.Curtain); }
        public int? Portcullis { get => IsSet(A3Flags.Portcullis); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Portcullis) : Reset(A3Flags.Portcullis); } //M
        public int? Fence { get => IsSet(A3Flags.Fence); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Fence) : Reset(A3Flags.Fence); }
        public int? Far { get => IsSet(A3Flags.Far); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Far) : Reset(A3Flags.Far); }
        */

        public Var Invisible { get => IsSet(A3Flags.Invisible); set => m_flags = (value != 0) ? Set(A3Flags.Invisible) : Reset(A3Flags.Invisible); } //M
        public Var Passable { get => IsSet(A3Flags.Passable); set => m_flags = (value != 0) ? Set(A3Flags.Passable) : Reset(A3Flags.Passable); } //M
        public Var Impassable { get => IsSet(A3Flags.Impassable); set => m_flags = (value != 0) ? Set(A3Flags.Impassable) : Reset(A3Flags.Impassable); } //M
        public Var Visible { get => IsSet(A3Flags.Visible); set => m_flags = (value != 0) ? Set(A3Flags.Visible) : Reset(A3Flags.Visible); } //R
        public Var Berkeley { get => IsSet(A3Flags.Berkeley); set => m_flags = (value != 0) ? Set(A3Flags.Berkeley) : Reset(A3Flags.Berkeley); } //M
        public Var Seen { get => IsSet(A3Flags.Seen); set => m_flags = (value != 0) ? Set(A3Flags.Seen) : Reset(A3Flags.Seen); } //M
        public Var Play { get => IsSet(A3Flags.Play); set => m_flags = (value != 0) ? Set(A3Flags.Play) : Reset(A3Flags.Play); } //M
        public Var Immaterial { get => IsSet(A3Flags.Immaterial); set => m_flags = (value != 0) ? Set(A3Flags.Immaterial) : Reset(A3Flags.Immaterial); } //M
        public Var Fragile { get => IsSet(A3Flags.Fragile); set => m_flags = (value != 0) ? Set(A3Flags.Fragile) : Reset(A3Flags.Fragile); } //M
        public Var Save { get => IsSet(A3Flags.Save); set => m_flags = (value != 0) ? Set(A3Flags.Save) : Reset(A3Flags.Save); } //M
        public Var Sensitive { get => IsSet(A3Flags.Sensitive); set => m_flags = (value != 0) ? Set(A3Flags.Sensitive) : Reset(A3Flags.Sensitive); } //M
        public Var Thing { get => IsSet(A3Flags.Thing); set => m_flags = (value != 0) ? Set(A3Flags.Thing) : Reset(A3Flags.Thing); } //M
        public Var Actor { get => IsSet(A3Flags.Actor); set => m_flags = (value != 0) ? Set(A3Flags.Actor) : Reset(A3Flags.Actor); } //M

        //Thing, Actor
        public Var Liber { get => IsSet(A3Flags.Liber); set => m_flags = (value != 0) ? Set(A3Flags.Liber) : Reset(A3Flags.Liber); } //M
        public Var Ground { get => IsSet(A3Flags.Ground); set => m_flags = (value != 0) ? Set(A3Flags.Ground) : Reset(A3Flags.Ground); } //M
        public Var Candelaber { get => IsSet(A3Flags.Candelaber); set => m_flags = (value != 0) ? Set(A3Flags.Candelaber) : Reset(A3Flags.Candelaber); } //M
        public Var Flat { get => IsSet(A3Flags.Flat); set => m_flags = (value != 0) ? Set(A3Flags.Flat) : Reset(A3Flags.Flat); } //M

        //Actor
        public Var Moved { get => IsSet(A3Flags.Moved); set => m_flags = (value != 0) ? Set(A3Flags.Moved) : Reset(A3Flags.Moved); } //M
        public Var Carefully { get => IsSet(A3Flags.Carefully); set => m_flags = (value != 0) ? Set(A3Flags.Carefully) : Reset(A3Flags.Carefully); } //M

        //Wall
        public Var Transparent { get => IsSet(A3Flags.Transparent); set => m_flags = (value != 0) ? Set(A3Flags.Transparent) : Reset(A3Flags.Transparent); } //M
        public Var Curtain { get => IsSet(A3Flags.Curtain); set => m_flags = (value != 0) ? Set(A3Flags.Curtain) : Reset(A3Flags.Curtain); }
        public Var Portcullis { get => IsSet(A3Flags.Portcullis); set => m_flags = (value != 0) ? Set(A3Flags.Portcullis) : Reset(A3Flags.Portcullis); } //M
        public Var Fence { get => IsSet(A3Flags.Fence); set => m_flags = (value != 0) ? Set(A3Flags.Fence) : Reset(A3Flags.Fence); }
        public Var Far { get => IsSet(A3Flags.Far); set => m_flags = (value != 0) ? Set(A3Flags.Far) : Reset(A3Flags.Far); }

        //Undocumented - dummy
        public Var Oneshot { get => IsSet(A3Flags.Oneshot); set => m_flags = (value != 0) ? Set(A3Flags.Oneshot) : Reset(A3Flags.Oneshot); }

        public void Locate()
        {

        }

        public void Drop()
        {

        }

        public void Place()
        {

        }

        public void Explode()
        {

        }

        public void Shake()
        {

        }

        public void Play_sound(Sound sound, Var volume)
        {

        }

        public void Shoot()
        {
            //am I shot?
        }

        //TODO: rewrite these iterators for new BaseObject arrangement
        public new BaseObject Next()
        {
            return base.Next();
        }

        public BaseObject Next_there()
        {
            //TODO: this is for objects of same name only. Needs to be implemented for objects of ANY name (new global lookup list required)
            BaseObject obj = null;
            do
            {
                obj = base.Next() as BaseObject;
            } while (obj.Region != Region);
            return obj;
        }
    }

}
