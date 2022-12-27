using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public abstract class BaseObject<T> : MapObject<T>, ILevelObject where T : MapObject<T>
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
        protected Var m_x;
        protected Var m_y;
        protected Region m_region; //M
        protected Function m_if_near; //M
        protected Function m_if_far; //M
        protected Function m_if_hit; //M
        protected Function m_each_cycle; //M
        protected Function m_each_tick; //M

        public BaseObject() : base() { }

        public Texture Texture { get => m_texture; set => m_texture = value; }
        public Texture Attach { get => m_attach; set => m_attach = value; }
        public Var Cycle { get => m_cycle; set => m_cycle = value; }
        public Overlay Overlay { get => m_overlay; set => m_overlay = value; }
        public Var Height { get => m_height; set => m_height = value; }
        public Var Angle { get => m_angle; set => m_angle = value; }
        public Var Map_color { get => m_map_color; set => m_map_color = value; }
        public Var Dist { get => m_dist; set => m_dist = value; }
        public Var Distance { get => m_distance; set => m_distance = value; }
        public Var Size_x { get => m_size_x; set => m_size_x = value; }
        public Var Size_y { get => m_size_y; set => m_size_y = value; }
        public Var Floor_hgt { get => m_floor_hgt; set => m_floor_hgt = value; }
        public Var Result { get => m_result; set => m_result = value; }
        public Var X { get => m_x; set => m_x = value; }
        public Var Y { get => m_y; set => m_y = value; }
        public Region Region { get => m_region; set => m_region = value; }
        public Function If_near { get => m_if_near; set => m_if_near = value; }
        public Function If_far { get => m_if_far; set => m_if_far = value; }
        public Function If_hit { get => m_if_hit; set => m_if_hit = value; }
        public Function Each_cycle { get => m_each_cycle; set => m_each_cycle = value; }
        public Function Each_tick { get => m_each_tick; set => m_each_tick = value; }

        public int Invisible { get => IsSet(A3Flags.Invisible); set => m_flags = (value != 0) ? Set(A3Flags.Invisible) : Reset(A3Flags.Invisible); } //M
        public int Passable { get => IsSet(A3Flags.Passable); set => m_flags = (value != 0) ? Set(A3Flags.Passable) : Reset(A3Flags.Passable); } //M
        public int Impassable { get => IsSet(A3Flags.Impassable); set => m_flags = (value != 0) ? Set(A3Flags.Impassable) : Reset(A3Flags.Impassable); } //M
        public int Visible { get => IsSet(A3Flags.Visible); set => m_flags = (value != 0) ? Set(A3Flags.Visible) : Reset(A3Flags.Visible); } //R
        public int Berkeley { get => IsSet(A3Flags.Berkeley); set => m_flags = (value != 0) ? Set(A3Flags.Berkeley) : Reset(A3Flags.Berkeley); } //M
        public int Liber { get => IsSet(A3Flags.Liber); set => m_flags = (value != 0) ? Set(A3Flags.Liber) : Reset(A3Flags.Liber); } //M
        public int Ground { get => IsSet(A3Flags.Ground); set => m_flags = (value != 0) ? Set(A3Flags.Ground) : Reset(A3Flags.Ground); } //M
        public int Candelaber { get => IsSet(A3Flags.Candelaber); set => m_flags = (value != 0) ? Set(A3Flags.Candelaber) : Reset(A3Flags.Candelaber); } //M
        public int Seen { get => IsSet(A3Flags.Seen); set => m_flags = (value != 0) ? Set(A3Flags.Seen) : Reset(A3Flags.Seen); } //M
        public int Play { get => IsSet(A3Flags.Play); set => m_flags = (value != 0) ? Set(A3Flags.Play) : Reset(A3Flags.Play); } //M
        public int Immaterial { get => IsSet(A3Flags.Immaterial); set => m_flags = (value != 0) ? Set(A3Flags.Immaterial) : Reset(A3Flags.Immaterial); } //M
        public int Flat { get => IsSet(A3Flags.Flat); set => m_flags = (value != 0) ? Set(A3Flags.Flat) : Reset(A3Flags.Flat); } //M
        public int Fragile { get => IsSet(A3Flags.Fragile); set => m_flags = (value != 0) ? Set(A3Flags.Fragile) : Reset(A3Flags.Fragile); } //M
        public int Save { get => IsSet(A3Flags.Save); set => m_flags = (value != 0) ? Set(A3Flags.Save) : Reset(A3Flags.Save); } //M

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

    }

}
