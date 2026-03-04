using Historique;

namespace TestHistorique;

[TestClass]
public sealed class TestService
{
    [TestMethod]
    public void TestService_ok()
    {
        var service = new UpdateObjetService();

        TextReader reader = new StringReader("1");
        Console.SetIn(reader);

        bool res = service.showMenu();

        Assert.IsTrue(res);
    }
}