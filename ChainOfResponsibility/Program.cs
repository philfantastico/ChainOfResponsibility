using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning Processing");

            Worker handler = new Worker();

            handler.Process("command1");
            handler.Process("command2");
            handler.Process("command3");

            Console.WriteLine("Processing Complete");
            Console.ReadKey();
        }
    }
}
