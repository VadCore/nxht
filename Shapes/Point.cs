using System;

namespace Nxsht
{
    public abstract class Point
    {
        protected double X { get; set; }
        protected double Y { get; set; }

        public Point(double x, double y) => (X, Y) = (x, y);

        public void MoveToCoordinate(double x, double y) => (X, Y) = (x, y);

        public virtual void PrintInfo() => Console.WriteLine(ToString());

        public override string ToString() => string.Format($"anchorPointX:{X}, anchorPointY:{Y}");

        public abstract void Scale (double factor);
    }
}
