using Historique;

namespace TestHistorique;

[TestClass]
public sealed class TestProvider
{
    [TestMethod]
    public void TestProvider_notNull()
    {
        IInputProvider providerConsole = new ConsoleInputProvider();
        TextReader reader = new StringReader("10000");
        Console.SetIn(reader);

        EtatHistorique etat = providerConsole.getEtatHistoriqueInput();
        
        Assert.IsNotNull(etat);
    }
}
