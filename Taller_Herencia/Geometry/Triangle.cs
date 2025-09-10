using System;

namespace Geometry
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get { return _c; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado C debe ser positivo.");
                _c = value;
            }
        }

        public double H
        {
            get { return _h; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La altura H debe ser positiva.");
                _h = value;
            }
        }

        public Triangle(string name, double a, double b, double c, double h)
            : base(name, a, b)
        {
            C = c;
            H = h;
            ValidateC(); 
            ValidateH(); 
        }

        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        private void ValidateC()
        {
            if (C <= 0)
                throw new ArgumentException("El valor de C debe ser mayor que cero.");
        }

        private void ValidateH()
        {
            if (H <= 0)
                throw new ArgumentException("El valor de H debe ser mayor que cero.");
        }
    }
}