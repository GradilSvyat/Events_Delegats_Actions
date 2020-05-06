using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class StringCollector
    {
        private List<string> StringCollection { get; set; } = new List<string>();

        public void AddString(string addSrting)
        {
            if (!addSrting.Any(char.IsDigit))
                StringCollection.Add(addSrting);
        }

    }
}
