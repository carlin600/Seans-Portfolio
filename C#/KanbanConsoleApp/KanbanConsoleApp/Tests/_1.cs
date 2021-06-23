using KanbanConsoleApp.Features.Tasks;

namespace KanbanConsoleApp.Tests
{
    public static class _1
    {
        public static void AbilityToGetATaskById_ThenTheCorrectTaskIsRetrieved()
        {
            //This works 100% - tested with breakpoints
            var engine = new TaskEngine();
            engine.SaveTask(new Task { Id = "1", Description = "Ability to login to the order system."  });
            engine.SaveTask(new Task { Id = "2", Description = "Ability to logout of the order system." });

            var result = engine.RetrieveTaskById("2");
            Assert.AreEqual(result.Description, "Ability to logout of the order system.");
            
            
        }
    }
}