//
// this is starting point, does following
// 1) defines different helping classes like mark, degree etc.
// 2) extension methods used in different places
// 3) also it sets data structures (creates dictionaries for all) as in Lab10
// 4) starts StartForm
//
//
//


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManagement
{
    // marks of student (student + course = mark)
    public enum Mark
    {
        A=6, B=5, C=4, D=3, E=2, F=1, none=0
    }

    // degree of teacher
    public enum Degree
    {
        BD, MD, PhD, none     // bachelor, master and doctor
    }


    // keys in marks dict.
    public struct MarkKey : IComparable
    {
        private string studentID;
        private string courseID;

        public MarkKey(string studentID, string courseID)
        {
            this.studentID = studentID;
            this.courseID = courseID;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string CourseID { get => courseID; set => courseID = value; }

        public int CompareTo(object obj)    // required to compare two such structs
        {
            MarkKey key = (MarkKey)obj;
            if (studentID.CompareTo(key.studentID) != 0)
                return studentID.CompareTo(key.studentID);
            return courseID.CompareTo(key.courseID);
        }
    }


    // ENTRY
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        // extension methods for GUI to easily code e.g. GUI.Get()
        public static string Get(this ListBox box)
        {
            return box.GetItemText(box.SelectedItem);
        }

        public static string Get(this ComboBox box)
        {
            return box.GetItemText(box.SelectedItem);
        }
       
        // extend string to transform it to mark
        public static Mark toMark(this string str)
        {
            switch (str)
            {
                case "A":
                    return Mark.A;
                case "B":
                    return Mark.B;
                case "C":
                    return Mark.C;
                case "D":
                    return Mark.D;
                case "E":
                    return Mark.E;
                case "F":
                    return Mark.F;
                default:
                    return Mark.none;
            }
        }
        

        // similar for degree
        public static Degree toDegree(this string str)
        {
            switch (str)
            {
                case "BD":
                    return Degree.BD;
                case "MD":
                    return Degree.MD;
                case "PhD":
                    return Degree.PhD;
                default:
                    return Degree.none;
            }
        }
            
        // here also extend string to search ...
        public static String substringToChar(this string str, char ch)
        {
            int index = str.IndexOf(ch);
            if (index == -1)
                return null;
            else
                return str.Substring(0, index);
        }



        // here go common data structures:
        public static SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();
        public static SortedDictionary<string, Teacher> teachers = new SortedDictionary<string, Teacher>();
        public static SortedDictionary<string, Admin> admins = new SortedDictionary<string, Admin>();
        public static SortedDictionary<string, Course> courses = new SortedDictionary<string, Course>();
        public static SortedDictionary<MarkKey, Mark> marks = new SortedDictionary<MarkKey, Mark>();
        public static User currentUser = null;     // using polymorphism -- link to generic type of user

        // used by all forms when closed to return to start form
        public static Form mainForm = null;
            
        [STAThread]
        static void Main()  // start ALL
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
