using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public static class Scheduler
    {

        private static string s_inkey_string;

        public static string Inkey_string { get => s_inkey_string; set => s_inkey_string = value; }

        public static IEnumerator Inkey(string input)
        {
            s_inkey_string = input;
            //TODO: set Inkey_string;
            yield break;
        }

/*
        public static IEnumerator Wait(Var value)
        {
            yield break;
        }

        public static IEnumerator Waitt(Var value)
        {
            yield break;
        }
        */
        public static void Run(Function function)
        {

        }
    }
}
