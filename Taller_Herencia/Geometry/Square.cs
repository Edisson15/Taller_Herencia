namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double _a;

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

        public Square(string name, double a) : base(name)
        {
            A = a;
            ValidateA();
        }

        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private void ValidateA()
        {
            if (A <= 0)
                throw new ArgumentException("El valor de A debe ser mayor que cero.");
        }
    }
}
