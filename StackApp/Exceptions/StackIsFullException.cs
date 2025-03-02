using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp.Exceptions
{
    internal class StackIsFullException
    {
        private string v;

        public StackIsFullException(string v)
        {
            this.v = v;
        }
    }
}
