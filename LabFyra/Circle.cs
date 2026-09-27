using System;
using System.Collections.Generic;
using System.Text;

namespace LabFyra
{
    internal class Circle
    {
        int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }

    }
}
