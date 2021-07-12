using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Square : Shape
    {
        // 1. Inconsistent lines. Doesn't matter if we decide line after class declaration or not, but it should be consistent.
        public int SquarePrice = 1;

        public Square(int numberOfRedSquares, int numberOfBlueSquares, int numberOfYellowSquares)
        {
            Name = "Square";
            base.Price = SquarePrice;
            AdditionalCharge = 1;
            base.NumberOfRedShape = numberOfRedSquares;
            base.NumberOfBlueShape = numberOfBlueSquares;
            base.NumberOfYellowShape = numberOfYellowSquares;
        }

        public override int Total()
        {
            return RedSquaresTotal() + BlueSquaresTotal() + YellowSquaresTotal();
        }
        // 2. Missing spaces between methods. 
        public int RedSquaresTotal()
        {
            return (base.NumberOfRedShape * Price);
        }
        public int BlueSquaresTotal()
        {
            return (base.NumberOfBlueShape * Price);
        }
        public int YellowSquaresTotal()
        {
            return (base.NumberOfYellowShape * Price);
        }
    }
}
