namespace Ex2
{
    public class Tiger: Animal
    {
        
        public Tiger(int weight, string name) : base(weight, name)
        {
        }

        public override void SetMe(int weight, string name)
        {
            Name = name;
            Weight = weight;
        }
    }
}