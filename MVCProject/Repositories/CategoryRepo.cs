using MVCProject.Interfaces;
using MVCProject.Models;

namespace MVCProject.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {

        Context context;


        public CategoryRepo(Context _context)
        {

            context = _context;
        }


        public void Add(Category category)
        {
            context.Add(category);

        }

        public void Delete(int id)
        {
            Category category = GetById(id);
            context.Remove(category);
        }

        public List<Category> GetAll()
        {
            return context.Category.ToList();

        }

        public Category GetById(int id)
        {
            return context.Category.FirstOrDefault(a => a.ID == id);

        }
        public void Update(Category category)
        {
            context.Category.Update(category);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
