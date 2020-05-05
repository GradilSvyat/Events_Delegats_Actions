﻿using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Events_Delegats_Actions
{
    public delegate void AddString (string addString);
    class Program
    {
        static void Main(string[] args)
        {
            string userString;
            bool containsDigit;
            StringCollector stringCollection = new StringCollector();
            AlphaNumbericCollector numericCollection = new AlphaNumbericCollector();
            AddString addString= stringCollection.AddString;
            AddString addStringWithDigit = numericCollection.AddString;
            while (true)
            {
                userString = InputHandler.Input();
                containsDigit = userString.Any(char.IsDigit);

                if (containsDigit)
                {
                    addStringWithDigit(userString);
                }
                else
                {
                    addString(userString);
                }
            }
        }
    }
}
