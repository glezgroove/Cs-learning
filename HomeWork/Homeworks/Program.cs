using static System.Console;

namespace Homeworks
{
    public class HomeworkConsoleApp
    {
        public ICollection<int> GetPositiveNumbers(ICollection<int> numbers)
        {
            return numbers.Where(i => i > 0).ToList();
        }
        
        public int? GetFirstOddNumber(ICollection<int>? numbers)
        {
            var result =  numbers.FirstOrDefault(i => i % 2 != 0);
            if (result == 0) 
                return null;
            return result;
        }
        
        public int? GetLastOddNumber(ICollection<int>? numbers)
        {
            var result =  numbers.FirstOrDefault(i => i % 2 != 0);
            if (result == 0) 
                return null;
            return result;
        }

        public ICollection<int> InputHandler()
        {
            List<int> list = new List<int>();
            string? number;
            WriteLine("Введите необходимые числа. Для расчёта введите что угодно, кроме целого числа.");
            while (true)
            {
                try
                {
                    number = ReadLine();
                    {
                        if (!int.TryParse(number, out int parsedNum))
                        {
                            WriteLine("Введено не целое число. Вывод первого и последнего числа");
                            break;
                        }
                        WriteLine($"Ваше число {number}");
                        list.Add(parsedNum);
                    }
                }
                catch (Exception e)
                {
                    WriteLine(e);
                    throw;
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            var consoleApp = new HomeworkConsoleApp();
            var userInputList = consoleApp.InputHandler();
            //var result = consoleApp.GetPositiveNumbers(userInputList);
            //foreach (int number in result)
            //WriteLine(number);
            var result = consoleApp.GetFirstOddNumber(userInputList);
            WriteLine(result);
            result = consoleApp.GetLastOddNumber(userInputList);
            WriteLine(result);
        }
    } 
}