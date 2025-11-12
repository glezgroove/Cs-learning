namespace ConsoleApp
{
    public class ConsoleApp
    {
        public static IEnumerable<int> GetOdd(ICollection<int> nums)
        {
            List<int> result = new List<int>();
            foreach (int i in nums)
            {
                if (i % 2 != 0)
                    result.Add(i);
            }
            return result;
        }
        
        public static List<int> InputHandler()
        {
            List<int> list = new List<int> ();
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
                            Console.WriteLine("Введено не целое число. Вывод нечётных чисел");
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
            var UserInputList = InputHandler();
            var result = GetOdd(UserInputList);
            foreach (int number in result)
                Console.WriteLine(number);
        } 
    } 
}