using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString;
            StringCollector stringCollection = new StringCollector();
            AlphaNumbericCollector numericCollection = new AlphaNumbericCollector();
            InputHandler inputUserString = new InputHandler();
            inputUserString.InputString += stringCollection.AddString;
            inputUserString.InputString += numericCollection.AddString;
            while (true)
            {
                userString = inputUserString.Input();
            }
        }
    }
}
