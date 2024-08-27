using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarden
{
    internal class InvalidSizeGarden : Exception
    {
        public InvalidSizeGarden(string message) :base(message){ }
    }
}
