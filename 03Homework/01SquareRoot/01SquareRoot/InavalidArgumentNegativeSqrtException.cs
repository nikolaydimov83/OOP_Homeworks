using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01SquareRoot
{
    class ArgumentNegativeSqrtException:ArgumentException
    {
        public ArgumentNegativeSqrtException(string msg)
            : base(msg)
    {
    
    }


    }
}
