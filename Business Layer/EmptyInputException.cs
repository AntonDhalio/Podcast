using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer

{
    [Serializable]
    public class EmptyInputException : Exception
    {
        public EmptyInputException(string message) : base(message) { }

        public EmptyInputException() : base("Textrutan får ej vara tom") { }

    }


}
