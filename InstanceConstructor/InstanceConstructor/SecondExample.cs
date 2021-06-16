using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceConstructor
{
    abstract class Shape
    {
        public const double pi = Math.PI;
        protected double x, y;

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Area();
    }

    class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, 0)
        {
        }

        public override double Area()
        {
            return pi * x * x;
        }
    }

    class Cylinder : Circle
    {
        public Cylinder(double radius, double height)
            : base(radius)
        {
            y = height;
        }

        public override double Area()
        {
            return (2 * base.Area()) + (2 * pi * x * y);
        }
    }
}
