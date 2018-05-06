using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Worker
    {
        private List<Processor> processors;

        public Worker()
        {
            // Initialize chain of processors
            processors = new List<Processor>
            {
                new Processor1(),
                new Processor2()
            };
        }

        public void Process(string command)
        {
            foreach(Processor processor in processors)
            {
                processor.Execute(command);
            }
        }
    }
}
