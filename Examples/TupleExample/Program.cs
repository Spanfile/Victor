using System;

using Victor.T;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Victor Tuple (T) Example";

            var t1 = t(1);
            var t2 = t(1, 2);
            var t3 = t(1, 2, 3);
            var t4 = t("Moony", "Wormtail", "Padfoot", "Prongs");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            Console.ReadKey();
        }
    }
}
