using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public abstract class Asset
    {
        protected string m_file;

        public Asset(string file)
        {
            m_file = file;
        }
    }

    public abstract class Bitmap : Asset
    {
        protected Var m_x;
        protected Var m_y;
        protected Var m_dx;
        protected Var m_dy;

        public Bitmap(string file) : base(file)
        {
            m_x = 0;
            m_y = 0;
            //TODO: DX = bitmap size, DY = bitmap height
        }
        public Bitmap(string file, Var x, Var y, Var dx, Var dy) : base(file)
        {
            m_x = x;
            m_y = y;
            m_dx = dx;
            m_dy = dy;
        }
    }

    public class Bmap : Bitmap
    {
        public Bmap(string file) : base(file) { }
        public Bmap(string file, Var x, Var y, Var dx, Var dy) : base(file, x, y, dx, dy) { }
    }

    public class Ovly : Bitmap
    {
        public Ovly(string file) : base(file) { }
        public Ovly(string file, Var x, Var y, Var dx, Var dy) : base(file, x, y, dx, dy) { }
    }

    public class Flic : Asset
    {
        public Flic(string file) : base(file) { }
    }

    public class Model : Asset
    {
        public Model(string file) : base(file) { }
    }

    public class Sound : Asset
    {
        public Sound(string file) : base(file) { }
    }

    public class Font : Bitmap
    {
        private Var m_width;
        private Var m_height;

        public Font(string file, Var width, Var height) : base(file)
        {
            m_width = width;
            m_height = height;
        }
        public Font(string file, Var width, Var height, Var x, Var y, Var dx, Var dy) : base(file, x, y, dx, dy)
        {
            m_width = width;
            m_height = height;
        }
    }

    public class Way { }
    public class Function { }

}
