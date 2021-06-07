using System;

namespace ConsoleApplication1.PRACTICAL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            Console.WriteLine("Enter the dimensions of the cylinder");
            while (true)
            {
                try
                {
                    Console.Write("Radius: ");
                    cylinder.Radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Height: ");
                    cylinder.Height = Convert.ToDouble(Console.ReadLine());
                    cylinder.Process();
                    Console.WriteLine("\nCylinder Characteristics");
                    Console.WriteLine(cylinder.Result());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}