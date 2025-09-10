namespace Geometry
{
    // Square inherits from GeometricFigure
    public class Square : GeometricFigure
    {
        // Field for side A
        private double _a;

        // Property for side A
        public double A
        {
            get { return _a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado A debe ser positivo.");
                _a = value;
            }
        }

        // Constructor with name and side A
        public Square(string name, double a) : base(name)
        {
            A = a;
            ValidateA(); // Check if A is valid
        }

        // Method to calculate area
        public override double GetArea()
        {
            // Formula: A * A
            return A * A;
        }

        // Method to calculate perimeter
        public override double GetPerimeter()
        {
            // Formula: 4 * A
            return 4 * A;
        }

        // Validation method for side A
        private void ValidateA()
        {
            if (A <= 0)
                throw new ArgumentException("El valor de A debe ser mayor que cero.");
        }
    }
}