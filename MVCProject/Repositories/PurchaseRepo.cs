using MVCProject.Interfaces;
using MVCProject.Models;

namespace MVCProject.Repositories
{
    public class PurchaseRepo : IPurchaseRepo
    {
        Context context;


        public PurchaseRepo(Context _context)
        {
            this.context = _context;
        }


        public void Add(Purchase purchase)
        {
            context.Add(purchase);

        }

        public void Delete(int id)
        {
            Purchase purchase = GetById(id);
            context.Remove(purchase);
        }

        public List<Purchase> GetAll()
        {
            return context.Purchase.ToList();

        }

        public Purchase GetById(int id)
        {
            return context.Purchase.FirstOrDefault(a => a.ID == id);

        }
        public void Update(Purchase purchase)
        {
            context.Purchase.Update(purchase);
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
