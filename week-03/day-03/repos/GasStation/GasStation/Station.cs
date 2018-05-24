using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
    class Station
    {
        public int stationGasAmount;

        public Station(int stationGasAmount)
        {
            this.stationGasAmount = stationGasAmount;
        }

        public void Refill(Car car)
        {
            stationGasAmount -= car.GetMissingFuel();
            car.SetCarGasAmount(car.GetCarGasAmount() + car.GetMissingFuel());
        }
    }
}
