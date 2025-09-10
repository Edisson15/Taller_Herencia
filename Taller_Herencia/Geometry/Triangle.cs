using System;

namespace Geometry
{
    // Triangle inherits from Rectangle
    public class Triangle : Rectangle
    {
        // Field for side C
        private double _c;
        // Field for height H
        private double _h;

        // Property for side C
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

        // Constructor with name, sides A, B, C and height H
        public Triangle(string name, double a, double b, double c, double h)
            : base(name, a, b)
        {
            C = c;
            H = h;
            ValidateC(); // check if C is valid
            ValidateH(); // check if H is valid
        }

        // Method to calculate area
        public override double GetArea()
        {
            // Formula: (B * H) / 2
            return (B * H) / 2;
        }

        // Method to calculate perimeter
        public override double GetPerimeter()
        {
            // Formula: A + B + C
            return A + B + C;
        }

        // Validation method for side C
        private void ValidateC()
        {
            if (C <= 0)
                throw new ArgumentException("El valor de C debe ser mayor que cero.");
        }

        // Validation method for height H
        private void ValidateH()
        {
            if (H <= 0)
                throw new ArgumentException("El valor de H debe ser mayor que cero.");
        }
    }
}