using KanbanConsoleApp.Features.Clients;

namespace KanbanConsoleApp.Tests
{
    public static class _4
    {
        public static void AbilityToDeleteAClient()
        {
            var engine = new TaskEngine();
            engine.SaveClient(new Client { Name = "Audi" });
            engine.SaveClient(new Client { Name = "BMW" });

            engine.RemoveClientByName("Audi");

            var clients = engine.GetClients();

            Assert.AreEqual(clients.Count, 1);
            Assert.AreEqual(clients[0].Name, "BMW");
        }
    }
}