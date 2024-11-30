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

        static enCalculator ReadOperationToCalculate(int from , int to)
        {
            int op;
            do
            {
                Console.WriteLine("\t**********************");
                Console.WriteLine("\t[1] Addtion");
                Console.WriteLine("\t[2] Substraction");
                Console.WriteLine("\t[3] Multiplication");
                Console.WriteLine("\t[4] Division");
                Console.WriteLine("\t**********************");
                
                Console.WriteLine("\nWhat type of operation would you like to do  ? [ 1 => 4]");
                op = Convert.ToInt32(Console.ReadLine());

            } while (!Enumerable.Range(from, to).Contains(op));

            return (enCalculator)op;
        }

        static void Calculator(double firstNum , double secondNum , enCalculator op) {

            switch(op)
            {
                case enCalculator.eAddition:
                    Console.Write("The result is : ");
                    Console.WriteLine(firstNum + secondNum);
                    break;
                case enCalculator.eSubtraction:
                    Console.Write("The result is : ");
                    Console.WriteLine(firstNum - secondNum);
                    break;
                case enCalculator.eMultiplication:
                    Console.Write("The result is : ");
                    Console.WriteLine(firstNum * secondNum);
                    break;
                case enCalculator.eDivision:
                    Console.WriteLine(secondNum == 0 ? "\aError Cannot Divide by Zero\nThe result is " +double.NaN : "The result is :" + firstNum / secondNum);
                    break;
                default:
                    Console.WriteLine("Wrong Operation Type :-( ");
                    break;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello , Welcome to the calculator program");
            
            double firstNum = ReadNumber("\nPlease enter your First number ?");
            double secondNum = ReadNumber("\nPlease enter your Second number ?");

            Calculator(firstNum,secondNum,ReadOperationToCalculate(1, 4));
            Console.WriteLine("\nThank you for using the calculator program :-)");
            Console.ReadKey();
        }
    }
}
