using System;

namespace ClassLibraryDPRigoli
{
    public class ClassLibrary
    {
        public void StartMenu()
        {
            Menu menu = new Menu();

            string option = "";

            do
            {
                option = menu.ShowMenu();
            } while (!option.Equals("0"));
        }

    }
}
