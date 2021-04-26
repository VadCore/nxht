using System;
using System.Collections.Generic;
using System.Text;

namespace NixSolHomeTask1
{
    class Triangle : Rectangle
    {
        private double Point3ShiftX { get; set; }
        private double Point3ShiftY { get; set; }

        public Triangle(double anchorPointX, double anchorPointY, double point2ShiftX, double point2ShiftY,
            double point3ShiftX, double point3ShiftY)
            : base(anchorPointX, anchorPointY, point2ShiftX, point2ShiftY)
        {
            Point3ShiftX = point3ShiftX;
            Point3ShiftY = point3ShiftY;
        }

        public override void Scale(double factor)
        {
            base.Scale(factor);
            Point3ShiftX *= factor;
            Point3ShiftY *= factor;
        }

        public override string ToString() => 
            base.ToString() + string.Format($", Point3ShiftX = {Point3ShiftX}, Point3ShiftY = {Point3ShiftY}");
    }
}
