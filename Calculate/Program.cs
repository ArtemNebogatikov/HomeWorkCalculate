using Log;

namespace Calculate
{

    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            Console.WriteLine("Мини калькулятор суммы");
            Calculate calc = new Calculate(Logger);
            int num1 = calc.GetNum(1);
            int num2 = calc.GetNum(2);
            Console.WriteLine("Сумма равна: {0}", calc.Sum(num1, num2));
            Console.ReadKey();

        }
    }
}






