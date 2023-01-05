using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public static class Commands
    {
        //Set
        //Set_all
        //Add
        //Addt
        //Sin
        //Asin
        //Sqrt
        //And
        //Rule
        //If_above
        //If_below
        //If_equal
        //If_nequal
        //If_min
        //If_max
        //Else
        //Skip
        //Goto
        //Branch
        //Call
        //End
        //Set_string
        //Add_string (new39)
        //Set_skill (new39)
        //To_string (new39)

/* Implemented by Skill
        public static Skill Accel(Skill skill1, Skill skill2)
        {
            return new Skill();
        }

        public static Var Randomize(Var value)
        {
            return value;
        }
*/
/* Implemented by BaseObject, Wall
        public static void Play_sound(Sound sound, Var volume, ILevelObject obj)
        {

        }
*/
/* Implemented by BaseObject, Wall
        public static void Play_sound(string file, Var volume, ILevelObject obj)
        {

        }
*/
        //Diag
        public static void Beep()
        {

        }
/* implemented by Text

        public static void Fade_pal(Palette palette, Var factor)
        {

        }
*/
/* implemented by Text
        public static void Find(Text text, string str)
        {

        }
*/
        /* Implemented by Player

        public static void Push(Var distance)
        {

        }

        public static void Shoot()
        {

        }
        */
        /* Implemented by ILevelObejct

        public static void Shoot(ILevelObject target)
        {

        }

                public static void Locate()
                {
                    //Relocate Player
                }

                public static void Locate(ILevelObject obj)
                {

                }

                public static void Drop(ILevelObject obj)
                {

                }

                public static void Place(ILevelObject obj)
                {

                }

                public static void Explode(ILevelObject obj)
                {

                }

                public static void Shake(ILevelObject obj)
                {

                }
        */

        /* implemented by Region
                public static void Lift(Region region, Var dz)
                {

                }

                public static void Tilt(Region region, Var multiplier)
                {

                }

                public static void Shift(Region region, Var dx, Var dy)
                {

                }

                public static void Rotate(Region region, Var radians)
                {

                }
        */
        //Diag
        public static void Printfile(string name, Var number)
        {

        }
        //Diag
        public static void Print(Var value)
        {

        }
        //Diag
        public static void Print(string text)
        {

        }

        /*implemented by MapObject
        public static void Exclusive()
        {

        }
        */
        /*implemented by BaseObject, Wall, ILevelObject
        public static void Next_my()
        {

        }

        public static void Next_there()
        {

        }

        public static void Next_my_there()
        {

        }
        */
    }

}
