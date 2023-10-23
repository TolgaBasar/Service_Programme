using AltinayStaj2.Models;
using System;
using System.Linq;

namespace AltinayStaj2
{
    public class CarInstall
    {
        private readonly ApplicationDbContext _dbContext;

        public CarInstall(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Install()
        {
          
            var carsToAdd = new List<Car>
            {
                new Car { Name = "Audi" },
                new Car { Name = "BMW" },
                new Car { Name = "Mercedes" }
            };

            foreach (var car in carsToAdd)
            {
                
                var existingCar = _dbContext.Cars.FirstOrDefault(c => c.Name == car.Name);

                
                if (existingCar == null)
                {
                    _dbContext.Cars.Add(car);
                }
                else
                {
                    Console.WriteLine($"Araba {car.Name} zaten mevcut, eklenmedi.");
                }
            }

            try
            {
                _dbContext.SaveChanges();
                Console.WriteLine("Cars tablosuna veriler başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cars tablosuna veri eklenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
