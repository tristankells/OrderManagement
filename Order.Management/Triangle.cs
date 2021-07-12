using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    // 3. Class names. The abstraction feels a little confused. A class called triangle has a lot triangles. 
    class Triangle : Shape
    {
        // 4. Should be removed or made private. I would prefer we did something more polymorhpic, made Price
        // and abstract property. That way the editor would give us nice little hints as well for future shapes.
        public int TrianglePrice = 2;
        public Triangle(int numberOfRedTriangles, int numberOfBlueTriangles, int numberOfYellowTriangles)
        {
            // 6. I feel the same way about Name. Make it an abstract class in Shape() and override in each of the children.
            // If we ever need a shape that does not need a shape, we can add an interface.
            Name = "Triangle";
            base.Price = TrianglePrice; //See 4.

            // 7. According to our brief, the additional charge is always 1. So this should be set once in the base class. DRY
            AdditionalCharge = 1;

            // 8. So if we take the rest out of the construtor only thing we have left is taking the number of shapes
            // and inputting them her. So we can move this all into the base class 
            base.NumberOfRedShape = numberOfRedTriangles;
            base.NumberOfBlueShape = numberOfBlueTriangles;
            base.NumberOfYellowShape = numberOfYellowTriangles;
        }

        // 5. Following from below, the Total() logic is repeated in each Shape() class
        public override int Total()
        {
            return RedTrianglesTotal() + BlueTrianglesTotal() + YellowTrianglesTotal();
        }

        // 1. The red, blue and yellow {insert shape} methods are repeated for every shape. They belong in the base class.
        
        // 2. These methods are not called externally, so should be private

        public int RedTrianglesTotal()
        {
            return (base.NumberOfRedShape * Price);
        }
        public int BlueTrianglesTotal()
        {
            return (base.NumberOfBlueShape * Price);
        }
        public int YellowTrianglesTotal()
        {
            return (base.NumberOfYellowShape * Price);
        }  
    // Incorrect Indentation (Readability) and a added line
}
}
