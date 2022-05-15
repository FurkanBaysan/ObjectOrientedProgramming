using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // Defensive Programming Technique
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }

            // Best-Practice
            Move(newLocation.X, newLocation.Y);

        }
    }
}
