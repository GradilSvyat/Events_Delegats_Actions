using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class AlphaNumbericCollector
    {
        private List<string> StringWithDigitCollection { get; set; } = new List<string>();

        public void AddString(string addSrting)
        {
            if (addSrting.Any(char.IsDigit))
                StringWithDigitCollection.Add(addSrting);
        }
    }
}
