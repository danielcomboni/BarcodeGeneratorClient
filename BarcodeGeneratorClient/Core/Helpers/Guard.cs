using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcodeGeneratorClient.Core.Exceptions ;

namespace BarcodeGeneratorClient.Core.Helpers
{
    public class Guard
    {
        public static void ThrowIfNullOrEmpty(string argumentValue, string message)
        {
            if (string.IsNullOrWhiteSpace(argumentValue)) throw new ClientFriendlyException(message);
        }
    }
}
