using System;

namespace Test_ConsoleApp
{
    class Program
    {
        static void UnaryOperands()
        {
            //X++ - сначала присвоили, после прибавили
            //++х - сначала прибавили, после присвоили
            int x = 5;
            int y = x++;
            Console.WriteLine($"x is {x},  y is {y}");
            x = 5;
            y = ++x;
            Console.WriteLine($"x is {x},  y is {y}");
        }

        static void BinaryOperands()
        {
            int e = 11;
            int f = 3;
            Console.WriteLine($"e is {e},  f is {f}");
            Console.WriteLine($"e + f = {e + f}");
            Console.WriteLine($"e - f = {e - f}");
            Console.WriteLine($"e * f = {e * f}");
            Console.WriteLine($"e % f = {e % f}");

            // decimal d = 11;
            double d = 11;
            Console.WriteLine($"d = {d:N5}");
            Console.WriteLine($"d / e = {(d / f):N64}");

            int p = 6;
            p += 5; // -=5, *=3, /=3
            Console.WriteLine($"p = {p}");
        }

        static void LogicalOperations()
        {
            // & - И, | - или, ^ - XOR (хотя бы один true, но не все)
            bool a = true;
            bool b = false;
            Console.WriteLine($"AND | a     | b    ");
            Console.WriteLine($"a   | {a & a,-5} | {a & b,-5} ");
            Console.WriteLine($"b   | {b & a,-5} | {b & b,-5} ");
            Console.WriteLine($"OR | a     | b    ");
            Console.WriteLine($"a   | {a | a,-5} | {a | b,-5} ");
            Console.WriteLine($"a   | {b | a,-5} | {b | b,-5} ");
            Console.WriteLine($"XOR | a     | b    ");
            Console.WriteLine($"a   | {a ^ a,-5} | {a ^ b,-5} ");
            Console.WriteLine($"a   | {b ^ a,-5} | {b ^ b,-5} ");
            // && - может быть более эффектиыным. Если первое значение уже равно false - не смотрим что там дальше
        }

        static void BitwiseAndShiftOperations()
        {
            int a = 14; // 1110
            int b = 5; // 0101
            Console.WriteLine($"a & b = {a & b}"); // 0100
            Console.WriteLine($"a | b = {a | b}"); // 1111
            Console.WriteLine($"a ^ b = {a ^ b}"); // 1011
            Console.WriteLine($"a << 3 = {a << 3}"); // 1110000
            Console.WriteLine($"a >> 3 = {a >> 1}"); // 111
            Console.WriteLine(Convert.ToString(a, toBase: 2).PadLeft(8, '0')); // преобразование в двоичный вид
        }
        
        static void Nameof_Sizeof()
        {
            string Name = "55523";
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(nameof(Name)); // Вывод имени переменной, не значения
        }
        
        static void If_in_If()
        {
            object o = 3;
            int j = 5;
            if (o is int i) // это ужас?
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                Console.WriteLine("o is not an int so it cannot multiply!");
            }
        }

        static void Switch_Stream()
        {
            // string path = "/Users/markjprice/Code/Chapter03";
            string path = @"C:/Users/VM/streetschecker/pythonProject4/checker.py";
            Console.Write("Press R for read-only or anything else for writeable: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Stream? s;
            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    path,
                    FileMode.OpenOrCreate,
                    FileAccess.Read);
            }
            else
            {
                s = File.Open(
                    path,
                    FileMode.OpenOrCreate,
                    FileAccess.Write);
            }

            string message;
            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file.";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address.";
                    break;
                default: // всегда выполняется последним, несмотря на текущее положение
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null.";
                    break;
            }

            Console.WriteLine(message);

            string? password;
        }





        static void Main(string[] args)
        {
            // UnaryOperands();  
            // BinaryOperands();
            // LogicalOperations();
            // BitwiseAndShiftOperations();
            // Nameof_Sizeof();
            // If_in_If();
            // Switch_Stream(); // стоит ли упрощать скобки?
            // string? password // if password is not string, return null
            double[] doubles = new[]
                { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            foreach (double n in doubles)
            {
                Console.WriteLine($"ToInt32({n}) is {Convert.ToInt32(n)}");
            } // ЗАЧЕМ?
        }
    }
}


