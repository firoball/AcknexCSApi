using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public static class Environment
    {

        public static Skill Inport(Var port)
        {
            return new Skill();
        }

        public static void Outport(Skill skill, Var port)
        {

        }

        public static void Freeze(Bmap bmap, Var factor)
        {

        }

        public static void Screenshot(string name, Var count)
        {

        }

        public static void Save(string name, Var number, bool info)
        {

        }

        public static void Load(string name, Var number, bool info)
        {

        }

        public static void Save_demo(string name, Var number)
        {

        }

        public static void Play_demo(string name, Var number)
        {

        }

        public static void Stop_demo()
        {

        }

        public static void Map(string file)
        {

        }

        public static void Level(string file)
        {
            //how to handle wrs parameter?
        }

        public static void Exit()
        {

        }

        public static void Exit(string message)
        {

        }

    }
}
