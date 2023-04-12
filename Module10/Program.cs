using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger Logger = new Logger();
            ICalculator calculator = new Calculator();
            Logger.Event("Введите первое число:"); 
            int a = Calculator.Input();
            Logger.Event("Введите второе число:");
            int b = Calculator.Input();
            Logger.Event($"Результат: {calculator.Calc(a, b)}");
        }
    }

    public interface ICalculator
    {
        int Calc(int a, int b) 
        { 
            return a + b; 
        }

    }

    public interface ILogger
    {
        public void Event(string message);
        public void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }
}