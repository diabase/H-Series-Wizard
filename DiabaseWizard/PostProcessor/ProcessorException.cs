using System;

namespace DiabaseWizard
{
    class ProcessorException : Exception
    {
        public ProcessorException(string message) : base(message) { }
    }
}
