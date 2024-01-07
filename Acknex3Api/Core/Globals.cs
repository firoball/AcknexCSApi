using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public static class Globals
    {
        /* Global Settings*/
        public static string Video;
        public static Var Nexus;
        public static Var Clip_dist;
        public static Var Light_angle;
        public static string Ibank;
        public static string Drumbank;
        public static Var Midi_pitch;
        public static string Mapfile;
        public static string Savedir;
        public static string Starttext;
        public static Var Dither;

        /* Lists */
        public static Function[] Each_tick = new Function[16];
        public static Function[] Each_sec = new Function[16];
        public static Panel[] Panels = new Panel[16];
        public static Overlay[] Layers = new Overlay[16];
        public static Text[] Messages = new Text[16];

        /* Synonyms */
        public static Region Here;
        public static Region There; //inside Function only
        public static BaseObject My; //inside Function only - identify type automatically based on thing/actor flags
        public static BaseObject Hit; //Thing, Actor, Wall -- TODO: level instances 
        public static Text Touch_text;
        public static BaseObject Touched; //Thing, Actor, Wall -- TODO: level instances 
        public static Texture Touch_tex;
        public static Region Touch_reg;
        public static string Command_line;
        public static Overlay Msprite;
        public static Region Region1; //undocumented
        public static Region Region2; //undocumented
        public static Region Region3; //undocumented
        public static Region Region4; //undocumented
        public static Region Region5; //undocumented
        public static Region Region6; //undocumented
        public static Region Region7; //undocumented
        public static Region Region8; //undocumented

        /* Player object */
        public static Actor Player;
    }
}
