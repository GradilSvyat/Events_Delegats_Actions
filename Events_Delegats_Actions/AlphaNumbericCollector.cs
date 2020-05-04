using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Delegats_Actions
{
    class AlphaNumbericCollector
    {
        private List<string> StringWithDigitCollection { get; set; }

        public void AddString(string addSrting)
        {
            StringWithDigitCollection.Add(addSrting);
        }
    }
}
