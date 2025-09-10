using System;

namespace Geometry
{
    // Parallelogram inherits from Rectangle
    public class Parallelogram : Rectangle
    {
        // Field for height H
        private double _h;

        // Property for height H
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

        // Constructor with name, side A, side B, and height H
        public Parallelogram(string name, double a, double b, double h)
            : base(name, a, b)
        {
            H = h;
            ValidateH(); // Check if H is valid
        }

        // Method to calculate area
        public override double GetArea()
        {
            // Formula: base * height
            return B * H;
        }

        // Method to calculate perimeter
        public override double GetPerimeter()
        {
            // Formula: 2 * (A + B)
            return 2 * (A + B);
        }

        // Validation method for H
        private void ValidateH()
        {
            if (H <= 0)
                throw new ArgumentException("El valor de H debe ser mayor que cero.");
        }
    }
}