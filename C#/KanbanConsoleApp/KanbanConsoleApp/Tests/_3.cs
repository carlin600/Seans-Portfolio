using KanbanConsoleApp.Features.Clients;

namespace KanbanConsoleApp.Tests
{
    public static class _3
    {
        public static void WhenRetrievingAListOfClients_ThenTheListIsReturnedAlphabetically()
        {
            var engine = new TaskEngine();
            engine.SaveClient(new Client { Name = "Alphabet" });
            engine.SaveClient(new Client { Name = "Dacia" });
            engine.SaveClient(new Client { Name = "Volkswagen" });
            engine.SaveClient(new Client { Name = "Audi" });
            engine.SaveClient(new Client { Name = "BMW" });

            var clients = engine.GetClients();

            Assert.AreEqual(clients[0].Name, "Alphabet");
            Assert.AreEqual(clients[1].Name, "Audi");
            Assert.AreEqual(clients[2].Name, "BMW");
            Assert.AreEqual(clients[3].Name, "Dacia");
            Assert.AreEqual(clients[4].Name, "Volkswagen");
        }
    }
}