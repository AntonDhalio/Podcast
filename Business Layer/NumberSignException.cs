using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer
{ 
[Serializable]
public class NumberSignException : Exception
{
    public NumberSignException(string message) : base(message) { }

    public NumberSignException() : base("Textrutan får endast innehålla bokstäver") { }

}
}
