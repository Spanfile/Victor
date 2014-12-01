using System;

using Victor.Make;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Victor Tuple Example";

            var t1 = T(1);
            var t2 = T(1, 2);
            var t3 = T(1, 2, 3);
            var t4 = T("Moony", "Wormtail", "Padfoot", "Prongs");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            Console.ReadKey();
        }
    }
}
