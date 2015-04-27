using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework2
{
    class NegativeLeaveDays : Exception
    {
        public NegativeLeaveDays(string message)
            : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
