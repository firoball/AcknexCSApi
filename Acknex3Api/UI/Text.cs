using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Text : UIObject
    {
        private Var m_size_y; //M
        private Var m_offset_y; //M
        private Var m_strings;
        private Font m_font;
        private Var m_scale_x; //R
        private Var m_scale_y; //R
        private string[] m_string_array; //M
        private Var m_index; //M

        public Var Size_y { get => m_size_y; set => m_size_y = value; }
        public Var Offset_y { get => m_offset_y; set => m_offset_y = value; }
        public Var Strings { get => m_strings; set => m_strings = value; }
        public Font Font { get => m_font; set => m_font = value; }
        public Var Scale_x { get => m_scale_x; set => m_scale_x = value; }
        public Var Scale_y { get => m_scale_y; set => m_scale_y = value; }
        public string[] String_array { get => m_string_array; set => m_string_array = value; } //special case for construction of a new Text
        public string String { get => m_string_array[m_index-1]; set => m_string_array[m_index - 1] = value; }
        public Var Index { get => m_index; set => m_index = value; }

        public int Center_x { get => IsSet(A3Flags.Center_x); set => m_flags = (value != 0) ? Set(A3Flags.Center_x) : Reset(A3Flags.Center_x); }
        public int Center_y { get => IsSet(A3Flags.Center_y); set => m_flags = (value != 0) ? Set(A3Flags.Center_y) : Reset(A3Flags.Center_y); }
        public int Condensed { get => IsSet(A3Flags.Condensed); set => m_flags = (value != 0) ? Set(A3Flags.Condensed) : Reset(A3Flags.Condensed); }
        public int Narrow { get => IsSet(A3Flags.Narrow); set => m_flags = (value != 0) ? Set(A3Flags.Narrow) : Reset(A3Flags.Narrow); }

        public Var Find(string str)
        {
            //handle setting of Result-Skill here or at caller level?
            return -1;
        }

    }
}
