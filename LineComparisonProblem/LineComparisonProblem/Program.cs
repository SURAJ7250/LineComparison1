using System;

namespace LineComparisionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparision comparison = new Comparision(4, 5, 6, 7);
            double line1 = comparison.CalcLength();
            Console.WriteLine("Length of 1st Line: " + line1);
            Comparision linecomparison = new Comparision(8, 9, 10, 12);
            double line2 = linecomparison.CalcLength();
            Console.WriteLine("Length of 2nd Line: " + line2);
            if (line1.Equals(line2))
                Console.WriteLine("Both Lines are Equal");
            {
                if (line1.CompareTo(line2) > 0)
                    Console.WriteLine("1st Line is Greater than 2nd Line");
                else
                    Console.WriteLine("2nd Line is Greater than 1st Line");
            }
        }
    }
}
