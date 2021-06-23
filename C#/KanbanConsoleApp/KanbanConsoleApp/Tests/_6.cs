using KanbanConsoleApp.Features.Tasks;

namespace KanbanConsoleApp.Tests
{
    public static class _6
    {
        public static void WhenAddingATaskForAClientThatDoesNotExist_ThenAnExceptionIsThrown()
        {
            var engine = new TaskEngine();

            //passing a method to the throws method.
            var exception = Assert.Throws(() => engine.SaveTask(new Task 
            { Id = "1", 
              ClientName = "Vauxhall", 
              Description = "Ability to configure a new Vauxhall car." }));

            Assert.AreEqual(exception.Message, "The supplied Client could not be found.");
        }
    }
}