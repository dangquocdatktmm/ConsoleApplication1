namespace ConsoleApplication1.PRACTICAL.Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var tiger = new Tiger(100, "tiger");
            var lion = new Lion(200, "lion");
            
            tiger.Show();
            lion.Show();
        }
    }
}