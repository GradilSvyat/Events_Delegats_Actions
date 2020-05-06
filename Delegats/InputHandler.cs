using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Delegats_Actions
{
    class InputHandler
    {
        public static string Input()
        {
            Console.WriteLine("Введите строку: \n");
            return Console.ReadLine();
        }

    }
}
