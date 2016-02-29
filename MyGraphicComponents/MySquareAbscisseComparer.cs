using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class MySquareAbscisseComparer : IComparer<Square>
    {
        public int Compare(Square s1, Square s2)
        {
            if (s1._shapepoint._x > s2._shapepoint._x)
                return 1;
            else if (s1._shapepoint._x < s2._shapepoint._x)
                return -1;
            else
                return 0;
        }
    }
}
