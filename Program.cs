using System;

namespace b1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comience a escribir números:");
            Int32 debm;
            Int32 debm1;
            debm1 = 0;
            Console.WriteLine("Comienza a escribir números:");
            do {
                debm = Int32.Parse(Console.ReadLine());
                if (debm > 0){
                debm1 = (debm1 + debm);  
                }            
            }while (debm > 0);
            Console.WriteLine("La suma total es: "+debm1);
            Console.ReadKey();
        }
    }
}
