using System.Drawing;

namespace Model
{
    public class Car
    {
        public Car(string model, string category)
        {
            Model = model;
            Category = category;
            Color = Color.Blue;
            CarPassport = new CarPassport(this);
        }

        public Color Color { get; set; }
        public string Model { get;}
        public string CarNumber { get; private set; }
        public string Category { get; }
        public CarPassport CarPassport { get; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
            if (driver.Category.Contains(Category))
            {
                CarPassport.Owner = driver;
                driver.OwnCar(this);
                CarNumber = carNumber;
            }
            else
            {
                throw new CategoryNotFoundException("Водитель: " + driver.Name + " не обладает категорией " + Category);
            }
        }
    }
}
