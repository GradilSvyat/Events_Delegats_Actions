using System;
using System.Collections.Generic;
using System.Text;

namespace Action_Predicate
{
    class StringCollector
    {
        private static List<string> StringCollection { get; set; } = new List<string>();

        public static void AddString(string addSrting)
        {
            StringCollection.Add(addSrting);
        }
    }
}
