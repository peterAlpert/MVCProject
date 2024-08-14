using MVCProject.Interfaces;
using MVCProject.Models;

namespace MVCProject.Repositories
{
    public class ClientRepo : IClientRepo
    {

        Context context;


        public ClientRepo(Context _context)
        {
            this.context = _context;
        }


        public void Add(Client client)
        {
            context.Add(client);

        }

        public void Delete(int id)
        {
            Client client = GetById(id);
            context.Remove(client);
        }

        public List<Client> GetAll()
        {
            return context.Client.ToList();

        }

        public Client GetById(int id)
        {
            return context.Client.FirstOrDefault(a => a.ID == id);

        }
        public void Update(Client client)
        {
            context.Client.Update(client);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
