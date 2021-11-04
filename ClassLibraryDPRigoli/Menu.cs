using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDPRigoli
{
    class Menu
    {
        private ManagerData data;

        public Menu()
        {
            data = new ManagerData();
        }

        public string ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n1. Add a teacher\n" +
                               "2. Add a subject\n" +
                              "3. Add a student\n" +
                              "4. Show teachers\n" +
                              "5. Show subject\n" +
                              "6. Show students\n" +
                              "0. Exit");
            Console.ForegroundColor = ConsoleColor.White;
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    string[] teacher = AddNew(Categories.teacher);
                    data.AddTeacher(teacher[0], teacher[1], teacher[2]);
                    break;
                case "2":
                    string[] subject = AddNew(Categories.subject);
                    data.AddSubject(subject[0], subject[1]);
                    break;
                case "3":
                    string[] student = AddNew(Categories.student);
                    data.AddStudent(student[0], student[1], student[2]);
                    break;
                case "4":
                    data.ShowTeachers();
                    break;
                case "5":
                    data.ShowSubjects();
                    break;
                case "6":
                    data.ShowStudants();
                    break;
                case "0":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid option, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            return option;
        }

        private string[] AddNew(Categories categoria)
        {
            Console.WriteLine("What is the " + categoria + "'s name?");
            string name = Console.ReadLine();

            if (categoria == Categories.subject)
            {
                Console.WriteLine("What is the " + categoria + "'s code?");
                string code = Console.ReadLine();

                return new string[] {name, code};
            } else
            {
                Console.WriteLine("What is the " + categoria + "'s class?");
                string classe = Console.ReadLine();

                Console.WriteLine("What is the " + categoria + "'s class?");
                string section = Console.ReadLine();

                return new string[] { name, classe, section };
            }
        }
    }
}
