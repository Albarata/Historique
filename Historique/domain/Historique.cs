using System.Collections;

namespace Historique
{
    public class Historique
    {
        public Objet objet{get;set;}
        public List<EtatHistorique> historique;

        public Historique(Objet objet)
        {
            this.objet = objet;
            this.historique = [];
        }

        public override string ToString()
        {
            string output =$"{objet.name}\n";
            foreach(EtatHistorique etat in historique)
            {
                output+=$"{etat.etat} \t| {etat.description} \t| {etat.dateChange}\n";
            }
            return output;
        }
    }
}