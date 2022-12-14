using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Acknex3.Api
{
    class Program
    {
        public static IEnumerable<int> Integers()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }

        public static void Exec(IEnumerable<IEnumerable<bool>> func)
        {
            foreach (IEnumerable<bool> ie in func)
            {
                foreach (bool b in ie)
                {
                    Debug.WriteLine(b.ToString());
                }
            }

        }

        public static IEnumerable<bool> Wait(long ms)
        {
            long start = DateTime.Now.Ticks;
            while (DateTime.Now.Ticks - start < 10000 * ms)
            {
                Debug.WriteLine((double)(DateTime.Now.Ticks - start) / 10000.0 + "ms");
                yield return false;
            }
            yield return true;
        }

        public static IEnumerable<IEnumerable<bool>> MyFunc()
        {
            Debug.WriteLine("Started");
           yield return Wait(1000);
            Debug.WriteLine("Done");
            yield break;
            //TimeSpan ts = new TimeSpan(10000);
        }

        static Thing w = new Thing()
        {
            Height = 3
        };
        static Skill b;
        static void Main(string[] args)
        {
            Exec(MyFunc());
            //bool ok = false;
            //do
            //{
                //ok = MyFunc().Current;
                //foreach (bool ok in MyFunc())
                    //Debug.WriteLine(ok.ToString());
                //MyFunc().MoveNext();
            //} while (!ok);

            
            foreach (int yi in Integers())
                Debug.WriteLine(yi.ToString());
            //var lobj;// = w;
            //Thing th;
            //Actor act;
            //if (lobj is Thing) th = lobj;
            //if (lobj is Actor) act = lobj;

            Bmap ba = null, bb = null, bc = null;
            Texture tx = new Texture
            {
                Bmaps = new [] { ba, bb, bc }
            };

            Region tex1 = new Region()
            {
                Floor_hgt = 1,
            };
            tex1.Instantiate();
            Region tex2 = tex1[1];
            tex2.Floor_hgt = 2;
            tex2.Skill1.Val = 23;
            tex2.Instantiate();
            tex2.Instantiate();

            Palette pal1 = new Palette()
            {
                Flags = A3Flags.Blur,
                Palfile = "testpal.pcx",
                Range = new [,] { { 16, 32 }, { 48, 32 }, { 80, 32 }, { 112, 32 }, { 144, 32 }, { 176, 32 }, { 208, 32 } },
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

            //Synonym<Palette> syn = new Synonym<Palette>();
            //syn = pal1;
            //((Palette)syn).Palfile = "x.pcx";//fixme
            Skill a = new Skill(12);
            Skill x = new Skill();
            Skill y = new Skill();
            x.Val = 23;
            y.Val = new Var(42);
            Skill z = a;
            a.Val = 66;
            a += x;

            Skill p = new Skill() { Val = 7, Min = -3, Max = 250};
            p.Val = 270;
            DoStuff(ref p);
            p.Val = a;
            x++;
            x.Val++;

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
            s.Val = 3;
            b = s;
            b *= 4;
        }
    }
}
