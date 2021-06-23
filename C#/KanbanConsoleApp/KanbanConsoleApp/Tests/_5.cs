using System.Linq;
using KanbanConsoleApp.Features.Clients;
using KanbanConsoleApp.Features.Tasks;

namespace KanbanConsoleApp.Tests
{
    public static class _5
    {
        public static void AbilityToGetAllTasksAssociatedWithAClient()
        {
            var engine = new TaskEngine();
            engine.SaveClient(new Client { Name = "Audi" });
            engine.SaveClient(new Client { Name = "BMW" });

            engine.SaveTask(new Task { Id = "1", Description = "Ability to add an item from the Audi stock system.", ClientName = "Audi" });
            engine.SaveTask(new Task { Id = "2", Description = "Ability to remove an item from Audi the stock system .", ClientName = "Audi" });
            engine.SaveTask(new Task { Id = "3", Description = "Ability to retrieve an item from the Audi stock system.", ClientName = "Audi" });
            engine.SaveTask(new Task { Id = "4", Description = "Ability to add an item from the BMW stock system.", ClientName = "BMW" });
            engine.SaveTask(new Task { Id = "5", Description = "Ability to remove an item from the BMW stock system.", ClientName = "BMW" });
            engine.SaveTask(new Task { Id = "6", Description = "Ability to retrieve an item from the BMW stock system.", ClientName = "BMW" });

            var tasks = engine.GetTasksForClient("Audi");

            Assert.AreEqual(tasks.Count, 3);
            Assert.AreEqual(tasks.Any(x => x.Id == "1"), true);
            Assert.AreEqual(tasks.Any(x => x.Id == "2"), true);
            Assert.AreEqual(tasks.Any(x => x.Id == "3"), true);
        }
    }
}