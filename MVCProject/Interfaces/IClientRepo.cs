using MVCProject.Models;

namespace MVCProject.Interfaces
{
    public interface IClientRepo
    {
        public void Add(Client client);
        public void Update(Client client);
        public void Delete(int id);
        public List<Client> GetAll();
        public Client GetById(int id);
        public void Save();
    }
}
