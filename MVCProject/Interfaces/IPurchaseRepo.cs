using MVCProject.Models;

namespace MVCProject.Interfaces
{
    public interface IPurchaseRepo
    {
        public void Add(Purchase purchase);
        public void Update(Purchase purchase);
        public void Delete(int id);
        public List<Purchase> GetAll();
        public Purchase GetById(int id);
        public void Save();
    }
}
