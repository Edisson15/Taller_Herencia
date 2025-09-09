using System;

namespace Geometry
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

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

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
            ValidateD1();
            ValidateD2();
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }


        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private void ValidateD1()
        {
            if (D1 <= 0)
                throw new ArgumentException("El valor de D1 debe ser mayor que cero.");
        }

        private void ValidateD2()
        {
            if (D2 <= 0)
                throw new ArgumentException("El valor de D2 debe ser mayor que cero.");
        }
    }
}
