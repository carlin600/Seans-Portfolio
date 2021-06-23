using System.Collections.Generic;
using KanbanConsoleApp.Features.Clients;
using KanbanConsoleApp.Features.Tasks;
using System.Linq;
using System;

namespace KanbanConsoleApp
{
    public class TaskEngine
    {
        private readonly TaskRepository _taskRepository = new TaskRepository();

        private readonly ClientRepository _clientRepository = new ClientRepository();

        public void SaveTask(Task task)
        {
            //if a task contains a valid name or null name then it can be saved, 
            //else throw exception as requested by test.
            //So what is the exception requested?
            //Answer
            //"The supplied Client could not be found."
            //How do we verify that a name is valid and exists?

            if (task.ClientName != null)
            {
                if (!_clientRepository.GetClients().Any(x => x.Name == task.ClientName))
                {
                    throw new Exception("The supplied Client could not be found.");
                }

            }
            _taskRepository.SaveTask(task);
        }

        public Task RetrieveTaskById(string id)
        {
            //Quickest Method.
            return _taskRepository.GetTaskById(id);

            //Good - but not as fast.
            //return _taskRepository.GetTasks().FirstOrDefault(x => x.Id == id);

            //Simplest Method.
            //var allTasks = _taskRepository.GetTasks();

            //foreach (var task in allTasks)
            //{
            //    //Searches retrieved tasks for id parameter.
            //    if (task.Id == id)
            //    {
            //        return task;
            //    }
            //}

            //return null;
        }

        public void ReorderTasks(List<string> list)
        {
            List<Task> taskReOrdered = list.Select(x => _taskRepository.GetTaskById(x)).ToList();

            foreach (var x in list)
            {
                _taskRepository.RemoveTaskById(x);
            }

            foreach (Task task in taskReOrdered)
            {
                _taskRepository.SaveTask(task);
            }
        }

        public void SaveClient(Client client)
        {
            _clientRepository.SaveClient(client);
        }

        public List<Client> GetClients()
        {
            return _clientRepository.GetClients();
            //return new List<Client>();
        }

        public void RemoveClientByName(string name)
        {
            _clientRepository.RemoveClientByName(name);
        }

        public List<Task> GetTasksForClient(string clientName)
        {
            return _taskRepository.GetTasksByClientName(clientName);
            //return new List<Task>();
        }


    }
}