using System;

namespace DiabasePrintingWizard
{
    class ProcessorException : Exception
    {
        public ProcessorException(string message) : base(message) { }
    }
}
