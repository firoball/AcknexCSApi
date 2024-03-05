using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Texture : A3Object
    {
        private Var m_sides;
        private Var m_cycles;
        private Var m_frame;
        private Bmap[] m_bmaps;
        private Flic m_flic;
        private string m_title;
        private Model m_model;
        private Var[] m_delay;
        private Var[] m_mirror;
        private Var[] m_offset_x;
        private Var[] m_offset_y;
        private Var m_random;
        private Var m_scale_x;
        private Var m_scale_y;
        private Var m_ambient;
        private Var m_albedo;
        private Var m_radiance;
        private Sound m_sound;
        private Var m_svol;
        private Var m_sdist;
        private Var m_svdist;
        private Var[] m_scycles;
        private Var m_scycle; //undocumented
        private Texture m_attach;
        private Var m_pos_x;
        private Var m_pos_y;
        private string m_touch;
        private Font m_font;
        private Function m_if_touch;
        private Function m_if_release;
        private Function m_if_klick;

        public Texture(string name) : base(name) {}

        public Var Sides { get => m_sides; set => m_sides = value; }
        public Var Cycles { get => m_cycles; set => m_cycles = value; }
        public Var Frame { get => m_frame; set => m_frame = value; }
        public Bmap[] Bmaps { get => m_bmaps; set => m_bmaps = value; }
        public Flic Flic { get => m_flic; set => m_flic = value; }
        public string Title { get => m_title; set => m_title = value; }
        public Model Model { get => m_model; set => m_model = value; }
        public Var[] Delay { get => m_delay; set => m_delay = value; }
        public Var[] Mirror { get => m_mirror; set => m_mirror = value; }
        public Var[] Offset_x { get => m_offset_x; set => m_offset_x = value; }
        public Var[] Offset_y { get => m_offset_y; set => m_offset_y = value; }
        public Var Random { get => m_random; set => m_random = value; }
        public Var Scale_x { get => m_scale_x; set => m_scale_x = value; } //M
        public Var Scale_y { get => m_scale_y; set => m_scale_y = value; } //M
        public Var[] Scale_xy
        {
            set {
                if (value.Length >= 2)
                {
                    m_scale_x = value[0];
                    m_scale_y = value[1];
                }
            }
        } //M
        public Var Scale
        {
            set { m_scale_x = value; m_scale_y = value; }
        } //M - undocumented
        public Var Ambient { get => m_ambient; set => m_ambient = value; } //M
        public Var Albedo { get => m_albedo; set => m_albedo = value; } //M
        public Var Radiance { get => m_radiance; set => m_radiance = value; }
        public Sound Sound { get => m_sound; set => m_sound = value; } //M
        public Var Svol { get => m_svol; set => m_svol = value; } //M
        public Var Sdist { get => m_sdist; set => m_sdist = value; } //M
        public Var Svdist { get => m_svdist; set => m_svdist = value; } //M
        public Var[] Scycles { get => m_scycles; set => m_scycles = value; }
        public Var Scycle { get => m_scycle; set => m_scycle = value; }
        public Texture Attach { get => m_attach; set => m_attach = value; } //M
        public Var Pos_x { get => m_pos_x; set => m_pos_x = value; } //M
        public Var Pos_y { get => m_pos_y; set => m_pos_y = value; } //M
        public string Touch { get => m_touch; set => m_touch = value; } //M
        public Font Font { get => m_font; set => m_font = value; }
        public Function If_touch { get => m_if_touch; set => m_if_touch = value.Create(this); } //M
        public Function If_release { get => m_if_release; set => m_if_release = value.Create(this); } //M
        public Function If_klick { get => m_if_klick; set => m_if_klick = value.Create(this); } //M

        public Var Oneshot { get => IsSet(A3Flags.Oneshot); set => m_flags = (value != 0) ? Set(A3Flags.Oneshot) : Reset(A3Flags.Oneshot); }
        public Var Ghost { get => IsSet(A3Flags.Ghost); set => m_flags = (value != 0) ? Set(A3Flags.Ghost) : Reset(A3Flags.Ghost); }
        public Var Diaphanous { get => IsSet(A3Flags.Diaphanous); set => m_flags = (value != 0) ? Set(A3Flags.Diaphanous) : Reset(A3Flags.Diaphanous); }
        public Var Behind { get => IsSet(A3Flags.Behind); set => m_flags = (value != 0) ? Set(A3Flags.Behind) : Reset(A3Flags.Behind); }
        public Var Shadow { get => IsSet(A3Flags.Shadow); set => m_flags = (value != 0) ? Set(A3Flags.Shadow) : Reset(A3Flags.Shadow); }
        public Var Lightmap { get => IsSet(A3Flags.Lightmap); set => m_flags = (value != 0) ? Set(A3Flags.Lightmap) : Reset(A3Flags.Lightmap); }
        public Var Sky { get => IsSet(A3Flags.Sky); set => m_flags = (value != 0) ? Set(A3Flags.Sky) : Reset(A3Flags.Sky); }
        public Var Wire { get => IsSet(A3Flags.Wire); set => m_flags = (value != 0) ? Set(A3Flags.Wire) : Reset(A3Flags.Wire); }
        public Var Cluster { get => IsSet(A3Flags.Cluster); set => m_flags = (value != 0) ? Set(A3Flags.Cluster) : Reset(A3Flags.Cluster); }
        public Var No_clip { get => IsSet(A3Flags.No_clip); set => m_flags = (value != 0) ? Set(A3Flags.No_clip) : Reset(A3Flags.No_clip); }
        public Var Clip { get => IsSet(A3Flags.Clip); set => m_flags = (value != 0) ? Set(A3Flags.Clip) : Reset(A3Flags.Clip); }
        public Var Sloop { get => IsSet(A3Flags.Sloop); set => m_flags = (value != 0) ? Set(A3Flags.Sloop) : Reset(A3Flags.Sloop); }
        public Var Condensed { get => IsSet(A3Flags.Condensed); set => m_flags = (value != 0) ? Set(A3Flags.Condensed) : Reset(A3Flags.Condensed); }
        public Var Narrow { get => IsSet(A3Flags.Narrow); set => m_flags = (value != 0) ? Set(A3Flags.Narrow) : Reset(A3Flags.Narrow); }
        public Var Save { get => IsSet(A3Flags.Save); set => m_flags = (value != 0) ? Set(A3Flags.Save) : Reset(A3Flags.Save); }

    }
}
