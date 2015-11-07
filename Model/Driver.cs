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
            var check = 0;
            foreach (var t in Category.Where(t => t == car.Category))
            {
                check++;
                Car = car;
            }

            try
            {
                if (check == 0)
                    throw new Exception("Исключение: категория водителя не соответствует, категории машины!!!");
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
