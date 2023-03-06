// See https://aka.ms/new-console-template for more information
using System;
namespace LineComputation
{
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("welcome to Line Comparision : ");
            Console.WriteLine("enter x1 value");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x2 value");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y1 value");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y2 value");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Geometric_Length len = new Geometric_Length(x1, x2, y1, y2);
            len.Calculate();
        }
    }

}
