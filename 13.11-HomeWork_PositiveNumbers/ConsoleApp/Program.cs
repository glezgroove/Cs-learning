namespace _13_11_HomeWork_ConsoleApp
{
    public class HomeworkConsoleApp
    {
        public ICollection<int> GetPositiveNumbers(ICollection<int> numbers)
        {
            return numbers.Where(i => i > 0).ToList();
        }
        
        public ICollection<int> InputHandler()
        {
            List<int> list = new List<int>();
            string? number;
            Console.WriteLine("Введите необходимые числа. Для расчёта введите что угодно, кроме целого числа.");
            while (true)
            {
                try
                {
                    number = Console.ReadLine();
                    {
                        if (!int.TryParse(number, out int parsedNum))
                        {
                            Console.WriteLine("Введено не целое число. Вывод положительных чисел");
                            break;
                        }
                        Console.WriteLine($"Ваше число {number}");
                        list.Add(parsedNum);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            var consoleApp = new HomeworkConsoleApp();
            var userInputList = consoleApp.InputHandler();
            var result = consoleApp.GetPositiveNumbers(userInputList);
            foreach (int number in result)
                Console.WriteLine(number);
        }
    } 
}
