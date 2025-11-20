using System.Collections.Immutable;
using static System.Console;

namespace Homeworks
{
    public class HomeworkConsoleApp
    {
        public sealed record User
        {
            public required Guid Id { get; init; }
            public required int Age { get; init; }
            public string? Name { get; init; }
        }
        
        public ICollection<User> SelectUsers(ICollection<User> users)
        {
            if (users == null)
            {
                return [];
            }
            return users
                .OrderBy(user => user.Age)
                .ToList();
        }
        public ICollection<Guid> SelectUserIds(ICollection<User> users, int age)
        {
            return users.Where(user => user.Age > age).Select(user => user.Id).ToList();
        }
        
        
        public int? GetElementAtOrDefault (ICollection<int>? collection,int index)
        {
            if (collection == null)
                return null;
            if (index < 0 || index >= collection.Count)
                return null;
            return collection.ElementAtOrDefault(index);
        }

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
            //var userInputList = consoleApp.InputHandler();
            //var result = consoleApp.GetPositiveNumbers(userInputList);
            //foreach (int number in result)
            //WriteLine(number);
            //var result = consoleApp.GetFirstOddNumber(userInputList);
            //WriteLine(result);
            //result = consoleApp.GetLastOddNumber(userInputList);
            //WriteLine(result);
            //WriteLine(consoleApp.GetElementAtOrDefault(userInputList,2));
        }
    } 
}