﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Events
{
    public delegate void InputStringHandler(string userString);
    class InputHandler
    {
        public event InputStringHandler InputString;

        private string userString;
        public void Input()
        {
            while (true)
            {
                Console.WriteLine("Введите строку: \n");
                userString = Console.ReadLine();
                InputString?.Invoke(userString);
            }
        }
    }
}
