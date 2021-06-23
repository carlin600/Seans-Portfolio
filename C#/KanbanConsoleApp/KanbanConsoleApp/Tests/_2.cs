using KanbanConsoleApp.Features.Clients;

namespace KanbanConsoleApp.Tests
{
    public static class _2
    {
        public static void AbilityToStoreClients()
        {
            var engine = new TaskEngine();
            engine.SaveClient(new Client { Name = "BMW" });
            var clients = engine.GetClients();

            Assert.AreEqual(clients[0].Name, "BMW");
        }
    }
}