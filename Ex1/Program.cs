using System;

namespace Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            cylinder.Radius = 38.64;
            cylinder.Height = 22.48;
            Console.WriteLine("Enter the dimensions of the cylinder");
            Console.WriteLine($"Radius: {cylinder.Radius}");
            Console.WriteLine($"Height: {cylinder.Height}");
            cylinder.Process();
            cylinder.Result();
        }
    }
}