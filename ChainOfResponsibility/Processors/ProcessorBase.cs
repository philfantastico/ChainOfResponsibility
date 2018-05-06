using System.Collections.Specialized;

namespace ChainOfResponsibility
{
    public abstract class Processor
    {
        private StringCollection responsibleFor = new StringCollection();
        protected abstract string[] ResponsibleFor { get; }
        protected abstract void Process(string toProcess);

        public Processor() { SetResponsibility(); }

        private void SetResponsibility() { responsibleFor.AddRange(ResponsibleFor); }

        private bool IsResponsibleFor(string command) { return responsibleFor.Contains(command); }

        public void Execute(string command)
        {
            if (IsResponsibleFor(command))
            {
                Process(command);
            }
        }
    }
}
