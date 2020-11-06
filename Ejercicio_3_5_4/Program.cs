using System;

namespace Ejercicio_3_5_4
{
    class Program
    {
        static int n1, n2;
        static bool ambosPares;
        static void Main(string[] args)
        {
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            ambosPares = (n1 % 2 == 0) && (n2 % 2 == 0);

            if(ambosPares)
            {
                Console.WriteLine(ambosPares);
            }
            else
            {
                Console.WriteLine(ambosPares + " abduscan al a juak polla");
            }

            while (true)
            {
                Console.WriteLine("SHERK NO HIZO NADA MALO");
            }
            // pito corto quien lo lea ajajjajajaa xd saludos, posdata te gusta el lol ya me joderia
        }
    }
}
