using System;
using System.Text;

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
                // Interpolated string : C# >= v6.
                int resOperation = i * multiple;
                resultat += $"{i:00} x {multiple,2} = {resOperation}";
                resultat += "\n";
            }
                
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(resultat);

            Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
