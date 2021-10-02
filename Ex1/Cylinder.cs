using System;
using System.Diagnostics;

namespace Ex1
{
    public class Cylinder
    {
        public double Radius { get; set; }
        public double Height{ get; set; }
        public double BaseArea{ get; set; }
        public double LateralArea{ get; set; }
        public double TotalArea{ get; set; }
        public double Volume{ get; set; }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine($"Radius: {Radius}, Height: {Height}");
            Console.WriteLine($"Base: {String.Format("{0:0.00}", BaseArea)} | Lateral: {String.Format("{0:0.00}", LateralArea)} | " +
                              $"Total: {String.Format("{0:0.00}", TotalArea)} | Volume: {String.Format("{0:0.00}", Volume)}");
        }
    }
}