using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer
{
    [Serializable]
    public class UrlException : Exception
    {
        public UrlException(string message) : base(message) { }

    }
}

