using System;

namespace Geometry
{
    // Kite inherits from Rhombus
    public class Kite : Rhombus
    {
        // Field for side B
        private double _b;

        // Property for side B
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

        // Constructor with name, side A, diagonals D1 and D2, and side B
        public Kite(string name, double a, double d1, double d2, double b)
            : base(name, a, d1, d2)
        {
            B = b;
            ValidateB(); // Check if B is valid
        }

        // Method to calculate area
        public override double GetArea()
        {
            // Formula: (D1 * D2) / 2
            return (D1 * D2) / 2;
        }

        // Method to calculate perimeter
        public override double GetPerimeter()
        {
            // Formula: 2 * (A + B)
            return 2 * (A + B);
        }

        // Validation method for B
        private void ValidateB()
        {
            if (B <= 0)
                throw new ArgumentException("El valor de B debe ser mayor que cero.");
        }
    }
}