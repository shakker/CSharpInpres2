using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class MyCircleAbscisseComparer : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1._shapepoint._x > c2._shapepoint._x)
                return 1;
            else if (c1._shapepoint._x < c2._shapepoint._x)
                return -1;
            else
                return 0;
        }
    }
}
