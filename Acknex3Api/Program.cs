using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Acknex3.Api
{
    class Program
    {
        static Skill b;
        static void Main(string[] args)
        {
            Region tex1 = new Region()
            {
                Floor_hgt = 1
            };
            tex1.Instantiate();
            Region tex2 = tex1[1];
            tex2.Floor_hgt = 2;
            tex2.Skill1.Value = 23;
            tex2.Instantiate();
            tex2.Instantiate();

            Palette pal1 = new Palette()
            {
                Flags = A3Flags.Blur,
                Palfile = "testpal.pcx",
                Range = new[,] { { 16, 32 }, { 48, 32 }, { 80, 32 }, { 112, 32 }, { 144, 32 }, { 176, 32 }, { 208, 32 } },
            };
            Region tex3 = new Region()
            {
                Floor_hgt = 3
            };
            Region tex4 = tex2[0];
            foreach(Region t in tex1)
            {
                Debug.WriteLine(t.Floor_hgt);// +" " +t.Skill1.Value+" ");
            }

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

            RegisterMethod(() => { return x+10; });
            result();
        }

        public static Func<Var> result;
        static void RegisterMethod(Func<Var> update)
        {
            result = update;
        }


        static void DoStuff(ref Skill s)
        {
            Debug.WriteLine(s);
            s.Value = 3;
            b = s;
            b *= 4;
        }
    }
}
