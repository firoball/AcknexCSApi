using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Wall : MapObject<Wall>, ILevelObject
    {
        private Texture m_texture;
        private Texture m_attach;
        private Var m_offset_x;
        private Var m_offset_y;
        private Var m_cycle;
        private Var m_position;
        private Var m_map_color;
        private Var m_dist;
        private Var m_distance;
        private Var m_length;
        private Var m_size_x;
        private Var m_x1;
        private Var m_y1;
        private Var m_z1;
        private Var m_x2;
        private Var m_y2;
        private Var m_z2;
        private Region m_left;
        private Region m_right;
        private Function m_if_near;
        private Function m_if_far;
        private Function m_if_hit;
        private Function m_each_cycle;
        private Function m_each_tick;

        public Wall() : base() { }

        public Texture Texture { get => m_texture; set => m_texture = value; } //M
        public Texture Attach { get => m_attach; set => m_attach = value; } //M
        public Var Offset_x { get => m_offset_x; set => m_offset_x = value; } //M
        public Var Offset_y { get => m_offset_y; set => m_offset_y = value; } //M
        public Var Cycle { get => m_cycle; set => m_cycle = value; } //M
        public Var Position { get => m_position; set => m_position = value; } //M
        public Var Map_color { get => m_map_color; set => m_map_color = value; }
        public Var Dist { get => m_dist; set => m_dist = value; } //M
        public Var Distance { get => m_distance; set => m_distance = value; } //R
        public Var Length { get => m_length; set => m_length = value; } //R
        public Var Size_x { get => m_size_x; set => m_size_x = value; } //R
        public Var X1 { get => m_x1; set => m_x1 = value; } //M
        public Var Y1 { get => m_y1; set => m_y1 = value; } //M
        public Var Z1 { get => m_z1; set => m_z1 = value; } //M
        public Var X2 { get => m_x2; set => m_x2 = value; } //M
        public Var Y2 { get => m_y2; set => m_y2 = value; } //M
        public Var Z2 { get => m_z2; set => m_z2 = value; } //M
        public Region Left { get => m_left; set => m_left = value; } //R
        public Region Right { get => m_right; set => m_right = value; } //R
        public Function If_near { get => m_if_near; set => m_if_near = value; } //M
        public Function If_far { get => m_if_far; set => m_if_far = value; } //M
        public Function If_hit { get => m_if_hit; set => m_if_hit = value; } //M
        public Function Each_cycle { get => m_each_cycle; set => m_each_cycle = value; } //M
        public Function Each_tick { get => m_each_tick; set => m_each_tick = value; } //M

        public Var X { get => m_x1; set => m_x1 = value; } //implement ILevelObject
        public Var Y { get => m_y1; set => m_y1 = value; } //implement ILevelObject

        public int Invisible { get => IsSet(A3Flags.Invisible); set => m_flags = (value != 0) ? Set(A3Flags.Invisible) : Reset(A3Flags.Invisible); } //M
        public int Passable { get => IsSet(A3Flags.Passable); set => m_flags = (value != 0) ? Set(A3Flags.Passable) : Reset(A3Flags.Passable); } //M
        public int Immaterial { get => IsSet(A3Flags.Immaterial); set => m_flags = (value != 0) ? Set(A3Flags.Immaterial) : Reset(A3Flags.Immaterial); } //M
        public int Impassable { get => IsSet(A3Flags.Impassable); set => m_flags = (value != 0) ? Set(A3Flags.Impassable) : Reset(A3Flags.Impassable); } //M
        public int Visible { get => IsSet(A3Flags.Visible); set => m_flags = (value != 0) ? Set(A3Flags.Visible) : Reset(A3Flags.Visible); } //R
        public int Seen { get => IsSet(A3Flags.Seen); set => m_flags = (value != 0) ? Set(A3Flags.Seen) : Reset(A3Flags.Seen); } //M
        public int Berkeley { get => IsSet(A3Flags.Berkeley); set => m_flags = (value != 0) ? Set(A3Flags.Berkeley) : Reset(A3Flags.Berkeley); } //M
        public int Transparent { get => IsSet(A3Flags.Transparent); set => m_flags = (value != 0) ? Set(A3Flags.Transparent) : Reset(A3Flags.Transparent); } //M
        public int Play { get => IsSet(A3Flags.Play); set => m_flags = (value != 0) ? Set(A3Flags.Play) : Reset(A3Flags.Play); } //M
        public int Curtain { get => IsSet(A3Flags.Curtain); set => m_flags = (value != 0) ? Set(A3Flags.Curtain) : Reset(A3Flags.Curtain); }
        public int Portcullis { get => IsSet(A3Flags.Portcullis); set => m_flags = (value != 0) ? Set(A3Flags.Portcullis) : Reset(A3Flags.Portcullis); } //M
        public int Fence { get => IsSet(A3Flags.Fence); set => m_flags = (value != 0) ? Set(A3Flags.Fence) : Reset(A3Flags.Fence); }
        public int Sensitive { get => IsSet(A3Flags.Sensitive); set => m_flags = (value != 0) ? Set(A3Flags.Sensitive) : Reset(A3Flags.Sensitive); } //M
        public int Fragile { get => IsSet(A3Flags.Fragile); set => m_flags = (value != 0) ? Set(A3Flags.Fragile) : Reset(A3Flags.Fragile); } //M
        public int Far { get => IsSet(A3Flags.Far); set => m_flags = (value != 0) ? Set(A3Flags.Far) : Reset(A3Flags.Far); }
        public int Save { get => IsSet(A3Flags.Save); set => m_flags = (value != 0) ? Set(A3Flags.Save) : Reset(A3Flags.Save); }

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
