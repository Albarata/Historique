namespace Historique
{
    public class ConsoleInputProvider : IInputProvider
    {
        public EtatHistorique? getEtatHistoriqueInput()
        {
            try
            {
                string description, etat;
                string? etatInput, descriptionInput;
                Console.WriteLine("Mettre à jour vers l'état: ");
                etatInput = Console.ReadLine();
                etat = etatInput == null ? "" : etatInput;
                Console.WriteLine("Ajoutez une description: ");
                descriptionInput = Console.ReadLine();
                description = descriptionInput == null ? "": descriptionInput;
    
                return new EtatHistorique(etat, description);
            }
            catch (Exception)
            {
                Console.WriteLine("Une erreur est survenue lors de la saisie, merci de réessayer.");
                return null;
            }
        }
    }
}