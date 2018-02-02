using System;
namespace Commandes
{
    class LigneCmd // nom complet : Commandes.LigneCmd
    {
        private double _prixUnitaire;
        private double _quantite;

        // Le constructeur est appelé lors de l'instanciation (création)
        // de l'objet
        // Il a même nom que la classe et il n'a aucun type de retour
        public LigneCmd(string designation, double prixUnitaire, double quantite)
        {
            Designation = designation;
            PrixUnitaire = prixUnitaire;
            Quantite = quantite;
        }

        // Propriété pour prix unitaire
        public double PrixUnitaire
        {
            // Acces en lecture
            get
            {
                return _prixUnitaire;
            }

            // Acces en ecriture
            set
            {
                if (value < 0)
                {
                    // throw lève une exception
                    throw new System.ArgumentOutOfRangeException();
                }
                else
                {
                    _prixUnitaire = value;
                }
            }
        }

        public double Quantite
        {
            // Acces en lecture
            get
            {
                return _quantite;
            }

            // Acces en ecriture
            set
            {
                if (value < 0)
                {
                    // throw lève une exception
                    throw new System.ArgumentOutOfRangeException();
                }
                else
                {
                    _quantite = value;
                }
            }
        }

        public string Designation { get; set; }

        public double Montant()
        {
            return Quantite * PrixUnitaire;
        }

        public string Description()
        {
            return
                $"{Designation}, qt:{Quantite}, pu:{PrixUnitaire:C}, mnt:{Montant():C}";
        }
    }
}