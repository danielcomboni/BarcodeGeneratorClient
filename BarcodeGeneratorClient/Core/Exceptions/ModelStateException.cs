using System;

namespace BarcodeGeneratorClient.Core.Exceptions
{
    public class ModelStateException : Exception
    {
        public ModelStateException(string message) : base(message)
        {
        }

    }
}
