using System;

namespace ClassLibraryDPRigoli
{
    public class ClassLibrary
    {
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public void DisplayDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

    }
}
