using KanbanConsoleApp.Features.Clients;
using KanbanConsoleApp.Features.Tasks;
using System.Collections.Generic;

namespace KanbanConsoleApp.Tests
{
    public static class _7
    {
        public static void AbilityToReorderTasks()
        {
            var engine = new TaskEngine();

            engine.SaveClient(new Client { Name = "Audi" });
            engine.SaveTask(new Task { ClientName = "Audi", Description = "Ability to login to the order system.", Id = "1" });
            engine.SaveTask(new Task { ClientName = "Audi", Description = "Ability to update an order.", Id = "2" });
            engine.SaveTask(new Task { ClientName = "Audi", Description = "Ability to filter Audi cars in the stock feed.", Id = "3" });
            engine.SaveTask(new Task { ClientName = "Audi", Description = "Ability for users to manage stock preferences.", Id = "4" });
            engine.SaveTask(new Task { ClientName = "Audi", Description = "Ability for stock management team to see vehicles that need taxing.", Id = "5" });
            engine.SaveTask(new Task { ClientName = "Audi", Description = "Ability to track the delivery of orders being shipped into the country.", Id = "6" });

            // TODO - Extend the engine here to re-order tasks. Look at the test assertions to see the expected ordering.
            //Current order is = 1,2,3,4,5,6
            //new order has to be 1,6,4,3,5,2
            //new list

            List<string> list = new List<string>
            {
                "1",
                "6",
                "4",
                "3",
                "5",
                "2"
            };

            engine.ReorderTasks(list);

            // TODO - Swap 3 and 4
            // TODO - Swap 2 and 6

            var tasks = engine.GetTasksForClient("Audi");
            Assert.AreEqual(tasks[0].Id, "1");
            Assert.AreEqual(tasks[1].Id, "6");
            Assert.AreEqual(tasks[2].Id, "4");
            Assert.AreEqual(tasks[3].Id, "3");
            Assert.AreEqual(tasks[4].Id, "5");
            Assert.AreEqual(tasks[5].Id, "2");
        }
    }
}