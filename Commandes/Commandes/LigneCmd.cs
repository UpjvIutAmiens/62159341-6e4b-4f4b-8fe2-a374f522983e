namespace Commandes
{
    class LigneCmd // nom complet : Commandes.LigneCmd
    {
        public string designation;
        public double prixUnitaire;
        public double quantite;

        public double Montant()
        {
            return quantite * prixUnitaire;
        }

        public string Description()
        {
            return
                $"{designation}, qt:{quantite}, pu:{prixUnitaire:C}, mnt:{Montant():C}";
        }
    }
}