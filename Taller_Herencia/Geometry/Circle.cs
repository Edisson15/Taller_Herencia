using System;

namespace Geometry
{
     public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El radio debe ser positivo.");
                _r = value;
            }
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;          
            ValidateR();   
        }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        private void ValidateR()
        {
            if (R <= 0)
                throw new ArgumentException("El radio debe ser mayor que cero.");
        }
    }
}