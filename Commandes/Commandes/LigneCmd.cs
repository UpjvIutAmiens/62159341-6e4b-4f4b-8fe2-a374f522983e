namespace Commandes
{
    class LigneCmd // nom complet : Commandes.LigneCmd
    {
        public string designation;
        private double _prixUnitaire;
        public double quantite;

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
                    System.Console.WriteLine("Erreur");
                }
                else
                {
                    _prixUnitaire = value;
                }
            }
        }

        public double Montant()
        {
            return quantite * PrixUnitaire;
        }

        public string Description()
        {
            return
                $"{designation}, qt:{quantite}, pu:{PrixUnitaire:C}, mnt:{Montant():C}";
        }
    }
}