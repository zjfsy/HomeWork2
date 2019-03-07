using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Staticstate
{
    static class Hello
    {
        public static void hello()
        {
            Console.Write("Hello World!");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Hello.hello();
            for(int i = 0; i < args.Length; i++)
            {
                Console.Write(" " + args[i]);
            }
            Console.WriteLine();
        }
    }
}
