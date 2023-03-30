using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fuelcapacity-ni daxil edin");
            double benzin;
            string str=Console.ReadLine();
            while(!double.TryParse(str, out benzin))
            {
                Console.WriteLine("Daxil etdiyiniz deyer duzgun deyil");
                str = Console.ReadLine();
            }
            Console.WriteLine("NowCapacity-ni daxil edin:");
            double fuel;
            string str2 = Console.ReadLine();
            while(!double.TryParse(str2, out fuel))
            {
                Console.WriteLine("Daxil etdiyiniz deyer duzgun deyil");
                str2 = Console.ReadLine();
            }
            Car car = new Car
            {
                Brand = Console.ReadLine(),
                Model = Console.ReadLine(),
                FuelCapacity =double.Parse(str),
                NowCapacity =double.Parse(str2)
            };
            
            Console.WriteLine(car.Drive(20));
            Console.WriteLine( car.GetInfo());
        }
    }
}
