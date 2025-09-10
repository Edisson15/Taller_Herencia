using System.Globalization;

namespace Geometry
{
    // Abstract class for geometric figures
    public abstract class GeometricFigure
    {
        // Property for the figure name
        public string Name { get; set; }

        // Constructor to set the name
        public GeometricFigure(string name)
        {
            Name = name;
        }

        // Abstract method to calculate the area
        public abstract double GetArea();

        // Abstract method to calculate the perimeter
        public abstract double GetPerimeter();

        // Method to return the figure information as text
        public override string ToString()
        {
            // Shows the name, area, and perimeter with format
            return string.Format(CultureInfo.InvariantCulture,
                "{0,-15} => Area.....: {1,12:F5}   Perimeter: {2,12:F5}",
                Name, GetArea(), GetPerimeter());
        }
    }
}