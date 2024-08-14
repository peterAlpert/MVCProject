using MVCProject.Interfaces;
using MVCProject.Models;

namespace MVCProject.Repositories
{
    public class CarRepo : ICarRepo
    {
        Context context;


        public CarRepo(Context _context)
        {

            context = _context;
        }


        public void Add(Car car)
        {
            context.Add(car);

        }

        public void Delete(int id)
        {
            Car car = GetById(id);

            context.Remove(car);
        }

        public List<Car> GetAll()
        {
            return context.Car.ToList();

        }

        public Car GetById(int id)
        {
            return context.Car.FirstOrDefault(a => a.ID == id);

        }
        public void Update(Car car)
        {
            context.Car.Update(car);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
