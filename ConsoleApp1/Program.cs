namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            if (args.Length < 1)
            {
                Console.WriteLine("No args!");
                Console.ReadKey();
                return;
            }
            List<char> symbs = new List<char> { '+', '-', '*', '/' };
            int result = 0;
            int num1 = Convert.ToInt32(args[0]);
           int num2 = Convert.ToInt32(args[1]);
           char  symbol = args[2].First();
            if (args[2].Length > 1)
            {
                Console.WriteLine("To many symbols!");
                Console.ReadKey();
                return;
            }
            if (!symbs.Contains(symbol))
            {
                Console.WriteLine("Unknown command!");
                Console.ReadKey();
                return;
            }
            if (symbol == '+')
              result = num1 + num2;
             if (symbol == '-')
                result = num1 - num2;
             if (symbol == '*')
                result = num1 * num2;
            if (symbol == '/')
                result = num1 / num2;
            if(num2 == 0)
            {
                Console.WriteLine("Num is equal to zero");
                 Console.ReadKey();
                return;

            }
            Console.WriteLine($"{num1} {symbol} {num2} = {result}");
            Console.ReadKey();
        }
    }
}