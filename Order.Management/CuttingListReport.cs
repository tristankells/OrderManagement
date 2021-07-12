using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Order.Management
{
    class CuttingListReport : Order
    {
        // 1. This should be private.
        public int tableWidth = 20;
        public CuttingListReport(string customerName, string customerAddress, string dueDate, List<Shape> shapes)
        {
            base.CustomerName = customerName;
            base.Address = customerAddress;
            base.DueDate = dueDate;
            base.OrderedBlocks = shapes;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour cutting list has been generated: ");
            Console.WriteLine(base.ToString());
            generateTable();
        } 
        // 1. Missing new line here
        // 4. Missing uppercase here. 
        public void generateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();


            //8. We are at the use for that Name shape here, we can chuck this part into a foreach loop 
            // and iterate through our list. Cut down on repetition with added benefit of extendability.
            PrintRow("Square",base.OrderedBlocks[0].TotalQuantityOfShape().ToString());
            PrintRow("Triangle", base.OrderedBlocks[1].TotalQuantityOfShape().ToString());
            PrintRow("Circle", base.OrderedBlocks[2].TotalQuantityOfShape().ToString());
            PrintLine();
        }

        // 2. Lots of public methods that should be private in here.
        // 7. Repeated in all subclasses, move to base class. 
        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        // 6. Repeated in all subclasses, move to base class. 
        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        // 5. Align center is repeated in all of the subclasses. Move to base class.
        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else //6. Minor issue, but the else is redudant here.
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        // 3. Added lines at the bottom.
    }
}
