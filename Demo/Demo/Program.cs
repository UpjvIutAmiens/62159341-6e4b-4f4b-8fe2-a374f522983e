
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afficher la tables des 8
            // Concaténation : +
            // Saut de ligne : \n
            const int multiple = 8;
            const int valMax = 10;

            string resultat = "";

            for (int i=0 ; i<=valMax ; i++)
            {
                resultat += String.Format("{0:00} x {1,2} = {2:0.000}",
                    i,
                    multiple,
                    i * multiple);
                resultat += "\n";
            }

            Console.WriteLine(resultat);

            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
