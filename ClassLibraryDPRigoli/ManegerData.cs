using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDPRigoli
{
    class ManagerData
    {
        private static List<Student> students;
        private static List<Teacher> teachers;
        private static List<Subject> subjects;

        public void ShowStudants()
        {
            foreach (Student s in students)
            {
                Console.WriteLine(s.ToString());
            }
        }

        public void ShowTeachers()
        {
            foreach (Teacher t in teachers)
            {
                Console.WriteLine(t.ToString());
            }
        }

        public void ShowSubjects()
        {
            foreach (Subject s in subjects)
            {
                Console.WriteLine(s.ToString());
            }
        }

        public void AddTeacher(string name, string c, string section)
        {
            Teacher t = new Teacher(name, c, section);
            teachers.Add(t);
        }

        public void AddStudent(string name, string c, string section)
        {
            Student t = new Student(name, c, section);
            students.Add(t);
        }

        public void AddStudent(string code, string name)
        {
            Subject t = new Subject(code, name);
            subjects.Add(t);
        }
    }
}
