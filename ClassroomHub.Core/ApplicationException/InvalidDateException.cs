using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Core.ApplicationExeception
{
    public class InvalidDateException : ApplicationException
    {
        public InvalidDateException(string message):base(message)
        {
            
        }
    }
}
