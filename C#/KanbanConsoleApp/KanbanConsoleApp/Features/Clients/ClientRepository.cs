using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KanbanConsoleApp.Features.Clients;

namespace KanbanConsoleApp.Features.Clients
{
    class ClientRepository
    {
        private readonly List<Client> _clients = new List<Client>();

        public void SaveClient(Client client)
        {
            _clients.Add(client);
        }

        public List<Client> GetClients()
        {
            return _clients.Select(client => new Client { Name = client.Name }).OrderBy(x => x.Name).ToList();
        }

        public void RemoveClientByName(String name)
        {
            Client _client = _clients.FirstOrDefault(x => x.Name == name);

            if (_client != null)
            {
                _clients.Remove(_client);
            }
        }



    }
}
