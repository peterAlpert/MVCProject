using MVCProject.Models;

namespace MVCProject.Interfaces
{
    public interface ICategoryRepo
    {
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(int id);
        public List<Category> GetAll();
        public Category GetById(int id);
        public void Save();
    }
}
