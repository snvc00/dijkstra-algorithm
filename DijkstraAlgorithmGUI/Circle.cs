using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMALG_actividad04
{
    public class Circle
    {
        int x, y, radius;

        public void SetValues(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public int X
        {
            get { return this.x; }
            set { }
        }

        public int Y
        {
            get { return this.y; }
            set { }
        }

        public int Radius
        {
            get { return this.radius; }
            set { }
        }

        public override string ToString()
        {
            return "X: " + this.x + " Y: " + this.y + " Radio: " + this.radius;
        }
    }
}
