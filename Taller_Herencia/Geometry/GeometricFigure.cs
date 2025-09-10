using System.Globalization;

namespace Geometry
{
    public abstract class GeometricFigure
    {
              public string Name { get; set; }

             public GeometricFigure(string name)
        {
            Name = name;
        }

         public abstract double GetArea();

              public abstract double GetPerimeter();

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "{0,-15} => Area.....: {1,12:F5}   Perimeter: {2,12:F5}",
                Name, GetArea(), GetPerimeter());
        }
    }
}