// course data structure

namespace SchoolManagement
{
    class Course
    {
        private string courseID;
        private string topic;
        private int credits;
        private Teacher teacherID;

        public string CourseID { get => courseID; set => courseID = value; }
        public string Topic { get => topic; set => topic = value; }
        public int Credits { get => credits; set => credits = value; }
        public Teacher TeacherID { get => teacherID; set => TeacherID = value; }

        public Course(string courseID, string topic, int credits, Teacher teacherID)
        {
            this.courseID = courseID;
            this.topic = topic;
            this.credits = credits;
            this.teacherID = teacherID;
        }
    }
}
