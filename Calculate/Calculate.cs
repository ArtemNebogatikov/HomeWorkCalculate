using System;
using Log;

namespace Calculate
{
    
    public interface ISum
    {
        public int Sum(int a, int b);
    }
    class Calculate : ISum
    {
        ILogger Logger { get; }
        public Calculate(ILogger logger)
        {
            Logger = logger;
        }
        public int Sum(int a, int b)
        {
            Logger.Error("Калькулятор начал свою работу");
            Thread.Sleep(1000);
            Logger.Event("Калькулятор закончил свою работу");
            return a + b;
        }
        public int GetNum(int number)
        {
            int num = 0;
            while(true)
            {
                try
                {
                    Console.WriteLine("Введите {0} число", number);
                    num = Convert.ToInt32(Console.ReadLine());
                    return num;
                }
                catch
                {
                    Logger.Error("Введено некорректное значение");
                }
                
            }
            
        }
    }
}
