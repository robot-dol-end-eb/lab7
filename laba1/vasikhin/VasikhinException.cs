using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vasikhin
{
    class VasikhinException : Exception
    {
        public VasikhinException(string message)
            : base(message)
        {
        }
    }
}
