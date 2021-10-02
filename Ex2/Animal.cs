using System;

namespace Ex2
{
    public class Animal
    {
        public int Weight { get; set; }
        public string Name { get; set; }

        public Animal(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }
        
        public void Show()
        {
            Console.WriteLine($"Name: {this.Name}, Weight: {this.Weight}");
        }

        public virtual void SetMe(int weight, string name)
        {
            this.Weight = weight;
            this.Name = name;
        }
    }
}