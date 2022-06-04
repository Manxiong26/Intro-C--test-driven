namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}What can I help you with {name}?");
            var response = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}You want to me to {response}?");
            var responseTwo = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}I'll {response} then! Give me one minute");
            Console.ReadKey(true);
        }
    }
}