using System;
using System.Linq;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY
            Console.WriteLine("Please Enter The Size Of The Array");
            int Size = int.Parse(Console.ReadLine());
            int[] Values = new int[Size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < Size; i++)
            {
                Console.Write("Element {0}: ", i);
                Values[i] = int.Parse(Console.ReadLine());
            }

            //MEDIAN
            int Median;
            if (Size % 2 == 0)
            {
                //even
                int Middle = Size / 2;
                Median = (Values[Middle - 1] + Values[Middle]) / 2;
            }
            else
            {
                //odd
                int Middle = (Size - 1) / 2;
                Median = Values[Middle];
            }
            System.Console.WriteLine("The Median :" + Median);

            //MODULUS
            Console.WriteLine("Modulus value: ");
            int Mod = int.Parse(Console.ReadLine());
            foreach (int Number in Values)
            {
                int Result = Number % Mod;
                Console.WriteLine($"{Number} Mod {Mod} Is {Result}");
            }

            //RANGE
            int Range = Values.Max() - Values.Min();
            System.Console.WriteLine("The Range Is : " + Range);

            //1ST AND 3RD QUARTILE
            int Q1 = 0, Q3 = 0;
            int X = Values.Length;
            int q1 = (X / 4) + 1;
            Q1 = Values[q1 - 1];
            int q3 = (3 * X) / 4;
            Q3 = Values[q3];
            System.Console.WriteLine("The 1st Quartile Is :" + Q1);
            System.Console.WriteLine("The 3rd Quartile Is :" + Q3);

            //PERCENTILE
            double P90 = 0;
            int p90 = (int)Math.Floor(X * 0.9);
            P90 = Values[p90];
            Console.WriteLine("P90 Is :" + P90);

            //INTERQUARTILE
            int InterQ = Q3 - Q1;
            System.Console.WriteLine("The InterQuartile Is :" + InterQ);

            //BOUNDARY
            double LowerB = Q1 - 1.5 * InterQ;
            double UpperB = Q3 + 1.5 * InterQ;
            System.Console.WriteLine("The LowerBoundary Is :" + LowerB);
            System.Console.WriteLine("The UpperBoundary Is :" + UpperB);

            //OUTLIER
            System.Console.WriteLine("Please Enter The Input Value");
            int InputV = int.Parse(Console.ReadLine());
            if (InputV < LowerB || InputV > UpperB)
            {
                System.Console.WriteLine(InputV + "Is An Outlier");
            }
            else
            {
                System.Console.WriteLine(InputV + "Is Not An Outlier");
            }
            Console.ReadLine();
        }
    }
}