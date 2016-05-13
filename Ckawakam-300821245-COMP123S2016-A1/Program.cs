using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ckawakam_300821245_COMP123S2016_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the hello world to console method
            HelloWorldToConsole();
        }
        /*
         * @discription: This is my HelloWorldMethod
         * @method: HelloWorldToConsole
         * @return: {string} helloworldString
         */
        public static string HelloWorldToConsole()
        {
            string helloworldString = "Hello,World!";
            Console.WriteLine(helloworldString);
            return helloworldString;
        }
    }
}
