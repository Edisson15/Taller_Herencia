using System;

namespace Geometry
{
     public class Circle : GeometricFigure
    {
        // Field for the radius
        private double _r;

        // Property for the radius
        public double R
        {
            get { return _r; }
            set
            {
                // The radius must be positive
                if (value <= 0)
                    throw new ArgumentException("El radio debe ser positivo.");
                _r = value;
            }
        }

        // Constructor with name and radius
        public Circle(string name, double r) : base(name)
        {
            R = r;          
            ValidateR();   
        }

        // Method to calculate the area
        public override double GetArea()
        {
            // Formula: π * r^2
            return Math.PI * R * R;
        }

        // Method to calculate the perimeter (circumference)
        public override double GetPerimeter()
        {
            // Formula: 2 * π * r
            return 2 * Math.PI * R;
        }

        // Validation method for the radius
        private void ValidateR()
        {
            // Check if R is greater than zero
            if (R <= 0)
                throw new ArgumentException("El radio debe ser mayor que cero.");
        }
    }
}