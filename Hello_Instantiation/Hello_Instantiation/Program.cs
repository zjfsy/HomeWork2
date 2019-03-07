using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Instantiation
{
    class Hello
    {
        public Hello()
        {

        }
        public void print(String[] args)
        {
            Console.Write("Hello World!");
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(" " + args[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.print(args);
        }
    }
}
