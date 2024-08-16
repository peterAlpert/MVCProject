using MVCProject.Models;

namespace MVCProject.Interfaces
{
    public interface IAdminRepo
    {
        public void Add(Admin course);
        public void Update(Admin course);
        public void Delete(int id);
        public List<Admin> GetAll();
        public Admin GetById(int id);
        public void Save();

    }
}
