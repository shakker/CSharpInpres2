using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public struct mypoint
    {
        public int _x, _y;
        public mypoint(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public mypoint(mypoint p)
        {
            this._x = p._x;
            this._y = p._y;
        }

        public override string ToString()
        {
            return "X(" + _x + "), Y(" + _y + ")" ;
        }

        public void Draw()
        {
            Console.Write(this.ToString());
        }

        public double CalculLongueur( mypoint otherPoint)
        {
            return Math.Sqrt((double)((Math.Pow(this._x - otherPoint._x, this._x - otherPoint._x)) + (Math.Pow(this._y - otherPoint._y, this._y - otherPoint._y))));
        }
    }

    public abstract class Shape : IComparable<Shape>
    {
        public mypoint _shapepoint {get; set;}

        protected string _name ;

        public string Name { get { return _name; } set {_name = value;} }

        public Shape()
        {
            _shapepoint = new mypoint(0, 0);
        }

        public Shape(mypoint p)
        {
            _shapepoint = new mypoint(p);
        }

        public Shape(int x, int y)
        {
            _shapepoint = new mypoint(x, y);
        }

        public abstract void Draw();

        public abstract double Surface();

        public int CompareTo(Shape otherShape)
        {
            return this.Surface().CompareTo(otherShape.Surface());
        }

    }
}
