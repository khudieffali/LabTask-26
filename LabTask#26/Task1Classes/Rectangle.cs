using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTask_26.Interfaces;

namespace LabTask_26.Task1Classes
{
    internal class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public double CalculateArea()
        {
            return Width * Length;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Length);
        }
    }
}
