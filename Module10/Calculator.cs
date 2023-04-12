using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Calculator : ICalculator
    {
        static ILogger ILogger = new Logger();
        public int Calc(int a, int b)
        {
            return a + b;
        }

        public static int Input()
        {
            int number;
            while (true)
            {
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    return number;
                }
                catch (Exception ex)
                {
                    ILogger.Error("Введите корректное число:");
                }
            }

        }
    }
}
