using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    internal class Input
    {
        public Double? Input1 { get; set; }
        public Double? Input2 { get; set; }
        public Operators? Operator { get; set; }


        public void Clear()
        {
            Input1 = null;
            Input2 = null;
            Operator = null;
        }
    }
}
