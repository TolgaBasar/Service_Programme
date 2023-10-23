using System;
using System.Linq;

namespace AltinayStaj2
{
    public class DeleteCar
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteCar(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RemoveCar(int carId)
        {
            var carToRemove = _dbContext.Cars.FirstOrDefault(c => c.Id == carId);

            if (carToRemove != null)
            {
                _dbContext.Cars.Remove(carToRemove);
                _dbContext.SaveChanges();
                Console.WriteLine($"Car with Id {carId} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Car with Id {carId} does not exist.");
            }
        }
    }
}
