using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Triangle : Figure
    {
        public double aside { get; set; }

        public double bsite { get; set; }

        public double csite { get; set; }

        public double square { get; set; }

        public bool pruamougol { get; set; }

        public Triangle(double aside, double bsite, double csite)
        {
            this.aside = aside;
            this.bsite = bsite;
            this.csite = csite;
            pruamougol = Proverkanapryam();

        }



        private bool Proverkanapryam()
        {
            var maxSide = new[] { aside, bsite, csite }.Max();
            var maxx2 = Math.Pow(maxSide, 2);

            return maxx2 + maxx2 == Math.Pow(aside, 2) + Math.Pow(bsite, 2) + Math.Pow(csite, 2);
        }



        public override double Square()
        {
            var poluper = (aside + bsite + csite) / 2;

            return Math.Sqrt(poluper * (poluper - aside) * (poluper - bsite) * (poluper - csite));




        }
    }
}
