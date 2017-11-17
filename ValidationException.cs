using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdmxLibrary
{
    class ValidationException : Exception
    {
        private string p;

        public ValidationException(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
    }
}
