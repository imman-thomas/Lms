using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class IdenticalEmailException:ApplicationException
    {
        public IdenticalEmailException() : base() { }
        public IdenticalEmailException(string message) : base(message) { }
    }
}
