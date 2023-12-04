using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    public static class Output
    {
        private static bool firstInput = true;
        private static Queue<string> recentList;

        internal static bool FirstInput { get => firstInput; set => firstInput = value; }
        private static Queue<string> RecentList { get => recentList; set => recentList = value; }


        /// <summary>
        /// checks if the display was recently cleared
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

        /// <summary>
        /// Adds the most recent calculation, and deletes the oldest one when limit is hit
        /// </summary>
        /// <param name="calculation"></param>
        public static void NewLastCalculation(String calculation)
        {
            RecentList.Enqueue(calculation);

            if (RecentList.Count > 10)
                RecentList.Dequeue();
        }
    }
}
