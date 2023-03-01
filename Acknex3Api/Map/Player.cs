using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public class Player : BaseObject
    {
        private static Player s_player = null;

        public Player()
        {
            if (s_player == null)
                s_player = this;
        }

        public static void Push(Var distance)
        {

        }

        public static new void Shoot()
        {
            //shoot nearest obj in line of sight of player
        }

        public static new void Locate()
        {
            //update Globals.Here to actual region of player
        }
    }
}
