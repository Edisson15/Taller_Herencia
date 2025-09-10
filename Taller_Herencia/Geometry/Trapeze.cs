namespace Geometry
{
    public class Trapeze : Triangle
    {
        private double _d;

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

        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h)
        {
            D = d;
            ValidateD(); 
        }

        public override double GetArea()
        {
            return (B + D) * H / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        private void ValidateD()
        {
            if (D <= 0)
                throw new ArgumentException("El valor de D debe ser mayor que cero.");
        }
    }
}