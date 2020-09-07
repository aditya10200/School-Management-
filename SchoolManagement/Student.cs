// student, inherits from User
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
   
    class Student : User
    {
        private Mark totalGPA;

        public Mark GPA { get => totalGPA; set => totalGPA = value; }
        
        public Student(string userID, string password, string name, string email, 
            string address, string phone, Mark totalGPA) :
            base(userID, password, name, email, address, phone)
        {
            this.totalGPA = totalGPA;
        }

        // markkey is a pair(student_id, course_id), so we have
        // to find values for all keys where student_id is this.user_id and some mark is set, 
        // and get their average
        public void CalculateGPA(SortedDictionary<MarkKey, Mark> marks)
        {
            // <stud_id string, course_id string> ---> string
            var results = marks.Where(mark => (mark.Key.StudentID.Equals(userID) 
                                && !mark.Value.Equals(Mark.none))).Select(mark => mark.Value);

            // results now is array of Mark enums
            Mark average;
            if (results.Count() > 0)
            {
                float total = 0f;
                foreach (Mark mark in results)
                {
                    total += (int)mark;
                }
                average = (Mark)((int)Math.Round(total / results.Count(),
                    MidpointRounding.AwayFromZero));
            }
            else
                average = Mark.none;

            // set updated GPA
            this.GPA = average;
        }

        public override void showForm()
        {
            StudentForm form = new StudentForm();
            form.Show();
        }
    }
}
