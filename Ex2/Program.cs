namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var lion = new Lion(200,"lion");
            var tiger = new Tiger(100,"tiger");
            lion.Show();
            tiger.Show();
        }
    }
}