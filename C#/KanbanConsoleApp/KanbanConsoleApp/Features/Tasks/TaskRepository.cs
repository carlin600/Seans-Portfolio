using KanbanConsoleApp.Features.Clients;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KanbanConsoleApp.Features.Tasks
{
    public class TaskRepository
    {
        private readonly List<Task> _tasks = new List<Task>();

        public void SaveTask(Task task)
        {
            _tasks.Add(task);
        }

        public List<Task> GetTasks()
        {
            var tasksToReturn = new List<Task>();

            foreach (var task in _tasks)
            {
                tasksToReturn.Add(new Task
                {
                    Id = task.Id,
                    Description = task.Description
                });
            }

            return tasksToReturn;
        }

        public Task GetTaskById(string Id)
        {
            return _tasks.FirstOrDefault(x => x.Id == Id);
        }

        public List<Task> GetTasksByClientName(string clientName)
        {
            return _tasks.Where(x => x.ClientName == clientName).ToList();
        }

        public void RemoveTaskById(string id)
        {
            Task _task = _tasks.FirstOrDefault(x => x.Id == id);

            if (_task != null)
            {
                _tasks.Remove(_task);
            }
        }
    }
}
