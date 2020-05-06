using System;
using System.Linq;

namespace Action_Predicate
{
    class Program
    {
        public delegate void Action<T>(string inputString);

        static void Main(string[] args)
        {
            Predicate<string> isDigit = delegate (string x) { return x.Any(char.IsDigit); };
            string userString;
            StringCollector stringCollection = new StringCollector();
            AlphaNumbericCollector numericCollection = new AlphaNumbericCollector();
            Action<string> addString = StringCollector.AddString;
            Action<string> addStringWithDigit = AlphaNumbericCollector.AddString;
            while (true)
            {
                userString = InputHandler.Input();
                if (isDigit(userString))
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