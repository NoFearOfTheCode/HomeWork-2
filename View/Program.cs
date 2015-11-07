using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            //FR001
            ///путём, гугла было выявлено что цвет баклажан это DarkMagenta, но я не уверен.
            var carLada = new Car("Лада", 'D') {Color = Color.DarkMagenta};
            
            //FR002
            try
            {
                Console.WriteLine("Имя владельца Лады: {0}", carLada.CarPassport.Owner.Name);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("Исключение: невозможно вывести имя владельца!!!\n" + exception.Message + "\n");
            }
            
            //FR003
            var driverVoldemar = new Driver(new DateTime(2012, 10, 13), "Вольдемар") { Category = "BC"};

            //FR004
            carLada.ChangeOwner(driverVoldemar, "o777oo");

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
