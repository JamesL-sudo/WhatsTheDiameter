using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WhatsTheDiameter
{
    class Circle : IComparable<Circle>
    {
        private double radius;
        // You can use Math.PI to get pi.

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return this.radius;
        }

        override public String ToString()
        {
            return this.radius.ToString();
        }

        public double getDiameter()
        {
            return this.radius * 2;
        }
        public double getCircumference()
        {
            return this.getDiameter() * Math.PI;
        }
        public double getArea()
        {
            return this.radius * this.radius * Math.PI;
        }
        public void setRadius(double rad)
        {
            this.radius = rad;
        }

        public int CompareTo (Circle that)
        {
            if (this.radius < that.radius)
                return -1;
            else if (this.radius > that.radius)
                return 1;
            return 0;
        }
        // Need now getDiameter, getCircumference, getArea.

        // Neet also setRadius.
    }
}
