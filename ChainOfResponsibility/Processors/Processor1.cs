using System;

namespace ChainOfResponsibility
{
    public class Processor1 : Processor
    {
        protected override string[] ResponsibleFor => new string[] { "command1" };

        protected override void Process (string toProcess)
        {
            Console.WriteLine($"Processor1 processing {toProcess}");
        }
    }

    public class Processor2 : Processor
    {
        protected override string[] ResponsibleFor => new string[] { "command1", "command2" };

        protected override void Process(string toProcess)
        {
            Console.WriteLine($"Processor2 processing {toProcess}");
        }
    }
}
