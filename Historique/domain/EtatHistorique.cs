namespace Historique
{
    public class EtatHistorique
    {
        public string description{get; set;}
        public string etat{get; set;}
        public DateTime dateChange{get;set;}

        public EtatHistorique(string etat, string description)
        {
            this.etat = etat;
            this.description = description;
            this.dateChange = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Changement d'état: {etat}\t\t | {description}\t | {dateChange}";
        }
    }
}