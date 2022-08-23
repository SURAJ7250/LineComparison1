using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparision comparison = new Comparision(1, 2, 3, 4);
            double line1 = Comparision.CalculateLength();
            Console.WriteLine("Length of first line " + line1);
            Comparision LineComparisonProblem = new Comparision(1, 2, 3, 4);
            double line2 = LineComparisonProblem.CalculateLength();
            Console.WriteLine("Length of second line" + line2);
            if (line1 == line2)
            {
                Console.WriteLine("Line 1 and Line 2 are equal");
            }
            else
                Console.WriteLine("Not equal");
        }
    }
}
