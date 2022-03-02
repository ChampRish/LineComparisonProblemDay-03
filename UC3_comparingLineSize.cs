using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class UC3_comparingLineSize
    {
        public static void lineSize()
        {
            double lineLength1;
            Console.Write("Length of x1 : ");
            double linex1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of x2 : ");
            double linex2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y1 : ");
            double liney1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y2 : ");
            double liney2 = Convert.ToInt32(Console.ReadLine());
            lineLength1 = (linex2 - linex1) * (linex2 - linex1) - (liney2 - liney1) * (liney2 - liney1);
            Console.WriteLine("Length of two points : " + Math.Sqrt(lineLength1));

            double lineLength2;
            Console.Write("Length of x3 : ");
            double linex3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of x4 : ");
            double linex4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y3 : ");
            double liney3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y4 : ");
            double liney4 = Convert.ToInt32(Console.ReadLine());
            lineLength2 = (linex4 - linex3) * (linex4 - linex3) - (liney4 - liney3) * (liney4 - liney3);
            Console.WriteLine("Length of two points : " + Math.Sqrt(lineLength2));
            if (lineLength1 == lineLength2)
            {
                Console.WriteLine("line are equal");
            }
            else if (lineLength1 > lineLength2)
            {
                Console.WriteLine("lineLength1 is greater than lineLength2");
            }
            else
            {
                Console.WriteLine("lineLength1 is less than lineLength2");
            }
        }
    }
}
