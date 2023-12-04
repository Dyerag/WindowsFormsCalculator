using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    internal static class Input
    {
        public static Double? Input1 { get; set; }
        public static Double? Input2 { get; set; }
        public static Operators? Operator { get; set; }
        public static string FullCalculation
        {
            get
            {

                return FullCalculation;
            }
            set
            {

            }
        }

        public static void Clear()
        {
            Input1 = null;
            Input2 = null;
            Operator = null;
            FullCalculation = null;
        }

        public static void Addnumbers(string number, Operators Op)
        {
            if (Input1 == null)
                Input1 = Convert.ToDouble(number);
            else
                Input2 = Convert.ToDouble(number);
            if (Operator == null)
                Operator = Op;
        }

    }
}
