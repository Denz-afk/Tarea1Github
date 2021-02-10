using System;

namespace b3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 debm;
            debm = 10*10;
            do{
                debm = debm+2;
                Console.WriteLine(""+debm);
            }while (debm<121);
            Console.ReadKey();
        }
    }
}
