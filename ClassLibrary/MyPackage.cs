using System;

namespace ClassLibrary
{
    public class MyPackage
    {
        public void DisplayTest(string text)
        {
            Console.WriteLine(text);
        }

        public void DisplayDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
