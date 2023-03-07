using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    public class Geometric_Length
    {
        int x1, x2, y1, y2;
        public Geometric_Length(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public double Calculate()//remove void and give double for return value to compare two lines
        {
            double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of the Line" + res);
            return res;
        }
        public void Equality_Of_Two_Lines(double Line1, double Line2)
        {
            if (Line1 == Line2)
                Console.WriteLine("Two lines are eaqual");
            else
                Console.WriteLine("Two lines are not equal");
        }
        public void Compare_Two_Lines(double Line1, double Line2)
        {
            if (Line1.CompareTo(Line2)==0)
                Console.WriteLine("Lengths of Two lines are eaqual");
            if (Line1.CompareTo(Line2)> 0)
                Console.WriteLine("Length of Line1 is greaterthan Length of  Line2");
            if (Line1.CompareTo(Line2) < 0)
                Console.WriteLine("Length of Line2 is greaterthan Length of  Line1");
        }
    }
}
