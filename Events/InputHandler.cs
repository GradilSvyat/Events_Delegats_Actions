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
        public string UserString
        {
            get { return userString; }
            set
            {
                userString = value;
                InputString(userString);
            }
        }       
        public void Input()
        {
            userString = Console.ReadLine();
        }
    }
}