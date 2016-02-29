using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Circle : Shape, IlsPointIn, IComparable<Circle>, IEquatable<Circle>
    {
        public int _rayon { get; set; }

        public Circle()
        {
            _rayon = 1;
            _shapepoint = new mypoint();
        }

        public Circle(int ray, mypoint accroche)
            : base(accroche)
        {
            _rayon = ray;
        }

        public Circle(int ray, int x, int y)
            : base(x, y)
        {
            _rayon = ray;
        }

        public Circle(Circle c)
        {
            _rayon = c._rayon;
            _shapepoint = c._shapepoint;
        }

        public override string ToString()
        {
            return "Rayon :" + _rayon + ", Accroche :" + _shapepoint;
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public bool IsPointIn(mypoint InPoint)
        {
            double longueur = InPoint.CalculLongueur(_shapepoint);
            if (longueur > (double)_rayon)
                return false;
            else
                return true;
        }

        public override double Surface()
        {
            return Math.Truncate(Math.PI * Math.Pow(_rayon, _rayon));
        }

        public int CompareTo(Circle otherCircle)
        {
            return _rayon.CompareTo(otherCircle._rayon);
        }

        public bool Equals(Circle otherCircle)
        {
            if (otherCircle == null)
                return false;

            if (this._rayon == otherCircle._rayon)
                return true;
            else
                return false;
        }
    }
}
