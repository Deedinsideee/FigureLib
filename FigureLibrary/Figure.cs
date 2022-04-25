using System;

namespace FigureLibrary
{
    public abstract class Figure
    {

        private double square;


        public Figure()
        {
            square = Square();
        }

        public abstract double Square();
        


    }
}
