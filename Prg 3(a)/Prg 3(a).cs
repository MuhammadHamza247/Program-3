using System;

namespace Prg_3_a_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x= 20, y=35;
            x=y++ + x++;
            y=++y + ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
