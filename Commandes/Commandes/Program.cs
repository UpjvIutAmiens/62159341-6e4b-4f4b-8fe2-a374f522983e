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
            LigneCmd l1 = new LigneCmd("Gomme", 2.1, 10);
            
            LigneCmd l2 = new LigneCmd(
                quantite: 5,
                designation: "Crayon",
                prixUnitaire: 0.2
            );

            LigneCmd l3 = new LigneCmd("Bureau", 1000, 50);

            Console.WriteLine(l1.Description());
            Console.WriteLine(l2.Description());
            Console.WriteLine(l3.Description());

            //Console.WriteLine("Press a key");
            Console.ReadKey();
        }
    }
}
