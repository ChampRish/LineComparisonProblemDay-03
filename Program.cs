using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            Console.ReadLine();
            UC1_CartesianSystem.Cartesion();
            Console.ReadLine();
            UC2_CompareLineLength.compareLine();
            Console.ReadLine();
            UC3_comparingLineSize.lineSize();
            Console.ReadLine();

        }
    }
}
