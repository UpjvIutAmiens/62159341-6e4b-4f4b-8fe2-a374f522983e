using System;
using System.Text;

namespace Commandes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Création d'un premier objet LigneCmd
            // l1 est une référence
            LigneCmd l1;

            // Création d'un objet LigneCmd référencé par l1
            l1 = new LigneCmd();

            // Modification de la désignation
            l1.designation = "Gomme";
            l1.PrixUnitaire = 2.1;
            l1.quantite = 10;

            LigneCmd l2 = new LigneCmd()
            {
                designation = "Crayon",
                PrixUnitaire = 0.2,
                quantite = 5
            };

            LigneCmd l3 = new LigneCmd();
            l3.designation = "Bureau";
            l3.PrixUnitaire = -1000;
            l3.quantite = 50;

            Console.WriteLine(l1.Description());
            Console.WriteLine(l2.Description());
            Console.WriteLine(l3.Description());

            //Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
