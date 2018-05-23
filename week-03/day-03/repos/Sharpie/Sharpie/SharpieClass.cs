using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class SharpieClass
    {
        private string color;
        private float width;
        private float inkAmount;

        public SharpieClass(string color, float width)
        {
            this.color = color;
            this.width = width;
            inkAmount = 100f;
        }

        public float GetInkAmount()
        {
            return inkAmount;
        }

        public void Use()
        {
            inkAmount -= 5;
        }
    }
}
