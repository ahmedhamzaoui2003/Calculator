using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    enum enCalculator
    {
        eAddition = 1,
        eSubtraction = 2,
        eMultiplication = 3,
        eDivision = 4
    }
    internal class Program
    {

        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double num = Convert.ToInt32(Console.ReadLine());

            return num;
        }

        static enCalculator ReadOperationToCalculate(string message,int from , int to)
        {
            int op;
            do
            {
                Console.WriteLine(message);
                op = Convert.ToInt32(Console.ReadLine());

            } while (Enumerable.Range(from, to).Contains(op));
            return (enCalculator)op;




        }
        static void Main(string[] args)
        {
        }
    }
}
