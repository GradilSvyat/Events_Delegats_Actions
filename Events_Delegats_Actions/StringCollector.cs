using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Delegats_Actions
{
    class StringCollector
    {
        private List<string> StringCollection { get; set; }

        public void AddString(string addSrting)
        {
            StringCollection.Add(addSrting);
        }
    }
}
