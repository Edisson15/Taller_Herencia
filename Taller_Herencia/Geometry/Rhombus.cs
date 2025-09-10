using System;

namespace Geometry
{
    // Rhombus inherits from Square
    public class Rhombus : Square
    {
        // Fields for diagonals
        private double _d1;
        private double _d2;

        // Property for diagonal D1
        public double D1
        {
            get { return _d1; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La diagonal D1 debe ser positiva.");
                _d1 = value;
            }
        }

        // Property for diagonal D2
        public double D2
        {
            get { return _d2; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La diagonal D2 debe ser positiva.");
                _d2 = value;
            }
        }

        // Constructor with name, side A, and diagonals D1, D2
        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
            ValidateD1(); // Check if D1 is valid
            ValidateD2(); // Check if D2 is valid
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
            // Formula: 4 * A
            return 4 * A;
        }

        // Validation method for D1
        private void ValidateD1()
        {
            if (D1 <= 0)
                throw new ArgumentException("El valor de D1 debe ser mayor que cero.");
        }

        // Validation method for D2
        private void ValidateD2()
        {
            if (D2 <= 0)
                throw new ArgumentException("El valor de D2 debe ser mayor que cero.");
        }
    }
}