﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public static class Globals
    {
        /* Skills */
        public static Skill Acceleration = new Skill();
        public static Skill Actions = new Skill();
        public static Skill Active_nexus = new Skill();
        public static Skill Active_objticks = new Skill();
        public static Skill Active_targets = new Skill();
        public static Skill Actor_ceil_hgt = new Skill();
        public static Skill Actor_climb = new Skill();
        public static Skill Actor_dist = new Skill();
        public static Skill Actor_floor_hgt = new Skill();
        public static Skill Actor_impact_vx = new Skill();
        public static Skill Actor_impact_vy = new Skill();
        public static Skill Actor_impact_vz = new Skill();
        public static Skill Actor_width = new Skill();
        public static Skill Ambient = new Skill();
        public static Skill Aspect = new Skill();
        public static Skill Blur_mode = new Skill();
        public static Skill Bounce_vx = new Skill();
        public static Skill Bounce_vy = new Skill();
        public static Skill Cdaudio_vol = new Skill();
        public static Skill Cd_track = new Skill();
        public static Skill Ceil_hgt = new Skill();
        public static Skill Channel = new Skill();
        public static Skill Channel_0 = new Skill();
        public static Skill Channel_1 = new Skill();
        public static Skill Channel_2 = new Skill();
        public static Skill Channel_3 = new Skill();
        public static Skill Channel_4 = new Skill();
        public static Skill Channel_5 = new Skill();
        public static Skill Channel_6 = new Skill();
        public static Skill Channel_7 = new Skill();
        public static Skill Clipping = new Skill();
        public static Skill Color_actors = new Skill();
        public static Skill Color_border = new Skill();
        public static Skill Color_player = new Skill();
        public static Skill Color_things = new Skill();
        public static Skill Color_walls = new Skill();
        public static Skill Dark_dist = new Skill();
        public static Skill Debug_mode = new Skill();
        public static Skill Delta_angle = new Skill();
        public static Skill Error = new Skill();
        public static Skill Flic_frame = new Skill();
        public static Skill Floor_hgt = new Skill();
        public static Skill Force_ahead = new Skill();
        public static Skill Force_rot = new Skill();
        public static Skill Force_strafe = new Skill();
        public static Skill Force_tilt = new Skill();
        public static Skill Force_up = new Skill();
        public static Skill Friction = new Skill();
        public static Skill Hit_dist = new Skill();
        public static Skill Hit_mindist = new Skill();
        public static Skill Hit_x = new Skill();
        public static Skill Hit_y = new Skill();
        public static Skill Impact_vrot = new Skill();
        public static Skill Impact_vx = new Skill();
        public static Skill Impact_vy = new Skill();
        public static Skill Impact_vz = new Skill();
        public static Skill Inertia = new Skill();
        public static Skill Joystick_x = new Skill();
        public static Skill Joystick_y = new Skill();
        public static Skill Joy_4 = new Skill();
        public static Skill Joy_sense = new Skill();
        public static Skill Key_0 = new Skill();
        public static Skill Key_1 = new Skill();
        public static Skill Key_2 = new Skill();
        public static Skill Key_3 = new Skill();
        public static Skill Key_4 = new Skill();
        public static Skill Key_5 = new Skill();
        public static Skill Key_6 = new Skill();
        public static Skill Key_7 = new Skill();
        public static Skill Key_8 = new Skill();
        public static Skill Key_9 = new Skill();
        public static Skill Key_a = new Skill();
        public static Skill Key_alt = new Skill();
        public static Skill Key_any = new Skill();
        public static Skill Key_apo = new Skill();
        public static Skill Key_b = new Skill();
        public static Skill Key_bksl = new Skill();
        public static Skill Key_bksp = new Skill();
        public static Skill Key_brackl = new Skill();
        public static Skill Key_brackr = new Skill();
        public static Skill Key_c = new Skill();
        public static Skill Key_cal = new Skill();
        public static Skill Key_car = new Skill();
        public static Skill Key_comma = new Skill();
        public static Skill Key_ctrl = new Skill();
        public static Skill Key_cud = new Skill();
        public static Skill Key_cul = new Skill();
        public static Skill Key_cur = new Skill();
        public static Skill Key_cuu = new Skill();
        public static Skill Key_d = new Skill();
        public static Skill Key_del = new Skill();
        public static Skill Key_e = new Skill();
        public static Skill Key_end = new Skill();
        public static Skill Key_enter = new Skill();
        public static Skill Key_equals = new Skill();
        public static Skill Key_esc = new Skill();
        public static Skill Key_f = new Skill();
        public static Skill Key_f1 = new Skill();
        public static Skill Key_f10 = new Skill();
        public static Skill Key_f11 = new Skill();
        public static Skill Key_f12 = new Skill();
        public static Skill Key_f2 = new Skill();
        public static Skill Key_f3 = new Skill();
        public static Skill Key_f4 = new Skill();
        public static Skill Key_f5 = new Skill();
        public static Skill Key_f6 = new Skill();
        public static Skill Key_f7 = new Skill();
        public static Skill Key_f8 = new Skill();
        public static Skill Key_f9 = new Skill();
        public static Skill Key_g = new Skill();
        public static Skill Key_h = new Skill();
        public static Skill Key_home = new Skill();
        public static Skill Key_i = new Skill();
        public static Skill Key_ins = new Skill();
        public static Skill Key_j = new Skill();
        public static Skill Key_k = new Skill();
        public static Skill Key_l = new Skill();
        public static Skill Key_m = new Skill();
        public static Skill Key_minus = new Skill();
        public static Skill Key_n = new Skill();
        public static Skill Key_o = new Skill();
        public static Skill Key_p = new Skill();
        public static Skill Key_pause = new Skill();
        public static Skill Key_period = new Skill();
        public static Skill Key_pgdn = new Skill();
        public static Skill Key_pgup = new Skill();
        public static Skill Key_plus = new Skill();
        public static Skill Key_q = new Skill();
        public static Skill Key_r = new Skill();
        public static Skill Key_s = new Skill();
        public static Skill Key_semic = new Skill();
        public static Skill Key_sense = new Skill();
        public static Skill Key_shift = new Skill();
        public static Skill Key_slash = new Skill();
        public static Skill Key_space = new Skill();
        public static Skill Key_sz = new Skill();
        public static Skill Key_t = new Skill();
        public static Skill Key_tab = new Skill();
        public static Skill Key_u = new Skill();
        public static Skill Key_v = new Skill();
        public static Skill Key_w = new Skill();
        public static Skill Key_x = new Skill();
        public static Skill Key_y = new Skill();
        public static Skill Key_z = new Skill();
        public static Skill Light_dist = new Skill();
        public static Skill Load_mode = new Skill();
        public static Skill Map_centerx = new Skill();
        public static Skill Map_centery = new Skill();
        public static Skill Map_edge_x1 = new Skill();
        public static Skill Map_edge_x2 = new Skill();
        public static Skill Map_edge_y1 = new Skill();
        public static Skill Map_edge_y2 = new Skill();
        public static Skill Map_layer = new Skill();
        public static Skill Map_maxx = new Skill();
        public static Skill Map_maxy = new Skill();
        public static Skill Map_minx = new Skill();
        public static Skill Map_miny = new Skill();
        public static Skill Map_mode = new Skill();
        public static Skill Map_offs_x = new Skill();
        public static Skill Map_offs_y = new Skill();
        public static Skill Map_rot = new Skill();
        public static Skill Map_scale = new Skill();
        public static Skill Max_dist = new Skill();
        public static Skill Mickey_x = new Skill();
        public static Skill Mickey_y = new Skill();
        public static Skill Motion_blur = new Skill();
        public static Skill Mouse_angle = new Skill();
        public static Skill Mouse_calm = new Skill();
        public static Skill Mouse_left = new Skill();
        public static Skill Mouse_middle = new Skill();
        public static Skill Mouse_mode = new Skill();
        public static Skill Mouse_moving = new Skill();
        public static Skill Mouse_right = new Skill();
        public static Skill Mouse_sense = new Skill();
        public static Skill Mouse_time = new Skill();
        public static Skill Mouse_x = new Skill();
        public static Skill Mouse_y = new Skill();
        public static Skill Move_angle = new Skill();
        public static Skill Move_mode = new Skill();
        public static Skill Music_vol = new Skill();
        public static Skill Node = new Skill();
        public static Skill Palanim_delay = new Skill();
        public static Skill Panel_layer = new Skill();
        public static Skill Player_Angle = new Skill();
        public static Skill Player_arc = new Skill();
        public static Skill Player_climb = new Skill();
        public static Skill Player_cos = new Skill();
        public static Skill Player_depth = new Skill();
        public static Skill Player_hgt = new Skill();
        public static Skill Player_last_x = new Skill();
        public static Skill Player_last_y = new Skill();
        public static Skill Player_light = new Skill();
        public static Skill Player_sin = new Skill();
        public static Skill Player_size = new Skill();
        public static Skill Player_speed = new Skill();
        public static Skill Player_tilt = new Skill();
        public static Skill Player_vrot = new Skill();
        public static Skill Player_vx = new Skill();
        public static Skill Player_vy = new Skill();
        public static Skill Player_vz = new Skill();
        public static Skill Player_width = new Skill();
        public static Skill Player_x = new Skill();
        public static Skill Player_y = new Skill();
        public static Skill Player_z = new Skill();
        public static Skill Psound_tone = new Skill();
        public static Skill Psound_vol = new Skill();
        public static Skill Random = new Skill();
        public static Skill Remote_0 = new Skill();
        public static Skill Remote_1 = new Skill();
        public static Skill Render_mode = new Skill();
        public static Skill Result = new Skill();
        public static Skill Screen_hgt = new Skill();
        public static Skill Screen_width = new Skill();
        public static Skill Screen_x = new Skill();
        public static Skill Screen_y = new Skill();
        public static Skill Secs = new Skill();
        public static Skill Shift_sense = new Skill();
        public static Skill Shoot_angle = new Skill();
        public static Skill Shoot_fac = new Skill();
        public static Skill Shoot_range = new Skill();
        public static Skill Shoot_sector = new Skill();
        public static Skill Shoot_x = new Skill();
        public static Skill Shoot_y = new Skill();
        public static Skill Skip_frames = new Skill();
        public static Skill Sky_offs_x = new Skill();
        public static Skill Sky_offs_y = new Skill();
        public static Skill Slope_ahead = new Skill();
        public static Skill Slope_side = new Skill();
        public static Skill Slope_x = new Skill();
        public static Skill Slope_y = new Skill();
        public static Skill Sound_vol = new Skill();
        public static Skill Steps = new Skill();
        public static Skill Str_len = new Skill();
        public static Skill Text_layer = new Skill();
        public static Skill Thing_dist = new Skill();
        public static Skill Thing_width = new Skill();
        public static Skill Ticks = new Skill();
        public static Skill Time_corr = new Skill();
        public static Skill Time_fac = new Skill();
        public static Skill Touch_dist = new Skill();
        public static Skill Touch_mode = new Skill();
        public static Skill Touch_state = new Skill();
        public static Skill Walk = new Skill();
        public static Skill Walk_period = new Skill();
        public static Skill Walk_time = new Skill();
        public static Skill Wave = new Skill();
        public static Skill Wave_period = new Skill();

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

        /* Events */


        /* Lists */
        public static Function[] Each_tick = new Function[16];
        public static Function[] Each_sec = new Function[16];
        public static Panel[] Panels = new Panel[16];
        public static Overlay[] Layers = new Overlay[16];
        public static Text[] Messages = new Text[16];

        /* Synonyms */
        public static Region Here;
        //public static Region There; //inside Function only
        //public static A3Object My; //inside Function only - identify type automatically based on thing/actor flags
        public static ILevelObject Hit; //Thing, Actor, Wall -- TODO: level instances 
        public static Text Touch_text;
        public static ILevelObject Touched; //Thing, Actor, Wall -- TODO: level instances 
        public static Texture Touch_tex;
        public static Region Touch_reg;
        public static string Command_line;
        public static Overlay Msprite;

    }
}
