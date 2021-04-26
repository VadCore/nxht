using System;
using System.Collections.Generic;
using System.Text;

namespace NixSolHomeTask1
{
    public class Rectangle : Point
    {
        private double Point2ShiftX { get; set; }
        private double Point2ShiftY { get; set; }

        public Rectangle(double anchorPointX, double anchorPointY, double point2ShiftX, double point2ShiftY)
            : base (anchorPointX, anchorPointY)
        {
            Point2ShiftX = point2ShiftX;
            Point2ShiftY = point2ShiftY;
        }

        public override void Scale(double factor)
        {
            Point2ShiftX *= factor;
            Point2ShiftY *= factor;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($", Point2ShiftX = {Point2ShiftX}, Point2ShiftY = {Point2ShiftY}");
        }
    }
}
