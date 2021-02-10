using System;

namespace b2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 debm;
            debm = 0;
            do{
                debm = debm + 1;
                Console.WriteLine(""+ debm);
            } while (debm < 10);
            Console.ReadKey();
        }
    }
}
