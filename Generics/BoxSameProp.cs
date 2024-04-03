using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class BoxSameProp: EqualityComparer<Box>
    {
        public override bool Equals(Box U1,Box U2)
        {
            if (U1.height == U2.height && U1.width == U2.width && U1.lenght == U2.lenght || U1.volym == U2.volym)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box s)
        {
            return s.GetHashCode();
        }
    }
}
