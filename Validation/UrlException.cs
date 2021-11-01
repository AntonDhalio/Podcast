using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
    [Serializable]
    public class UrlException : Exception
    {
        public UrlException(string message) : base(message) { }

    }
}
