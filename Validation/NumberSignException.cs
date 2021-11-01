﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
    [Serializable]
    public class NumberSignException : Exception
    {
        public NumberSignException(string message) : base(message) { }

        public NumberSignException() : base("Textrutan får endast innehålla bokstäver") { }

    }
}
