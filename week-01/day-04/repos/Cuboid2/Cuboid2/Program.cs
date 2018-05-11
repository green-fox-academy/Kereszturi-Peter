using System;

public class Program
{
    public static void Main()
    {
        Decimal Cube_Length, Surface_Area, Volume;

        Console.Write("Enter Length of Cube : ");
        Cube_Length = Convert.ToDecimal(Console.ReadLine());

        Surface_Area = (Decimal)6.0 * Cube_Length * Cube_Length;
        Volume = (Decimal)Math.Pow((Double)Cube_Length, 3);

        Console.Write("\nSurface Area of Cube is : " + Surface_Area);
        Console.Write("\nVolume of Cube is : " + Volume);
    }
}