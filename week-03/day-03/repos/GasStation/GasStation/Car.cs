using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
    class Car
    {
        private int carGasAmount;
        private int carGasCapacity;

        public Car()
        {
            carGasAmount = 0;
            carGasCapacity = 100;
        }

        public int GetCarGasAmount()
        {
            return carGasAmount;
        }

        public int GetCarGasCapacity()
        {
            return carGasCapacity;
        }

        public void SetCarGasAmount(int toThisAmount)
        {
            carGasAmount = toThisAmount;
        }

        public int GetMissingFuel()
        {
            return carGasCapacity - carGasAmount;
        }
    }
}
