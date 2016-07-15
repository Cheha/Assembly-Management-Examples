#define COMPILE1
#define COMPILE2
#undef COMPILE1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreprocessorDirectives
{
    class Program
    {
        #region #if, #else, #elif, #endif
        //static void Main(string[] args)
        //{
        //#if COMPILE1
        //    Console.WriteLine("COMPILE1 mode");
        //#elif COMPILE2
        //    Console.WriteLine("COMPILE2 mode");
        //#else
        //    Console.WriteLine("not COMPILE1 and not COMPILE2 mode");
        //#endif
        //    Console.ReadLine();
        //}
        #endregion

        #region #warning, #error
        //static void Main(string[] args)
        //{
        //    #warning This is warning
        //    #error This is error
        //}
        #endregion

        #region Methods

        #region Private
#endregion


        static void Main()
        {
            // This example has unreachable code!
            // ... The pragma directives hide the warning.
           #pragma warning disable 0162
            if (false)
            {
                Console.WriteLine("Perls");
            }
            #pragma warning restore
            if (false)
            {
                Console.WriteLine("Perls");
            }
        }
        #endregion

    }
}
