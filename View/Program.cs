﻿using System;
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
            Console.WriteLine("Имя владельца Лады: {0}", carLada.CarPassport.Owner);
            
            //FR003
            var licenceDate = new DateTime(2012, 10, 13);
            var driverVoldemar = new Driver(licenceDate, "Вольдемар") { Category = "BC"};

            //FR004
            carLada.ChangeOwner(driverVoldemar, "o777oo");

            //FR005
            driverVoldemar.Category += "D";
            carLada.ChangeOwner(driverVoldemar, "o777oo");

            //FR006
            Console.WriteLine("Номер машины Вольдемара: {0}", driverVoldemar.Car.CarNumber);

            //FR007
            Console.WriteLine("Имя владельца лады : {0}", carLada.CarPassport.Owner);

            Console.ReadKey();
        }
    }
}
