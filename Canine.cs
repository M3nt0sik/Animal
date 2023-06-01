using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Canine:Animals
    {
        public bool BelongsToPack { get; protected set; } = false;
    }
}
