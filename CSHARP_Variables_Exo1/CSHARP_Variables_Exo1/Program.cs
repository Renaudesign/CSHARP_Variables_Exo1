﻿using System;

namespace CSHARP_Variables_Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeur1 = 14;
            int valeur2 = 66;
            int valeur3 = valeur1 + valeur2;

            Console.WriteLine("Je prends d'abord le nombre " + valeur1);
            Console.WriteLine("je lui projette violemment le nombre " + valeur2);
            Console.WriteLine("Et PAF ça donne " + valeur3);
            Console.WriteLine("Donc si je réssume tout ce fatras d'informations. " + valeur1 + " et " + valeur2 + " additionés font " + valeur3 + ".");
        }
    }
}
