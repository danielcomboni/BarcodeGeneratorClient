using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarcodeGeneratorClient.Core.Helpers ;

namespace BarcodeGeneratorClient.Services
{
    public class GeneratorService : IGeneratorService
    { /// <summary>
        /// Returns a PDF417 encoded bytes array from a given string
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public byte[] GetBytesArray(string content)
        {
            return BarcodeHelper.GenerateByteArray(content);
        }
    }
}
