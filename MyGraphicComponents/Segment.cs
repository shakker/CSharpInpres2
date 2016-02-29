using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Segment : Shape, IlsPointIn, IComparable<Segment>, IEquatable<Segment>
    {
        public mypoint _ext { get; set; }

        private int cmpt;

        public Segment()
        {
            _ext = new mypoint(1, 1);
            _shapepoint = new mypoint();
        }

        public Segment(mypoint E1, mypoint Accroche)
        {
            _ext = E1;
            _shapepoint = Accroche;
        }

        public Segment(int xshape, int yshape, int xext, int yext)
        {
            _ext = new mypoint(xext, yext);
            _shapepoint = new mypoint(xshape, yshape);
        }

        public Segment(Segment s)
        {
            _ext = new mypoint(s._ext);
            _shapepoint = new mypoint(s._shapepoint);
        }

        public override string ToString()
        {
            return "Debut :" + _shapepoint + ", Fin :" + _ext;
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public bool IsPointIn(mypoint InPoint)
        {
            double shapeC, extC, shapeext;

            shapeC = _shapepoint.CalculLongueur(InPoint);
            extC = _ext.CalculLongueur(InPoint);
            shapeext = _shapepoint.CalculLongueur(_ext);

            if ((shapeC + extC - shapeext) < 5)
                return true;
            else
                return false;
        }

        public override double Surface()
        {
            return 100000;
        }

        public int CompareTo(Segment otherSegment)
        {
            double lgThis, lgOther;

            lgThis = this._ext.CalculLongueur(this._shapepoint);
            lgOther = otherSegment._ext.CalculLongueur(otherSegment._shapepoint);

            return lgThis.CompareTo(lgOther);
        }

        public bool Equals(Segment otherSegment)
        {
            double lgThis, lgOther;

            lgThis = this._ext.CalculLongueur(this._shapepoint);
            lgOther = otherSegment._ext.CalculLongueur(otherSegment._shapepoint);

            if (otherSegment == null)
                return false;

            else if ((long)lgThis == (long)lgOther)
                return true;
            else
                return false;
        }
    }
}
