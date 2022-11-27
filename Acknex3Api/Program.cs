using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    class Program
    {
        static Skill b;
        static void Main(string[] args)
        {
            Texture tex1 = new Texture()
            {
                Sides = 3
            };

            Palette pal1 = new Palette()
            {
                Flags = A3Flags.Blur,
                Palfile = "testpal.pcx",
                Range = new[,] { { 16, 32 }, { 48, 32 }, { 80, 32 }, { 112, 32 }, { 144, 32 }, { 176, 32 }, { 208, 32 } },
            };

            Synonym<Palette> syn = new Synonym<Palette>();
            syn = pal1;
            ((Palette)syn).Palfile = "x.pcx";//fixme
            Skill a = new Skill(12);
            Skill x = new Skill();
            Skill y = new Skill();
            x.Value = 23;
            y.Value = new Var(42);
            Skill z = a;
            a.Value = 66;
            a += x;

            Skill p = new Skill() { Value = 7, Min = -3, Max = 250};
            p.Value = 270;
            DoStuff(ref p);
            p.Value = a;
            x++;
            x.Value++;
        }

        static void DoStuff(ref Skill s)
        {
            s.Value = 3;
            b = s;
            b *= 4;
        }
    }
}
