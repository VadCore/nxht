using System;
using System.Collections.Generic;
using System.Text;

namespace NixSolHomeTask1
{
    class Circle : Point
    {
        private double Radius { get; set; }

        public Circle(double anchorPointX, double anchorPointY, double radius)
            : base(anchorPointX, anchorPointY)
        {
            Radius = radius;
        }

        public override void Scale(double factor)
        {
            Radius *= factor;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($", Radius = {Radius}");
        }
    }
}
