namespace Geometry
{
    // Trapeze inherits from Triangle
    public class Trapeze : Triangle
    {
        // Field for base D
        private double _d;

        // Property for base D
        public double D
        {
            get { return _d; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El valor de D debe ser positivo.");
                _d = value;
            }
        }

        // Constructor with name, sides A, B, C, base D, and height H
        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h)
        {
            D = d;
            ValidateD(); // Check if D is valid
        }

        // Method to calculate area
        public override double GetArea()
        {
            // Formula: (B + D) * H / 2
            return (B + D) * H / 2;
        }

        // Method to calculate perimeter
        public override double GetPerimeter()
        {
            // Formula: A + B + C + D
            return A + B + C + D;
        }

        // Validation method for D
        private void ValidateD()
        {
            if (D <= 0)
                throw new ArgumentException("El valor de D debe ser mayor que cero.");
        }
    }
}