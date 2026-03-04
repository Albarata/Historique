namespace Historique
{
    public class UpdateObjetService
    {
        private Historique historique{get;set;}

        private bool continueProcessing{get;set;}

        private IInputProvider providerConsole = new ConsoleInputProvider();

        public UpdateObjetService()
        {
            this.historique = new Historique(new Objet{name = "objet1", etatObjet="initial"});
            this.continueProcessing = true;
        }

        public bool showMenu()
        {
            String input;
            while (continueProcessing)
            {
                System.Console.WriteLine("Tapez 1 pour mettre à jour l'objet");
                System.Console.WriteLine("Tapez 2 pour afficher l'historique des modifications");
                System.Console.WriteLine("Tapez un autre caractère pour quitter.");
                input = Console.ReadLine();
                switch (input){
                    case "1" :
                        processOne();
                        break;
                    case "2" :
                        showHistorique();
                        break;
                    default: 
                        continueProcessing = false;
                        break;
                }
            }
            return true;
        }

        private bool processOne()
        {
            EtatHistorique? etat = providerConsole.getEtatHistoriqueInput();
            if (etat != null)
            {
                historique.historique.Add(etat);
                Console.WriteLine($"Le nouvel état a bien été enregistré. Nouvel état: {etat.etat}");
                return true;
            }
            else
            {
                Console.WriteLine($"Une erreur est survenue lors de la lecture du nouvel état, veuillez réessayer.");
                return false;
            }
        }

        private void showHistorique()
        {
            Console.WriteLine($"Affichage de l'historique des modifications de l'objet: ");
            System.Console.WriteLine(historique);
        }
    }
}