using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTask_26.Interfaces;

namespace LabTask_26.Task1Classes
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }
        public double Pi { get; set; } = 3.14;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Pi * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Pi * Radius;
        }
    }
}
