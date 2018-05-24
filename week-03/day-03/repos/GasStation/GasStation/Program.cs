using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station1 = new Station(100_000);
            Car car1 = new Car();

            station1.Refill(car1);

            Console.WriteLine(car1.GetCarGasAmount().ToString());
            Console.WriteLine(station1.stationGasAmount);

            Console.ReadLine();
        }
    }
}
