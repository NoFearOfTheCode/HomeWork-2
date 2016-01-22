using System;
using System.Drawing;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            //FR001
            var carLada = new Car("Лада", "D") {Color = Color.DarkMagenta};
            
            //FR002
            try
            {
                Console.WriteLine("Имя владельца Лады: {0}", carLada.CarPassport.Owner.Name);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("Исключение: невозможно вывести имя владельца!!!\n Сообщение: " + exception.Message + "\n");
            }
            
            //FR003
            var driverVoldemar = new Driver(new DateTime(2012, 01, 22), "Вольдемар") { Category = "BC"};

            //FR004
            try
            {
                carLada.ChangeOwner(driverVoldemar, "o777oo");
            }
            catch (CategoryNotFoundException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
           
            //FR005
            driverVoldemar.Category += "D";
            carLada.ChangeOwner(driverVoldemar, "o777oo");

            //FR006
            Console.WriteLine("\nНомер машины Вольдемара: {0}", driverVoldemar.Car.CarNumber);

            //FR007
            Console.WriteLine("\nИмя владельца лады : {0}", carLada.CarPassport.Owner.Name);

            Console.ReadKey();
        }
    }
}
