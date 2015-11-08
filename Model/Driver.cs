using System;
using System.Linq;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenceDate, string name)
        {
            LicenceDate = licenceDate;
            Name = name;       
        }

        public DateTime LicenceDate { get; }
        public string Name { get; }
        public int Experience => DateTime.Now.Year - LicenceDate.Year;
        public string Category { get; set; }
        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            try
            {
                if (!Category.Contains(car.Category))
                    throw new CategoryNotFoundException("Водитель: " + Name + " не обладает категорией " + car.Category);
                else { Car = car;}
            }
            catch (CategoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
