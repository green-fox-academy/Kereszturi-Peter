using System;

namespace StructureVolumeOfcuboid
{
    public class Program
    {


        struct Cuboid
        {
            int length;
            int breadth;
            int height;

            Cuboid(int x, int y, int z)
            {
                length = x;
                breadth = y;
                height = z;
            }
            int Volume()
            {
                return length * breadth * height;
            }
            int Surface()
            {
                return 2 *length * breadth + 2 * length * height + 2 * breadth * height;
            }
            public static void Main(string[] args)
            {
                Cuboid vol = new Cuboid(10, 20, 30);
                Console.WriteLine("\n Volume:" + vol.Volume());
                Console.WriteLine("\n Surface Area:" + vol.Surface());



                Console.ReadKey();
            }
        }
    }
}