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
        Thing = 0x100,
        Actor = 0x200,
        Save = 0x400,
        Visible = 0x800,
        Seen = 0x1000,
        Play = 0x2000,
        Invisible = 0x4000,
        Passable = 0x8000,
        Berkeley = 0x10000,
        Immaterial = 0x20000,
        Sensitive = 0x40000,
        Fragile = 0x80000,
        Transparent = 0x100000,
        Condensed = 0x200000,
        Narrow = 0x400000,
        Impassable = 0x800000,

        /* Region */
        Floor_ascend = 0x1000000,
        Ceil_ascend = 0x2000000,
        Floor_descend = 0x4000000,
        Ceil_descend = 0x8000000,
        Ceil_lifted = 0x10000000,
        Floor_lifted = 0x20000000,
        Lifted = 0x40000000,
        Save_all = Transparent,
        Here = Condensed,
        Base = Narrow,
        Sticky = Impassable,

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
        Sky = Sensitive,
        Wire = Fragile,
        Cluster = Transparent,
        No_clip = Condensed,
        Clip = Narrow,
        Sloop = Impassable,
        Floor = Visible, //undocumented

        /* Palette */
        Hard = Floor_ascend,
        Autorange = Ceil_ascend,
        Blur = Floor_descend,

        /* Thing/Actor */
        Liber = Floor_ascend,
        Ground = Ceil_ascend,
        Candelaber = Floor_descend,
        Moved = Ceil_descend,
        Flat = Ceil_lifted,
        Carefully = Floor_lifted,
        Abspos = Lifted,
        Master = Transparent,

        /* Panel */
        Refresh = Floor_ascend,
        Relpos = Ceil_ascend,

        /* Text */
        Center_x = Floor_ascend,
        Center_y = Ceil_ascend,
        Center = Center_x | Center_y, //undocumented
    }
}
