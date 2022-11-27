using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public enum A3Flags
    {
        /* Basic */
        Flag1 = 0x1,
        Flag2 = 0x2,
        Flag3 = 0x4,
        Flag4 = 0x8,
        Flag5 = 0x10,
        Flag6 = 0x20,
        Flag7 = 0x40,
        Flag8 = 0x80,

        /* Shared */
        Save = 0x100,
        Visible = 0x200,
        Seen = 0x400,
        Play = 0x800,
        Invisible = 0x1000,
        Passable = 0x2000,
        Berkeley = 0x4000,
        Immaterial = 0x8000,
        Sensitive = 0x10000,
        Fragile = 0x20000,
        Transparent = 0x40000,
        Condensed = 0x80000,
        Narrow = 0x100000,
        Impassable = 0x200000,

        /* Region */
        Floor_ascend = 0x400000,
        Ceil_ascend = 0x800000,
        Floor_descend = 0x1000000,
        Ceil_descend = 0x2000000,
        Ceil_lifted = 0x4000000,
        Floor_lifted = 0x8000000,
        Lifted = 0x10000000,
        Save_all = 0x20000000,
        Here = 0x40000000,
        Base = Impassable,
        Sticky = Narrow,

        /* Wall */
        Curtain = Floor_ascend,
        Portcullis = Ceil_ascend,
        Fence = Floor_descend,
        Far = Ceil_descend,

        /* Texture */
        Oneshot = Floor_ascend,
        Ghost = Ceil_ascend,
        Diaphanous = Floor_descend,
        Behind = Ceil_descend,
        Shadow = Ceil_lifted,
        Lightmap = Floor_lifted,
        Sky = Lifted,
        Wire = Save_all,
        Cluster = Here,
        No_clip = Impassable,
        Clip = Transparent,
        Sloop = Fragile,

        /* Palette */
        Hard = Floor_ascend,
        Autorange = Ceil_ascend,
        Blur = Floor_descend,

        /* Thing/Actor */
        Liber = Floor_ascend,
        Ground = Ceil_ascend,
        Candelaber = Floor_descend,
        Moved = Ceil_descend,
        Flat = Ceil_lifted, //change
        Carefully = Floor_lifted, //change
        Abspos = Lifted,
        Master = Save_all,

        /* Panel */
        Refresh = Floor_ascend,
        Relpos = Ceil_ascend,

        /* Text */
        Center_x = Floor_ascend,
        Center_y = Ceil_ascend,

        /* Hit Synonym */
        Thing = Ceil_lifted, //bit position must not be used by Wall, Thing, Actor
        Actor = Floor_lifted, // bit position must not be used by Wall, Thing, Actor
    }
}
