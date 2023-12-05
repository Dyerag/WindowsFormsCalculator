using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    internal static class Formulas
    {
        public static double? Formula()
        {
            switch (Input.Operator)
            {
                case Operators.Addition:
                    return Input.Input1 + Input.Input2;


                case Operators.Subtraction:
                    return Input.Input1 - Input.Input2;


                case Operators.Multiplication:
                    return Input.Input1 * Input.Input2;

                case Operators.Division:
                    return Input.Input1 / Input.Input2;

                default:
                    return null;
            }
        }

        public static char? SplitSeparator()
        {
            switch (Input.Operator)
            {
                case Operators.Addition:
                    return '+';

                case Operators.Subtraction:
                    return '-';

                case Operators.Multiplication:
                    return '*';

                case Operators.Division:
                    return '/';

                default:
                    return null;
            }

        }
    }
}
