namespace FindAndCountFileName
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
            DirectoryInfo dir = new DirectoryInfo(args[0]);
            var name = args[1];
            Console.WriteLine($"This dir contain {name}: {dir.GetFiles().Count(e => e.Name.Contains(name))+dir.GetDirectories().Count(e => e.Name.Contains(name))} time(s)");
            Console.ReadKey();
        }
    }
}