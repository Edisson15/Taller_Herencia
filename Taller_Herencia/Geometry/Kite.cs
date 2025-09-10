using System;

namespace Geometry
{
    public class Kite : Rhombus
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
                public Kite(string name, double a, double d1, double d2, double b)
            : base(name, a, d1, d2)
        {
            B = b;
            ValidateB(); 
        }
        public override double GetArea()
        {
            return (D1 * D2) / 2;
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