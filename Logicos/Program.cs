using System;

namespace Logico{
    class Program{
        static void Main(string[] args){
            
            //operado logico and
            bool c1 = 2 > 3 && 4 != 5;
            Console.WriteLine(c1);

            //operado logico or
            bool c2 = 2 > 3 || 4 != 5;
            Console.WriteLine(c2);

            //operado logico no
            bool c3 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c3);
        }
    }
}
