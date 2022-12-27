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
*/
        public static Var Randomize(Var value)
        {
            return value;
        }

        //Todo: IENumerator - Scheduler class
        public static void Wait(Var value)
        {

        }

        //Todo: IENumerator - Scheduler class
        public static void Waitt(Var value)
        {

        }
        //Todo: Media class
        public static void Play_sound(Sound sound, Var volume)
        {

        }

        //Todo: Media class
        public static void Play_sound(Sound sound, Var volume, Var balance)
        {

        }

/* Implemented by BaseObject, Wall
        public static void Play_sound(Sound sound, Var volume, ILevelObject obj)
        {

        }
*/
        //Todo: Media class
        public static void Play_sound(string file, Var volume, Var balance)
        {

        }

/* Implemented by BaseObject, Wall
        public static void Play_sound(string file, Var volume, ILevelObject obj)
        {

        }
*/
        public static void Stop_sound()
        {

        }

        public static void Play_song(Music music, Var volume, bool loop)
        {

        }

        public static void Play_cd(Var start, Var end)
        {

        }

        public static void Play_flic(Flic flic)
        {

        }

        public static void Play_flic(string file)
        {

        }

        public static void Stop_flic()
        {

        }

        public static void Beep()
        {

        }

        public static Skill Inport(Var port)
        {
            return new Skill();
        }

        public static void Outport(Skill skill, Var port)
        {

        }

        public static void Fade_pal(Palette palette, Var factor)
        {

        }

        public static void Setmidi(Var channel, Var status)
        {

        }

        public static Var Getmidi(Var channel)
        {
            return new Var();
        }

        public static void Midi_com(Var status, Var data1, Var data2)
        {

        }

        public static string Inkey()
        {
            return string.Empty;
        }

/* implemented by Text
        public static void Find(Text text, string str)
        {

        }
*/

        public static void Freeze(Bmap bmap, Var factor)
        {

        }

        public static void Screenshot(string name, Var count)
        {

        }

        public static void Push(Var distance)
        {

        }

        public static void Shoot()
        {

        }

        public static void Shoot(ILevelObject target)
        {

        }

        /* Implemented by ILevelObejct
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

        public static void Printfile(string name, Var number)
        {

        }

        public static void Print(Var value)
        {

        }

        public static void Print(string text)
        {

        }

        //move to MapObject?
        public static void Exclusive()
        {

        }

        public static void Next_my()
        {

        }

        public static void Next_there()
        {

        }

        public static void Next_my_there()
        {

        }
    }

}
