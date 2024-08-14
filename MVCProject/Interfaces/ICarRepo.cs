using MVCProject.Models;

namespace MVCProject.Interfaces
{
    public interface ICarRepo
    {

        public void Add(Car car);
        public void Update(Car car);
        public void Delete(int id);
        public List<Car> GetAll();
        public Car GetById(int id);
        public void Save();
    }
}
