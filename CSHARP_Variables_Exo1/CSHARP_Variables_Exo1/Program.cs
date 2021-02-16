using System;

namespace CSHARP_Variables_Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 14;
            int value2 = 66;
            int somme = value1 + value2;

            Console.WriteLine("Je prends d'abord le nombre " + value1);
            Console.WriteLine("je lui projette violemment le nombre " + value2);
            Console.WriteLine("Et PAF ça donne " + somme);
            Console.WriteLine("Donc si je réssume tout ce fatras d'informations. " + value1 + " et " + value2 + " additionés font " + somme + ".");
        }
    }
}
