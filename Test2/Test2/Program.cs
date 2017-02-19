using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi! Welcome here");
            SecondClass sc = new SecondClass();
            sc.n = 10;
            Console.Write(sc.n);
        }
    }
}
