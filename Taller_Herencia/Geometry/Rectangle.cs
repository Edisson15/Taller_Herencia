using System;

namespace Geometry
{
        public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get { return _b; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El valor de B debe ser positivo.");
                _b = value;
            }
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
            ValidateB(); 
        }

        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
             return 2 * (A + B);
        }

        private void ValidateB()
        {
            if (B <= 0)
                throw new ArgumentException("El valor de B debe ser mayor que cero.");
        }
    }
}