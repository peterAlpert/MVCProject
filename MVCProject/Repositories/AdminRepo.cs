using MVCProject.Interfaces;
using MVCProject.Models;

namespace MVCProject.Repositories
{
    public class AdminRepo : IAdminRepo
    {
       Context context;


        public AdminRepo(Context _context)
        {
           
            context = _context;
        }


        public void Add(Admin admin)
        {
            context.Add(admin);
            
        }

        public void Delete(int id)
        {
            Admin admin = GetById(id);
            context.Remove(admin);
        }

        public List<Admin> GetAll()
        {
            return context.Admin.ToList();

        }

        public Admin GetById(int id)
        {
            return context.Admin.FirstOrDefault(a => a.ID == id);
            
        }
        public void Update(Admin admin)
        {
            context.Admin.Update(admin);
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
