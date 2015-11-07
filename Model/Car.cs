using System;
using System.Drawing;

namespace Model
{
    public class Car
    {
        public Car(string model, char category)
        {
            Model = model;
            Category = category;
            Color = Color.Blue;
            CarPassport = new CarPassport(this);
        }

        public Color Color { get; set; }
        public string Model { get;}
        public string CarNumber { get; private set; }
        public char Category { get; }
        public CarPassport CarPassport { get; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
            CarPassport.Owner = driver.Name; 
            driver.OwnCar(this);
            CarNumber = carNumber;
        }
    }
}
