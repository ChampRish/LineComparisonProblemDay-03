using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class UC1_CartesianSystem
    {
        public static void Cartesion()
        {
            double lineLength;
            Console.Write("Length of x1 : ");
            double linex1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of x2 : ");
            double linex2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y1 : ");
            double liney1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of y2 : ");
            double liney2 = Convert.ToInt32(Console.ReadLine());
            lineLength = (linex2 - linex1) * (linex2 - linex1) - (liney2 - liney1) * (liney2 - liney1);
            Console.WriteLine("Length of two points : " + Math.Sqrt(lineLength));
        }
    }
}
