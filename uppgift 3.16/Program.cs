using System;

namespace uppgift_3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt är din låt i min?");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("hur långt är din låt i skunder?");
            int skund = int.Parse(Console.ReadLine());

            if (min <= 2 && skund < 45)
            {
                Console.WriteLine("låten är tyvär förkort");
            }
            else if (min >= 4 && skund > 20)
            {
                Console.WriteLine("låten är förlångt");
            }
            else
                Console.WriteLine("du kan köra låten");
        }
    }
}
