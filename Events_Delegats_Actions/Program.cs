using System;
using System.Security.Cryptography.X509Certificates;

namespace Events_Delegats_Actions
{
    public delegate void AddString (string addString);
    class Program
    {
        static void Main(string[] args)
        {
            string userString;
            bool isDigit;
            AddString addString;
            StringCollector stringCollection = new StringCollector();
            AlphaNumbericCollector numbericCollection = new AlphaNumbericCollector();
            while (true)
            {
                userString = InputHandler.Input();
                isDigit = false;
                addString = null;
                foreach(char i in userString)
                {
                    switch (i)
                    {
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                            isDigit = true;
                            break;
                        default:
                            continue;
                    }
                }
                if (isDigit)
                {
                    addString = numbericCollection.AddString;
                    addString(userString);
                }
                else
                {
                    addString = stringCollection.AddString;
                    addString(userString);
                }
            }
        }
        
    }
}
