using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int radius;
        double volume;

        Console.WriteLine("Please enter the radius of the sphere");
        Console.WriteLine("");

        Console.Write("radius: ");
        radius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        volume = 1.3333 * Math.PI * radius * radius * radius;

        Console.WriteLine("Area: " + volume.ToString("0.00") + "cm³");

        Console.WriteLine("\nDone.");
    }
}