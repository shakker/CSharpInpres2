using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Square : Shape, IlsPointIn, IComparable<Square>, IEquatable<Square>, IPointy
    {
        public int _lg { get; set; }

        public Square()
        {
            _lg = 1;
            _shapepoint = new mypoint();
        }

        public Square(int longueur, mypoint accroche)
            : base(accroche)
        {
            _lg = longueur;
        }

        public Square(int longueur, int x, int y)
            : base(x, y)
        {
            _lg = longueur;
        }

        public Square(Square s)
        {
            _lg = s._lg;
            _shapepoint = s._shapepoint;
        }

        public override string ToString()
        {
            return "Longueur :" + _lg + ", Accroche :" + _shapepoint;
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public int Points
        {
            get { return 4; }
        }

        public bool IsPointIn(mypoint InPoint)
        {
            if (this._shapepoint._x <= InPoint._x && this._shapepoint._y >= InPoint._y && this._shapepoint._x + this._lg >= InPoint._x && this._shapepoint._y - this._lg <= InPoint._y)
                return true;
            else
                return false;
        }

        public override double Surface()
        {
            return Math.Truncate((double)(_lg * _lg));
        }

        public int CompareTo(Square otherSquare)
        {
            return _lg.CompareTo(otherSquare._lg);
        }

        public bool Equals(Square otherSquare)
        {
            if (otherSquare == null)
                return false;

            else if (this._lg == otherSquare._lg)
                return true;
            else
                return false;
        }
    }
}
