using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask13
{
    internal class FileSearchException : Exception
    {
        internal FileSearchException(string message) : base (message) { }
    }
}
