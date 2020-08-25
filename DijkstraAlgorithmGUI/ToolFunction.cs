using System;
using System.Drawing;

namespace SEMALG_actividad04
{
    public static class ToolFunction
    {
        readonly public static double INFINITE = Double.MaxValue;
        public static double Distance(Point A, Point B)
        {
            return Math.Sqrt((double)(Math.Pow((double)(B.X - A.X), 2) + Math.Pow((double)(B.Y - A.Y), 2)));
        }
    }
}
