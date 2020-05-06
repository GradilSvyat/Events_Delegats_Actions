using System;
using System.Collections.Generic;
using System.Text;

namespace Action_Predicate
{
    class AlphaNumbericCollector
    {
        private static List<string> StringWithDigitCollection { get; set; } = new List<string>();

        public static void AddString(string addSrting)
        {
            StringWithDigitCollection.Add(addSrting);
        }
    }
}
