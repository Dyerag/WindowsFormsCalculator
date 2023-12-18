using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public static class Output
    {
        private static bool firstInput = true;
        private static Queue<string> _RecentList = new Queue<string>();

        public static bool FirstInput { get => firstInput; set => firstInput = value; }
       
        public static Queue<string> RecentList
        {
            get
            {
                return _RecentList;
            }
            set
            {
                _RecentList.Enqueue(value.Dequeue());
                if (_RecentList.Count > 10)
                    _RecentList.Dequeue();
            }
        }

        /// <summary>
        /// Checks if the display was recently cleared
        /// </summary>
        public static bool Check()
        {
            bool value = FirstInput;
            if (value)
            {
                FirstInput = false;
                return value;
            }
            else
                return value;
        }
    }
}
