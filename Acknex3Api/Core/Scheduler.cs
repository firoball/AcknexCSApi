using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public static class Scheduler
    {

        //TODO: set global inkey_str and assign it in instruction since out parameter is not allowed
        public static IEnumerator Inkey(string text)
        {
            yield break;
        }

        public static IEnumerator Wait(Var value)
        {
            yield break;
        }

        public static IEnumerator Waitt(Var value)
        {
            yield break;
        }

        public static void Run(Func<IEnumerator> function)
        {

        }
    }
}
