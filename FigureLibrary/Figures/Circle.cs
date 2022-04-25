using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;

        }



        public override double Square()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
