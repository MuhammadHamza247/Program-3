using System;

namespace Prg_3_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x= 10, y=15;
            x=x++;
            y=++y;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
