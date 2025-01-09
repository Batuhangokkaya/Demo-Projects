using System;

namespace Loops
{
    public class ForLoop
    {
        public void ForMethod1()
        {
            int sum1 = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum1 += i;
            }
            Console.WriteLine(sum1);
        }

        public void ForMethod2()
        {
            int sum2 = 0;
            int number, average;
            for (int counter = 1; counter <= 5; counter++)
            {
                Console.Write("Enter Number {0} : ", counter);
                number = Convert.ToInt32(Console.ReadLine());
                sum2 += number;
            }
            average = sum2 / 5;
            Console.WriteLine("Average : {0}", average);
        }

        public void ForMethod3()
        {
            int a = 1;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 8; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }

        public void ForMethod4()
        {
            for (int i = 21; i <= 30; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("H");
            }
        }
    }
}