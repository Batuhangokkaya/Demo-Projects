using System;
using System.Diagnostics;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            PrintName();

            Console.Write("Enter a Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter a Last Name : ");
            string lastName = Console.ReadLine();
            PrintName(name, lastName);

            // Method 2
            int result1 = PrintNumber(0); // Direkt Konsola Yazdırılabilir.
            Console.WriteLine(result1);

            // Method 3
            int result2 = DefaultParameter(14);
            Console.WriteLine(result2);

            // Method 4
        RETRADE:
            Console.Write("Enter a number1 : ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number2 : ");
            double number2 = Convert.ToDouble(Console.ReadLine());
        BACK:
            Console.Write("Make Your Choice (Addition: 1, Subtraction: 2, Division: 3, Multiplication: 4 ) : ");
            char chooseFourProcesses = Convert.ToChar(Console.ReadLine());
            switch (chooseFourProcesses)
            {
                case '1':
                    FourOperations aggregationProcess = new FourOperations();
                    double addition = aggregationProcess.Addition(number1, number2);
                    Console.WriteLine("Aggregation result : {0}", addition);
                    break;
                case '2':
                    FourOperations subtractionProcess = new FourOperations();
                    double subtraction = subtractionProcess.Subtraction(number1, number2);
                    Console.WriteLine("Subtraction result : {0}", subtraction);
                    break;
                case '3':
                    FourOperations divisionProcess = new FourOperations();
                    double division = divisionProcess.Division(number1, number2);
                    Console.WriteLine("Division result : {0}", division);
                    break;
                case '4':
                    FourOperations MultiplicationProcess = new FourOperations();
                    double multiplication = MultiplicationProcess.Multiplication(number1, number2);
                    Console.WriteLine("Multiplication result : {0}", multiplication);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You have made the wrong choice, please select the numbers specified.");
                    goto BACK;
            }
            CONTINUESELECTION:
            Console.Write("Would You Like To Re-Trade? (YES : Y, NO : N)");
            char selectContinue = Convert.ToChar(Console.ReadLine());
            if (selectContinue == 'Y' || selectContinue == 'y')
            {
                Console.Clear();
                goto RETRADE;
            }
            else if (selectContinue == 'N' || selectContinue == 'n')
            {
                Console.WriteLine("Your Transaction Is Done, Thank You.");
            }
            else
            {
                Console.WriteLine("You Made the Wrong Choice, Please Choose Again.");
                goto CONTINUESELECTION;
            }

            //Method 5
            Console.Write("Enter the length of the short side : ");
            double shortEdge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of the long side : ");
            double longEdge = Convert.ToDouble(Console.ReadLine());
            double rectangularArea = CalculateAreaPerimeter.CalculateArea(shortEdge, longEdge);
            double rectangularCircumference = CalculateAreaPerimeter.CalculatePerimeter(shortEdge, longEdge);
            Console.WriteLine("Area of the Rectangle : {0}, Perimeter of the Rectangle : {1}", rectangularArea, rectangularCircumference);

            // Ref Method
            int number3 = 6;
            int number4 = 6;
            int result3 = RefMethod(ref number3, number4); // ref tanımlarken değeri önceden set etmek gerekir.
            Console.WriteLine(result3);

            // Ref Method
            int number5;
            int number6 = 6;
            int result4 = OutMethod(out number3, number4); // out tanımlarken değeri önceden set etmek zorunlu değildir.
            Console.WriteLine(result4);

            // Params Method
            int result5 = ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8, 9); // 2 tane parametre olduğu için ilk değer 1. parametreye atanacaktır.
            Console.WriteLine(result5);

            Console.ReadKey();
        }

        // Method 1
        public static void PrintName()
        {
            Console.WriteLine("Batuhan Gökkaya");
        }

        public static void PrintName(string name, string lastName) // override
        {
            Console.WriteLine($"Name : {name}, Last Name : {lastName}");
        }

        // Method 2
        private static int PrintNumber(int number)
        {
            return (number);
        }

        // Method 3
        private static int DefaultParameter(int number1, int number2 = 0)
        {
            return (number1 + number2);
        }

        // Ref Method
        public static int RefMethod(ref int number3, int number4)
        {
            number3 = 2;
            return (number3 + number4);
        }

        // Out Method
        public static int OutMethod(out int number5, int number6)
        {
            number5 = 2; // out tanımlarken değeri metotun içinde set etmek gerekir.
            return (number5 + number5);
        }

        // Params Metthod
        public static int ParamsMethod(int number, params int[] numbers) // params tanımlarken her zaman parametrenin en sonunda olmak zorundadır.
        {
            return numbers.Sum(); // Sum() toplama metotudur.
        }
    }
}