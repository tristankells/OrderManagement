using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    abstract class Shape
    {
        // 1. Currenty, this shape is only being set, it is never being used. Should we throw it?
        public string Name { get; set; }

        // 2. If we go down the road of making this polymorphic, we can remove the set method entirely. 
        public int Price { get; set; }

        // 3. We should make this private. This does not need to be exposed, and use AdditionalChargeTotal() instead.
        public int AdditionalCharge { get; set; }
        public int NumberOfRedShape { get; set; }
        public int NumberOfBlueShape { get; set; }
        public int NumberOfYellowShape { get; set; }
        public int TotalQuantityOfShape()
        {
            return NumberOfRedShape + NumberOfBlueShape + NumberOfYellowShape;
        }

        // 4. In the current implementation, we use or lose it. However, instead of losing it, we should use in, all the places additional charge is currently being used.
        public int AdditionalChargeTotal()
        {
            return NumberOfRedShape * AdditionalCharge;
        }

        // 5. Make this not abstract and pull the logic from the children class to this one. 
        public abstract int Total();

    }
}
