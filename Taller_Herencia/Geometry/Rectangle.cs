using System;

namespace Geometry
{
    // Rectangle inherits from Square
    public class Rectangle : Square
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

        // Constructor with name, side A and side B
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
            ValidateB(); // Check if B is valid
        }

        // Method to calculate area
        public override double GetArea()
        {
            // Formula: A * B
            return A * B;
        }

        // Method to calculate perimeter
        public override double GetPerimeter()
        {
            // Formula: 2 * (A + B)
            return 2 * (A + B);
        }

        // Validation method for side B
        private void ValidateB()
        {
            if (B <= 0)
                throw new ArgumentException("El valor de B debe ser mayor que cero.");
        }
    }
}