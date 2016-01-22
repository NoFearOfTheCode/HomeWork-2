using System;

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

        public int Experience
        {
            get
            {
                var experience = DateTime.Now - LicenceDate;
                return experience.Days / 365;
            }
        }

        public string Category { get; set; }
        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (!Category.Contains(car.Category))
            {
                throw new CategoryNotFoundException("Водитель: " + Name + " не обладает категорией " + car.Category);
            }
            else
            {
                Car = car;
            }
        }
    }
}
