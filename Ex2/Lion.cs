namespace Ex2
{
    public class Lion: Animal
    {
        public Lion(int weight, string name) : base(weight, name)
        {
        }

        public override void SetMe(int weight, string name)
        {
            Name = name;
            Weight = weight;
        }
    }
}