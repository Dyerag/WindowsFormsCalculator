using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    internal static class Input
    {
        public static double? Input1 { get; set; }
        public static double? Input2 { get; set; }
        public static Operators? Operator { get; set; }

        /// <summary>
        /// Empties the class variables after use
        /// </summary>
        public static void Clear()
        {
            Input1 = null;
            Input2 = null;
            Operator = null;
        }

        /// <summary>
        /// Adds the values on the CurrentDisplay to variables for use in calculations
        /// </summary>
        /// <param name="number"></param>
        public static void AddNumbers(string number)
        {
            if (Input1 == null)
                Input1 = Convert.ToDouble(number);
            else if(Input2 == null)
                Input2 = Convert.ToDouble(number); 
        }

        public static void AddOperator(Operators Op)
        {
            if (Operator == null)
                Operator = Op;
        }
    }
}
