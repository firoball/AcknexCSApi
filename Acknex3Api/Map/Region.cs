using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Region : MapObject<Region>
    {
        private Texture m_floor_tex;
        private Texture m_ceil_tex;
        private Texture m_texture1; //undocumented
        private Texture m_texture2; //undocumented
        private Texture m_texture3; //undocumented
        private Texture m_texture4; //undocumented
        private Var m_floor_hgt;
        private Var m_ceil_hgt;
        private Var m_floor_offs_x;
        private Var m_floor_offs_y;
        private Var m_ceil_offs_x;
        private Var m_ceil_offs_y;
        private Var m_floor_angle;
        private Var m_ceil_angle;
        private Region m_below;
        private Region m_top;
        private Thing m_genius;
        private Var m_ambient;
        private Var m_clip_dist;
        private Function m_if_enter;
        private Function m_if_leave;
        private Function m_if_dive;
        private Function m_if_arise;
        private Function m_each_cycle;
        private Function m_each_tick;
        private Function m_do; //undocumented

        public Region() : base() { }

        public Texture Floor_tex { get => m_floor_tex; set => m_floor_tex = value; } //M
        public Texture Ceil_tex { get => m_ceil_tex; set => m_ceil_tex = value; } //M
        public Texture Texture1 { get => m_texture1; set => m_texture1 = value; } //M
        public Texture Texture2 { get => m_texture2; set => m_texture2 = value; } //M
        public Texture Texture3 { get => m_texture3; set => m_texture3 = value; } //M
        public Texture Texture4 { get => m_texture4; set => m_texture4 = value; } //M
        public Var Floor_hgt { get => m_floor_hgt; set => m_floor_hgt = value; } //M
        public Var Ceil_hgt { get => m_ceil_hgt; set => m_ceil_hgt = value; } //M
        public Var Floor_offs_x { get => m_floor_offs_x; set => m_floor_offs_x = value; } //M
        public Var Floor_offs_y { get => m_floor_offs_y; set => m_floor_offs_y = value; } //M
        public Var Ceil_offs_x { get => m_ceil_offs_x; set => m_ceil_offs_x = value; } //M
        public Var Ceil_offs_y { get => m_ceil_offs_y; set => m_ceil_offs_y = value; } //M
        public Var Floor_angle { get => m_floor_angle; set => m_floor_angle = value; } //M
        public Var Ceil_angle { get => m_ceil_angle; set => m_ceil_angle = value; } //M
        public Region Below { get => m_below; set => m_below = value; } //R
        public Region Top { get => m_top; set => m_top = value; } //R
        public Thing Genius { get => m_genius; set => m_genius = value; } //M
        public Var Ambient { get => m_ambient; set => m_ambient = value; } //M
        public Var Clip_dist { get => m_clip_dist; set => m_clip_dist = value; }
        public Function If_enter { get => m_if_enter; set => m_if_enter = value.Create(this); } //M
        public Function If_leave { get => m_if_leave; set => m_if_leave = value.Create(this); } //M
        public Function If_dive { get => m_if_dive; set => m_if_dive = value.Create(this); } //M
        public Function If_arise { get => m_if_arise; set => m_if_arise = value.Create(this); } //M
        public Function Each_cycle { get => m_each_cycle; set => m_each_cycle = value.Create(this); } //M
        public Function Each_cycle_c { get => m_each_cycle; set => m_each_cycle = value.Create(this); } //M undocumented, probably exclusive to ceil texture animation
        public Function Each_tick { get => m_each_tick; set => m_each_tick = value.Create(this); } //M
        public Function Do { get => m_do; set => m_do = value.Create(this); } //M

        public int? Floor_ascend { get => IsSet(A3Flags.Floor_ascend); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Floor_ascend) : Reset(A3Flags.Floor_ascend); }
        public int? Ceil_ascend { get => IsSet(A3Flags.Ceil_ascend); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Ceil_ascend) : Reset(A3Flags.Ceil_ascend); }
        public int? Floor_descend { get => IsSet(A3Flags.Floor_descend); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Floor_descend) : Reset(A3Flags.Floor_descend); }
        public int? Ceil_descend { get => IsSet(A3Flags.Ceil_descend); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Ceil_descend) : Reset(A3Flags.Ceil_descend); }
        public int? Ceil_lifted { get => IsSet(A3Flags.Ceil_lifted); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Ceil_lifted) : Reset(A3Flags.Ceil_lifted); }
        public int? Floor_lifted { get => IsSet(A3Flags.Floor_lifted); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Floor_lifted) : Reset(A3Flags.Floor_lifted); }
        public int? Lifted { get => IsSet(A3Flags.Lifted); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Lifted) : Reset(A3Flags.Lifted); }
        public int? Visible { get => IsSet(A3Flags.Visible); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Visible) : Reset(A3Flags.Visible); } //R
        public int? Seen { get => IsSet(A3Flags.Seen); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Seen) : Reset(A3Flags.Seen); } //M
        public int? Save { get => IsSet(A3Flags.Save); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Save) : Reset(A3Flags.Save); }
        public int? Save_all { get => IsSet(A3Flags.Save_all); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Save_all) : Reset(A3Flags.Save_all); }
        public int? Here { get => IsSet(A3Flags.Here); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Here) : Reset(A3Flags.Here); } //R
        public int? Base { get => IsSet(A3Flags.Base); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Base) : Reset(A3Flags.Base); } //M
        public int? Sticky { get => IsSet(A3Flags.Sticky); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Sticky) : Reset(A3Flags.Sticky); }
        public int? Play { get => IsSet(A3Flags.Play); set => m_flags = (value.HasValue && (value != 0)) ? Set(A3Flags.Play) : Reset(A3Flags.Play); } //M

        public void Lift(Var dz)
        {

        }

        public void Tilt(Var multiplier)
        {

        }

        public void Shift(Var dx, Var dy)
        {

        }

        public void Rotate(Var radians)
        {

        }

    }

}
