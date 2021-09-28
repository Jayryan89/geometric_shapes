using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes
{
    class Square
    {
        public int Side1 { get; set; }

        public int Perimeter()
        {
            return 4 * Side1;
        }
        public int Area()
        {
            return Side1 * Side1;
        }
    }
}
